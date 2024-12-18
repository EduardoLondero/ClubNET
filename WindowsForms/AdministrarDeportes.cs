using Domain.Services;
using Domain.Model;
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
    public partial class AdministrarDeportes : Form
    {
        public AdministrarDeportes()
        {
            InitializeComponent();

            cargarDeportes();

        }

        public void cargarDeportes()
        {
            DeporteService deporteService = new DeporteService();

            var deportes = deporteService.GetAll();

            cBoxDeporte.DataSource = deportes;
            cBoxDeporte.DisplayMember = "nombreDeporte";
            cBoxDeporte.ValueMember = "id";


        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonBuscar_Click(object sender, EventArgs e)
        {
            btonEliminar.Enabled = true;

            btonCrear.Enabled = false;

            int idDeporte = (int)cBoxDeporte.SelectedValue;

            DeporteService deporteService = new DeporteService();


            Deporte deporteNuevo = deporteService.Get(idDeporte);


            if (deporteNuevo == null)
            {
                MessageBox.Show("No se encontró un deporte con el ID proporcionado");
                return;
            }


            txtNombreDeporte.Text = deporteNuevo.nombreDeporte;
            txtHoraInicio.Text = deporteNuevo.horaInicio;
            txtHoraFin.Text = deporteNuevo.horaFin;
            txtPrecioDeporte.Text = deporteNuevo.precio.ToString();
        }


        private void btonEditar_Click(object sender, EventArgs e)
        {
            int idDeporte = (int)cBoxDeporte.SelectedValue;

            DeporteService deporteService = new DeporteService();

            string nombreDeporte = txtNombreDeporte.Text;
            string horaInicio = txtHoraInicio.Text;
            string horaFin = txtHoraFin.Text;


            if (!int.TryParse(txtPrecioDeporte.Text, out int precio))
            {
                MessageBox.Show("Precio ingresado inválido");
                return;
            }


            Deporte deporteToUpdate = deporteService.Get(idDeporte);
            if (deporteToUpdate == null)
            {
                MessageBox.Show("Deporte no encontrado con el ID proporcionado");
                return;
            }


            deporteToUpdate.nombreDeporte = nombreDeporte;
            deporteToUpdate.precio = precio;
            deporteToUpdate.horaInicio = horaInicio;
            deporteToUpdate.horaFin = horaFin;


            deporteService.Update(deporteToUpdate);

            MessageBox.Show("Deporte actualizado correctamente");
        }

        private void btonCrear_Click(object sender, EventArgs e)
        {
            DeporteService deporteService = new DeporteService();

            string nombreDeporte = txtNombreDeporte.Text;
            string horaInicio = txtHoraInicio.Text;
            string horaFin = txtHoraFin.Text;


            if (!int.TryParse(txtPrecioDeporte.Text, out int precio))
            {
                MessageBox.Show("Precio ingresado inválido");
                return;
            }


            Deporte deporteNuevo = new Deporte
            {
                nombreDeporte = nombreDeporte,
                horaInicio = horaInicio,
                horaFin = horaFin,
                precio = precio
            };


            deporteService.add(deporteNuevo);

            MessageBox.Show("Deporte Creado Con Exito");

            cargarDeportes();
        }

        private void btonEliminar_Click(object sender, EventArgs e)
        {
            

            DeporteService deporteService = new DeporteService();
            MembresiaDeporteService membresiaDeporteService = new MembresiaDeporteService();


            int idDeporte = (int)cBoxDeporte.SelectedValue;


            bool canDelete = membresiaDeporteService.CanDeleteDeporte(idDeporte);

            if (!canDelete)
            {

                MessageBox.Show("No se puede eliminar el deporte porque está en uso por un usuario.");
            }
            else
            {

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este deporte?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


                if (result == DialogResult.Yes)
                {
                    deporteService.Delete(idDeporte);
                    MessageBox.Show("Deporte eliminado con éxito.");
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
            }
        }

        private void AdministrarDeportes_Load(object sender, EventArgs e)
        {
            btonEliminar.Enabled = false;
        }
    }
}
