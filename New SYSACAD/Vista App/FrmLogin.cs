using System.Windows.Forms;
using Logica_Sysacad;

namespace Vista_App
{
    #region AAAA


    #endregion

    public partial class FrmLogin : Form
    {
        #region CAMPOS Y CONSTRUCTORES
        private string usuarioValido;
        private string claveValida;
        private FrmMenuPrincipal? menuPrincipal;
        private FrmMenuEstudiante? menuEstudiante;
        private Usuario? usuarioLogueado;

        public FrmLogin()
        {
            InitializeComponent();
            usuarioValido = "ma@gmail.com";
            claveValida = "40916734";
            //usuarioValido = "jdiaz@utn.com";
            //claveValida = "30303030";
            tbxUsuario.Text = usuarioValido;
            tbxClave.Text = claveValida;
        }
        #endregion

        #region METODOS
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //  REVISAR MENUS SON NULOS ???
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

        /*
         metodo
        si aprieto ctrl + esc se cierra el programa
         
            Application.Exit();
         */

        #endregion

    }
}