using System.Windows.Forms;

namespace Vista_App
{
    public partial class frmIniciarSesion : Form
    {
        private string usuarioValido;
        private string contraseniaValida;
        FrmMenuPrincipal menuPrincipal;

        public frmIniciarSesion()
        {
            InitializeComponent();
            usuarioValido = "asd";
            contraseniaValida = "123";
            tbxUsuario.Text = usuarioValido;
            tbxContrasenia.Text = contraseniaValida;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = tbxUsuario.Text;
            string contraseniaIngresada = tbxContrasenia.Text;

            if (usuarioIngresado == usuarioValido && contraseniaIngresada == contraseniaValida)
            {
                if (menuPrincipal == null)
                {
                    menuPrincipal = new FrmMenuPrincipal(usuarioIngresado);
                    menuPrincipal.Show();
                    //this.Hide();
                }
            }
            else
            {
                MessageBox.Show($"El usuario o la contraseña son inválidos", $"¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}