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
    public partial class AdministrarProvincia : Form
    {
        public AdministrarProvincia()
        {
            InitializeComponent();

            cargarProvincias();

            btonEditar.Enabled = false;
        }


        public void cargarProvincias()
        {
            ProvinciaService provinciaService = new ProvinciaService();
            var provincias = provinciaService.GetAll();

            cBoxProvincia.DataSource = provincias;
            cBoxProvincia.DisplayMember = "nombreProvincia";
            cBoxProvincia.ValueMember = "Id";
        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonBuscar_Click(object sender, EventArgs e)
        {
            btonCrear.Enabled = false;
            btonEditar.Enabled = true;

            ProvinciaService provinciaService = new ProvinciaService();
            int idProvincia = (int)cBoxProvincia.SelectedValue;

            Provincia provinciaToUpdate = provinciaService.Get(idProvincia);

            txtIdProvincia.Text = provinciaToUpdate.Id.ToString();
            txtNombrePronvincia.Text = provinciaToUpdate.nombreProvincia;

        }

        private void btonEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombrePronvincia.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la provincia.");
                return;
            }

            ProvinciaService provinciaService = new ProvinciaService();
            int idProvincia = (int)cBoxProvincia.SelectedValue;

            Provincia provinciaToUpdate = provinciaService.Get(idProvincia);

            if (provinciaToUpdate == null)
            {
                MessageBox.Show("Provincia no encontrada.");
                return;
            }

            provinciaToUpdate.nombreProvincia = txtNombrePronvincia.Text;

            provinciaService.Update(provinciaToUpdate);

            MessageBox.Show("Provincia Actualizada Con Éxito");
        }

        private void btonCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombrePronvincia.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la provincia.");
                return;
            }

            ProvinciaService provinciaService = new ProvinciaService();

            Provincia provinciaNew = new Provincia
            {
                nombreProvincia = txtNombrePronvincia.Text
            };

            provinciaService.Add(provinciaNew);

            MessageBox.Show("Provincia Creada Con Éxito");

            cargarProvincias();
        }

        private void btonEliminar_Click(object sender, EventArgs e)
        {
            LocalidadService localidadService = new LocalidadService();
            ProvinciaService provinciaService = new ProvinciaService();


            int idProvincia = (int)cBoxProvincia.SelectedValue;


            bool canDelete = localidadService.CanDeleteProvince(idProvincia);

            if (!canDelete)
            {

                MessageBox.Show("No se puede eliminar la Pronvicia porque está en uso por una Localidad.");
            }
            else
            {

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta Provincia?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


                if (result == DialogResult.Yes)
                {
                    provinciaService.Delete(idProvincia);
                    MessageBox.Show("Provincia eliminada con éxito.");
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
            }
        }
    }
}
