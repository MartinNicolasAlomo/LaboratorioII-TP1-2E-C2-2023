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

        #region CAMPOS Y CONSTRUCTORES
        private Administrador administradorLogueado;                               //  tipo Usuario    / profe/admin
        private FrmLogin login;
        private FrmGestionCursos? gestionCursos;

        public FrmMenuPrincipal(Administrador administradorLogueado, FrmLogin login)                 //  recibe usuario / profe/admin
        {
            InitializeComponent();
            this.administradorLogueado = administradorLogueado;
            this.login = login;
            Text = $"Bienvenido a SYSACAD - Usuario {administradorLogueado.NombreCompletoOrdenApellido}";
        }

        #endregion




        #region CASO 1 - REGISTRAR ESTUDIANTE
        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            FrmAltaEstudiante? altaEstudiate = new FrmAltaEstudiante();
            if (altaEstudiate.ShowDialog() == DialogResult.OK)
            {

                //      LIST.ADD(altaEstudiate.NUEVO)

                StringBuilder text = new StringBuilder();
                text.AppendLine($"¡Se guardaron los datos del Estudante {altaEstudiate.NuevoEstudiante?.NombreCompletoOrdenApellido}!").AppendLine()
                    .AppendLine($"¡Se envió un email a {altaEstudiate.NuevoEstudiante?.Email} notificando la confirmación de ingreso!")
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

        #endregion



        #region CASO 2 - GESTIONAR CURSOS
        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            gestionCursos = new FrmGestionCursos(this);
            Hide();
            if (gestionCursos.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("SALIO BIEN", $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"¡Se Cancelo el gestio99sad54as6!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /*

                     if (gestionCursos == null)
        {
            gestionCursos = new FrmGestionCursos(this);
            gestionCursos.Show();
            Hide();
        }
         */



        #region CERRAR MENU PRINCIPAL
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //FrmMenuPrincipal_FormClosing(sender, (FormClosingEventArgs)e);
            login.MostrarLogin();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.MostrarLogin();
        }

        #endregion


        public void MostrarMenuPrincipal()
        {
            Show();
            gestionCursos = null;
        }





    }

    #endregion



}
