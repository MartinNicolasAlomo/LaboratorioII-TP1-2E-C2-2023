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
        private Administrador administradorLogueado;
        private FrmLogin login;

        public FrmMenuPrincipal(Administrador administradorLogueado, FrmLogin login)
        {
            InitializeComponent();
            this.administradorLogueado = administradorLogueado;
            this.login = login;
            Text = $"Bienvenido a SYSACAD - {administradorLogueado.NombreCompletoOrdenApellido}";
        }


        #endregion


        #region CASO 1 - REGISTRAR ESTUDIANTE
        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            FrmAltaEstudiante? altaEstudiate = new FrmAltaEstudiante();
            Hide();
            if (altaEstudiate.ShowDialog() == DialogResult.OK)
            {
                Show();
                SistemaUTN.ListaEstudiantes?.Add(altaEstudiate.NuevoEstudiante);
                MessageBox.Show(CrearMensajeConfirmacionRegistroEstudiante(altaEstudiate.NuevoEstudiante), $"¡Registro realizado con éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Show();
                MessageBox.Show($"¡Se Cancelo el registro!", $"¡Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CrearMensajeConfirmacionRegistroEstudiante(Estudiante nuevoEstudiante)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"¡Se guardaron los datos del Estudante {nuevoEstudiante.NombreCompletoOrdenApellido}!").AppendLine()
                .AppendLine(EnviarEmailConfirmacion(nuevoEstudiante.Email))
                //.AppendLine($"¡Se envió un email a {nuevoEstudiante.Email} notificando la confirmación de ingreso!")
                ;
            return text.ToString();
        }

        private static string EnviarEmailConfirmacion(string emailIngresado)
        {
            return $"¡Se envió un email a {emailIngresado} notificando la confirmacion de ingreso!";
        }


        #endregion



        #region CASO 2 - GESTIONAR CURSOS
        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            FrmGestionCursos? auxGestion = new FrmGestionCursos();
            Hide();
            auxGestion.ShowDialog();
            Show();

        }


        #endregion



        #region CERRAR MENU
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
            login.MostrarLogin();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.MostrarLogin();
        }

        public void MostrarMenu()
        {
            //Show();
            //gestionCursos = null;
        }

        #endregion






    }




}
