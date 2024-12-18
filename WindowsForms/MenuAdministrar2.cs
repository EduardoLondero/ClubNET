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
    public partial class MenuAdministrar2 : Form
    {
        public MenuAdministrar2()
        {
            InitializeComponent();
        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonAdministrarUsuario_Click(object sender, EventArgs e)
        {
            AdministrarRoles form = new AdministrarRoles();

            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void btonAdministrarDeportes_Click(object sender, EventArgs e)
        {
            AdministrarLocalidad form = new AdministrarLocalidad();

            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void btonAdministrarMembresias_Click(object sender, EventArgs e)
        {
            AdministrarProvincia form = new AdministrarProvincia();

            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();    
        }
    }
}
