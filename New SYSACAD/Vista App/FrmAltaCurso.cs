using Logica_Sysacad;

namespace Vista_App
{
    public partial class FrmAltaCurso : Form
    {
        Curso? nuevoCurso;

        public FrmAltaCurso()
        {
            InitializeComponent();
        }

        public Curso? NuevoCurso
        {
            get { return nuevoCurso; }
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



            //***************************


            //private Turno turno;
            //private string aula;    //  numero en texto
            //private Profesor profesor;
            //private byte horaInicio;
            //private byte horaFinal;
            //private byte minutoInicio;
            //private byte minutoFinal;
            #endregion

            string nombresIngresado = "3as3d";
            string descripcionIngresada = "corvalan 435";
            string cupoMaximoIngresado = "110";
            Turno turnoIngresado = Turno.Noche; //  USAR EL TOOL QUE TIENE PARA SELECCIONAR PREDETERMINADO, SE DESPLIEGAN OPCIONES YA ESTABLECIDAS
            string aulaIngresado = "lll@gmail.com"; // MISMO TOOL
            Profesor profe1 = new Profesor("Mario", "Rampi", "33222444", "mrampi@utn.com", "40406060", "Mitre 205");
            string horaInicioIngresado = "18";
            string horaFinalIngresado = "30";
            string minutoInicioIngresado = "22";
            string minutoFinalIngresado = "30";
            decimal cupoFinal = 110;
            if (
                //Validador.ValidarNombreIngresado(ref nombresIngresados, 50) &&
                //Validador.ValidarNombreIngresado(ref apellidosIngresados, 50) &&
                //Validador.ValidarNumeroIngresado(out cupoFinal,cupoMaximoIngresado,1,120) &&
                //Validador.ValidarTextoNumerico(aulaIngresado, 3) &&
                //Validador.ValidarTextoNumerico(horaInicioIngresado, 2) &&
                //Validador.ValidarTextoNumerico(minutoInicioIngresado, 2) &&
                //Validador.ValidarTextoNumerico(horaFinalIngresado, 2) &&
                //Validador.ValidarTextoNumerico(minutoFinalIngresado, 2) &&
                //Validador.ValidarDireccionIngresada(ref direccionIngresada, 90) &&
                //Validador.ValidarTextoNumerico(telefonoIngresado, 8) &&
                //Validador.ValidarEmailIngresado(emailIngresado) &&
                //Validador.ValidarClaveIngresada(claveIngresada) &&
                //Validador.ValidaFechaIngresada(out DateTime fechaFinal, anioIngresado, mesIngresado, diaIngresado)
                true)
            {
                nuevoCurso = new Curso(nombresIngresado, descripcionIngresada, (byte)cupoFinal, turnoIngresado, aulaIngresado, profe1, horaInicioIngresado, horaFinalIngresado, minutoInicioIngresado, minutoFinalIngresado);
                if (SistemaUTN.EncontrarCursoRegistrado(nuevoCurso))
                {
                    MessageBox.Show($"Ya existe este/a curso registrado en el sistema.");
                }
                else
                {
                    string preguntaConfirmacion = $"¿Está seguro/a que desea confirmar el registro del curso {nuevoCurso.Nombre}?";
                    if (PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                    {
                        nuevoCurso.AsignarCodigo();
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
    }
}
