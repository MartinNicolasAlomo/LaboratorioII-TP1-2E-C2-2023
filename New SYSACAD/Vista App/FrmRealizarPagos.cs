﻿using Logica_Sysacad;
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
            DataGridViewCheckBoxColumn columnaCheckBox = new DataGridViewCheckBoxColumn();
            columnaCheckBox.Name = "ServicioSeleccionado";
            columnaCheckBox.HeaderText = "Seleccionado";
            columnaCheckBox.Width = 100;
            columnaCheckBox.ReadOnly = false;
            dgvServiciosImpagos.Columns.Add(columnaCheckBox);
            EstablecerConfiguracionDataGrid();
        }

        private void EstablecerConfiguracionDataGrid()
        {
            dgvServiciosImpagos.DataSource = estudianteLogueado.ServiciosImpagos;
            dgvServiciosImpagos.Columns[9].Visible = false;
            dgvServiciosImpagos.Columns[2].DefaultCellStyle.Format = "C2";
            dgvServiciosImpagos.Columns[3].DefaultCellStyle.Format = "C2";
            dgvServiciosImpagos.Columns[8].DefaultCellStyle.Format = "C2";
            dgvServiciosImpagos.Columns[2].HeaderText = "Precio por Cuota";
            dgvServiciosImpagos.Columns[3].HeaderText = "Precio Total";
            dgvServiciosImpagos.Columns[4].HeaderText = "Cuotas Impagas";
            dgvServiciosImpagos.Columns[5].HeaderText = "Cuotas Abonadas";
            dgvServiciosImpagos.Columns[6].HeaderText = "Cuotas Totales";
            dgvServiciosImpagos.Columns[7].HeaderText = "Cuotas Elegidas";
            dgvServiciosImpagos.Columns[8].HeaderText = "Monto Total";
            dgvServiciosImpagos.Columns[1].Width = 185;
            dgvServiciosImpagos.Columns[2].Width = 90;
            dgvServiciosImpagos.Columns[3].Width = 90;
            dgvServiciosImpagos.Columns[4].Width = 75;
            dgvServiciosImpagos.Columns[5].Width = 75;
            dgvServiciosImpagos.Columns[6].Width = 75;
            dgvServiciosImpagos.Columns[7].Width = 75;
            dgvServiciosImpagos.Columns[8].Width = 75;
            foreach (DataGridViewColumn column in dgvServiciosImpagos.Columns)
            {
                if (column.Index > 1)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }




        private void btnPagarServicio_Click(object sender, EventArgs e)
        {
            if (serviciosSeleccionados.Count == 0)
            {
                MessageBox.Show("No hay servicios elegidoa para pagar");
            }
            else
            {
                VerificarFormaDePago();
                if (FrmMensajeConfirmacion.PreguntarConfirmacion("Confirma??") == DialogResult.OK)
                {
                    string mensaje;
                    foreach (Servicio servicio in serviciosSeleccionados)
                    {
                        estudianteLogueado.PagarServicios(servicio, servicio.CuotasElegidasAPagar, out mensaje);
                        servicio.ActulizarCuotasYMontoElegidos(0, 0);

                        MessageBox.Show(mensaje);
                    }
                    RestaurarValoresOriginales();
                    ActualizarDataGridView();

                    MessageBox.Show(estudianteLogueado.MostrarServiciosAPagar(), "EN BASE DE DATOS");
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

                    //if (isChecked)
                    //{
                    //    if (!serviciosSeleccionados.Contains(servicioElegido))
                    //    {
                    //        serviciosSeleccionados.Add(servicioElegido);
                    //    }
                    //}
                    //else
                    //{
                    //    serviciosSeleccionados.Remove(servicioElegido);
                    //}

                }
            }
        }

        private void VerificarFormaDePago()
        {
            if (rbnTransferencia.Checked == true)
            {
                InstanciarFrmDatosBancarios(estudianteLogueado, '1');
            }
            else if (rbnTarjetaDebito.Checked == true)
            {
                InstanciarFrmDatosBancarios(estudianteLogueado, '2');
            }
            else if (rbnTarjetaCredito.Checked == true)
            {
                InstanciarFrmDatosBancarios(estudianteLogueado, '3');
            }
        }

        private void InstanciarFrmDatosBancarios(Estudiante estudianteLogueado, char formaPago)
        {
            FrmDatosBancarios datosBancarios = new FrmDatosBancarios(estudianteLogueado, formaPago);
            Hide();
            datosBancarios.ShowDialog();
            Show();
        }

        private void RestaurarValoresOriginales()
        {
            serviciosSeleccionados.Clear();
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
                DataGridViewCheckBoxCell? celdaCheckBox = dgvServiciosImpagos.Rows[indiceFila].Cells[indiceColumna] as DataGridViewCheckBoxCell;
                bool isChecked = (bool)celdaCheckBox.EditedFormattedValue;
                if (isChecked)
                {
                    if (servicioElegido.CuotasImpagas == 1)
                    {
                        serviciosSeleccionados.Add(servicioElegido);
                        ActualizarCuotasYMontoServicio(indiceFila, servicioElegido, 1, servicioElegido.PrecioCuota, true);
                        MessageBox.Show($"Se eligio {servicioElegido.CuotasElegidasAPagar} por un total de {servicioElegido.PrecioCuota:C2}", $"¡Cuotas seleccionadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            servicioElegido.ActulizarCuotasYMontoElegidos(cuotas, monto);
            dgvServiciosImpagos.Rows[indiceFila].Cells[7].Value = cuotas;
            dgvServiciosImpagos.Rows[indiceFila].Cells[8].Value = monto;
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
