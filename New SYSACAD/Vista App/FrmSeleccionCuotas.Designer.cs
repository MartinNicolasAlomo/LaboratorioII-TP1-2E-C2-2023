namespace Vista_App
{
    partial class FrmSeleccionCuotas
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
            dgvProductoElegido = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            NumeroCuota = new DataGridViewTextBoxColumn();
            PrecioCuota = new DataGridViewTextBoxColumn();
            CuotaSeleccionada = new DataGridViewCheckBoxColumn();
            servicioBindingSource = new BindingSource(components);
            lblCuotasElegidas = new Label();
            lblMontoTotal = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            cbxSeleccionarTodo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductoElegido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvProductoElegido
            // 
            dgvProductoElegido.AllowUserToAddRows = false;
            dgvProductoElegido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductoElegido.Columns.AddRange(new DataGridViewColumn[] { Nombre, NumeroCuota, PrecioCuota, CuotaSeleccionada });
            dgvProductoElegido.Location = new Point(12, 12);
            dgvProductoElegido.Name = "dgvProductoElegido";
            dgvProductoElegido.Size = new Size(609, 209);
            dgvProductoElegido.TabIndex = 0;
            dgvProductoElegido.CellContentClick += dgvProductoElegido_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Resizable = DataGridViewTriState.False;
            Nombre.Width = 150;
            // 
            // NumeroCuota
            // 
            NumeroCuota.HeaderText = "N° de Cuota";
            NumeroCuota.Name = "NumeroCuota";
            // 
            // PrecioCuota
            // 
            PrecioCuota.HeaderText = "Precio por Cuota";
            PrecioCuota.Name = "PrecioCuota";
            // 
            // CuotaSeleccionada
            // 
            CuotaSeleccionada.HeaderText = "Seleccionada";
            CuotaSeleccionada.Name = "CuotaSeleccionada";
            CuotaSeleccionada.Resizable = DataGridViewTriState.False;
            // 
            // servicioBindingSource
            // 
            servicioBindingSource.DataSource = typeof(Logica_Sysacad.Servicio);
            // 
            // lblCuotasElegidas
            // 
            lblCuotasElegidas.AutoSize = true;
            lblCuotasElegidas.Location = new Point(685, 24);
            lblCuotasElegidas.Name = "lblCuotasElegidas";
            lblCuotasElegidas.Size = new Size(0, 15);
            lblCuotasElegidas.TabIndex = 1;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(685, 137);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(0, 15);
            lblMontoTotal.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(227, 297);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(378, 299);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbxSeleccionarTodo
            // 
            cbxSeleccionarTodo.AutoSize = true;
            cbxSeleccionarTodo.Location = new Point(406, 234);
            cbxSeleccionarTodo.Name = "cbxSeleccionarTodo";
            cbxSeleccionarTodo.Size = new Size(115, 19);
            cbxSeleccionarTodo.TabIndex = 5;
            cbxSeleccionarTodo.Text = "Seleccionar Todo";
            cbxSeleccionarTodo.UseVisualStyleBackColor = true;
            //cbxSeleccionarTodo.Click += cbxSeleccionarTodo_Click;
            // 
            // FrmSeleccionCuotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxSeleccionarTodo);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblMontoTotal);
            Controls.Add(lblCuotasElegidas);
            Controls.Add(dgvProductoElegido);
            Name = "FrmSeleccionCuotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSeleccionCuotas";
            Load += FrmSeleccionCuotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductoElegido).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductoElegido;
        private BindingSource servicioBindingSource;
        private Label lblCuotasElegidas;
        private Label lblMontoTotal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn NumeroCuota;
        private DataGridViewTextBoxColumn PrecioCuota;
        private DataGridViewCheckBoxColumn CuotaSeleccionada;
        private Button btnConfirmar;
        private Button btnCancelar;
        private CheckBox cbxSeleccionarTodo;
    }
}