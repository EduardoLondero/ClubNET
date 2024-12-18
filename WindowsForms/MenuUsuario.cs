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
    public partial class MenuUsuario : Form
    {
        Usuario usuarioApp;

        public MenuUsuario(Usuario user)
        {
            InitializeComponent();

            cargarDatosUsuario(dgvUsuario, user);

            usuarioApp = user;
        }


        private void cargarDatosUsuario(DataGridView dgvUsuarios, Usuario user)
        {
            UserServices userService = new UserServices();

            Usuario? usuario = userService.Get(user.Id);

            if (usuario != null)
            {
                var usuarioProyectado = new
                {
                    usuario.email,
                    usuario.telefono,
                    usuario.direccion,
                    usuario.contraseña,
                    RolDescripcion = usuario.oRol?.descripcionrol ?? "Sin rol", 
                    LocalidadNombre = usuario.oLocalidad?.nombreLocalidad ?? "Sin localidad"
                };

                var listaUsuarios = new List<object> { usuarioProyectado };

                dgvUsuarios.DataSource = listaUsuarios;

                dgvUsuarios.Columns[0].HeaderText = "Email";
                dgvUsuarios.Columns[1].HeaderText = "Teléfono";
                dgvUsuarios.Columns[2].HeaderText = "Dirección";
                dgvUsuarios.Columns[3].HeaderText = "Contraseña";
                dgvUsuarios.Columns[4].HeaderText = "Rol";
                dgvUsuarios.Columns[5].HeaderText = "Localidad";
            }
            else
            {
                MessageBox.Show("No se encontró el usuario.");
            }
        }


        private void btonActualizar_Click(object sender, EventArgs e)
        {
            string newEmail = txtEmailNew.Text;
            string newPass = txtPassNew.Text;

            UserServices userservice = new UserServices();

            int usuarioid = usuarioApp.Id;

            Usuario usuariaActualizado = new Usuario
            {
                Id = usuarioid,
                email = newEmail,
                contraseña = newPass
            };

            userservice.Update(usuariaActualizado);

            MessageBox.Show("Usuario Actualizado");

        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}



