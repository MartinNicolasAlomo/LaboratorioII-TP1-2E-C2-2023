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
            //***************************
            #region INGRESO DATOS .TEXT
            //string nombresIngresados = tbxNombres.Text;
            //string apellidosIngresados = tbxApellidos.Text;
            //string dniIngresado = tbxDNI.Text;
            //string direccionIngresada = tbxDireccion.Text;
            //string telefonoIngresado = tbxTelefono.Text;
            //string emailIngresado = tbxEmail.Text;
            //string claveIngresada = tbxClave.Text;
            //string diaIngresado = tbxDia.Text;
            //string mesIngresado = tbxMes.Text;
            //string anioIngresado = tbxAnio.Text;
            //  1- crea el estudiante con ID = 0;
            //  2- una vez creado, busca que no exista dentro del sistema
            //  3- si esta todo bien y el admin confirma, asignarle un n° de legajo


            #endregion

            //***************************

            string nombresIngresados = "martín nicolas";
            string apellidosIngresados = "alomo";
            string dniIngresado = "40916777";
            string direccionIngresada = "corvalan 435";
            string telefonoIngresado = "40901613";
            string emailIngresado = "lll@gmail.com";
            string claveIngresada = "asd";
            string diaIngresado = "07";
            string mesIngresado = "01";
            string anioIngresado = "1998";
            if (Validador.ValidarNombreIngresado(ref nombresIngresados, 50) &&
                Validador.ValidarNombreIngresado(ref apellidosIngresados, 50) &&
                Validador.ValidarTextoNumerico(dniIngresado, 8) &&
                Validador.ValidarDireccionIngresada(ref direccionIngresada, 90) &&
                Validador.ValidarTextoNumerico(telefonoIngresado, 8) &&
                Validador.ValidarEmailIngresado(emailIngresado) &&
                Validador.ValidarClaveIngresada(claveIngresada) &&
                Validador.ValidaFechaIngresada(out DateTime fechaFinal, anioIngresado, mesIngresado, diaIngresado))
            {
                nuevoEstudiante = new Estudiante(nombresIngresados, apellidosIngresados, dniIngresado, emailIngresado, telefonoIngresado, direccionIngresada, fechaFinal);
                if (SistemaUTN.EncontrarEstudianteRegistrado(nuevoEstudiante))
                {
                    MessageBox.Show($"Ya existe este/a estudiante registrado en el sistema.");
                }
                else
                {
                    string preguntaConfirmacion = $"¿Está seguro/a que desea confirmar el ingreso del/la estudiante {nuevoEstudiante.NombreCompletoOrdenApellido}?";
                    if (PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                    {
                        nuevoEstudiante.AsignarNumeroLegajo();
                        DialogResult = DialogResult.OK;
                        //MostrarDatos(nuevoEstudiante);
                        // ACTUALIZAR BASEDATOS
                    }
                }
            }
            else
            {
                MessageBox.Show($"Los datos ingresados no son válidos, reviselos y vuelva a intentarlo.");
            }
        }

        private static DialogResult PreguntarConfirmacion(string pregunta)
        {
            FrmMensajeConfirmacion? mensajeConfirmacion = new FrmMensajeConfirmacion(pregunta);
            if (mensajeConfirmacion.ShowDialog() == DialogResult.OK)
            {
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        private static void MostrarDatos(Estudiante nuevoEstudiante)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"Informacion ingresada del Estudiante:")
                .AppendLine($"{nuevoEstudiante.Legajo}")
                .AppendLine($"{nuevoEstudiante.Nombres}")
                .AppendLine($"{nuevoEstudiante.Apellidos}")
                .AppendLine($"{nuevoEstudiante.DNI}")
                .AppendLine($"{nuevoEstudiante.FechaNacimiento.ToString("dd/MM/yyyy")}")
                .AppendLine($"{nuevoEstudiante.Direccion}")
                .AppendLine($"{nuevoEstudiante.Telefono}")
                .AppendLine($"{nuevoEstudiante.Email}")
                .AppendLine($"{nuevoEstudiante.Clave}")
                ;
            MessageBox.Show(text.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
