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
            //dgvServiciosImpagos.Columns[7].Data
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.Name = "MonthlyFeesColumn"; // Set a name for the column
            comboColumn.HeaderText = "CUOTITAS?"; // Set the header text
            comboColumn.DataPropertyName = "monthlyFee"; // Set DataPropertyName to the property name
            dgvServiciosImpagos.Columns.Add(comboColumn);

        }

        private void btnPagarServicio_Click(object sender, EventArgs e)
        {
            // CREAR FORMILARIO
            //StringBuilder text = new StringBuilder();
            //text.AppendLine("VISTA PREVIA: se seleccionaron estos cursos para solicitar inscripcion!!!!!!");
            //foreach (Servicio servicio in serviciosSeleccionados)
            //{
            //    text.AppendLine(servicio.Nombre);
            //}
            //MessageBox.Show(text.ToString());
            if (FrmMensajeConfirmacion.PreguntarConfirmacion("Confirma??") == DialogResult.OK)
            {
                string mensaje;
                //estudianteLogueado.ServiciosImpagos?.Clear();
                //estudianteLogueado.ServiciosAbonados?.Clear();
                foreach (Servicio servicio in serviciosSeleccionados)
                {
                    // si ya fue pagado en total    - remover de serviciosSeleccionados;
                    //  if estudianteLogueado.Servicios.contains(servicio)      continue;
                    if (estudianteLogueado.PagarServicios(servicio, 3, out mensaje))
                    {

                    }
                    MessageBox.Show(mensaje);
                    //serviciosSeleccionados.Remove(servicio);
                }
                ActualizarDataGridView();
                MessageBox.Show(estudianteLogueado.MostrarServiciosAPagar(), "EN BASE DE DATOS");
                //if (estudianteLogueado.ServiciosImpagos?.Count == 0)
                //{
                //    MessageBox.Show("¡Se pagaron todos los servicios. No hay pagos pendientes!");
                //    Close();
                //}
            }
        }


        public void ActualizarDataGridView()
        {
            dgvServiciosImpagos.DataSource = null;
            dgvServiciosImpagos.DataSource = estudianteLogueado.ServiciosImpagos;
        }


        private void dgvServiciosImpagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvServiciosImpagos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                Servicio servicioElegido = (Servicio)dgvServiciosImpagos.Rows[e.RowIndex].DataBoundItem;
                DataGridViewCheckBoxCell celdaCheckBox = dgvServiciosImpagos.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool isChecked = (bool)celdaCheckBox.EditedFormattedValue;
                if (isChecked)
                {
                    FrmSeleccionCuotas seleccionCuotas = new FrmSeleccionCuotas(servicioElegido);
                    if (seleccionCuotas.ShowDialog() == DialogResult.OK)
                    {
                        serviciosSeleccionados.Add(servicioElegido);
                        servicioElegido.CuotasElegidasAPagar = seleccionCuotas.CuotasElegidas;
                        servicioElegido.MontoTotalAPagar = seleccionCuotas.MontoTotal;
                        dgvServiciosImpagos.Rows[e.RowIndex].Cells[7].Value = servicioElegido.CuotasElegidasAPagar;
                        dgvServiciosImpagos.Rows[e.RowIndex].Cells[8].Value = $"{servicioElegido.MontoTotalAPagar:C2}";

                        MessageBox.Show($"Se eligio {servicioElegido.CuotasElegidasAPagar} por un total de {servicioElegido.MontoTotalAPagar:C2}", $"¡Cuotas seleccionadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        celdaCheckBox.EditingCellFormattedValue = false;
                        servicioElegido.CuotasElegidasAPagar = 0;
                        servicioElegido.MontoTotalAPagar = 0;
                        MessageBox.Show($"canelado 1 SERVICIO FINAL{servicioElegido.CuotasElegidasAPagar} por un total de {servicioElegido.MontoTotalAPagar:C2}", $"¡Cuotas seleccionadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // USAR PROPIEDAD CANTELEGIDAS Y MONTOTOTAL
                    // AJUSTAR= CUOTASAPAGAR = CANTELEGIDAS         MONTOTOTAL.TEXT = MONTOTTAL
                    //


                }
                else
                {
                    serviciosSeleccionados.Remove(servicioElegido);
                    servicioElegido.CuotasElegidasAPagar = 0;
                    servicioElegido.MontoTotalAPagar = 0; 
                    dgvServiciosImpagos.Rows[e.RowIndex].Cells[7].Value = servicioElegido.CuotasElegidasAPagar;
                    dgvServiciosImpagos.Rows[e.RowIndex].Cells[8].Value = $"{servicioElegido.MontoTotalAPagar:C2}";
                    MessageBox.Show($"cancelo 2 {servicioElegido.CuotasElegidasAPagar} por un total de {servicioElegido.MontoTotalAPagar:C2}", $"¡Cuotas seleccionadas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //servicioElegido.CuotasImpagas = cuotasImpagasOriginales;
                    //servicioElegido.CuotasImpagas = cuotasImpagasOriginales;


                }
            }
        }



    }
}
