using Domain.Model;
using Domain.Services;


namespace WindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            
            string emails = txtEmail.Text;
            string password = txtPass.Text;

            UserServices userService = new UserServices();


            Usuario? usuario = userService.GetAll()
                                          .FirstOrDefault(u => u.email == emails && u.contraseña == password);

            if (usuario != null)
            {

                string email = usuario.email;
                int rolUsuario = usuario.oRolId;

                MenuPrincipal form = new MenuPrincipal(email, rolUsuario, usuario);
                form.FormClosed += (s, args) => this.Show(); 
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
                limpiarBox();
        }

        public void limpiarBox()
        {

            txtEmail.Text = "";
            txtPass.Text = "";

        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            Registrase form = new Registrase();

            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();
        }
    }
}

