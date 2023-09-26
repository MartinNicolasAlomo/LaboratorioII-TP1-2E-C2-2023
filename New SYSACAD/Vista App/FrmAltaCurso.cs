using Logica_Sysacad;
using System.Text;

namespace Vista_App
{
    public partial class FrmAltaCurso : Form
    {
        Curso? nuevoCurso;
        private string? cuatrimestreIngresado;
        private string? divisionIngresada;
        private string? descripcionIngresada;
        private string? cupoIngresado;
        private string? turnoIngresado;
        private string? diaIngresado;
        private string? aulaIngresada;
        private string? horarioIngresado;

        public FrmAltaCurso(string titulo)
        {
            InitializeComponent();
            Text = titulo;
        }

        public Curso? NuevoCurso
        {
            get { return nuevoCurso; }
        }

        private void FrmAltaCurso_Load(object sender, EventArgs e)
        {
            cbxCuatrimestre.DataSource = Curso.cuatrimestres;
            cbxDivision.DataSource = Enum.GetNames(typeof(Division));
            cbxTurno.DataSource = Enum.GetNames(typeof(Turno));
            cbxDia.DataSource = Enum.GetNames(typeof(Dia));
            cbxDescripcion.DataSource = Curso.materias;
            cbxHorario.DataSource = Curso.horarios;
            cbxAula.DataSource = Curso.aulas;
        }

        private void Horaer()
        {

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

            //string nombresIngresado = cuatrimestreIngresado;
            //string descripcionIngresada = "Segundo Grupo, 3 Cuatrimestre";
            ////string cupoMaximoIngresado = "110";
            //Turno turnoIngresado = Turno.Noche; //  USAR EL TOOL QUE TIENE PARA SELECCIONAR PREDETERMINADO, SE DESPLIEGAN OPCIONES YA ESTABLECIDAS
            //Dia diaIngresado = Dia.Martes;
            //string aulaIngresado = "207"; // MISMO TOOL
            ////Profesor profe1 = new Profesor("Mario", "Rampi", "33222444", "mrampi@utn.com", "40406060", "Mitre 205");
            //string horarioIngresado = "18:30 - 22:30";
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
                string nombre = $"{cuatrimestreIngresado}{divisionIngresada}";
                nuevoCurso = new Curso(nombre, descripcionIngresada, (byte)cupoFinal, turnoIngresado, diaIngresado, aulaIngresada, horarioIngresado);
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
                        MostrarDatos(nuevoCurso);
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

        private static void MostrarDatos(Curso nuevoCurso)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"Informacion ingresada del Estudiante:")
                .AppendLine($"{nuevoCurso.Codigo}")
                .AppendLine($"{nuevoCurso.Nombre}")
                .AppendLine($"{nuevoCurso.Descripcion}")
                .AppendLine($"{nuevoCurso.Turno}")
                .AppendLine($"{nuevoCurso.Horario}")
                .AppendLine($"{nuevoCurso.Dia}")
                //.AppendLine($"{nuevoCurso.HorarioFinal}")
                //.AppendLine($"{nuevoCurso.Profesor.NombreCompletoOrdenApellido}")
                .AppendLine($"{nuevoCurso.Aula}")
                .AppendLine($"{nuevoCurso.CupoMaximo}")
                ;
            MessageBox.Show(text.ToString());
        }

        private void cbxCuatrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuatrimestreIngresado = cbxCuatrimestre.Items[cbxCuatrimestre.SelectedIndex].ToString();
        }

        private void cbxDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisionIngresada = cbxDivision.Items[cbxDivision.SelectedIndex].ToString();
        }

        private void cbxDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            descripcionIngresada = cbxDescripcion.Items[cbxDescripcion.SelectedIndex].ToString();
        }

        private void cbxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            horarioIngresado = cbxHorario.Items[cbxHorario.SelectedIndex].ToString();
        }

        private void cbxAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            aulaIngresada = cbxAula.Items[cbxAula.SelectedIndex].ToString();
        }

        private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            diaIngresado = cbxDia.Items[cbxDia.SelectedIndex].ToString();
        }

        private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            turnoIngresado = cbxTurno.Items[cbxTurno.SelectedIndex].ToString();
        }
    }
}
