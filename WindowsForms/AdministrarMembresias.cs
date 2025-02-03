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
    public partial class AdministrarMembresias : Form
    {
        public AdministrarMembresias()
        {
            InitializeComponent();

            TipoMembresiaService tipoMembresiaService = new TipoMembresiaService();


            var tipoMembresia = tipoMembresiaService.GetAll().ToList();

            cBoxTipoMembresia.DataSource = tipoMembresia;
            cBoxTipoMembresia.DisplayMember = "descripcion";
            cBoxTipoMembresia.ValueMember = "id";

            btonEditar.Enabled = false;
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

            if (cBoxTipoMembresia.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de membresía.");
                return;
            }

            int tipoMembresia = (int)cBoxTipoMembresia.SelectedValue;

            TipoMembresiaService tipoMembresiaService = new TipoMembresiaService();

            Tipo_Membresia tMembresia = tipoMembresiaService.Get(tipoMembresia);

            if (tMembresia == null)
            {
                MessageBox.Show("Tipo de membresía no encontrado.");
                return;
            }

            txtDescripcion.Text = tMembresia.descripcion;
            txtPrecio.Text = tMembresia.precioMembresia.ToString();
        }

        private void btonEditar_Click(object sender, EventArgs e)
        {
            EditarTipoMembresia();
        }

        private void btonCrear_Click(object sender, EventArgs e)
        {
            CrearTipoMembresia();
        }

        private void EditarTipoMembresia()
        {
            TipoMembresiaService tipoMembresiaService = new TipoMembresiaService();

            string descripcionTM = txtDescripcion.Text;
            string precioTexto = txtPrecio.Text;
            int precioTM;

            if (string.IsNullOrEmpty(descripcionTM))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            bool isINT = int.TryParse(precioTexto, out precioTM);
            if (!isINT || precioTM <= 0)
            {
                MessageBox.Show("El precio ingresado es inválido.");
                return;
            }

            int tipoMembresia = (int)cBoxTipoMembresia.SelectedValue;

            Tipo_Membresia tMembresia = tipoMembresiaService.Get(tipoMembresia);
            if (tMembresia == null)
            {
                MessageBox.Show("Tipo de Membresía no encontrado.");
                return;
            }

            tMembresia.descripcion = descripcionTM;
            tMembresia.precioMembresia = precioTM;
            tipoMembresiaService.Update(tMembresia);

            MessageBox.Show("Tipo de Membresía Editada Con Éxito");
        }

        private void CrearTipoMembresia()
        {
            TipoMembresiaService tipoMembresiaService = new TipoMembresiaService();

            string descripcionTM = txtDescripcion.Text;
            string precioTexto = txtPrecio.Text;
            int precioTM;

            if (string.IsNullOrEmpty(descripcionTM))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            bool isINT = int.TryParse(precioTexto, out precioTM);
            if (!isINT || precioTM <= 0)
            {
                MessageBox.Show("El precio ingresado es inválido.");
                return;
            }

            Tipo_Membresia tMembresia = new Tipo_Membresia
            {
                precioMembresia = precioTM,
                descripcion = descripcionTM
            };

            tipoMembresiaService.Add(tMembresia);

            MessageBox.Show("Tipo de Membresía Creada Con Éxito");
        }

        private void btonEliminar_Click(object sender, EventArgs e)
        {
            MembresiaService membresiaService = new MembresiaService();
            TipoMembresiaService tipoMembresiaService = new TipoMembresiaService();

            
            int idTipoMembresia = (int)cBoxTipoMembresia.SelectedValue;

            
            bool canDeletePagos = membresiaService.CanDeleteTipoRol(idTipoMembresia);
            
            if (!canDeletePagos )
            {
                MessageBox.Show("No se puede eliminar el Tipo Membresía porque está en uso por otra Membresia.");
                return;
            }

            
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar este Tipo Membresía?",
                "Confirmación de eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            
            if (result == DialogResult.Yes)
            {
                tipoMembresiaService.Delete(idTipoMembresia);
                MessageBox.Show("Tipo Membresía eliminada con éxito.");
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.");
            }
        }




        private void AdministrarMembresias_Load(object sender, EventArgs e)
        {
            btonEliminar.Enabled = false;
        }
    }
}
