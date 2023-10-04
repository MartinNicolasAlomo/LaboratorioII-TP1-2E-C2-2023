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
            dgvServiciosImpagos = new DataGridView();
            Seleccion = new DataGridViewCheckBoxColumn();
            lblPagosPendientes = new Label();
            btnPagarServicio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosImpagos).BeginInit();
            SuspendLayout();
            // 
            // dgvServiciosImpagos
            // 
            dgvServiciosImpagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosImpagos.Columns.AddRange(new DataGridViewColumn[] { Seleccion });
            dgvServiciosImpagos.Location = new Point(54, 43);
            dgvServiciosImpagos.Name = "dgvServiciosImpagos";
            dgvServiciosImpagos.RowTemplate.Height = 25;
            dgvServiciosImpagos.Size = new Size(683, 197);
            dgvServiciosImpagos.TabIndex = 0;
            dgvServiciosImpagos.CellContentClick += dgvServiciosImpagos_CellContentClick;
            // 
            // Seleccion
            // 
            Seleccion.HeaderText = "Seleccionado";
            Seleccion.Name = "Seleccion";
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
            btnPagarServicio.Location = new Point(199, 329);
            btnPagarServicio.Name = "btnPagarServicio";
            btnPagarServicio.Size = new Size(151, 33);
            btnPagarServicio.TabIndex = 2;
            btnPagarServicio.Text = "Pagar Servicio";
            btnPagarServicio.UseVisualStyleBackColor = true;
            btnPagarServicio.Click += btnPagarServicio_Click;
            // 
            // FrmRealizarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPagarServicio);
            Controls.Add(lblPagosPendientes);
            Controls.Add(dgvServiciosImpagos);
            Name = "FrmRealizarPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRealizarPagos";
            Load += FrmRealizarPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServiciosImpagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServiciosImpagos;
        private Label lblPagosPendientes;
        private Button btnPagarServicio;
        private DataGridViewCheckBoxColumn Seleccion;
    }
}