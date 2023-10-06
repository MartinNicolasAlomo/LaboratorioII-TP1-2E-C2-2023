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
        private Servicio servicioElegido;
        private byte cuotasElegidas;
        private decimal montoTotal;

        public FrmSeleccionCuotas(Servicio servicioEelgido)
        {
            InitializeComponent();
            servicioElegido = servicioEelgido;
        }


        private void FrmSeleccionCuotas_Load(object sender, EventArgs e)
        {
            dgvProductoElegido.Rows.Clear();
            for (int mes = 1; mes <= servicioElegido.CuotasImpagas; mes++)
            {
                dgvProductoElegido.Rows.Add(servicioElegido.Nombre, "Cuota " + mes, $"{servicioElegido.PrecioCuota:C2}"); // Modify fee amount as needed
            }
            lblCuotasElegidas.Text = $"Cuotas elegidas:{Environment.NewLine}{0}";
            lblMontoTotal.Text = $"Monto total:{Environment.NewLine}{0:C2}";
            btnConfirmar.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public byte CuotasElegidas
        {
            get { return cuotasElegidas; }
        }

        public decimal MontoTotal
        {
            get { return montoTotal; }
        }





        private void dgvProductoElegido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;
            if (indiceFila >= 0 && dgvProductoElegido.Columns[indiceColumna] is DataGridViewCheckBoxColumn)
            {
                DataGridViewCheckBoxCell celdaCheckBox = dgvProductoElegido.Rows[indiceFila].Cells[indiceColumna] as DataGridViewCheckBoxCell;
                bool isChecked = (bool)celdaCheckBox.EditedFormattedValue;
                if (isChecked)
                {
                    ActualizarCuotasSeleccionadas(true);
                }
                else
                {
                    ActualizarCuotasSeleccionadas(false);
                }
                HabilitarBotonConfirmar();
                //if (cbxSeleccionarTodo.Checked == true)
                //{
                //    dgvProductoElegido.Rows[indiceFila].Cells[indiceColumna].Selected = false;
                //}
                //else
                //{
                //cbxSeleccionarTodo.Checked = false;
                //}
            }
        }

        private void ActualizarCuotasSeleccionadas(bool incrementaTotalCuotas)
        {
            if (incrementaTotalCuotas)
            {
                cuotasElegidas++;
                montoTotal += servicioElegido.PrecioCuota;
            }
            else
            {
                cuotasElegidas--;
                montoTotal -= servicioElegido.PrecioCuota;
            }
            lblCuotasElegidas.Text = $"Cuotas elegidas:{Environment.NewLine}{cuotasElegidas}";
            lblMontoTotal.Text = $"Monto total:{Environment.NewLine}{montoTotal:C2}";
        }

        private void HabilitarBotonConfirmar()
        {
            if (cuotasElegidas > 0)
            {
                btnConfirmar.Enabled = true;
            }
            else
            {
                btnConfirmar.Enabled = false;
            }
        }





        //private void cbxSeleccionarTodo_Click(object sender, EventArgs e)
        //{
        //    if (cuotasElegidas > 0)
        //    {
        //        cbxSeleccionarTodo.Enabled = false;
        //    }
        //    else
        //    {
        //        if (cbxSeleccionarTodo.Checked)
        //        {
        //            CambiarValorSeleccionTodasLasCuotas(true);
        //        }
        //        else
        //        {
        //            CambiarValorSeleccionTodasLasCuotas(false);
        //            cbxSeleccionarTodo.Enabled = true;
        //        }
        //        HabilitarBotonConfirmar();
        //    }

        //}

        //private void CambiarValorSeleccionTodasLasCuotas(bool valor)
        //{
        //    foreach (DataGridViewRow row in dgvProductoElegido.Rows)
        //    {
        //        DataGridViewCheckBoxCell? celdaCheckBox = row.Cells[3] as DataGridViewCheckBoxCell;
        //        celdaCheckBox.Value = valor;
        //        celdaCheckBox.ReadOnly = valor; // Makes it non-editable
        //        celdaCheckBox.Selected = !valor; // Makes it non-selectable
        //        row.Cells[3].Selected = !valor;
        //        ActualizarCuotasSeleccionadas(valor);
        //    }
        //}

    }
}
