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
    public partial class FrmInscripcionCursos : Form
    {
        private List<Curso> cursosInscriptos;
        private Estudiante estudiante;

        public FrmInscripcionCursos(Estudiante estudiante)
        {
            InitializeComponent();
            this.estudiante = estudiante;
            Text = $"Inscripción a Cursos C2, 2023 - {estudiante.NombreCompletoOrdenApellido}";
        }

        public List<Curso> CursosInscriptos
        {
            get { return cursosInscriptos; }
        }

    }
}
