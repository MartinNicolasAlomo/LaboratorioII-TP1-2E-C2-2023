using Logica_Sysacad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_App
{
    public partial class FrmInscripcionCursos : Form
    {
        private Estudiante estudianteLogueado;
        private List<Curso> cursosSeleccionados;
        private string? cuatrimestreIngresado;
        private string? materiaIngresada;

        public FrmInscripcionCursos(Estudiante estudianteLogueado)
        {
            InitializeComponent();
            this.estudianteLogueado = estudianteLogueado;
            cursosSeleccionados = new List<Curso>();
            base.Text = $"Inscripción a Cursos C2, 2023 - {estudianteLogueado.NombreCompletoOrdenApellido}";
        }

        private void FrmInscripcionCursos_Load(object sender, EventArgs e)
        {
            cbxCuatrimestre.DataSource = Curso.CuatrimestresDisponibles;
            cbxCuatrimestre.SelectedIndex = 0;
            DataGridViewCheckBoxColumn columnaCheckBox = new DataGridViewCheckBoxColumn();
            columnaCheckBox.Name = "CursoSeleccionado";
            columnaCheckBox.HeaderText = "Seleccionado";
            columnaCheckBox.Width = 100;
            columnaCheckBox.ReadOnly = false;
            dgvListaCursos.Columns.Add(columnaCheckBox);
            EstablecerConfiguracionDataGrid();
        }


        private void EstablecerConfiguracionDataGrid()
        {
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
            dgvListaCursos.Columns[10].Visible = false;
            dgvListaCursos.Columns[11].Visible = false;
            dgvListaCursos.Columns[12].Visible = false;
            dgvListaCursos.Columns[1].HeaderText = "Código";
            dgvListaCursos.Columns[3].HeaderText = "División";
            dgvListaCursos.Columns[5].HeaderText = "Día";
            dgvListaCursos.Columns[8].HeaderText = "Cupo Máx.";
            dgvListaCursos.Columns[9].HeaderText = "Cupo Disp.";
            dgvListaCursos.Columns[1].Width = 65;
            dgvListaCursos.Columns[2].Width = 225;
            dgvListaCursos.Columns[3].Width = 65;
            dgvListaCursos.Columns[4].Width = 80;
            dgvListaCursos.Columns[5].Width = 80;
            dgvListaCursos.Columns[7].Width = 60;
            dgvListaCursos.Columns[8].Width = 60;
            dgvListaCursos.Columns[9].Width = 60;
            foreach (DataGridViewColumn column in dgvListaCursos.Columns)
            {
                if (column.Index != 2)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MostrarCursosSeleccionados();
            StringBuilder text = new StringBuilder();

            string mensajeError = string.Empty;
            if (FrmMensajeConfirmacion.PreguntarConfirmacion("Confirma?") == DialogResult.OK)
            {
                foreach (Curso curso in cursosSeleccionados)
                {
                    if (estudianteLogueado.InscribirCurso(curso, ref mensajeError))
                    {
                        text.AppendLine(curso.NombreMateriaDivision);
                    }
                    else
                    {
                        MessageBox.Show(mensajeError, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            MessageBox.Show($"Se inscribieron los siguientes cursos correctamente:{Environment.NewLine}{Environment.NewLine}{text}", "¡Cursos inscriptos corréctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cursosSeleccionados.Clear();
        }

        private void MostrarCursosSeleccionados()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Vista Previa: Se seleccionaron estos cursos para solicitar inscripción{Environment.NewLine}");
            foreach (Curso curso in cursosSeleccionados)
            {
                text.AppendLine(curso.NombreMateriaDivision);
            }
            MessageBox.Show(text.ToString(),"Cursos solicitados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void FiltrarYMostrarCursosDisponibles()
        {

            //Get the selected year and subject from ComboBoxes

            // string ? selectedYear = cbxCuatrimestre.SelectedItem.ToString();
            //string? selectedSubject = cbxMaterias.SelectedItem.ToString();
            string? cuatrimestreElegido = cuatrimestreIngresado;
            string? materiaElegida = materiaIngresada;

            // Filter the listCourses based on the selected criteria
            List<Curso>? cursosFiltrados = SistemaUTN.BaseDatosCursos?.Where(curso => curso.Cuatrimentre == cuatrimestreElegido
                                           && curso.Materia == materiaElegida).ToList();
            // Use ToList to convert the IEnumerable to a List

            // Bind the filtered result to the DataGridView
            dgvListaCursos.DataSource = cursosFiltrados;
        }

        private void cbxCuatrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuatrimestreIngresado = cbxCuatrimestre.Items[cbxCuatrimestre.SelectedIndex].ToString();
            if (Curso.MateriasDisponibles.ContainsKey(cuatrimestreIngresado))
            {
                cbxMaterias.Items.Clear();
                cbxMaterias.Items.AddRange(Curso.MateriasDisponibles[cuatrimestreIngresado].ToArray());
                cbxMaterias.SelectedIndex = 0;
            }
            else
            {
                cbxMaterias.Enabled = false;
            }
        }

        public void ActualizarDataGridView()
        {
            dgvListaCursos.DataSource = null;
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
        }


        private void dgvListaCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvListaCursos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvListaCursos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null && (bool)cell.Value)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.SelectionBackColor = Color.Green;
                }
                else
                {
                    e.CellStyle.BackColor = dgvListaCursos.DefaultCellStyle.BackColor;
                    e.CellStyle.SelectionBackColor = dgvListaCursos.DefaultCellStyle.SelectionBackColor;
                }
            }
        }

        private void dgvListaCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvListaCursos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                Curso rowData = (Curso)dgvListaCursos.Rows[e.RowIndex].DataBoundItem;
                DataGridViewCheckBoxCell checkboxCell = dgvListaCursos.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool isChecked = (bool)checkboxCell.EditedFormattedValue;
                if (isChecked)
                {
                    checkboxCell.EditingCellFormattedValue = true;
                    cursosSeleccionados.Add(rowData);
                }
                else
                {
                    checkboxCell.EditingCellFormattedValue = false;
                    cursosSeleccionados.Remove(rowData);
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvListaCursos.DataSource = null;
            FiltrarYMostrarCursosDisponibles();
        }

        private void cbxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            materiaIngresada = cbxMaterias.Items[cbxMaterias.SelectedIndex].ToString();
        }

    }
}
