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
    public partial class FrmAltaEstudiante : Form
    {
        Estudiante? nuevoEstudiante;
        private string? nombresIngresados;
        private string? apellidosIngresados;
        private string? dniIngresado;
        private string? emailIngresado;
        private string? claveIngresada;
        private string? telefonoIngresado;
        private string? direccionIngresada;
        private string? diaIngresado;
        private string? mesIngresado;
        private string? anioIngresado;
        private DateTime fechaNacimiento;
        private byte edad;


        public FrmAltaEstudiante()
        {
            InitializeComponent();
        }

        public Estudiante? NuevoEstudiante
        {
            get { return nuevoEstudiante; }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            nombresIngresados = "martín nicolas";
            apellidosIngresados = "alomo";
            dniIngresado = "40916777";
            emailIngresado = "lll@gmail.com";
            claveIngresada = "lallaslal";
            telefonoIngresado = "40901613";
            direccionIngresada = "corvalan 435";
            diaIngresado = "01";
            mesIngresado = "10";
            anioIngresado = "1998";
            //nombresIngresados = tbxNombres.Text;
            //apellidosIngresados = tbxApellidos.Text;
            //dniIngresado = tbxDNI.Text;
            //direccionIngresada = tbxDireccion.Text;
            //telefonoIngresado = tbxTelefono.Text;
            //emailIngresado = tbxEmail.Text;
            //claveIngresada = tbxClave.Text;
            //diaIngresado = tbxDia.Text;
            //mesIngresado = tbxMes.Text;
            //anioIngresado = tbxAnio.Text;
            if (Validador.ValidarNombreIngresado(ref nombresIngresados, 50) &&
                Validador.ValidarNombreIngresado(ref apellidosIngresados, 50) &&
                Validador.ValidarTextoNumerico(dniIngresado, 8) &&
                Validador.ValidarEmailIngresado(emailIngresado) &&
                Validador.ValidarClaveIngresada(claveIngresada) &&
                Validador.ValidarTextoNumerico(telefonoIngresado, 8) &&
                Validador.ValidarDireccionIngresada(ref direccionIngresada, 90) &&
                Validador.ValidarFechaNacimiento(out fechaNacimiento, out edad, anioIngresado, mesIngresado, diaIngresado))
            {
                if (chxPermitirCambioClave.Checked == true)
                {
                    nuevoEstudiante = new Estudiante(nombresIngresados, apellidosIngresados, dniIngresado, fechaNacimiento, edad, emailIngresado, claveIngresada,telefonoIngresado, direccionIngresada);
                }
                else
                {
                    nuevoEstudiante = new Estudiante(nombresIngresados, apellidosIngresados, dniIngresado, fechaNacimiento, edad, emailIngresado, telefonoIngresado, direccionIngresada);
                }
                if (SistemaUTN.EncontrarEstudianteRegistrado(nuevoEstudiante))
                {
                    MessageBox.Show($"Ya existe este/a estudiante registrado en el sistema.");
                }
                else
                {
                    string preguntaConfirmacion = $"¿Está seguro/a que desea confirmar el registro del/la estudiante {nuevoEstudiante.NombreCompletoOrdenApellido}?";
                    if (FrmMensajeConfirmacion.PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                    {
                        nuevoEstudiante.AsignarNumeroLegajo();
                        MessageBox.Show(nuevoEstudiante.MostrarDatos());
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox.Show($"Los datos ingresados no son válidos, reviselos y vuelva a intentarlo.");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
