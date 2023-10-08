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
        private Estudiante estudianteLogueado;
        //private DataGridViewCellEventArgs? seleccion;
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

            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
            //FiltrarYMostrarCursosDisponibles();
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
            StringBuilder text = new StringBuilder();
            text.AppendLine("VISTA PREVIA: se seleccionaron estos cursos para solicitar inscripcion!!!!!!");
            foreach (Curso cursito in cursosSeleccionados)
            {
                text.AppendLine(cursito.Materia);
            }
            MessageBox.Show(text.ToString());

            //CREAR METOOD PARA AGREGAR Y ACTUALZIAR LAS BASES DE DATOS DE ESTUDIANTE Y CURSOS
            // VERIFICAR QUE HAYA CUPOS
            estudianteLogueado.CursosInscriptos?.Clear();
            foreach (Curso curso in cursosSeleccionados)
            {
                if ((curso.Nombre != "A" && curso.Materia != "B"))
                {
                    if (curso.CupoDisponible > 0)
                    {
                        estudianteLogueado.CursosInscriptos?.Add(curso);
                        curso.CupoDisponible--;
                        //if (FrmMensajeConfirmacion.PreguntarConfirmacion("Confirma") == DialogResult.OK)
                        //{ }
                    }
                    else
                    {
                        //  BLOQUEAR EL CURSO DE SER SELECCIONADO   - NUNCA ELIMINAR    -   NO SE ELIMINA
                        //        MessageBox.Show("Este curso está completo, no tiene mas cupos.");
                    }
                }
            }
            // ORDENARLOS POR CUATRI O CODIGO - PROG = 1 / LABO = 2 / MATEMATICA = 3 / INGLES = 4 / SPD = 5, ETC.
            MessageBox.Show(estudianteLogueado.MostrarCursosSubscritos());


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






        //private static string CrearMensajeConfirmacionRegistroCurso(Curso nuevoCurso)
        //{
        //    StringBuilder text = new StringBuilder();
        //    text.AppendLine($"¡Se guardaron los datos del Curso {nuevoCurso.Nombre}!").AppendLine()
        //        .AppendLine(nuevoCurso.MostrarDatos())
        //        ;
        //    return text.ToString();
        //}

        ////private void dgvListaCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    seleccion = e;
        //}


        //private Curso? ObtenerCursoDesdeDataGridView()
        //{
        //    int indice = seleccion.RowIndex;
        //    //  USAR  EXCEPCIONES   TRY CATCH
        //    //try
        //    //{

        //    //}
        //    //catch (Exception)
        //    //{

        //    //    throw;
        //    //}

        //    if (indice != -1 && indice >= 0)
        //    {
        //        return SistemaUTN.BaseDatosCursos?[indice];
        //    }
        //    return null;
        //}

        public void ActualizarDataGridView()
        {
            dgvListaCursos.DataSource = null;
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos; // CREAR CAMPO CURSOS SELECCIONADOS Y BIND A ESO
        }


        private void dgvListaCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvListaCursos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvListaCursos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Check if the cell is checked (value is true)
                if (cell.Value != null && (bool)cell.Value)
                {
                    // Change the background color to indicate checked state
                    e.CellStyle.BackColor = Color.Green; // You can choose any color you prefer
                    e.CellStyle.SelectionBackColor = Color.Green;
                }
                else
                {
                    // Optionally, reset the background color for unchecked cells
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
            //ActualizarDataGridView();
            dgvListaCursos.DataSource = null;
            FiltrarYMostrarCursosDisponibles();
        }

        private void cbxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            materiaIngresada = cbxMaterias.Items[cbxMaterias.SelectedIndex].ToString();
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
