using System.Windows.Forms;
using Logica_Sysacad;

namespace Vista_App
{
    public partial class frmIniciarSesion : Form
    {
        private string usuarioValido;
        private string claveValida;
        FrmMenuPrincipal? menuPrincipal;
        Usuario? usuarioLogueado;

        public frmIniciarSesion()
        {
            InitializeComponent();
            usuarioValido = "jperez@utn.com";
            claveValida = "30321654";
            tbxUsuario.Text = usuarioValido;
            tbxClave.Text = claveValida;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string emailIngresado = tbxUsuario.Text;
            string claveIngresada = tbxClave.Text;
            if (ValidarUsuarioIngresado(out usuarioLogueado, emailIngresado, claveIngresada))
            {
                if (usuarioLogueado?.GetType() == typeof(Administrador) && menuPrincipal == null)
                {
                    menuPrincipal = new FrmMenuPrincipal(emailIngresado);
                    menuPrincipal.Show();
                    //this.Hide();
                }
                else if (usuarioLogueado?.GetType() == typeof(Estudiante))
                {
                    //  Abrir el Form/Panel del PROFE
                }
            }
        }

        private bool ValidarUsuarioIngresado(out Usuario? usuarioIngresado, string emailIngresado, string claveIngresada)
        {
            usuarioIngresado = null;
            if (Validador.VerificarEsDatoVacio(emailIngresado) || Validador.VerificarEsDatoVacio(claveIngresada))
            {
                MessageBox.Show($"¡Faltan completar datos!", $"¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            usuarioIngresado = SistemaUTN.ObtenerUsuario(emailIngresado, claveIngresada);
            if (usuarioIngresado is null)
            {
                MessageBox.Show($"¡El usuario o la contraseña son inválidos!", $"¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}