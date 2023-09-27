using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_Sysacad;

namespace Vista_App
{
    public partial class FrmConsultaHorario : Form
    {
        private Estudiante estudiante;
        public FrmConsultaHorario(Estudiante estudiante)
        {
            InitializeComponent();
            this.estudiante = estudiante;
            Text = $"Horarios Semanales de {estudiante.NombreCompletoOrdenApellido}";
        }



    }
}
