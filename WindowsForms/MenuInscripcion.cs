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
    public partial class MenuInscripcion : Form
    {

        Usuario usuario;

        public MenuInscripcion(Usuario user)
        {
            InitializeComponent();

            cargarDeportes(dgvDeportes);

            buscarMembresias(dgvMembresia, user);

            usuario = user;
        }

        public void cargarDeportes(DataGridView dgvDeportes)
        {
            DeporteService deporteService = new DeporteService();

            IEnumerable<Deporte> deportes = deporteService.GetAll();

            dgvDeportes.DataSource = deportes.ToList();

        }

        private void btonInscribirse_Click(object sender, EventArgs e)
        {
            DeporteService deporteService = new DeporteService();
            MembresiaService membresiaService = new MembresiaService();
            MembresiaDeporteService membresiaDeporteService = new MembresiaDeporteService();

   
            if (!int.TryParse(txtIdDeporte.Text, out int idDeporte) || !int.TryParse(txtMembresiaId.Text, out int idMembresia))
            {
                MessageBox.Show("Por favor, ingrese valores válidos para los IDs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        
            bool yaInscripto = membresiaDeporteService.ExisteInscripcion(idDeporte, idMembresia);

            if (yaInscripto)
            {
                MessageBox.Show("Ya está inscrito a este deporte con esta membresía.", "Inscripción duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Membresia_deporte nuevaInscripcion = new Membresia_deporte
            {
                oDeporteId = idDeporte,
                oMembresiaId = idMembresia,
            };

            membresiaDeporteService.Add(nuevaInscripcion);


            Deporte nuevoDeporte = deporteService.Get(idDeporte);
            Membresia nuevaMembresia = membresiaService.Get(idMembresia);

            string nombreDeporte = nuevoDeporte?.nombreDeporte ?? "Desconocido";
            string nombreMembresia = nuevaMembresia?.oTipo_Membresia?.descripcion ?? "Sin tipo de membresía";

          
            string mensaje = $"Usted se ha inscripto al deporte {nombreDeporte} en su membresía {nombreMembresia}.";
            MessageBox.Show(mensaje, "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buscarMembresias(DataGridView dgvMembresia, Usuario user)
        {
            UserServices userService = new UserServices();


            Usuario usuarioConMembresias = userService.Get(user.Id);

            if (usuarioConMembresias != null && usuarioConMembresias.Membresias != null && usuarioConMembresias.Membresias.Any())
            {

                var membresiasProyectadas = usuarioConMembresias.Membresias.Select(m => new
                {
                    id = m.id,
                    Descripcion = m.oTipo_Membresia?.descripcion ?? "Sin descripción",
                    FechaFin = m.fechaFin
                })
                .Where(m => m.FechaFin == null)
                .ToList();


                dgvMembresia.DataSource = membresiasProyectadas;
            }
            else
            {
                MessageBox.Show("No se encontraron Membresías");
            }
        }


        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
