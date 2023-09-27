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
    public partial class FrmRealizarPagos : Form
    {
        private Estudiante estudiante;
        public FrmRealizarPagos(Estudiante estudiante)
        {
            InitializeComponent();
            this.estudiante = estudiante;
            Text = $"Pago de Cuotas C2, 2023 - {estudiante.NombreCompletoOrdenApellido}";
        }



    }
}
