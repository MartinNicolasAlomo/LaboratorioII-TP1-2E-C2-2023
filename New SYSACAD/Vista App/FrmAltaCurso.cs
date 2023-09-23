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
    public partial class FrmAltaCurso : Form
    {
        Curso? nuevoCurso;

        public Curso? NuevoCurso
        {
            get { return nuevoCurso; }
        }

        public FrmAltaCurso()
        {
            InitializeComponent();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            #region ALTA
            //***************************
            //#region INGRESO DATOS .TEXT
            ////string nombresIngresados = tbxNombres.Text;
            ////string apellidosIngresados = tbxApellidos.Text;
            ////string dniIngresado = tbxDNI.Text;
            ////string direccionIngresada = tbxDireccion.Text;
            ////string telefonoIngresado = tbxTelefono.Text;
            ////string emailIngresado = tbxEmail.Text;
            ////string claveIngresada = tbxClave.Text;
            ////string diaIngresado = tbxDia.Text;
            ////string mesIngresado = tbxMes.Text;
            ////string anioIngresado = tbxAnio.Text;
            ////  1- crea el estudiante con ID = 0;
            ////  2- una vez creado, busca que no exista dentro del sistema
            ////  3- si esta todo bien y el admin confirma, asignarle un n° de legajo


            //#endregion

            ////***************************


            ////private Turno turno;
            ////private string aula;    //  numero en texto
            ////private Profesor profesor;
            ////private byte horaInicio;
            ////private byte horaFinal;
            ////private byte minutoInicio;
            ////private byte minutoFinal;

            //string nombresIngresado = "3as3d";
            //string descripcionIngresada = "corvalan 435";
            //string cupoMaximoIngresado = "110";
            //Turno turnoIngresado = Turno.Noche; //  USAR EL TOOL QUE TIENE PARA SELECCIONAR PREDETERMINADO, SE DESPLIEGAN OPCIONES YA ESTABLECIDAS
            //string aulaIngresado = "lll@gmail.com"; // MISMO TOOL
            //Profesor profe1 = new Profesor("Mario", "Rampi", "33222444", "mrampi@utn.com", "40406060", "Mitre 205");
            //string horaInicioIngresado = "18";
            //string horaFinalIngresado = "30";
            //string minutoInicioIngresado = "22";
            //string minutoFinalIngresado = "30";
            //decimal cupoFinal = 110;
            //if (
            //    //Validador.ValidarNombreIngresado(ref nombresIngresados, 50) &&
            //    //Validador.ValidarNombreIngresado(ref apellidosIngresados, 50) &&
            //    //Validador.ValidarNumeroIngresado(out cupoFinal,cupoMaximoIngresado,1,120) &&
            //    //Validador.ValidarTextoNumerico(aulaIngresado, 3) &&
            //    //Validador.ValidarTextoNumerico(horaInicioIngresado, 2) &&
            //    //Validador.ValidarTextoNumerico(minutoInicioIngresado, 2) &&
            //    //Validador.ValidarTextoNumerico(horaFinalIngresado, 2) &&
            //    //Validador.ValidarTextoNumerico(minutoFinalIngresado, 2) &&
            //    //Validador.ValidarDireccionIngresada(ref direccionIngresada, 90) &&
            //    //Validador.ValidarTextoNumerico(telefonoIngresado, 8) &&
            //    //Validador.ValidarEmailIngresado(emailIngresado) &&
            //    //Validador.ValidarClaveIngresada(claveIngresada) &&
            //    //Validador.ValidaFechaIngresada(out DateTime fechaFinal, anioIngresado, mesIngresado, diaIngresado)
            //    true)
            //{
            //    curso = new Curso(nombresIngresado, descripcionIngresada, (byte)cupoFinal, turnoIngresado, aulaIngresado, profe1, horaInicioIngresado, horaFinalIngresado, minutoInicioIngresado, minutoFinalIngresado);
            //    if (SistemaUTN.EncontrarCursoRegistrado(curso))
            //    {
            //        MessageBox.Show($"Ya existe este/a curso registrado en el sistema.");
            //    }
            //    else
            //    {
            //        string preguntaConfirmacion = $"¿Está seguro/a que desea confirmar el registro del curso {curso.Nombre}?";
            //        if (PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
            //        {
            //            curso.AsignarCodigo();
            //            DialogResult = DialogResult.OK;
            //            //MostrarDatos(nuevoEstudiante);
            //            // ACTUALIZAR BASEDATOS
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show($"Los datos ingresados no son válidos, reviselos y vuelva a intentarlo.");
            //}

            #endregion

        }
    }
}
