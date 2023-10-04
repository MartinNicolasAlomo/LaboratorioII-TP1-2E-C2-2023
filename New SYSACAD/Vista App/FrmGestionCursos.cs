using Logica_Sysacad;
using System.Text;
using System.Windows.Forms;

namespace Vista_App
{
    public partial class FrmGestionCursos : Form
    {
        #region CAMPOS Y CONSTRUCTORES
        //private FrmMenuPrincipal? menuPrincipal;
        private DataGridViewCellEventArgs? seleccion;

        public FrmGestionCursos()
        {
            InitializeComponent();
            //this.menuPrincipal = menuPrincipal;
        }

        private void FrmGestionCursos_Load(object sender, EventArgs e)
        {
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
            dgvListaCursos.Columns[0].HeaderText = "Código";
            dgvListaCursos.Columns[3].HeaderText = "División";
            dgvListaCursos.Columns[4].HeaderText = "Descripción";
            dgvListaCursos.Columns[6].HeaderText = "Día";
            dgvListaCursos.Columns[9].HeaderText = "Cupo Máx.";
            dgvListaCursos.Columns[10].HeaderText = "Cupo Disp.";
            ////  AGREGAR CUPO ACTUAL:    17/60
            //dgvListaCursos.Columns[5].DisplayIndex = 3;
            btnEditarCurso.Enabled = false;
            btnEliminarCurso.Enabled = false;
        }



        #endregion



        #region A) AGREGAR CURSO
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
                MessageBox.Show($"¡Se canceló el agregado!", $"¡Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        #endregion


        #region B) MODIFICAR CURSO
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


        #endregion


        #region C) ELIMINAR CURSO
        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            Curso? auxCurso = ObtenerCursoDesdeDataGridView();
            if (auxCurso is not null)
            {
                //MessageBox.Show(auxCurso.MostrarDatos());
                string preguntaConfirmacion = $"¿Está seguro/a que desea confirmar la eliminación del curso {auxCurso.Descripcion} - {auxCurso.Nombre}?";
                if (FrmMensajeConfirmacion.PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                {
                    MessageBox.Show($"¡Se eliminó el curso {auxCurso.Descripcion} - {auxCurso.Nombre}!", $"¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SistemaUTN.BaseDatosCursos?.Remove(auxCurso);
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show($"¡Se canceló el eliminado!", $"¡Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"¡No se pudo recuperar la informacion del curso seleccionado!", $"¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion



        private void dgvListaCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarCurso.Enabled = true;
            btnEliminarCurso.Enabled = true;
            seleccion = e;
        }

        private Curso? ObtenerCursoDesdeDataGridView()
        {
            int indice = seleccion.RowIndex;
            //  USAR  EXCEPCIONES   TRY CATCH
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            if (indice != -1 && indice >= 0)
            {
                return SistemaUTN.BaseDatosCursos?[indice];
            }
            return null;
        }

        public void ActualizarDataGridView()
        {
            dgvListaCursos.DataSource = null;
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
        }

        private void FrmGestionCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //menuPrincipal?.MostrarMenu();
        }

    }
}
