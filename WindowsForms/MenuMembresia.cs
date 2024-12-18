using Domain.Model;
using Domain;
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
    public partial class MenuMembresia : Form
    {

        Usuario usuario;


        public MenuMembresia(Usuario user)
        {
            InitializeComponent();

            buscarMembresias(dgvMembresia, user);

            buscarTipoMembresia(dgvTipoMembresia);

            usuario = user;
        }

        public void buscarTipoMembresia(DataGridView dgvTipoMembresia)
        {
            TipoMembresiaService tipoMembresiaService = new TipoMembresiaService();

            IEnumerable<Tipo_Membresia> membresias = tipoMembresiaService.GetAll();

            dgvTipoMembresia.DataSource = membresias.ToList();
        }



        private void buscarMembresias(DataGridView dgvMembresia, Usuario user)
        {
            UserServices userService = new UserServices();

            Usuario usuarioConMembresias = userService.Get(user.Id);

            if (usuarioConMembresias != null)
            {

                var membresiasFiltradas = usuarioConMembresias.Membresias
                    .Select(m => new
                    {
                        idMembresia = m.id,
                        FechaInicio = m.fechaInicio,
                        FechaFin = m.fechaFin,
                        FechaVencimiento = m.fechaVencimiento,
                        Descripcion = m.oTipo_Membresia.descripcion
                    })
                    .ToList();

                dgvMembresia.DataSource = membresiasFiltradas;
            }
            else
            {
                MessageBox.Show("No se encontraron Membresias");
            }
        }

        private void btonEliminar_Click(object sender, EventArgs e)
        {
            int idMembresia;
            bool esInt = int.TryParse(txtEliminarMembresia.Text, out idMembresia);

            if (!esInt)
            {
                MessageBox.Show("Ingrese un número válido como ID.");
                return; 
            }

            MembresiaService membresiaService = new MembresiaService();

            Membresia membresiaToDelete = membresiaService.Get(idMembresia);

            if (membresiaToDelete != null)
            {
                usuario.Membresias.Remove(membresiaToDelete);

                membresiaToDelete.fechaFin = DateTime.Now; 

                membresiaService.Update(membresiaToDelete);

                MessageBox.Show("Membresía eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("El ID ingresado es inválido.");
            }
        }


        private void btonInscribirse_Click(object sender, EventArgs e)
        {
            int idTipoMembresia;

            bool esInt = int.TryParse(txtTipoMembresia.Text, out idTipoMembresia);

            if (!esInt)
            {
                MessageBox.Show("El ID de tipo de membresía no es válido.");
                return;
            }

            MembresiaService membresiaService = new MembresiaService();
            TipoMembresiaService tipoMembresiaService = new TipoMembresiaService();
            UserServices usuarioService = new UserServices();

            Tipo_Membresia tipoMembresia = tipoMembresiaService.Get(idTipoMembresia);

            if (tipoMembresia == null)
            {
                MessageBox.Show("No se encontró el tipo de membresía.");
                return;
            }

            Membresia MembresiaNueva = new Membresia
            {
                fechaInicio = DateTime.Now,
                OUsuarioId = usuario.Id,


                oTipo_MembresiaId = tipoMembresia.Id,
            };

            membresiaService.add(MembresiaNueva);
        }

        private void btonActualizar_Click(object sender, EventArgs e)
        {
            buscarMembresias(dgvMembresia, usuario);
        }

        private void btonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
