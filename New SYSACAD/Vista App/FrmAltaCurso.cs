using Logica_Sysacad;
using Microsoft.VisualBasic.Devices;
using System.Text;

namespace Vista_App
{
    public partial class FrmAltaCurso : Form
    {
        Curso? cursoIngresado;
        private bool esModificacion;
        private string? codigoIngresado;
        private string? cuatrimestreIngresado;
        private string? letraClaseIngresada;
        private string? materiaIngresada;
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
            PrecargarOpcionesComboboxes();
            if (cursoIngresado is null)
            {
                PrecargarComboboxesDesdeCero();
            }
            else
            {
                PrecargarComboboxesCursoExistente();
            }
        }

        private void PrecargarComboboxesDesdeCero()
        {
            cbxCuatrimestre.SelectedIndex = 0;
            cbxLetraClase.SelectedIndex = 0;
            cbxTurno.SelectedIndex = 0;
            cbxDia.SelectedIndex = 0;
            cbxAula.SelectedIndex = 0;
        }

        private void PrecargarComboboxesCursoExistente()
        {
            cbxCuatrimestre.SelectedItem = cursoIngresado.Cuatrimentre;
            cbxLetraClase.SelectedItem = cursoIngresado.LetraClase;
            cbxMateria.SelectedItem = cursoIngresado.Materia;
            cbxTurno.SelectedItem = cursoIngresado.Turno;
            cbxDia.SelectedItem = cursoIngresado.Dia;
            cbxHorario.SelectedItem = cursoIngresado.Horario;
            cbxAula.SelectedItem = cursoIngresado.Aula;
            tbxCupoMaximo.Text = cursoIngresado.CupoMaximo.ToString();
            tbxCodigo.Text = cursoIngresado.Codigo.ToString();
        }

        private void PrecargarOpcionesComboboxes()
        {
            cbxCuatrimestre.DataSource = Curso.CuatrimestresDisponibles;
            cbxLetraClase.DataSource = Curso.ClasesDisponibles;
            cbxTurno.DataSource = Curso.TurnosDisponibles;
            cbxDia.DataSource = Curso.DiasDisponibles;
            cbxAula.DataSource = Curso.AulasDisponibles;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            codigoIngresado = tbxCodigo.Text;
            cupoIngresado = tbxCupoMaximo.Text;
            if (Validador.ValidarTextoNumerico(codigoIngresado, 3) &&
                Validador.ValidarNumeroIngresado(out byte cupoMaximo, cupoIngresado, 15, 120))
            {
                cursoIngresado = new Curso(codigoIngresado, cuatrimestreIngresado, letraClaseIngresada, materiaIngresada, turnoIngresado, diaIngresado, horarioIngresado, aulaIngresada, cupoMaximo);
                if (esModificacion)
                {
                    preguntaConfirmacion = $"¿Está seguro/a que desea confirmar la modificación del curso {cursoIngresado.NombreMateriaDivision}?";
                }
                else
                {
                    preguntaConfirmacion = $"¿Está seguro/a que desea confirmar el registro del curso {cursoIngresado.NombreMateriaDivision}?";
                }
                if (SistemaUTN.EncontrarCursoRegistrado(cursoIngresado))
                {
                    MessageBox.Show($"¡Ya existe este/a curso registrado en el sistema!", $"¡Curso ya existente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (FrmMensajeConfirmacion.PreguntarConfirmacion(preguntaConfirmacion) == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox.Show($"¡Los datos ingresados no son válidos o estan incompletos!{Environment.NewLine}¡Reviselos y vuelva a intentarlo!", $"¡Datos inválidos o incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCuatrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuatrimestreIngresado = cbxCuatrimestre.Items[cbxCuatrimestre.SelectedIndex].ToString();
            if (Curso.MateriasDisponibles.ContainsKey(cuatrimestreIngresado.ToString()))
            {
                cbxMateria.Items.Clear();
                cbxMateria.Items.AddRange(Curso.MateriasDisponibles[cuatrimestreIngresado].ToArray());
                cbxMateria.SelectedIndex = 0;
            }
            else
            {
                cbxMateria.Enabled = false;
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

        private void cbxLetraClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            letraClaseIngresada = cbxLetraClase.Items[cbxLetraClase.SelectedIndex].ToString();
        }

        private void cbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            materiaIngresada = cbxMateria.Items[cbxMateria.SelectedIndex].ToString();
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
