using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_Sysacad;
using Microsoft.VisualBasic.Devices;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Vista_App
{
    public partial class FrmConsultaHorario : Form
    {
        private Estudiante estudianteLogueado;

        public FrmConsultaHorario(Estudiante estudianteLogueado)
        {
            InitializeComponent();
            this.estudianteLogueado = estudianteLogueado;
            Text = $"Horarios Semanales de {estudianteLogueado.NombreCompletoOrdenApellido}";
        }

        private void FrmConsultaHorario_Load(object sender, EventArgs e)
        {
            dgvListaCursos.Columns.Add("Dia", "Día");
            dgvListaCursos.Columns.Add("Materia", "Materia");
            dgvListaCursos.Columns.Add("Curso", "Curso");
            dgvListaCursos.Columns.Add("Turno", "Turno");
            dgvListaCursos.Columns.Add("Horario", "Horario");
            dgvListaCursos.Columns.Add("Aula", "Aula");

            //byte i = 0;
            dgvListaCursos.Rows.Clear();
            //foreach (Curso curso in estudianteLogueado.CursosInscriptos)
            //{
            //    if (curso is null)
            //    {
            //        dgvListaCursos.Rows.Add(Curso.DiasDisponibles[i], "---", "---", "---", "---", "---"); // Modify fee amount as needed
            //    }
            //    dgvListaCursos.Rows.Add(Curso.DiasDisponibles[i], curso.Materia, curso.Nombre, curso.Turno, curso.Horario, curso.Aula); // Modify fee amount as needed
            //    i++;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    //if (estudianteLogueado.CursosInscriptos[i] is null)
            //    if (i >= estudianteLogueado.CursosInscriptos.Count)
            //    {
            //        dgvListaCursos.Rows.Add(Curso.DiasDisponibles[i], "---", "---", "---", "---", "---"); // Modify fee amount as needed
            //    }
            //    dgvListaCursos.Rows.Add(Curso.DiasDisponibles[i], estudianteLogueado.CursosInscriptos[i].Materia, estudianteLogueado.CursosInscriptos[i].Nombre, estudianteLogueado.CursosInscriptos[i].Turno, estudianteLogueado.CursosInscriptos[i].Horario, estudianteLogueado.CursosInscriptos[i].Aula); // Modify fee amount as needed
            //    i++;
            //}



        }

        //private void btnMostrarHorarios_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("consulte horarios");


        private void FrmConsultaHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            //menuEstudiante?.MostrarMenu();
        }
    }
}
