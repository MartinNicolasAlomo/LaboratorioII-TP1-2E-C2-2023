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
    public partial class FrmSeleccionCuotas : Form
    {
        private Servicio servicioEelgido;
        private byte cantidadCuotasElegidas;
        private decimal montoTotal;


        public FrmSeleccionCuotas(Servicio servicioEelgido)
        {
            InitializeComponent();
            this.servicioEelgido = servicioEelgido;
        }

        public byte CuotasElegidas
        {
            get { return cantidadCuotasElegidas; }
        }

        public decimal MontoTotal
        {
            get { return montoTotal;  }
        }

        private void dgvProductoElegido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductoElegido.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                Servicio servicioElegido = (Servicio)dgvProductoElegido.Rows[e.RowIndex].DataBoundItem;
                DataGridViewCheckBoxCell celdaCheckBox = dgvProductoElegido.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool isChecked = (bool)celdaCheckBox.EditedFormattedValue;
                if (isChecked)
                {
                    cantidadCuotasElegidas++;
                    montoTotal += servicioEelgido.PrecioCuota;
                    //serviciosSeleccionados.Add(servicioElegido);
                    // ABRIR FRMSELECCIONCUOTAS     SHOWDIALOG()
                    // MANDARLE EL SERVICIO ELEGIDO TAL CUAL
                    // DENTRO SELECCIONAR LA CANTIDAD DE CUOTAS A PAGAR
                    // USAR PROPIEDAD CANTELEGIDAS Y MONTOTOTAL
                    // AJUSTAR= CUOTASAPAGAR = CANTELEGIDAS         MONTOTOTAL.TEXT = MONTOTTAL
                    //


                }
                else
                {
                    cantidadCuotasElegidas--;
                    montoTotal -= servicioEelgido.PrecioCuota;
                    //serviciosSeleccionados.Remove(servicioElegido);
                }
                lblCuotasElegidas.Text = $"Cuotas elegidas:{Environment.NewLine}{cantidadCuotasElegidas}";
                lblMontoTotal.Text = $"Monto total:{Environment.NewLine}{montoTotal:C2}";
            }

        }

        private void FrmSeleccionCuotas_Load(object sender, EventArgs e)
        {
            dgvProductoElegido.Rows.Clear();
            for (int mes = 1; mes <= servicioEelgido.CuotasImpagas; mes++)
            {
                dgvProductoElegido.Rows.Add(servicioEelgido.Nombre, "Cuota " + mes, $"{servicioEelgido.PrecioCuota:C2}"); // Modify fee amount as needed
            }
            lblCuotasElegidas.Text = $"Cuotas elegidas:{Environment.NewLine}{0}";
            lblMontoTotal.Text = $"Monto total:{Environment.NewLine}{0:C2}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
