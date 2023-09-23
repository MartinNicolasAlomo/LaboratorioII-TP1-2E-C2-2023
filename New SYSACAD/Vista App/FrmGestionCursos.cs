using Logica_Sysacad;
using Microsoft.VisualBasic.Logging;
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
    public partial class FrmGestionCursos : Form
    {

        public FrmGestionCursos()
        {
            InitializeComponent();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            FrmAltaCurso? altaCurso = new FrmAltaCurso();
            if (altaCurso.ShowDialog() == DialogResult.OK)
            {
                StringBuilder text = new StringBuilder();
                text.AppendLine($"¡Se guardaron los datos del CURSO {altaCurso.NuevoCurso?.Nombre}!").AppendLine()
                    //.AppendLine($"¡Se envió un email a {altaCurso.NuevoCurso?.Nombre} notificando la confirmacion de ingreso!")
                    ;

                MessageBox.Show(text.ToString(), $"¡PERFECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"¡Se Cancelo el registro!", $"¡CANCALADOOOOOOO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    login.MostrarLogin();
        //}

    }
}
