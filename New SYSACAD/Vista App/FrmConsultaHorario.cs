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
using static System.Net.Mime.MediaTypeNames;

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
            dgvListaCursos.DataSource = estudianteLogueado.CursosInscriptos;
        }

        //private void btnMostrarHorarios_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("consulte horarios");

        //}

        private void FrmConsultaHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            //menuEstudiante?.MostrarMenu();
        }
    }
}
