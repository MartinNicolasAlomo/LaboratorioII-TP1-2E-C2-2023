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

        public FrmMenuEstudiante(Estudiante estudianteLogueado, FrmLogin login)
        {
            InitializeComponent();
            this.estudianteLogueado = estudianteLogueado;
            this.login = login;
            Text = $"Bienvenido a SYSACAD - {estudianteLogueado.NombreCompletoOrdenApellido}";
        }


        private void btnInscripcionCursos_Click(object sender, EventArgs e)
        {
            FrmInscripcionCursos? inscripcionCursos = new FrmInscripcionCursos(estudianteLogueado);
            Hide();
            inscripcionCursos.ShowDialog();
            Show();

        }

        private void btnConsultarHorario_Click(object sender, EventArgs e)
        {
            if (estudianteLogueado.CursosInscriptos?.Count == 0)
            {
                MessageBox.Show("¡El estudiante no esta inscripto en ningún curso!", $"¡Lista de cursos vacía!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmConsultaHorario? consultaHorarios = new FrmConsultaHorario(estudianteLogueado);
                Hide();
                consultaHorarios.ShowDialog();
                Show();
            }
        }

        private void btnRealizarPagos_Click(object sender, EventArgs e)
        {
            if (estudianteLogueado.ServiciosImpagos?.Count == 0)
            {
                MessageBox.Show($"¡El estudiante {estudianteLogueado.NombreCompletoOrdenApellido} está al día con sus pagos!", $"¡Cuotas pagadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmRealizarPagos? pagoServicios = new FrmRealizarPagos(estudianteLogueado);
                Hide();
                pagoServicios.ShowDialog();
                Show();
            }
        }



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
            login.MostrarLogin();
        }

        private void FrmMenuEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.MostrarLogin();
        }
    }
}
