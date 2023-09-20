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
        Estudiante? nuevoEstudiante;

        public FrmDatosEstudiante()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //string nombresIngresados = tbxNombres.Text;
            //string apellidosIngresados = tbxApellidos.Text;
            //string dniIngresado = tbxDNI.Text;
            //string direccionIngresada = tbxDireccion.Text;
            //string telefonoIngresado = tbxTelefono.Text;
            //string emailIngresado = tbxEmail.Text;
            //string claveIngresada = tbxClave.Text;

            string nombresIngresados = "martín nicolas";
            string apellidosIngresados = "alomo";
            string dniIngresado = "40916777";
            string direccionIngresada = "corvalan 435";
            string telefonoIngresado = "40901613";
            string emailIngresado = "lll@gmail.com";
            string claveIngresada = "asd";

            if (Validador.ValidarNombreIngresado(ref nombresIngresados, 50) &&
                Validador.ValidarNombreIngresado(ref apellidosIngresados, 50) &&
                Validador.ValidarTextoNumerico(dniIngresado, 8) &&
                Validador.ValidarDireccionIngresada(ref direccionIngresada, 90) &&
                Validador.ValidarTextoNumerico(telefonoIngresado, 8) &&
                Validador.ValidarEmailIngresado(emailIngresado) &&
                Validador.ValidarClaveIngresada(claveIngresada))
            {
                nuevoEstudiante = new Estudiante(nombresIngresados, apellidosIngresados, dniIngresado, emailIngresado, telefonoIngresado, direccionIngresada);

                //if (!SistemaUTN.EncontrarEstudianteRegistrado(nuevoEstudiante)         // && bool ConfirmarDesicion(string descripcion, string titulo)       //  botones aceptar o cancelar
                //    )
                if(nuevoEstudiante.RegistrarEstudianteIngresado())
                {
                    //  1- crea el estudiante con ID = 0;
                    //  2- una vez creado, busca que no exista dentro del sistema
                    //  3- si esta todo bien, asignarle un n° de legajo


                    DialogResult = DialogResult.OK;
                    // IF TRUE  // ACTUALIZAR BASEDATOS
                    MostrarDatos(nuevoEstudiante);
                    EnviarEmailConfirmacion(emailIngresado);
                }
                else
                {
                    MessageBox.Show($"YA EXISTE EL ALUMNO REGISTRADO EN EL SISTEMA");
                }
            }
            else
            {
                MessageBox.Show($"Error DATOS INVALIDOS");
            }
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
                .AppendLine($"{nuevoEstudiante.Direccion}")
                .AppendLine($"{nuevoEstudiante.Telefono}")
                .AppendLine($"{nuevoEstudiante.Email}")
                .AppendLine($"{nuevoEstudiante.Clave}")
                ;
            MessageBox.Show(text.ToString());
        }

        private static void EnviarEmailConfirmacion(string emailIngresado)
        {
            MessageBox.Show($"¡Se envió el email a {emailIngresado} notificando la confirmacion de ingreso!", $"¡Aviso de envío de confirmación!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
