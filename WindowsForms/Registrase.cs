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
            string newcontraseña = txtContraseña.Text;
            int idLocalidad;
            bool idLocalidadIsInt = int.TryParse(txtLocalidad.Text, out idLocalidad);

            if (string.IsNullOrEmpty(newEmail) || string.IsNullOrEmpty(newDireccion) || string.IsNullOrEmpty(newcontraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return;
            }

            if (telefonoIsInt == false)
            {
                MessageBox.Show("El número de teléfono debe ser un valor numérico.");
                return;
            }

            if (idLocalidadIsInt == false)
            {
                MessageBox.Show("El ID de localidad debe ser un valor numérico.");
                return;
            }



            if (idLocalidadIsInt == true && telefonoIsInt == true)
            {

                UserServices usuarioService = new UserServices();

                Usuario newUsuario = new Usuario
                {
                    email = newEmail,
                    telefono = nroTelefono,
                    contraseña = newcontraseña,
                    direccion = newDireccion,
                    oLocalidadId = idLocalidad,
                    oRolId = 0
                };


                usuarioService.Add(newUsuario);

                MessageBox.Show("Usuario Creado Exitosamente");

                this.Close();

            }


        }
    }
}
