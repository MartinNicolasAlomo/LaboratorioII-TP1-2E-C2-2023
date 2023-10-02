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
    public partial class FrmMenuEstudiante : Form
    {
        private Estudiante estudianteLogueado;
        private FrmLogin login;
        private FrmInscripcionCursos? inscripcionCursos;

        public FrmMenuEstudiante(Estudiante estudianteLogueado, FrmLogin login)
        {
            InitializeComponent();
            this.estudianteLogueado = estudianteLogueado;
            this.login = login;
            Text = $"Bienvenido a SYSACAD - {estudianteLogueado.NombreCompletoOrdenApellido}";
        }

        private void FrmMenuEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.MostrarLogin();
        }

        private void btnInscripcionCursos_Click(object sender, EventArgs e)
        {
            if (inscripcionCursos is null)
            {
                inscripcionCursos = new FrmInscripcionCursos(this, estudianteLogueado);
                inscripcionCursos.Show();
                Hide();
            }


            //FrmInscripcionCursos? inscripcionCursos = new FrmInscripcionCursos(this, estudianteLogueado);
            //if (inscripcionCursos.ShowDialog() == DialogResult.OK)
            //{
            //    //estudianteLogueado.cursosInscriptos = inscripcionCursos.CursosInscriptos.ToList();


            //    StringBuilder text = new StringBuilder();
            //    //text.AppendLine($"¡Se guardaron los datos del Estudante {altaEstudiate.NuevoEstudiante?.NombreCompletoOrdenApellido}!").AppendLine()
            //    //    .AppendLine($"¡Se envió un email a {altaEstudiate.NuevoEstudiante?.Email} notificando la confirmación de ingreso!")
            //    //    ;
            //    MessageBox.Show(text.ToString(), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show($"¡Se Cancelo el registro!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnConsultarHorario_Click(object sender, EventArgs e)
        {
            FrmConsultaHorario? inscripcionCursos = new FrmConsultaHorario(estudianteLogueado);
            if (inscripcionCursos.ShowDialog() == DialogResult.OK)
            {


                StringBuilder text = new StringBuilder();
                //text.AppendLine($"¡Se guardaron los datos del Estudante {altaEstudiate.NuevoEstudiante?.NombreCompletoOrdenApellido}!").AppendLine()
                //    .AppendLine($"¡Se envió un email a {altaEstudiate.NuevoEstudiante?.Email} notificando la confirmación de ingreso!")
                //    ;
                MessageBox.Show(text.ToString(), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"¡Se Cancelo el registro!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void MostrarMenuEstudiante()
        {
            Show();
            inscripcionCursos = null;
        }

    }
}
