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
        private Usuario? usuarioLogueado;

        public FrmLogin()
        {
            InitializeComponent();
            usuarioValido = "jperez@utn.com";
            claveValida = "30321654";
            tbxUsuario.Text = usuarioValido;
            tbxClave.Text = claveValida;
        }
        #endregion

        #region METODOS
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (menuPrincipal == null && ValidarUsuarioIngresado(out usuarioLogueado, tbxUsuario.Text, tbxClave.Text))
            {
                if (usuarioLogueado?.GetType() == typeof(Administrador))
                {
                    menuPrincipal = new FrmMenuPrincipal((Administrador)usuarioLogueado, this);
                    menuPrincipal.Show();
                    Hide();
                }

                else if (usuarioLogueado?.GetType() == typeof(Estudiante))
                {
                    //  Abrir el Form/Panel del PROFE
                }
            }
        }

        public void MostrarLogin()
        {
            Show();
            menuPrincipal = null;
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


        #endregion

    }
}