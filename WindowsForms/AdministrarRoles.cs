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
    public partial class AdministrarRoles : Form
    {
        public AdministrarRoles()
        {
            InitializeComponent();

            RolServices rolService = new RolServices();

            var roles = rolService.GetAll().ToList();

            cBoxRol.DataSource = roles;
            cBoxRol.DisplayMember = "descripcionrol";
            cBoxRol.ValueMember = "Id";

            txtIdRol.Enabled = false;

            txtFechaCreacion.Enabled = false;

        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonBuscar_Click(object sender, EventArgs e)
        {
            btonEliminar.Enabled = true;

            RolServices rolService = new RolServices();

            btonCrear.Enabled = false;

            int idRol = (int)cBoxRol.SelectedValue;

            Rol rolNuevo = new Rol();

            rolNuevo = rolService.Get(idRol);

            txtIdRol.Text = rolNuevo.Id.ToString();
            txtFechaCreacion.Text = rolNuevo.fechacreacionrol.ToString();
            txtDescripcionRol.Text = rolNuevo.descripcionrol;
        }

        private void btonCrear_Click(object sender, EventArgs e)
        {

            RolServices rolService = new RolServices();

            string descripcion = txtDescripcionRol.Text;
            DateTime fechaCreacionRol = DateTime.Now;

            Rol rolNuevo = new Rol
            {
                descripcionrol = descripcion,
                fechacreacionrol = fechaCreacionRol
            };

            rolService.add(rolNuevo);

            MessageBox.Show("Rol Creado con Exito");
        }

        private void btonEditar_Click(object sender, EventArgs e)
        {
            RolServices rolService = new RolServices();

            int idRol = (int)cBoxRol.SelectedValue;

            Rol rolNuevo = new Rol();

            rolNuevo = rolService.Get(idRol);

            rolNuevo.descripcionrol = txtDescripcionRol.Text;

            rolService.Update(rolNuevo);

            MessageBox.Show("Rol Actualizado con Exito");
        }




        private void AdministrarRoles_Load(object sender, EventArgs e)
        {
            btonEliminar.Enabled = false;
        }

        private void btonEliminar_Click(object sender, EventArgs e)
        {

            RolServices rolService = new RolServices();
            UserServices userServices = new UserServices();


            int idRol = (int)cBoxRol.SelectedValue;


            bool canDelete = userServices.CanDeleteRol(idRol);

            if (!canDelete)
            {

                MessageBox.Show("No se puede eliminar el rol porque está en uso por un usuario.");
            }
            else
            {

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta rol?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


                if (result == DialogResult.Yes)
                {
                    rolService.Delete(idRol);
                    MessageBox.Show("Rol eliminado con éxito.");
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
            }
        }
    }
}
