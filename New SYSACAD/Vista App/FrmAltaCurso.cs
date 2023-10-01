using Logica_Sysacad;
using System.Text;

namespace Vista_App
{
    public partial class FrmAltaCurso : Form
    {
        Curso? cursoIngresado;
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

        public FrmAltaCurso(Curso cursoIngresado, string titulo) : this(titulo)
        {
            this.cursoIngresado = cursoIngresado;
        }



        public Curso? CursoIngresado
        {
            get { return cursoIngresado; }
        }



        private void FrmAltaCurso_Load(object sender, EventArgs e)
        {
            //if (cursoIngresado is not null)
            //{
            //    cbxDescripcion.SelectedItem = cursoIngresado.Descripcion;
            //    cbxDia.SelectedItem = cursoIngresado.Dia;
            //    cbxAula.SelectedItem = cursoIngresado.Aula;
            //}


            cbxCuatrimestre.DataSource = Curso.cuatrimestres;
            cbxCuatrimestre.SelectedIndex = 0;

            cbxDivision.DataSource = Enum.GetValues(typeof(Division));
            cbxDivision.SelectedIndex = 0;

            cbxTurno.DataSource = Enum.GetValues(typeof(Turno));
            cbxTurno.SelectedIndex = 2;

            cbxDia.DataSource = Enum.GetValues(typeof(Dia));
            cbxAula.DataSource = Curso.aulas;   // se va  completar al final con las aulas disponiblles segun turno, dia y horario
            cbxAula.SelectedIndex = 0;
            //cbxTurno.Selected = Enum.GetValues(typeof(Turno));
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //cupoIngresado = tbxCupMaximo.Text;
            cupoIngresado = "80";
            if (Validador.ValidarNumeroIngresado(out decimal cupoFinal, cupoIngresado, 15, 120))
            {
                //  1- crea el curso con ID = 0;
                string nombre = $"{cuatrimestreIngresado}{divisionIngresada}";
                cursoIngresado = new Curso(nombre, descripcionIngresada, (byte)cupoFinal, turnoIngresado, diaIngresado, aulaIngresada, horarioIngresado);


                //  2- una vez creado, busca que no exista dentro del sistema
                if (SistemaUTN.EncontrarCursoRegistrado(cursoIngresado))
                {
                    MessageBox.Show($"Ya existe este curso registrado en el sistema.");
                }


                else
                {
                    //  3- si esta todo bien y el admin confirma, asignarle un n° de legajo
                    string preguntaConfirmacion = $"¿Está seguro/a que desea confirmar el registro del curso {cursoIngresado.Nombre}?";
                    if (PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                    {
                        cursoIngresado.AsignarCodigo();
                        DialogResult = DialogResult.OK;
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

        public static void MostrarDatos(Curso nuevoCurso)
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
            if (Curso.materiaPorCuatrimestre.ContainsKey(cuatrimestreIngresado.ToString()))
            {
                cbxDescripcion.Items.Clear();
                cbxDescripcion.Items.AddRange(Curso.materiaPorCuatrimestre[cuatrimestreIngresado].ToArray());
                cbxDescripcion.SelectedIndex = 0;
            }
            else
            {
                cbxDescripcion.Enabled = false;
            }
        }

        private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            turnoIngresado = (Turno)cbxTurno.Items[cbxTurno.SelectedIndex]; //(Turno)cbxHorario.SelectedItem;        ////.ToString();
            if (Curso.horarioPorTurno.ContainsKey(turnoIngresado))
            {
                cbxHorario.Enabled = true;
                cbxHorario.Items.Clear();
                cbxHorario.Items.AddRange(Curso.horarioPorTurno[turnoIngresado].ToArray());
                cbxHorario.SelectedIndex = 0;
            }
            else
            {
                cbxHorario.Enabled = false;
            }
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
            diaIngresado = (Dia)cbxDia.Items[cbxDia.SelectedIndex];
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
