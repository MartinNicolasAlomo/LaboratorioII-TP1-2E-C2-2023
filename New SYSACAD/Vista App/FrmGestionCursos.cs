using Logica_Sysacad;
using System.Text;

namespace Vista_App
{
    public partial class FrmGestionCursos : Form
    {
        private FrmMenuPrincipal? menuPrincipal;
        private List<Curso> listaCursos;

        public FrmGestionCursos(FrmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            listaCursos = new List<Curso>();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            FrmAltaCurso? altaCurso = new FrmAltaCurso();
            if (altaCurso.ShowDialog() == DialogResult.OK)
            {
                listaCursos.Add(altaCurso.NuevoCurso);
                StringBuilder text = new StringBuilder();
                text.AppendLine($"¡Se guardaron los datos del CURSO {altaCurso.NuevoCurso?.Nombre}!").AppendLine();
                MessageBox.Show(text.ToString(), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"¡Se Cancelo el registro!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGestionCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuPrincipal?.MostrarMenuPrincipal();
        }



    }
}
