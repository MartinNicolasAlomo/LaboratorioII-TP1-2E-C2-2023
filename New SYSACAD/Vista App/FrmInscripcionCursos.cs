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
        private Estudiante estudianteLogueado;
        private DataGridViewCellEventArgs? seleccion;

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
                text.AppendLine(cursito.Descripcion);
            }
            MessageBox.Show(text.ToString());


            // VERIFICAR QUE HAYA CUPOS

            //foreach (Curso curso in cursosSeleccionados)
            //{
            //    // cupoDisponible == cupoMaximo - cuposOcupados;
            //    if (curso.CupoDisponible < curso.CupoMaximo)
            //    {
            //        // ok
            //    }
            //    else
            //    {
            //        MessageBox.Show("Este curso está completo, no tiene mas cupos.");
            //        cursosSeleccionados.Remove(curso);
            //    }
            //}

            if (FrmMensajeConfirmacion.PreguntarConfirmacion("Confirma") == DialogResult.OK)
            {
                //CREAR METOOD PARA AGREGAR Y ACTUALZIAR LAS BASES DE DATOS DE ESTUDIANTE Y CURSOS
                estudianteLogueado.CursosInscriptos?.Clear();
                foreach (Curso cursito in cursosSeleccionados)
                {
                    estudianteLogueado.CursosInscriptos?.Add(cursito);
                    cursito.CupoDisponible--;
                }
                // ORDENARLOS POR CUATRI O CODIGO - PROG = 1 / LABO = 2 / MATEMATICA = 3 / INGLES = 4 / SPD = 5, ETC.
                MessageBox.Show(estudianteLogueado.MostrarCursosSubscritos());
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

        //public void ActualizarDataGridView()
        //{
        //    dgvListaCursos.DataSource = null;
        //    dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
        //}

        private void FrmInscripcionCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //menuEstudiante?.MostrarMenu();
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
                    cursosSeleccionados.Add(rowData);
                }
                else
                {
                    cursosSeleccionados.Remove(rowData);
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
