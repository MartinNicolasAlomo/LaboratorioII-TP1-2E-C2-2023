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

        public FrmRealizarPagos(Estudiante estudianteLogueado)
        {
            InitializeComponent();
            this.estudianteLogueado = estudianteLogueado;
            serviciosSeleccionados = new List<Servicio>();
            Text = $"Pago de Cuotas C2, 2023 - {estudianteLogueado.NombreCompletoOrdenApellido}";
        }

        private void FrmRealizarPagos_Load(object sender, EventArgs e)
        {
            dgvServiciosImpagos.DataSource = estudianteLogueado.ServiciosImpagos;
        }

        private void btnPagarServicio_Click(object sender, EventArgs e)
        {
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
                    serviciosSeleccionados.Add(servicioElegido);
                }
                else
                {
                    serviciosSeleccionados.Remove(servicioElegido);
                }
            }
        }
    }
}
