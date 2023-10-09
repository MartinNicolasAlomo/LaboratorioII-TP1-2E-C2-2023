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
    public partial class FrmDatosBancarios : Form
    {
        private Estudiante estudianteLogueado;
        private char formaPago;
        private string? tipoCuenta;

        public FrmDatosBancarios(Estudiante estudianteLogueado, char formaPago)
        {
            InitializeComponent();
            this.estudianteLogueado = estudianteLogueado;
            this.formaPago = formaPago;
            pnlPagoTarjeta.Visible = false;
            pnlPagoTransferencia.Visible = false;
        }



        public void DeterminarErroresIngresoDatos()
        {
            StringBuilder text = new StringBuilder();
            if (false)
            {
                text.AppendLine($"");
            }
            if (false)
            {
                text.AppendLine($"");
            }
            if (false)
            {
                text.AppendLine($"");
            }
            if (false)
            {
                text.AppendLine($"");
            }
            if (false)
            {
                text.AppendLine($"");
            }
            if (false)
            {
                text.AppendLine($"");
            }
            if (false)
            {
                text.AppendLine($"");
            }
        }

        private void FrmDatosBancarios_Load(object sender, EventArgs e)
        {
            if (formaPago == '1')
            {
                pnlPagoTransferencia.Visible = true;
                pnlPagoTransferencia.Dock = DockStyle.Fill;

                lblTitularTransferencia.Text = $"{estudianteLogueado.NombreCompletoOrdenApellido}";
                Text = "Pago por Transferencia";
            }
            else
            {
                pnlPagoTarjeta.Visible = true;
                pnlPagoTarjeta.Dock = DockStyle.Fill;
                lblTarjetaTitular.Text = $"{estudianteLogueado.NombreCompletoOrdenApellido}";
                if (formaPago == '2')
                {
                    Text = "Pago con Tarjeta de Débito";
                }
                else
                {
                    Text = "Pago Tarjeta de Crédito";
                }
            }
        }

        private void btnTarjetaConfirmar_Click(object sender, EventArgs e)
        {
            string numeroTarjeta = tbxNumeroTarjeta.Text;
            string mesIngresado = tbxMesVencimiento.Text;
            string anioIngresado = tbxAnioVencimiento.Text;
            string claveSeguridad = tbxClaveSeguridad.Text;
            if (Validador.ValidarTextoNumerico(numeroTarjeta, 16) &&
                Validador.ValidarFechaIngresada(out DateTime FechaVencimiento, anioIngresado, mesIngresado, "1") &&
                Validador.ValidarTextoNumerico(claveSeguridad, 3))
            {
                MessageBox.Show("TODO OK");
                DialogResult = DialogResult.OK;
            }
            //MessageBox.Show("ERROR---");
        }

        private void btnTarjetaCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnConfirmarTransferencia_Click(object sender, EventArgs e)
        {
            string banco = tbxBanco.Text;
            string numeroCuenta = tbxNumeroCuenta.Text;
            string cuit = tbxCUIT.Text;
            string cbu = tbxCBU.Text;
            string alias = tbxAlias.Text;
            if (Validador.ValidarNombreIngresado(ref banco, 70) &&
                Validador.ValidarTextoNumerico(numeroCuenta, 10) &&
                Validador.ValidarTextoNumerico(cuit, 11) &&
                Validador.ValidarTextoNumerico(cbu, 22) &&
                Validador.ValidarNombreIngresado(ref alias, 11))
            {
                MessageBox.Show("TODO OK");
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelarTransferencia_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cbxTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoCuenta = cbxTipoCuenta.Items[cbxTipoCuenta.SelectedIndex].ToString();
        }




    }
}
