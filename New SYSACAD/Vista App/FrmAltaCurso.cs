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
        private string? preguntaConfirmacion;


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
            cbxCuatrimestre.DataSource = Curso.CuatrimestresDisponibles;
            cbxDivision.DataSource = Curso.DivisionesDisponibles;
            cbxTurno.DataSource = Curso.TurnosDisponibles;
            cbxDia.DataSource = Curso.DiasDisponibles;
            cbxAula.DataSource = Curso.AulasDisponibles;   // se va  completar al final con las aulas disponiblles segun turno, dia y horario
            cbxCuatrimestre.SelectedIndex = 0;
            cbxDivision.SelectedIndex = 0;
            cbxTurno.SelectedIndex = 0;
            cbxDia.SelectedIndex = 0;
            cbxAula.SelectedIndex = 0;
        }

        private void PrecargarComboboxesCursoExistente()
        {
            // Populate the Name ComboBox with data
            cbxCuatrimestre.DataSource = Curso.CuatrimestresDisponibles;
            cbxDivision.DataSource = Curso.DivisionesDisponibles;
            cbxTurno.DataSource = Curso.TurnosDisponibles;
            cbxDia.DataSource = Curso.DiasDisponibles;
            cbxAula.DataSource = Curso.AulasDisponibles;
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
            if (Validador.ValidarNumeroIngresado(out decimal cupoMaximo, cupoIngresado, 15, 120))
            {
                if (esModificacion)
                {
                    cursoIngresado.ModificarCursoExistente(cuatrimestreIngresado, divisionIngresada, descripcionIngresada, turnoIngresado, diaIngresado, horarioIngresado, aulaIngresada, (byte)cupoMaximo, (byte)cupoMaximo);
                    preguntaConfirmacion = $"¿Está seguro/a que desea confirmar la modificación del curso {cursoIngresado.Nombre}?";
                }
                else
                {
                    cursoIngresado = new Curso(cuatrimestreIngresado, divisionIngresada, descripcionIngresada, turnoIngresado, diaIngresado, horarioIngresado, aulaIngresada, (byte)cupoMaximo, (byte)cupoMaximo);
                    preguntaConfirmacion = $"¿Está seguro/a que desea confirmar el registro del curso {cursoIngresado.Nombre}?";
                }
                if (SistemaUTN.EncontrarCursoRegistrado(cursoIngresado))
                {
                    MessageBox.Show($"Ya existe este curso registrado en el sistema.");
                }
                else
                {
                    if (FrmMensajeConfirmacion.PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                    {
                        if (!esModificacion)
                        {
                            cursoIngresado.AsignarCodigo();
                        }
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
            if (Curso.MateriasDisponibles.ContainsKey(cuatrimestreIngresado.ToString()))
            {
                cbxDescripcion.Items.Clear();
                cbxDescripcion.Items.AddRange(Curso.MateriasDisponibles[cuatrimestreIngresado].ToArray());
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
            if (Curso.HorariosDisponibles.ContainsKey(turnoIngresado))
            {
                cbxHorario.Enabled = true;
                cbxHorario.Items.Clear();
                cbxHorario.Items.AddRange(Curso.HorariosDisponibles[turnoIngresado].ToArray());
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
