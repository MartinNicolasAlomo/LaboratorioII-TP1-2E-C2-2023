using Logica_Sysacad;
using Microsoft.VisualBasic.Devices;
using System.Text;

namespace Vista_App
{
    public partial class FrmAltaCurso : Form
    {
        Curso? cursoIngresado;
        private bool esModificacion;
        private string? cuatrimestreIngresado;
        private string? divisionIngresada;
        private string? descripcionIngresada;
        private string? turnoIngresado;
        private string? diaIngresado;
        private string? horarioIngresado;
        private string? aulaIngresada;
        private string? cupoIngresado;

        public FrmAltaCurso(string titulo)
        {
            InitializeComponent();
            Text = titulo;
            esModificacion = false;
        }

        public FrmAltaCurso(Curso cursoIngresado, string titulo) : this(titulo)
        {
            this.cursoIngresado = cursoIngresado;
            esModificacion = true;
        }

        public Curso? CursoIngresado
        {
            get { return cursoIngresado; }
        }

        private void FrmAltaCurso_Load(object sender, EventArgs e)
        {
            if (cursoIngresado is not null)
            {
                PrecargarComboboxesCursoExistente();
            }
            else
            {
                PrecargarComboboxesDesdeCero();
            }
        }

        private void PrecargarComboboxesDesdeCero()
        {
            cbxCuatrimestre.DataSource = Curso.cuatrimestres;
            cbxDivision.DataSource = Curso.divisiones;
            cbxTurno.DataSource = Curso.turnos;
            cbxDia.DataSource = Curso.dias;
            cbxAula.DataSource = Curso.aulas;   // se va  completar al final con las aulas disponiblles segun turno, dia y horario
            cbxCuatrimestre.SelectedIndex = 0;
            cbxDivision.SelectedIndex = 0;
            cbxTurno.SelectedIndex = 0;
            cbxDia.SelectedIndex = 0;
            cbxAula.SelectedIndex = 0;
        }

        private void PrecargarComboboxesCursoExistente()
        {
            // Populate the Name ComboBox with data
            cbxCuatrimestre.DataSource = Curso.cuatrimestres;
            cbxDivision.DataSource = Curso.divisiones;
            cbxTurno.DataSource = Curso.turnos;
            cbxDia.DataSource = Curso.dias;
            cbxAula.DataSource = Curso.aulas;
            // Set the selected value based on the course object
            cbxCuatrimestre.SelectedItem = cursoIngresado.Cuatrimentre;
            cbxDivision.SelectedItem = cursoIngresado.Division;
            cbxDescripcion.SelectedItem = cursoIngresado.Descripcion;
            cbxTurno.SelectedItem = cursoIngresado.Turno;
            cbxDia.SelectedItem = cursoIngresado.Dia;
            cbxHorario.SelectedItem = cursoIngresado.Horario;
            cbxAula.SelectedItem = cursoIngresado.Aula;
            tbxCupoMaximo.Text = cursoIngresado.CupoMaximo.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cupoIngresado = tbxCupoMaximo.Text;
            if (Validador.ValidarNumeroIngresado(out decimal cupoFinal, cupoIngresado, 15, 120))
            {
                string preguntaConfirmacion;
                if (esModificacion)
                {
                    cursoIngresado.ModificarCursoExistente(cuatrimestreIngresado, divisionIngresada, descripcionIngresada, turnoIngresado, diaIngresado, horarioIngresado, aulaIngresada, (byte)cupoFinal);
                    preguntaConfirmacion = $"¿Está seguro/a que desea confirmar la modificación del curso {cursoIngresado.Nombre}?";
                }
                //  1- crea el curso con ID = 0;
                else
                {
                    cursoIngresado = new Curso(cuatrimestreIngresado, divisionIngresada, descripcionIngresada, turnoIngresado, diaIngresado, horarioIngresado, aulaIngresada, (byte)cupoFinal);
                    preguntaConfirmacion = $"¿Está seguro/a que desea confirmar el registro del curso {cursoIngresado.Nombre}?";
                }
                //  2- una vez creado, busca que no exista dentro del sistema
                if (SistemaUTN.EncontrarCursoRegistrado(cursoIngresado))
                {
                    MessageBox.Show($"Ya existe este curso registrado en el sistema.");
                }
                else
                {
                    //  3- si esta todo bien y el admin confirma, asignarle un n° de legajo
                    if (FrmMensajeConfirmacion.PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
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
            turnoIngresado = cbxTurno.Items[cbxTurno.SelectedIndex].ToString();
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
            diaIngresado = cbxDia.Items[cbxDia.SelectedIndex].ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
