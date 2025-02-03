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
    public partial class AdministrarPagos : Form
    {
        public AdministrarPagos()
        {


            InitializeComponent();
        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonFinalizar_Click(object sender, EventArgs e)
        {
            string pagoEstado = txtEstado.Text;

            DateTime fechaPago;
            if (!DateTime.TryParse(txtFechaPago.Text, out fechaPago))
            {
                MessageBox.Show("El formato de la fecha es inválido. Por favor, ingrese una fecha válida.");
                return;
            }

            int idMembresia;
            if (!int.TryParse(txtIDMembresia.Text, out idMembresia))
            {
                MessageBox.Show("Se ha ingresado un ID inválido.");
                return;
            }

            int precio;
            if (!int.TryParse(txtPagoTotal.Text, out precio))
            {
                MessageBox.Show("Se ha ingresado un monto inválido.");
                return;
            }

            MembresiaService membresiaService = new MembresiaService();
            
            if (membresiaService.Get(idMembresia) == null)
            {
                MessageBox.Show("No existe ninguna membresia con esa ID");
                return;
            }


            PagoService pagoService = new PagoService();

            Pago newPago = new Pago
            {
                estado = pagoEstado,
                fechaPago = fechaPago,
                precioTotal = precio,
                oMembresiaId = idMembresia,
            };

            pagoService.Add(newPago);
            MessageBox.Show("Pago Realizado Con Éxito");
            this.Close();
        }

    }
}
