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
            dgvListaCursos.ReadOnly = true;

            dgvListaCursos.Columns.Add("Cronograma", "Cronograma");
            dgvListaCursos.Columns.Add("Lunes", "Lunes");
            dgvListaCursos.Columns.Add("Martes", "Martes");
            dgvListaCursos.Columns.Add("Miercoles", "Miércoles");
            dgvListaCursos.Columns.Add("Jueves", "Jueves");
            dgvListaCursos.Columns.Add("Viernes", "Viernes");

            dgvListaCursos.Rows.Add("Materia", "", "", "", "", "");
            dgvListaCursos.Rows.Add("Division", "", "", "", "", "");
            dgvListaCursos.Rows.Add("Turno", "", "", "", "", "");
            dgvListaCursos.Rows.Add("Horario", "", "", "", "", "");
            dgvListaCursos.Rows.Add("Aula", "", "", "", "", "");


            StringBuilder text = new StringBuilder();
            byte columnaDia;
            foreach (Curso curso in estudianteLogueado.CursosInscriptos)
            {
                switch (curso.Dia)
                {
                    case "Lunes":
                        columnaDia = 1;
                        break;
                    case "Martes":
                        columnaDia = 2;
                        break;
                    case "Miércoles":
                        columnaDia = 3;
                        break;
                    case "Jueves":
                        columnaDia = 4;
                        break;
                    case "Viernes":
                        columnaDia = 5;
                        break;
                    default:
                        columnaDia = 0;
                        break;
                }

                dgvListaCursos.Rows[0].Cells[columnaDia].Value = curso.Materia.ToString();
                dgvListaCursos.Rows[1].Cells[columnaDia].Value = curso.Division.ToString();
                dgvListaCursos.Rows[2].Cells[columnaDia].Value = curso.Turno.ToString();
                dgvListaCursos.Rows[3].Cells[columnaDia].Value = curso.Horario.ToString();
                dgvListaCursos.Rows[4].Cells[columnaDia].Value = curso.Aula.ToString();
            }
            dgvListaCursos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
