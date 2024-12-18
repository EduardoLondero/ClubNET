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
    public partial class MenuAdministrar : Form
    {
        public MenuAdministrar()
        {
            InitializeComponent();
        }

        private void btonAdministrarPagos_Click(object sender, EventArgs e)
        {
            AdministrarPagos form = new AdministrarPagos();

            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();

        }

        private void btonAdministrarUsuario_Click(object sender, EventArgs e)
        {
            AdministrarUsuario form = new AdministrarUsuario();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void btonAdministrarDeportes_Click(object sender, EventArgs e)
        {
            AdministrarDeportes form = new AdministrarDeportes();

            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void btonAdministrarMembresias_Click(object sender, EventArgs e)
        {
            AdministrarMembresias form = new AdministrarMembresias();

            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonSiguiente_Click(object sender, EventArgs e)
        {
            MenuAdministrar2 form = new MenuAdministrar2();

            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }
    }
}
