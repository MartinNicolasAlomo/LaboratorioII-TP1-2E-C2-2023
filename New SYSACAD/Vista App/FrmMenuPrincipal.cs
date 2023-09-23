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
    public partial class FrmMenuPrincipal : Form
    {
        private Administrador administradorLogueado;                               //  tipo Usuario    / profe/admin
        private frmIniciarSesion login;

        public FrmMenuPrincipal(Administrador administradorLogueado, frmIniciarSesion login)                 //  recibe usuario / profe/admin
        {
            InitializeComponent();
            this.administradorLogueado = administradorLogueado;
            this.login = login;
            Text = $"Bienvenido a SYSACAD - Usuario {administradorLogueado.NombreCompletoOrdenApellido}";
        }



        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            FrmDatosEstudiante? altaEstudiate = new FrmDatosEstudiante();
            if (altaEstudiate.ShowDialog() == DialogResult.OK)
            {
                StringBuilder text = new StringBuilder();
                text.AppendLine($"¡Se guardaron los datos del Estudante {altaEstudiate.NuevoEstudiante?.NombreCompletoOrdenApellido}!").AppendLine()
                    .AppendLine($"¡Se envió un email a {altaEstudiate.NuevoEstudiante?.Email} notificando la confirmacion de ingreso!")
                    ;

                MessageBox.Show(text.ToString(), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"¡Se Cancelo el registro!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static void EnviarEmailConfirmacion(string emailIngresado)
        {
            MessageBox.Show($"¡Se envió un email a {emailIngresado} notificando la confirmacion de ingreso!", $"¡Aviso de envío de confirmación!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.MostrarLogin();
        }

        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            FrmGestionCursos? gestionCursos = new FrmGestionCursos();
            if (gestionCursos.ShowDialog() == DialogResult.OK)
            {
                //StringBuilder text = new StringBuilder();
                //text.AppendLine($"¡Se guardaron los datos gestionasdasdas5464as65d4sa656!").AppendLine()
                //    ;

                //MessageBox.Show(text.ToString(), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show($"¡Se Cancelo el gestio99sad54as6!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
