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
        private Turno turnoIngresado;
        private Dia diaIngresado;
        //private string? turnoIngresado;
        //private string? diaIngresado;
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
            cbxDivision.DataSource = Enum.GetValues(typeof(Division));
            cbxTurno.DataSource = Enum.GetValues(typeof(Turno));
            cbxDia.DataSource = Enum.GetValues(typeof(Dia));
            cbxDescripcion.DataSource = Curso.materias;
            cbxHorario.DataSource = Curso.horarios;
            cbxAula.DataSource = Curso.aulas;
        }

        private void Horaer()
        {

        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cupoIngresado = tbxCupMaximo.Text;
            if (Validador.ValidarNumeroIngresado(out decimal cupoFinal, cupoIngresado, 15, 120))
            {
                //  1- crea el estudiante con ID = 0;
                string nombre = $"{cuatrimestreIngresado}{divisionIngresada}";
                nuevoCurso = new Curso(nombre, descripcionIngresada, (byte)cupoFinal, turnoIngresado, diaIngresado, aulaIngresada, horarioIngresado);
                //  2- una vez creado, busca que no exista dentro del sistema
                if (SistemaUTN.EncontrarCursoRegistrado(nuevoCurso))
                {
                    MessageBox.Show($"Ya existe este curso registrado en el sistema.");
                }
                else
                {
                    //  3- si esta todo bien y el admin confirma, asignarle un n° de legajo
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
            diaIngresado = (Dia)cbxDia.Items[cbxDia.SelectedIndex];//.ToString();
        }

        private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            turnoIngresado = (Turno)cbxTurno.Items[cbxTurno.SelectedIndex];//.ToString();
        }
    }
}
