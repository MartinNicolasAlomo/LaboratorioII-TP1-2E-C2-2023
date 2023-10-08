using Logica_Sysacad;
using System.Text;
using System.Windows.Forms;

namespace Vista_App
{
    public partial class FrmGestionCursos : Form
    {
        #region CAMPOS Y CONSTRUCTORES
        private DataGridViewCellEventArgs? seleccion;

        public FrmGestionCursos()
        {
            InitializeComponent();
        }

        private void FrmGestionCursos_Load(object sender, EventArgs e)
        {
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
            dgvListaCursos.Columns[0].HeaderText = "Código";
            dgvListaCursos.Columns[3].HeaderText = "División";
            dgvListaCursos.Columns[4].HeaderText = "Materia";
            dgvListaCursos.Columns[6].HeaderText = "Día";
            dgvListaCursos.Columns[9].HeaderText = "Cupo Máx.";
            dgvListaCursos.Columns[10].HeaderText = "Cupo Disp.";
            ////  AGREGAR CUPO ACTUAL:    17/60
            //dgvListaCursos.Columns[5].DisplayIndex = 3;
            btnEditarCurso.Enabled = false;
            btnEliminarCurso.Enabled = false;
        }



        #endregion



        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            FrmAltaCurso? altaCurso = new FrmAltaCurso("Registrar nuevo curso");
            if (altaCurso.ShowDialog() == DialogResult.OK)
            {
                SistemaUTN.BaseDatosCursos?.Add(altaCurso.CursoIngresado);
                MessageBox.Show(CrearMensajeConfirmacionRegistroCurso(altaCurso.CursoIngresado), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show($"¡Se canceló el registro del curso!", $"¡Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CrearMensajeConfirmacionRegistroCurso(Curso nuevoCurso)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"¡Se guardaron los datos del Curso {nuevoCurso.Nombre}!").AppendLine()
                .AppendLine(nuevoCurso.MostrarDatos())
                ;
            return text.ToString();
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            Curso? auxCurso = ObtenerCursoDesdeDataGridView();
            if (auxCurso is not null)
            {
                FrmAltaCurso? edicionCurso = new FrmAltaCurso(auxCurso, "Modificar curso existente");
                if (edicionCurso.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(CrearMensajeConfirmacionRegistroCurso(edicionCurso.CursoIngresado), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show($"¡Se canceló la edición!", $"¡Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"¡No se pudo recuperar la informacion del curso seleccionado!", $"¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            Curso? auxCurso = ObtenerCursoDesdeDataGridView();
            if (auxCurso is not null)
            {
                //MessageBox.Show(auxCurso.MostrarDatos());
                string preguntaConfirmacion = $"¿Está seguro/a que desea confirmar la eliminación del curso {auxCurso.Materia} - {auxCurso.Nombre}?";
                if (FrmMensajeConfirmacion.PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                {
                    MessageBox.Show($"¡Se eliminó el curso {auxCurso.Materia} - {auxCurso.Nombre}!", $"¡Eliminado finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SistemaUTN.BaseDatosCursos?.Remove(auxCurso);
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show($"¡Se canceló la eliminación del curso!", $"¡Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"¡No se pudo recuperar la informacion del curso seleccionado!", $"¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvListaCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarCurso.Enabled = true;
            btnEliminarCurso.Enabled = true;
            seleccion = e;
        }

        private Curso? ObtenerCursoDesdeDataGridView()
        {
            int indiceFila = seleccion.RowIndex;
            int indiceColumna = seleccion.ColumnIndex;
            //  USAR  EXCEPCIONES   TRY CATCH
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            if (indiceColumna == 0)
            {
                indiceColumna = 1;
                if (indiceFila != -1 || indiceFila >= 0 && (indiceFila != -1 && indiceFila >= 0))
                {

                    return SistemaUTN.BaseDatosCursos?[indiceFila];
                }
            }
            return null;
        }

        public void ActualizarDataGridView()
        {
            dgvListaCursos.DataSource = null;
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
        }
    }
}
