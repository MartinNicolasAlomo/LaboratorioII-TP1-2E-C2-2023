using System.Windows.Forms;

namespace Vista_App
{
    public partial class frmIniciarSesion : Form
    {
        private string usuarioValido;
        private string contraseniaValida;

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
            //MessageBoxButtons
            //MessageBoxIcons
            string usuarioIngresado = tbxUsuario.Text;
            string contraseniaIngresada = tbxContrasenia.Text;

            if (usuarioIngresado == usuarioValido && contraseniaIngresada == contraseniaValida)
            {
                MessageBox.Show($"SE LOGRÓ INICIAR SESIÓN");
            }
            else
            {
                MessageBox.Show($"ERROR", $"111111", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}