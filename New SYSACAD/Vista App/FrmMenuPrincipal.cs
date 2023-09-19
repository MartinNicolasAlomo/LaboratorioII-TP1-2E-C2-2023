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
    public partial class FrmMenuPrincipal : Form
    {
        private string usuarioLogueado; //  tipo Usuario    / profe/admin

        public FrmMenuPrincipal(string usuarioLogueado) //  recibe usuario / profe/admin
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            Text = $"Bienvenido a SYSACAD - Usuario {usuarioLogueado}";
        }






    }
}
