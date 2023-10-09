namespace Vista_App
{
    partial class FrmRealizarPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvServiciosImpagos = new DataGridView();
            servicioBindingSource = new BindingSource(components);
            lblPagosPendientes = new Label();
            btnPagarServicio = new Button();
            gbxFormasPago = new GroupBox();
            rbnTarjetaCredito = new RadioButton();
            rbnTarjetaDebito = new RadioButton();
            rbnTransferencia = new RadioButton();
            lblTotalAPagar = new Label();
            lblMontoTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosImpagos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicioBindingSource).BeginInit();
            gbxFormasPago.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServiciosImpagos
            // 
            dgvServiciosImpagos.AllowUserToAddRows = false;
            dgvServiciosImpagos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvServiciosImpagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosImpagos.Location = new Point(28, 43);
            dgvServiciosImpagos.Name = "dgvServiciosImpagos";
            dgvServiciosImpagos.RowTemplate.Height = 25;
            dgvServiciosImpagos.Size = new Size(760, 197);
            dgvServiciosImpagos.TabIndex = 0;
            dgvServiciosImpagos.CellContentClick += dgvServiciosImpagos_CellContentClick;
            // 
            // servicioBindingSource
            // 
            servicioBindingSource.DataSource = typeof(Logica_Sysacad.Servicio);
            // 
            // lblPagosPendientes
            // 
            lblPagosPendientes.AutoSize = true;
            lblPagosPendientes.Location = new Point(54, 25);
            lblPagosPendientes.Name = "lblPagosPendientes";
            lblPagosPendientes.Size = new Size(103, 15);
            lblPagosPendientes.TabIndex = 1;
            lblPagosPendientes.Text = "Pagos pendientes:";
            // 
            // btnPagarServicio
            // 
            btnPagarServicio.Location = new Point(577, 316);
            btnPagarServicio.Name = "btnPagarServicio";
            btnPagarServicio.Size = new Size(151, 33);
            btnPagarServicio.TabIndex = 2;
            btnPagarServicio.Text = "Pagar Servicio";
            btnPagarServicio.UseVisualStyleBackColor = true;
            btnPagarServicio.Click += btnPagarServicio_Click;
            // 
            // gbxFormasPago
            // 
            gbxFormasPago.Controls.Add(rbnTarjetaCredito);
            gbxFormasPago.Controls.Add(rbnTarjetaDebito);
            gbxFormasPago.Controls.Add(rbnTransferencia);
            gbxFormasPago.Location = new Point(57, 250);
            gbxFormasPago.Name = "gbxFormasPago";
            gbxFormasPago.Size = new Size(151, 99);
            gbxFormasPago.TabIndex = 3;
            gbxFormasPago.TabStop = false;
            gbxFormasPago.Text = "Elija la forma de pago:";
            // 
            // rbnTarjetaCredito
            // 
            rbnTarjetaCredito.AutoSize = true;
            rbnTarjetaCredito.Location = new Point(6, 72);
            rbnTarjetaCredito.Name = "rbnTarjetaCredito";
            rbnTarjetaCredito.Size = new Size(117, 19);
            rbnTarjetaCredito.TabIndex = 2;
            rbnTarjetaCredito.Text = "Tarjeta de Crédito";
            rbnTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // rbnTarjetaDebito
            // 
            rbnTarjetaDebito.AutoSize = true;
            rbnTarjetaDebito.Location = new Point(6, 47);
            rbnTarjetaDebito.Name = "rbnTarjetaDebito";
            rbnTarjetaDebito.Size = new Size(113, 19);
            rbnTarjetaDebito.TabIndex = 1;
            rbnTarjetaDebito.Text = "Tarjeta de Débito";
            rbnTarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // rbnTransferencia
            // 
            rbnTransferencia.AutoSize = true;
            rbnTransferencia.Checked = true;
            rbnTransferencia.Location = new Point(6, 22);
            rbnTransferencia.Name = "rbnTransferencia";
            rbnTransferencia.Size = new Size(94, 19);
            rbnTransferencia.TabIndex = 0;
            rbnTransferencia.TabStop = true;
            rbnTransferencia.Text = "Transferencia";
            rbnTransferencia.UseVisualStyleBackColor = true;
            // 
            // lblTotalAPagar
            // 
            lblTotalAPagar.AutoSize = true;
            lblTotalAPagar.Location = new Point(327, 260);
            lblTotalAPagar.Name = "lblTotalAPagar";
            lblTotalAPagar.Size = new Size(77, 15);
            lblTotalAPagar.TabIndex = 4;
            lblTotalAPagar.Text = "Total a Pagar:";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(331, 286);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(34, 15);
            lblMontoTotal.TabIndex = 5;
            lblMontoTotal.Text = "$0,00";
            // 
            // FrmRealizarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(lblMontoTotal);
            Controls.Add(lblTotalAPagar);
            Controls.Add(gbxFormasPago);
            Controls.Add(btnPagarServicio);
            Controls.Add(lblPagosPendientes);
            Controls.Add(dgvServiciosImpagos);
            Name = "FrmRealizarPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmRealizarPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServiciosImpagos).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicioBindingSource).EndInit();
            gbxFormasPago.ResumeLayout(false);
            gbxFormasPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServiciosImpagos;
        private Label lblPagosPendientes;
        private Button btnPagarServicio;
        private BindingSource servicioBindingSource;
        private GroupBox gbxFormasPago;
        private RadioButton rbnTarjetaDebito;
        private RadioButton rbnTransferencia;
        private RadioButton rbnTarjetaCredito;
        private Label lblTotalAPagar;
        private Label lblMontoTotal;
    }
}