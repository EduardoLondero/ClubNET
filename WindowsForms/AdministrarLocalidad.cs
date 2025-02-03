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
    public partial class AdministrarLocalidad : Form
    {
        public AdministrarLocalidad()
        {
            
            InitializeComponent();
            cargarProvincia();
            cargarLocalidades();
            btonEditar.Enabled = false;
        }


        private void cargarLocalidades()
        {
            LocalidadService localidadService = new LocalidadService();

            var localidades = localidadService.GetAll();

            cBoxLocalidad.DataSource = localidades;
            cBoxLocalidad.DisplayMember = "nombreLocalidad";
            cBoxLocalidad.ValueMember = "Id";

        }

        private void cargarProvincia()
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
            btonEliminar.Enabled = true;

            LocalidadService localidadService = new LocalidadService();

            int idLocalidad = (int)cBoxLocalidad.SelectedValue;


            Localidad localidadToUpdate = new Localidad();

            localidadToUpdate = localidadService.Get(idLocalidad);

            int oProvinciaId = localidadToUpdate.oProvinciaId;

            txtNombreLocalidad.Text = localidadToUpdate.nombreLocalidad;
            txtCodigoPostal.Text = localidadToUpdate.codigoPostal.ToString();

            cBoxProvincia.SelectedValue = oProvinciaId;

        }

        private void btonEditar_Click(object sender, EventArgs e)
        {
            LocalidadService localidadService = new LocalidadService();

            if (cBoxLocalidad.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una localidad.");
                return;
            }

            int idLocalidad = (int)cBoxLocalidad.SelectedValue;
            Localidad localidadToUpdate = localidadService.Get(idLocalidad);

            if (localidadToUpdate == null)
            {
                MessageBox.Show("La localidad no existe.");
                return;
            }

            string nombreLocalidad = txtNombreLocalidad.Text;
            if (string.IsNullOrEmpty(nombreLocalidad))
            {
                MessageBox.Show("El nombre de la localidad no puede estar vacío.");
                return;
            }

            bool isInt = int.TryParse(txtCodigoPostal.Text, out int codigoPostal);
            if (!isInt)
            {
                MessageBox.Show("Código Postal ingresado es inválido");
                return;
            }

            if (cBoxProvincia.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una provincia.");
                return;
            }

            localidadToUpdate.nombreLocalidad = nombreLocalidad;
            localidadToUpdate.codigoPostal = codigoPostal;
            localidadToUpdate.oProvinciaId = (int)cBoxProvincia.SelectedValue;

            localidadService.Update(localidadToUpdate);
            MessageBox.Show("Localidad actualizada con éxito");

            cargarLocalidades();
            cargarProvincia();
        }

        private void btonCrear_Click(object sender, EventArgs e)
        {
            LocalidadService localidadService = new LocalidadService();

            string nombreLocalidad = txtNombreLocalidad.Text;
            if (string.IsNullOrEmpty(nombreLocalidad))
            {
                MessageBox.Show("El nombre de la localidad no puede estar vacío.");
                return;
            }

            bool isInt = int.TryParse(txtCodigoPostal.Text, out int codigoPostal);
            if (!isInt)
            {
                MessageBox.Show("Código Postal ingresado es inválido");
                return;
            }

            if (cBoxProvincia.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una provincia.");
                return;
            }

            int idProvincia = (int)cBoxProvincia.SelectedValue;

            Localidad localidadToAdd = new Localidad
            {
                nombreLocalidad = nombreLocalidad,
                codigoPostal = codigoPostal,
                oProvinciaId = idProvincia
            };

            localidadService.Add(localidadToAdd);
            MessageBox.Show("Localidad creada con éxito");

            cargarLocalidades();
            cargarProvincia();
        }


        private void btonEliminar_Click(object sender, EventArgs e)
        {
            LocalidadService localidadService = new LocalidadService();
            UserServices userServices = new UserServices();

            
            int idLocalidad = (int)cBoxLocalidad.SelectedValue;

           
            bool canDelete = userServices.CanDelete(idLocalidad);

            if (!canDelete)
            {
                
                MessageBox.Show("No se puede eliminar la localidad porque está en uso por un usuario.");
            }
            else
            {
                
                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta localidad?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                
                if (result == DialogResult.Yes)
                {
                    localidadService.Delete(idLocalidad);
                    MessageBox.Show("Localidad eliminada con éxito.");
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
            }
        }

        private void AdministrarLocalidad_Load(object sender, EventArgs e)
        {
            btonEliminar.Enabled = false;
        }
    }
}
