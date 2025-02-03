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
    public partial class Registrase : Form
    {
        public Registrase()
        {
            InitializeComponent();

            buscarProvincia(dgvProvincia);
            buscarLocalidad(dgvLocalidad);
        }


        public void buscarProvincia(DataGridView dgvProvincia)
        {
            ProvinciaService provinciaService = new ProvinciaService();

            IEnumerable<Provincia> provincias = provinciaService.GetAll();

            var provinciasProyectadas = provincias.Select(p => new
            {
                p.nombreProvincia,
                p.Id
            });

            dgvProvincia.DataSource = provinciasProyectadas.ToList();
        }



        public void buscarLocalidad(DataGridView dgvLocalidad)
        {
            LocalidadService localidadService = new LocalidadService();

            IEnumerable<Localidad> localidades = localidadService.GetAll();

            var localidadesProyectadas = localidades.Select(l => new
            {
                l.nombreLocalidad,
                l.codigoPostal,
                l.Id
            });

            dgvLocalidad.DataSource = localidadesProyectadas.ToList();
        }


        private void btonRegistrar_Click(object sender, EventArgs e)
        {
            string newEmail = txtEmail.Text;
            int nroTelefono;
            bool telefonoIsInt = int.TryParse(txtTelefono.Text, out nroTelefono);
            string newDireccion = txtDireccion.Text;
            string newContraseña = txtContraseña.Text;
            int idLocalidad;
            bool idLocalidadIsInt = int.TryParse(txtLocalidad.Text, out idLocalidad);

            if (string.IsNullOrEmpty(newEmail) || string.IsNullOrEmpty(newDireccion) || string.IsNullOrEmpty(newContraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return;
            }

            if (!IsValidEmail(newEmail))
            {
                MessageBox.Show("El formato del correo electrónico es inválido.");
                return;
            }

            if (!telefonoIsInt || txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El número de teléfono debe ser un valor numérico con 10 dígitos.");
                return;
            }

            if (newContraseña.Length < 1 || newContraseña.Length > 50)
            {
                MessageBox.Show("La contraseña debe tener entre 1 y 50 caracteres.");
                return;
            }

            if (!idLocalidadIsInt)
            {
                MessageBox.Show("El ID de localidad debe ser un valor numérico.");
                return;
            }

            UserServices usuarioService = new UserServices();

            Usuario newUsuario = new Usuario
            {
                email = newEmail,
                telefono = nroTelefono,
                contraseña = newContraseña,
                direccion = newDireccion,
                oLocalidadId = idLocalidad,
                oRolId = 7
            };

            usuarioService.Add(newUsuario);

            MessageBox.Show("Usuario Creado Exitosamente");

            this.Close();
        }

        
        private bool IsValidEmail(string email)
        {
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }

    }
}
