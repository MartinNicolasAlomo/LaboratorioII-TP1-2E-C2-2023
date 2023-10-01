using Logica_Sysacad;
using System.Text;
using System.Windows.Forms;

namespace Vista_App
{
    public partial class FrmGestionCursos : Form
    {
        #region CAMPOS Y CONSTRUCTORES
        private FrmMenuPrincipal? menuPrincipal;
        private DataGridViewCellEventArgs? seleccion;

        public FrmGestionCursos(FrmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
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
                MessageBox.Show($"¡Se Cancelo el registro!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




            //Curso? auxCurso = ObtenerCursoDesdeDataGridView();
            //if (auxCurso is not null)
            //{
            //    /////////
            //    FrmAltaCurso edicionCurso = new FrmAltaCurso(auxCurso, "Modificar curso existente");
            //    if (edicionCurso.ShowDialog() == DialogResult.OK)
            //    {
            //        ActualizarDataGridView();
            //        //listaCursos.Add(altaCurso.NuevoCurso);
            //        //StringBuilder text = new StringBuilder();
            //        //text.AppendLine($"¡Se MODIFICARON los datos del CURSO {altaCurso.NuevoCurso?.Nombre}!").AppendLine();
            //        //MessageBox.Show(text.ToString(), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show($"¡Se Cancelo la edicion!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}



        }


        #endregion


        #region C) ELIMINAR CURSO
        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            Curso? auxCurso = ObtenerCursoDesdeDataGridView();
            if (auxCurso is not null)
            {
                MessageBox.Show(auxCurso.MostrarDatos());
                //  preguntar confirmacion
                SistemaUTN.BaseDatosCursos?.Remove(auxCurso);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("MALALALALALLAL");
            }
        }

        #endregion


        private Curso? ObtenerCursoDesdeDataGridView()
        {
            int indice = seleccion.RowIndex;
            //  USAR  EXCEPCIONES   TRY CATCH
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
            menuPrincipal?.MostrarMenuPrincipal();
        }


        private void dgvListaCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarCurso.Enabled = true;
            btnEliminarCurso.Enabled = true;
            seleccion = e;
        }


        private void FrmGestionCursos_Load(object sender, EventArgs e)
        {
            dgvListaCursos.DataSource = SistemaUTN.BaseDatosCursos;
            dgvListaCursos.Columns[5].DisplayIndex = 3;
            dgvListaCursos.Columns[6].DisplayIndex = 4;
            dgvListaCursos.Columns[7].DisplayIndex = 5;
            dgvListaCursos.Columns[0].HeaderText = "Código";
            dgvListaCursos.Columns[2].HeaderText = "Descripción";
            //  AGREGAR CUPO ACTUAL:    17/60
            dgvListaCursos.Columns[4].HeaderText = "Cupo Máx.";
            dgvListaCursos.Columns[6].HeaderText = "Día";

            btnEditarCurso.Enabled = false;
            btnEliminarCurso.Enabled = false;

        }










        //private void dgvListaCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    btnEditarCurso.Enabled = true;
        //    btnEliminarCurso.Enabled = true;
        //    //ObtenerCursoDesdeDataGridView();
        //    //DataGridViewRow selectedRow = dgvListaCursos.SelectedRows[0];
        //    //var materia = selectedRow.Cells[3].Value;

        //    //MessageBox.Show(materia.ToString());
        //    //if (dgvListaCursos.SelectedRows.Count > 0)
        //    //{
        //    //    // Get the selected row
        //    //    MessageBox.Show(selectedRow.ToString());
        //    //}
        //    //else
        //    //{

        //    //    MessageBox.Show(dgvListaCursos.SelectedRows.Count.ToString());
        //    //}

        //}

        ////private void dgvListaCursos_SelectionChanged(object sender, EventArgs e)
        ////{
        ////    // Check if a row is selected
        //    //if (dgvListaCursos.SelectedRows.Count > 0)
        //    //{
        //    //    // Get the selected sport based on the selected row
        //    //    Curso selectedSport = (Curso)dgvListaCursos.SelectedRows[0].DataBoundItem;

        //    //    // Display sport information in a MessageBox
        //    //    string message = $"Name: {selectedSport.Codigo}\nType: {selectedSport.Turno}\nPlayers: {selectedSport.Descripcion} {selectedSport.Nombre}";
        //    //    MessageBox.Show(message, "Selected Sport Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //}
        //    //else
        ////    //{
        ////    //    MessageBox.Show(dgvListaCursos.SelectedRows.Count.ToString());
        ////    //}
        ////}

        ////private void dgvListaCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex>=0)
        //    {
        //        DataGridViewRow fila = dgvListaCursos.Rows[e.RowIndex];
        //        string materia = fila.Cells[0].Value.ToString();
        //        MessageBox.Show(materia);
        //    }
        //    else
        //    {

        //        MessageBox.Show("nada asdsa56");
        //    }
        //}
    }
}
