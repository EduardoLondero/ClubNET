using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Services;
using Domain.Model;


namespace WindowsForms
{
    public partial class MenuPrincipal : Form
    {
        string _rolusuario;

        Usuario user;

        public MenuPrincipal(string emailusuario, int rolUsuario, Usuario usario)
        {
            InitializeComponent();

            _rolusuario = emailusuario;

            lblusuario.Text = $"Bienvenido, {_rolusuario}";

            VerificarRolUsuario(rolUsuario);

            user = usario;

        }

        public void VerificarRolUsuario(int rolUsuario)
        {
            if (rolUsuario == 1)
            {
                btonAdministrar.Enabled = true;
            }

            else
            { btonAdministrar.Enabled = false; }
        }


        private void btonDeporte_Click(object sender, EventArgs e)
        {
            MenuInscripcion form = new MenuInscripcion(user);
            form.FormClosed += (s, args) => this.Show();


            this.Hide();
            form.Show();

        }


        private void btonUsuario_Click(object sender, EventArgs e)
        {
            MenuUsuario form = new MenuUsuario(user);
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();


        }

        private void btonMembresia_Click(object sender, EventArgs e)
        {
            MenuMembresia form = new MenuMembresia(user);

            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void btonPagos_Click(object sender, EventArgs e)
        {
            MenuPago form = new MenuPago(user);

            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();

        }

        private void btonAcercaDe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonAdministrar_Click(object sender, EventArgs e)
        {
            MenuAdministrar form = new MenuAdministrar();

            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();

        }
    }
}
