using Domain.Model;
using Domain.Services;
using Microsoft.VisualBasic.ApplicationServices;
using Reports;
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
    public partial class MenuPago : Form
    {
        Usuario usuario;


        public MenuPago(Usuario user)
        {
            InitializeComponent();

            buscarPagos(dgvPagos, user);

            usuario = user;
        }


        public void buscarPagos(DataGridView dgvPagos, Usuario user)
        {
            UserServices usuarioService = new UserServices();
            MembresiaService membresiaService = new MembresiaService();
            PagoService pagoService = new PagoService();

            List<Membresia> membresias = membresiaService.ObtenerUsuarioMembresias(user.Id);

            var pagosView = new List<object>();

            foreach (var membresia in membresias)
            {
                Pago pago = pagoService.ObtenerPagosPorMembresia(membresia.id);

                if (pago != null)
                {
                    pagosView.Add(new
                    {
                        Id = pago.id,
                        Estado = pago.estado,
                        FechaPago = pago.fechaPago,
                        PrecioTotal = pago.precioTotal,
                        MembresiaDescripcion = pago.oMembresia?.oTipo_Membresia?.descripcion ?? "Sin descripción"
                    });
                }
            }

            dgvPagos.DataSource = pagosView;
        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonActualizar_Click(object sender, EventArgs e)
        {
            buscarPagos(dgvPagos, usuario);
        }

        private void btonGenerarReporte_Click(object sender, EventArgs e)
        {
            PagoService pagoService = new PagoService();
            List<Pago> pagos = pagoService.ObtenerPagosPorUsuario(usuario.Id);

            string filePath = "C:\\Reportes\\Pagos";

            ReporteService reporteService = new ReporteService();

            reporteService.GenerarReportePagos(filePath, usuario, pagos);

            MessageBox.Show("Reporte generado con éxito.");
        }


    }


}
