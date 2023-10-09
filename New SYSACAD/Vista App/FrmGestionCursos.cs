using Logica_Sysacad;
using System.Text;
using System.Windows.Forms;

namespace Vista_App
{
    public partial class FrmGestionCursos : Form
    {
        private DataGridViewCellEventArgs? seleccion;
        private Administrador administradorLogueado;

        public FrmGestionCursos(Administrador administradorLogueado)
        {
            InitializeComponent();
            this.administradorLogueado = administradorLogueado;
        }

        private void FrmGestionCursos_Load(object sender, EventArgs e)
        {
            EstablecerConfiguracionDataGrid();
            btnEditarCurso.Enabled = false;
            btnEliminarCurso.Enabled = false;
        }

        private void EstablecerConfiguracionDataGrid()
        {
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
            dgvListaCursos.Columns[9].Visible = false;
            dgvListaCursos.Columns[10].Visible = false;
            dgvListaCursos.Columns[11].Visible = false;
            dgvListaCursos.Columns[0].HeaderText = "Código";
            dgvListaCursos.Columns[2].HeaderText = "División";
            dgvListaCursos.Columns[4].HeaderText = "Día";
            dgvListaCursos.Columns[7].HeaderText = "Cupo Máx.";
            dgvListaCursos.Columns[8].HeaderText = "Cupo Disp.";
            dgvListaCursos.Columns[0].Width = 65;
            dgvListaCursos.Columns[1].Width = 225;
            dgvListaCursos.Columns[2].Width = 65;
            dgvListaCursos.Columns[3].Width = 80;
            dgvListaCursos.Columns[4].Width = 80;
            dgvListaCursos.Columns[6].Width = 60;
            dgvListaCursos.Columns[7].Width = 60;
            dgvListaCursos.Columns[8].Width = 60;
            foreach (DataGridViewColumn column in dgvListaCursos.Columns)
            {
                if (column.Index != 1)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            FrmAltaCurso? altaCurso = new FrmAltaCurso("Registrar nuevo curso");
            if (altaCurso.ShowDialog() == DialogResult.OK)
            {
                administradorLogueado.RegistrarCurso(altaCurso.CursoIngresado);
                MessageBox.Show(CrearMensajeConfirmacionRegistroCurso(altaCurso.CursoIngresado), $"¡Curso registrado corréctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            text.AppendLine($"¡Se guardaron los datos del Curso {nuevoCurso.NombreMateriaDivision}!")
                .AppendLine(nuevoCurso.MostrarDatos());
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
                    administradorLogueado.ModificarCurso(auxCurso, edicionCurso.CursoIngresado);
                    MessageBox.Show(CrearMensajeConfirmacionRegistroCurso(edicionCurso.CursoIngresado), $"¡Curso modificado corréctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string preguntaConfirmacion = $"¿Está seguro/a que desea confirmar la eliminación del curso {auxCurso.NombreMateriaDivision}?";
                if (FrmMensajeConfirmacion.PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                {
                    MessageBox.Show($"¡Se eliminó el curso {auxCurso.NombreMateriaDivision}!", $"¡Curso eliminado corréctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    administradorLogueado.EliminarCurso(auxCurso);
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
            if (indiceColumna >= 0 && indiceFila >= 0)
            {
                return SistemaUTN.BaseDatosCursos?[indiceFila];
            }
            return null;
        }

        public void ActualizarDataGridView()
        {
            dgvListaCursos.DataSource = null;
            EstablecerConfiguracionDataGrid();
        }
    }
}
