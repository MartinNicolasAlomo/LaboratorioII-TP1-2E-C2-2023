using Logica_Sysacad;
using System.Text;

namespace Vista_App
{
    public partial class FrmGestionCursos : Form
    {
        #region CAMPOS Y CONSTRUCTORES
        private FrmMenuPrincipal? menuPrincipal;
        private List<Curso> listaCursos;

        public FrmGestionCursos(FrmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            listaCursos = new List<Curso>();
        }

        #endregion



        #region A) AGREGAR CURSO
        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            FrmAltaCurso? altaCurso = new FrmAltaCurso("Registrar nuevo curso");
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

        #endregion



        #region B) MODIFICAR CURSO
        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            if (true)
            {
                FrmAltaCurso? altaCurso = new FrmAltaCurso("Modificar curso existente");
                if (altaCurso.ShowDialog() == DialogResult.OK)
                {
                    listaCursos.Add(altaCurso.NuevoCurso);
                    StringBuilder text = new StringBuilder();
                    text.AppendLine($"¡Se MODIFICARON los datos del CURSO {altaCurso.NuevoCurso?.Nombre}!").AppendLine();
                    MessageBox.Show(text.ToString(), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"¡Se Cancelo la edicion!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion


        #region C) ELIMINAR CURSO
        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            // remove(),
        }

        #endregion


        private void FrmGestionCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuPrincipal?.MostrarMenuPrincipal();
        }

    }
}
