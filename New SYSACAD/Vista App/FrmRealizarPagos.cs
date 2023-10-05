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
        private Estudiante estudianteLogueado;
        private List<Servicio> serviciosSeleccionados;
        private byte cuotasImpagasOriginales;
        private static decimal montoTotalAPagar;

        public FrmRealizarPagos(Estudiante estudianteLogueado)
        {
            InitializeComponent();
            this.estudianteLogueado = estudianteLogueado;
            serviciosSeleccionados = new List<Servicio>();
            Text = $"Gestión de Pagos - {estudianteLogueado.NombreCompletoOrdenApellido}";
        }

        private void FrmRealizarPagos_Load(object sender, EventArgs e)
        {
            dgvServiciosImpagos.Columns[1].DefaultCellStyle.Format = "C2"; // C2 format represents currency with 2 decimal places
            dgvServiciosImpagos.Columns[2].DefaultCellStyle.Format = "C2"; // C2 format represents currency with 2 decimal places
            dgvServiciosImpagos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvServiciosImpagos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvServiciosImpagos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvServiciosImpagos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvServiciosImpagos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvServiciosImpagos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvServiciosImpagos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvServiciosImpagos.DataSource = estudianteLogueado.ServiciosImpagos;
        }

        private void btnPagarServicio_Click(object sender, EventArgs e)
        {
            if (serviciosSeleccionados.Count == 0)
            {
                MessageBox.Show("No hay servicios elegidoa para pagar");
            }
            else
            {
                if (FrmMensajeConfirmacion.PreguntarConfirmacion("Confirma??") == DialogResult.OK)
                {
                    string mensaje;
                    foreach (Servicio servicio in serviciosSeleccionados)
                    {
                        if (servicio.EstaPagadoTotalmente)
                        {
                            mensaje = $"¡El servicio {servicio.Nombre} ya fue pagado!";
                            continue;
                        }
                        else
                        {
                            if (estudianteLogueado.PagarServicios(servicio, servicio.CuotasElegidasAPagar, out mensaje))
                            {

                            }
                            servicio.ActulizarCuotasYMontoElegidos(0, 0);
                        }
                        MessageBox.Show(mensaje);
                    }
                    serviciosSeleccionados.Clear();
                    RestaurarMontoGeneral();
                    ActualizarDataGridView();

                    //MessageBox.Show(estudianteLogueado.MostrarServiciosAPagar(), "EN BASE DE DATOS");
                    // si ya fue pagado en total    - remover de serviciosSeleccionados;
                    //  if estudianteLogueado.Servicios.contains(servicio)      continue;
                    //serviciosSeleccionados.Remove(servicio);
                    //estudianteLogueado.ServiciosImpagos?.Clear();
                    //estudianteLogueado.ServiciosAbonados?.Clear();
                    //if (estudianteLogueado.ServiciosImpagos?.Count == 0)
                    //{
                    //    MessageBox.Show("¡Se pagaron todos los servicios. No hay pagos pendientes!");
                    //    Close();
                    //}
                }

            }

        }

        private void RestaurarMontoGeneral()
        {
            montoTotalAPagar = 0;
            lblMontoTotal.Text = $"{0:C2}";
        }

        private void dgvServiciosImpagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;
            if (indiceFila >= 0 && dgvServiciosImpagos.Columns[indiceColumna] is DataGridViewCheckBoxColumn)
            {
                Servicio servicioElegido = (Servicio)dgvServiciosImpagos.Rows[indiceFila].DataBoundItem;
                DataGridViewCheckBoxCell celdaCheckBox = dgvServiciosImpagos.Rows[indiceFila].Cells[indiceColumna] as DataGridViewCheckBoxCell;
                bool isChecked = (bool)celdaCheckBox.EditedFormattedValue;
                if (isChecked)
                {
                    if (servicioElegido.CuotasImpagas == 1)
                    {
                        serviciosSeleccionados.Add(servicioElegido);
                        ActualizarCuotasYMontoServicio(indiceFila, servicioElegido, 1, servicioElegido.PrecioCuota, true);
                        MessageBox.Show("SOLO QUEDA UNA CUOTA", $"¡Cuotas seleccionadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        FrmSeleccionCuotas seleccionCuotas = new FrmSeleccionCuotas(servicioElegido);
                        if (seleccionCuotas.ShowDialog() == DialogResult.OK)
                        {
                            serviciosSeleccionados.Add(servicioElegido);
                            ActualizarCuotasYMontoServicio(indiceFila, servicioElegido, seleccionCuotas.CuotasElegidas, seleccionCuotas.MontoTotal, true);
                            MessageBox.Show($"Se eligio {servicioElegido.CuotasElegidasAPagar} por un total de {servicioElegido.MontoTotalAPagar:C2}", $"¡Cuotas seleccionadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            celdaCheckBox.EditingCellFormattedValue = false;
                            ActualizarCuotasYMontoServicio(indiceFila, servicioElegido, 0, 0, false);
                            MessageBox.Show($"canelado 1 SERVICIO FINAL{servicioElegido.CuotasElegidasAPagar} por un total de {servicioElegido.MontoTotalAPagar:C2}", $"¡Cuotas seleccionadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    serviciosSeleccionados.Remove(servicioElegido);
                    ActualizarCuotasYMontoServicio(indiceFila, servicioElegido, 0, 0, false);
                    MessageBox.Show($"cancelo 2 {servicioElegido.CuotasElegidasAPagar} por un total de {servicioElegido.MontoTotalAPagar:C2}", $"¡Cuotas seleccionadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ActualizarCuotasYMontoServicio(int indiceFila, Servicio servicioElegido, byte cuotas, decimal monto, bool aumenta)
        {
            ActualizarMontoTotalGeneral(servicioElegido, monto, aumenta);
            //ActualDatos(servicioElegido, cuotas, monto);
            servicioElegido.ActulizarCuotasYMontoElegidos(cuotas, monto);
            dgvServiciosImpagos.Rows[indiceFila].Cells[7].Value = cuotas;
            dgvServiciosImpagos.Rows[indiceFila].Cells[8].Value = $"{monto:C2}";
        }

        private static void ActualDatos(Servicio servicioElegido, byte cuotas, decimal monto)
        {
            servicioElegido.CuotasElegidasAPagar = cuotas;
            servicioElegido.MontoTotalAPagar = monto;
        }

        private void ActualizarMontoTotalGeneral(Servicio servicioElegido, decimal monto, bool aumenta)
        {
            if (aumenta)
            {
                montoTotalAPagar += monto;
            }
            else
            {
                montoTotalAPagar -= servicioElegido.MontoTotalAPagar;
            }
            lblMontoTotal.Text = $"{montoTotalAPagar:C2}";
        }

        public void ActualizarDataGridView()
        {
            dgvServiciosImpagos.DataSource = null;
            dgvServiciosImpagos.DataSource = estudianteLogueado.ServiciosImpagos;
        }


    }
}
