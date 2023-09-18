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
        private string usuarioLogueado;

        public FrmMenuPrincipal(string usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            this.Text = usuarioLogueado;
        }



    }
}
