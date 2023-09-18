using Logica_Sysacad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_App
{
    public partial class FrmDatosEstudiante : Form
    {
        public FrmDatosEstudiante()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombresIngresados = tbxNombres.Text;
            string apellidosIngresados = tbxApellidos.Text;
            string dniIngresado = tbxDNI.Text;
            string direccionIngresada = tbxDireccion.Text;
            string telefonoIngresado = tbxTelefono.Text;
            string emailIngresado = tbxEmail.Text;
            string claveIngresada = tbxClave.Text;

            Estudiante nuevoEstudiante = new Estudiante(nombresIngresados, apellidosIngresados, dniIngresado, emailIngresado, telefonoIngresado, direccionIngresada);

            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"Informacion ingresada del Estudiante:")
                .AppendLine($"{nuevoEstudiante.Legajo}")
                .AppendLine($"{nombresIngresados}")
                .AppendLine($"{apellidosIngresados}")
                .AppendLine($"{dniIngresado}")
                .AppendLine($"{direccionIngresada}")
                .AppendLine($"{telefonoIngresado}")
                .AppendLine($"{emailIngresado}")
                .AppendLine($"{claveIngresada}")
                ;
            MessageBox.Show(text.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
