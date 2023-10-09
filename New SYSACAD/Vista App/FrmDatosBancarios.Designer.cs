namespace Vista_App
{
    partial class FrmDatosBancarios
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
            pnlPagoTarjeta = new Panel();
            lblTarjetaTitular = new Label();
            btnTarjetaCancelar = new Button();
            btnTarjetaConfirmar = new Button();
            lblClaveSeguridad = new Label();
            lblFechaVencimiento = new Label();
            lblNumeroTarjeta = new Label();
            tbxClaveSeguridad = new TextBox();
            tbxAnioVencimiento = new TextBox();
            tbxMesVencimiento = new TextBox();
            tbxNumeroTarjeta = new TextBox();
            pnlPagoTransferencia = new Panel();
            btnCancelarTransferencia = new Button();
            btnConfirmarTransferencia = new Button();
            lblTitularTransferencia = new Label();
            tbxCUIT = new TextBox();
            cbxTipoCuenta = new ComboBox();
            tbxAlias = new TextBox();
            tbxCBU = new TextBox();
            tbxNumeroCuenta = new TextBox();
            tbxBanco = new TextBox();
            pnlPagoTarjeta.SuspendLayout();
            pnlPagoTransferencia.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPagoTarjeta
            // 
            pnlPagoTarjeta.BackColor = SystemColors.Window;
            pnlPagoTarjeta.Controls.Add(lblTarjetaTitular);
            pnlPagoTarjeta.Controls.Add(btnTarjetaCancelar);
            pnlPagoTarjeta.Controls.Add(btnTarjetaConfirmar);
            pnlPagoTarjeta.Controls.Add(lblClaveSeguridad);
            pnlPagoTarjeta.Controls.Add(lblFechaVencimiento);
            pnlPagoTarjeta.Controls.Add(lblNumeroTarjeta);
            pnlPagoTarjeta.Controls.Add(tbxClaveSeguridad);
            pnlPagoTarjeta.Controls.Add(tbxAnioVencimiento);
            pnlPagoTarjeta.Controls.Add(tbxMesVencimiento);
            pnlPagoTarjeta.Controls.Add(tbxNumeroTarjeta);
            pnlPagoTarjeta.Dock = DockStyle.Left;
            pnlPagoTarjeta.Location = new Point(0, 0);
            pnlPagoTarjeta.Name = "pnlPagoTarjeta";
            pnlPagoTarjeta.Size = new Size(173, 411);
            pnlPagoTarjeta.TabIndex = 0;
            // 
            // lblTarjetaTitular
            // 
            lblTarjetaTitular.AutoSize = true;
            lblTarjetaTitular.Location = new Point(80, 20);
            lblTarjetaTitular.Name = "lblTarjetaTitular";
            lblTarjetaTitular.Size = new Size(40, 15);
            lblTarjetaTitular.TabIndex = 10;
            lblTarjetaTitular.Text = "Titular";
            // 
            // btnTarjetaCancelar
            // 
            btnTarjetaCancelar.Location = new Point(200, 350);
            btnTarjetaCancelar.Name = "btnTarjetaCancelar";
            btnTarjetaCancelar.Size = new Size(75, 23);
            btnTarjetaCancelar.TabIndex = 9;
            btnTarjetaCancelar.Text = "Cancelar";
            btnTarjetaCancelar.UseVisualStyleBackColor = true;
            btnTarjetaCancelar.Click += btnTarjetaCancelar_Click;
            // 
            // btnTarjetaConfirmar
            // 
            btnTarjetaConfirmar.Location = new Point(75, 350);
            btnTarjetaConfirmar.Name = "btnTarjetaConfirmar";
            btnTarjetaConfirmar.Size = new Size(75, 23);
            btnTarjetaConfirmar.TabIndex = 8;
            btnTarjetaConfirmar.Text = "Confirmar";
            btnTarjetaConfirmar.UseVisualStyleBackColor = true;
            btnTarjetaConfirmar.Click += btnTarjetaConfirmar_Click;
            // 
            // lblClaveSeguridad
            // 
            lblClaveSeguridad.AutoSize = true;
            lblClaveSeguridad.Location = new Point(80, 172);
            lblClaveSeguridad.Name = "lblClaveSeguridad";
            lblClaveSeguridad.Size = new Size(39, 15);
            lblClaveSeguridad.TabIndex = 7;
            lblClaveSeguridad.Text = "Clave:";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(80, 112);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(126, 15);
            lblFechaVencimiento.TabIndex = 6;
            lblFechaVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Location = new Point(80, 52);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(91, 15);
            lblNumeroTarjeta.TabIndex = 5;
            lblNumeroTarjeta.Text = "Número Tarjeta:";
            // 
            // tbxClaveSeguridad
            // 
            tbxClaveSeguridad.Location = new Point(80, 190);
            tbxClaveSeguridad.Name = "tbxClaveSeguridad";
            tbxClaveSeguridad.PlaceholderText = "Clave";
            tbxClaveSeguridad.Size = new Size(100, 23);
            tbxClaveSeguridad.TabIndex = 4;
            // 
            // tbxAnioVencimiento
            // 
            tbxAnioVencimiento.Location = new Point(136, 130);
            tbxAnioVencimiento.Name = "tbxAnioVencimiento";
            tbxAnioVencimiento.PlaceholderText = "Año";
            tbxAnioVencimiento.Size = new Size(70, 23);
            tbxAnioVencimiento.TabIndex = 3;
            // 
            // tbxMesVencimiento
            // 
            tbxMesVencimiento.Location = new Point(80, 130);
            tbxMesVencimiento.Name = "tbxMesVencimiento";
            tbxMesVencimiento.PlaceholderText = "Mes";
            tbxMesVencimiento.Size = new Size(50, 23);
            tbxMesVencimiento.TabIndex = 2;
            // 
            // tbxNumeroTarjeta
            // 
            tbxNumeroTarjeta.Location = new Point(80, 70);
            tbxNumeroTarjeta.Name = "tbxNumeroTarjeta";
            tbxNumeroTarjeta.PlaceholderText = "Nro. de Tarjeta";
            tbxNumeroTarjeta.Size = new Size(190, 23);
            tbxNumeroTarjeta.TabIndex = 0;
            // 
            // pnlPagoTransferencia
            // 
            pnlPagoTransferencia.Controls.Add(btnCancelarTransferencia);
            pnlPagoTransferencia.Controls.Add(btnConfirmarTransferencia);
            pnlPagoTransferencia.Controls.Add(lblTitularTransferencia);
            pnlPagoTransferencia.Controls.Add(tbxCUIT);
            pnlPagoTransferencia.Controls.Add(cbxTipoCuenta);
            pnlPagoTransferencia.Controls.Add(tbxAlias);
            pnlPagoTransferencia.Controls.Add(tbxCBU);
            pnlPagoTransferencia.Controls.Add(tbxNumeroCuenta);
            pnlPagoTransferencia.Controls.Add(tbxBanco);
            pnlPagoTransferencia.Dock = DockStyle.Left;
            pnlPagoTransferencia.Location = new Point(173, 0);
            pnlPagoTransferencia.Name = "pnlPagoTransferencia";
            pnlPagoTransferencia.Size = new Size(256, 411);
            pnlPagoTransferencia.TabIndex = 1;
            pnlPagoTransferencia.Visible = false;
            // 
            // btnCancelarTransferencia
            // 
            btnCancelarTransferencia.Location = new Point(200, 350);
            btnCancelarTransferencia.Name = "btnCancelarTransferencia";
            btnCancelarTransferencia.Size = new Size(75, 23);
            btnCancelarTransferencia.TabIndex = 10;
            btnCancelarTransferencia.Text = "Cancelar";
            btnCancelarTransferencia.UseVisualStyleBackColor = true;
            btnCancelarTransferencia.Click += btnCancelarTransferencia_Click;
            // 
            // btnConfirmarTransferencia
            // 
            btnConfirmarTransferencia.Location = new Point(75, 350);
            btnConfirmarTransferencia.Name = "btnConfirmarTransferencia";
            btnConfirmarTransferencia.Size = new Size(75, 23);
            btnConfirmarTransferencia.TabIndex = 9;
            btnConfirmarTransferencia.Text = "Confirmar";
            btnConfirmarTransferencia.UseVisualStyleBackColor = true;
            btnConfirmarTransferencia.Click += btnConfirmarTransferencia_Click;
            // 
            // lblTitularTransferencia
            // 
            lblTitularTransferencia.AutoSize = true;
            lblTitularTransferencia.Location = new Point(35, 20);
            lblTitularTransferencia.Name = "lblTitularTransferencia";
            lblTitularTransferencia.Size = new Size(40, 15);
            lblTitularTransferencia.TabIndex = 8;
            lblTitularTransferencia.Text = "Titular";
            // 
            // tbxCUIT
            // 
            tbxCUIT.Location = new Point(35, 175);
            tbxCUIT.Name = "tbxCUIT";
            tbxCUIT.PlaceholderText = "C.U.I.T.";
            tbxCUIT.Size = new Size(190, 23);
            tbxCUIT.TabIndex = 7;
            // 
            // cbxTipoCuenta
            // 
            cbxTipoCuenta.FormattingEnabled = true;
            cbxTipoCuenta.Location = new Point(35, 95);
            cbxTipoCuenta.Name = "cbxTipoCuenta";
            cbxTipoCuenta.Size = new Size(190, 23);
            cbxTipoCuenta.TabIndex = 5;
            cbxTipoCuenta.SelectedIndexChanged += cbxTipoCuenta_SelectedIndexChanged;
            // 
            // tbxAlias
            // 
            tbxAlias.Location = new Point(35, 255);
            tbxAlias.Name = "tbxAlias";
            tbxAlias.PlaceholderText = "Alias";
            tbxAlias.Size = new Size(190, 23);
            tbxAlias.TabIndex = 4;
            // 
            // tbxCBU
            // 
            tbxCBU.Location = new Point(35, 215);
            tbxCBU.Name = "tbxCBU";
            tbxCBU.PlaceholderText = "CBU";
            tbxCBU.Size = new Size(190, 23);
            tbxCBU.TabIndex = 3;
            // 
            // tbxNumeroCuenta
            // 
            tbxNumeroCuenta.Location = new Point(35, 135);
            tbxNumeroCuenta.Name = "tbxNumeroCuenta";
            tbxNumeroCuenta.PlaceholderText = "Nro. de Cuenta";
            tbxNumeroCuenta.Size = new Size(190, 23);
            tbxNumeroCuenta.TabIndex = 2;
            // 
            // tbxBanco
            // 
            tbxBanco.Location = new Point(35, 55);
            tbxBanco.Name = "tbxBanco";
            tbxBanco.PlaceholderText = "Banco";
            tbxBanco.Size = new Size(190, 23);
            tbxBanco.TabIndex = 0;
            // 
            // FrmDatosBancarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(pnlPagoTransferencia);
            Controls.Add(pnlPagoTarjeta);
            Name = "FrmDatosBancarios";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmDatosBancarios_Load;
            pnlPagoTarjeta.ResumeLayout(false);
            pnlPagoTarjeta.PerformLayout();
            pnlPagoTransferencia.ResumeLayout(false);
            pnlPagoTransferencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPagoTarjeta;
        private TextBox tbxNumeroTarjeta;
        private Label lblClaveSeguridad;
        private Label lblFechaVencimiento;
        private Label lblNumeroTarjeta;
        private TextBox tbxClaveSeguridad;
        private TextBox tbxAnioVencimiento;
        private TextBox tbxMesVencimiento;
        private Button btnTarjetaCancelar;
        private Button btnTarjetaConfirmar;
        private Label lblTarjetaTitular;
        private Panel pnlPagoTransferencia;
        private TextBox tbxAlias;
        private TextBox tbxCBU;
        private TextBox tbxNumeroCuenta;
        private TextBox tbxBanco;
        private ComboBox cbxTipoCuenta;
        private TextBox tbxCUIT;
        private Label lblTitularTransferencia;
        private Button btnCancelarTransferencia;
        private Button btnConfirmarTransferencia;
    }
}