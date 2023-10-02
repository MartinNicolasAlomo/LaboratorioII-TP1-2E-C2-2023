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
        #region CAMPOS Y CONSTRUCTORES
        private string? cuatrimestreIngresado;
        private List<Curso> cursosSeleccionados;
        private Estudiante estudiante;
        private FrmMenuEstudiante? menuEstudiante;
        private DataGridViewCellEventArgs? seleccion;

        public FrmInscripcionCursos(FrmMenuEstudiante menuEstudiante, Estudiante estudianteLogueado)
        {
            InitializeComponent();
            this.menuEstudiante = menuEstudiante;
            this.estudiante = estudianteLogueado;
            cursosSeleccionados = new List<Curso>();
            Text = $"Inscripción a Cursos C2, 2023 - {estudiante.NombreCompletoOrdenApellido}";
        }

        private void FrmInscripcionCursos_Load(object sender, EventArgs e)
        {
            cbxCuatrimestre.DataSource = Curso.CuatrimestresDisponibles;
            cbxCuatrimestre.SelectedIndex = 0;

            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
            dgvListaCursos.Columns[0].HeaderText = "Código";
            dgvListaCursos.Columns[3].HeaderText = "División";
            dgvListaCursos.Columns[4].HeaderText = "Descripción";
            dgvListaCursos.Columns[6].HeaderText = "Día";
            dgvListaCursos.Columns[9].HeaderText = "Cupo Máx.";
            dgvListaCursos.Columns[10].HeaderText = "Cupo Disp.";

        }


        #endregion




        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //StringBuilder text = new StringBuilder();
            //foreach (Curso cursito in cursosSeleccionados)
            //{
            //    text.AppendLine(cursito.MostrarDatos());
            //}
            //MessageBox.Show(text.ToString());

            foreach (Curso cursito in cursosSeleccionados)
            {
                estudiante.CursosInscriptos?.Add(cursito);
            }
            MessageBox.Show(estudiante.MostrarCursosSubscritos());
        }

        private static string CrearMensajeConfirmacionRegistroCurso(Curso nuevoCurso)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"¡Se guardaron los datos del Curso {nuevoCurso.Nombre}!").AppendLine()
                .AppendLine(nuevoCurso.MostrarDatos())
                ;
            return text.ToString();
        }

        //private void dgvListaCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    seleccion = e;
        //}


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

        private void FrmInscripcionCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuEstudiante?.MostrarMenuEstudiante();
        }

        private void dgvListaCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a checkbox cell was clicked
            if (e.RowIndex >= 0 && dgvListaCursos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Get the selected row's data
                Curso rowData = (Curso)dgvListaCursos.Rows[e.RowIndex].DataBoundItem;

                // Check the checkbox value
                DataGridViewCheckBoxCell checkboxCell = dgvListaCursos.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool isChecked = (bool)checkboxCell.EditedFormattedValue;

                // Add or remove the row data based on checkbox state
                if (isChecked)
                {
                    cursosSeleccionados.Add(rowData);
                    //estudiante.CursosInscriptos?.Add(rowData);
                    //StringBuilder text = new StringBuilder();
                    //foreach (Curso cursito in cursosSeleccionados)
                    //{
                    //    text.AppendLine(cursito.Descripcion);
                    //}
                    //MessageBox.Show(text.ToString());
                    //dgvListaCursos.Rows[e.RowIndex].ReadOnly = true;
                }
                else
                {
                    //cursosSeleccionados.Remove(rowData);
                    estudiante.CursosInscriptos?.Remove(rowData);

                    //MessageBox.Show($"Se deseleccionó {rowData.Descripcion}");
                }
            }
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

        //private void ShowSelectedDataButton_Click(object sender, EventArgs e)
        //{
        //    // Show the data of selected rows using MessageBox or any other UI element
        //    foreach (YourDataType rowData in selectedRows)
        //    {
        //        MessageBox.Show($"Selected Data: {rowData.Property1}, {rowData.Property2}, ...");
        //    }
        //}

    }
}
