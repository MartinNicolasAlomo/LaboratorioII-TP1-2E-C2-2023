using System.Windows.Forms;
using Logica_Sysacad;

namespace Vista_App
{
    public partial class frmIniciarSesion : Form
    {
        private string usuarioValido;
        private string claveValida;
        FrmMenuPrincipal menuPrincipal;

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
            string usuarioIngresado = tbxUsuario.Text;
            string claveIngresada = tbxClave.Text;
            if (!VerificarEsUsuarioIncorrecto(usuarioIngresado, claveIngresada))
            {
                Usuario? usuarioLogueado = SistemaUTN.ObtenerUsuario(usuarioIngresado, claveIngresada);
                if (usuarioLogueado != null)
                {
                    if (usuarioLogueado.GetType() == typeof(Administrador))
                    {
                        if (menuPrincipal == null)
                        {
                            menuPrincipal = new FrmMenuPrincipal(usuarioIngresado);
                            menuPrincipal.Show();
                            //this.Hide();
                        }
                    }
                    else if (usuarioLogueado.GetType() == typeof(Profesor))
                    {
                        //  Abrir el Form/Panel del PROFE
                    }
                    else
                    {
                        //  Abrir el Form/Panel del ESTUDIANTE
                    }
                }




            }

           
        }

        private bool VerificarEsUsuarioIncorrecto(string usuarioIngresado, string contraseniaIngresada)
        {
            if (Validador.VerificarEsTextoVacio(usuarioIngresado) || Validador.VerificarEsTextoVacio(contraseniaIngresada))
            {
                MessageBox.Show($"¡Faltan completar datos!", $"¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (usuarioIngresado != usuarioValido || contraseniaIngresada != claveValida)
            {
                MessageBox.Show($"¡El usuario o la contraseña son inválidos!", $"¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}