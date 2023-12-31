using System.Windows.Forms;
using Logica_Sysacad;

namespace Vista_App
{
    public partial class FrmLogin : Form
    {
        private string? usuarioValido;
        private string? claveValida;
        private FrmMenuPrincipal? menuPrincipal;
        private FrmMenuEstudiante? menuEstudiante;
        private Usuario? usuarioLogueado;

        public FrmLogin()
        {
            InitializeComponent();
            usuarioValido = "ma@gmail.com";
            claveValida = "40916734";
            tbxUsuario.Text = usuarioValido;
            tbxClave.Text = claveValida;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (menuPrincipal == null && menuEstudiante == null && ValidarUsuarioIngresado(out usuarioLogueado, tbxUsuario.Text, tbxClave.Text))
            {
                if (usuarioLogueado?.GetType() == typeof(Administrador))
                {
                    menuPrincipal = new FrmMenuPrincipal((Administrador)usuarioLogueado, this);
                    menuPrincipal.Show();
                    Hide();
                }
                else if (usuarioLogueado?.GetType() == typeof(Estudiante))
                {
                    menuEstudiante = new FrmMenuEstudiante((Estudiante)usuarioLogueado, this);
                    menuEstudiante.Show();
                    Hide();
                }
            }
        }

        public void MostrarLogin()
        {
            Show();
            menuPrincipal = null;
            menuEstudiante = null;
            tbxUsuario.Text = string.Empty;
            tbxClave.Text = string.Empty;
        }

        private bool ValidarUsuarioIngresado(out Usuario? usuarioIngresado, string emailIngresado, string claveIngresada)
        {
            if (Validador.VerificarEsDatoVacio(emailIngresado) || Validador.VerificarEsDatoVacio(claveIngresada))
            {
                MessageBox.Show($"�Faltan completar datos!", $"�Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioIngresado = null;
                return false;
            }
            usuarioIngresado = SistemaUTN.ObtenerUsuario(emailIngresado, claveIngresada);
            if (usuarioIngresado is null)
            {
                MessageBox.Show($"�El usuario o la contrase�a son inv�lidos!", $"�Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void btnCompletarDatosAdministrador_Click(object sender, EventArgs e)
        {
            usuarioValido = "jdiaz@utn.com";
            claveValida = "30303030";
            tbxUsuario.Text = usuarioValido;
            tbxClave.Text = claveValida;
        }

        private void btnCompletarDatosEstudiante_Click(object sender, EventArgs e)
        {
            usuarioValido = "ma@gmail.com";
            claveValida = "40916734";
            tbxUsuario.Text = usuarioValido;
            tbxClave.Text = claveValida;
        }
    }
}