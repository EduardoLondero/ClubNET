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
using Domain.Reports;

namespace WindowsForms
{
    public partial class AdministrarDeportes : Form
    {
        public AdministrarDeportes()
        {
            InitializeComponent();

            cargarDeportes();

            btonEditar.Enabled = false;
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

            btonEditar.Enabled = true;

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

            if (!IsValidTimeFormat(horaInicio))
            {
                MessageBox.Show("La hora de inicio debe tener un formato válido (HH:mm).");
                return;
            }

            if (!IsValidTimeFormat(horaFin))
            {
                MessageBox.Show("La hora de fin debe tener un formato válido (HH:mm).");
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


            if (string.IsNullOrWhiteSpace(nombreDeporte))
            {
                MessageBox.Show("El nombre del deporte no puede estar vacío.");
                return;
            }

            if (!int.TryParse(txtPrecioDeporte.Text, out int precio))
            {
                MessageBox.Show("Precio ingresado inválido.");
                return;
            }

            if (!IsValidTimeFormat(horaInicio))
            {
                MessageBox.Show("La hora de inicio debe tener un formato válido (HH:mm).");
                return;
            }

            if (!IsValidTimeFormat(horaFin))
            {
                MessageBox.Show("La hora de fin debe tener un formato válido (HH:mm).");
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


            MessageBox.Show("Deporte creado con éxito");

            cargarDeportes();
        }

        private bool IsValidTimeFormat(string time)
        {
            return TimeSpan.TryParse(time, out _);
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

        private void btonGenerarReporte_Click(object sender, EventArgs e)
        {
            int idDeporte = (int)cBoxDeporte.SelectedValue;

            DeporteService deporteService = new DeporteService();
            MembresiaDeporteService membresiaDeporteService = new MembresiaDeporteService();

            Deporte deporte = deporteService.Get(idDeporte);
            if (deporte == null)
            {
                MessageBox.Show("No se encontró el deporte seleccionado.");
                return;
            }

            List<Membresia_deporte> membresias = membresiaDeporteService.GetMembresiasByDeporteId(idDeporte);

            List<Usuario> usuarios = new List<Usuario>();
            foreach (var membresia in membresias)
            {
                if (membresia.oMembresia?.oUsuario != null)
                {
                    usuarios.Add(membresia.oMembresia.oUsuario);
                }
            }

            if (usuarios.Count == 0)
            {
                MessageBox.Show("No hay usuarios inscritos en este deporte.");
                return;
            }

            ReporteDeporteService reporteService = new ReporteDeporteService();
            reporteService.GenerarReporteInscritos("C:\\Reportes\\Deportes", deporte, usuarios);

            MessageBox.Show("Reporte generado con éxito.");
        }

    }
}
