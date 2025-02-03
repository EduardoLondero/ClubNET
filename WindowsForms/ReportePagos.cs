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
    public partial class ReportePagos : Form
    {
        public ReportePagos()
        {
            InitializeComponent();
            cargarPagos(dgvReporte);
        }

        private void cargarPagos(DataGridView dgvReporte)
        {
            PagoService pagoService = new PagoService();

            var pagos = pagoService.GetAll()
                .Select(p => new
                {
                    p.id,
                    p.estado,
                    p.fechaPago,
                    p.precioTotal,
                    UsuarioEmail = p.oMembresia.oUsuario.email 
                })
                .ToList();

            dgvReporte.DataSource = pagos;
        }


        private void btonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
