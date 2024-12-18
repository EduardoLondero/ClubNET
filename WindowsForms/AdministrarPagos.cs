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
            if (DateTime.TryParse(txtFechaPago.Text, out fechaPago))
            {
                MessageBox.Show($"Fecha válida: {fechaPago}");
            }
            else
            {
                MessageBox.Show("El formato de la fecha es inválido. Por favor, ingrese una fecha válida.");
            }

            int idMembresia;
            bool isInt = int.TryParse(txtIDMembresia.Text, out idMembresia);
            if (isInt != true)
            {
                MessageBox.Show("Se ha ingresado un ID Invalido");
            }
            int precio;
            bool priceIsInt = int.TryParse(txtPagoTotal.Text, out precio);
            if (priceIsInt != true)
            {
                MessageBox.Show("Se ha ingresado un monto invalido");
            }

            if (priceIsInt == true && isInt == true)
            {
                PagoService pagoService = new PagoService();

                Pago newPago = new Pago
                {
                    estado = pagoEstado,
                    fechaPago = fechaPago,
                    precioTotal = precio,
                    oMembresiaId = idMembresia,
                };

                pagoService.Add(newPago);
                MessageBox.Show("Pago Realizado Con Exito");
                this.Close();
            }
        }
    }
}
