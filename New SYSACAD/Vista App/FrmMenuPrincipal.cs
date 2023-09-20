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
            DialogResult resultado = altaEstudiate.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show($"¡Se guardaron los datos del Estudante!", $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"¡Se Cancelo el registro!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.MostrarLogin();
        }
    }
}
