using Domain.Model;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class AdministrarUsuario : Form
    {
        public AdministrarUsuario()
        {
            InitializeComponent();

            UserServices userServices = new UserServices();
            var users = userServices.GetAll().ToList();

            cboxUsuario.DataSource = users;
            cboxUsuario.DisplayMember = "Id";
            cboxUsuario.ValueMember = "Id";

            RolServices rolService = new RolServices();
            var rol = rolService.GetAll().ToList();

            cBoxRol.DataSource = rol;
            cBoxRol.DisplayMember = "descripcionrol";
            cBoxRol.ValueMember = "Id";

            LocalidadService localidadService = new LocalidadService();
            var localidad = localidadService.GetAll().ToList();

            cBoxLocalidad.DataSource = localidad;
            cBoxLocalidad.DisplayMember = "nombreLocalidad";
            cBoxLocalidad.ValueMember = "Id";
        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonBuscar_Click(object sender, EventArgs e)
        {
            btonEliminar.Enabled = true;


            int UserIdToSearch = (int)cboxUsuario.SelectedValue;

            UserServices userService = new UserServices();

            Usuario usuarioToUpdate = new Usuario();

            usuarioToUpdate = userService.Get(UserIdToSearch);

            txtDireccion.Text = usuarioToUpdate.direccion;
            txtEmail.Text = usuarioToUpdate.email;
            txtPassword.Text = usuarioToUpdate.contraseña;
            txtTelefono.Text = Convert.ToString(usuarioToUpdate.telefono);

            int rolIdUsuario = usuarioToUpdate.oRolId;
            int localidadIdUsuario = usuarioToUpdate.oLocalidadId;

            cBoxLocalidad.SelectedValue = localidadIdUsuario;
            cBoxRol.SelectedValue = rolIdUsuario;
        }

        private void btonAdministrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("El formato del email es inválido.");
                return;
            }

            UserServices userService = new UserServices();

            int telefonoToUpdate;
            bool isInt = int.TryParse(txtTelefono.Text, out telefonoToUpdate);
            if (!isInt)
            {
                MessageBox.Show("Teléfono ingresado inválido.");
                return;
            }

            int rolSeleccionado = (int)cBoxRol.SelectedValue;
            int localidadSeleccionada = (int)cBoxLocalidad.SelectedValue;

            string emailToUpdate = txtEmail.Text;
            string direccionToUpdate = txtDireccion.Text;
            string contraseñaToUpdate = txtPassword.Text;

            int userIdToUpdate = (int)cboxUsuario.SelectedValue;

            Usuario usuarioToUpdate = userService.Get(userIdToUpdate);
            if (usuarioToUpdate == null)
            {
                MessageBox.Show("Usuario no encontrado para actualizar.");
                return;
            }

            usuarioToUpdate.email = emailToUpdate;
            usuarioToUpdate.telefono = telefonoToUpdate;
            usuarioToUpdate.direccion = direccionToUpdate;
            usuarioToUpdate.contraseña = contraseñaToUpdate;
            usuarioToUpdate.oLocalidadId = localidadSeleccionada;
            usuarioToUpdate.oRolId = rolSeleccionado;

            userService.Update(usuarioToUpdate);
            MessageBox.Show("Usuario actualizado con éxito.");
        }

        private bool IsValidEmail(string email)
        {
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }

        private void btonEliminar_Click(object sender, EventArgs e)
        {
            MembresiaService membresiaService = new MembresiaService();
            UserServices userService = new UserServices();


            int UserIdToSearch = (int)cboxUsuario.SelectedValue;

            bool canDelete = membresiaService.CanDeleteUsuario(UserIdToSearch);

            if (!canDelete)
            {

                MessageBox.Show("No se puede eliminar el Usuario porque está en uso por una Membresia.");
            }
            else
            {

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este Usuario?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


                if (result == DialogResult.Yes)
                {
                    userService.Delete(UserIdToSearch);
                    MessageBox.Show("Usuario eliminado con éxito.");
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
            }
        }

        private void AdministrarUsuario_Load(object sender, EventArgs e)
        {
            btonEliminar.Enabled = false;
        }
    }
}
