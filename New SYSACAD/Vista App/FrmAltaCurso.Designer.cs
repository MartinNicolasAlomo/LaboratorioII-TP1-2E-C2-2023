namespace Vista_App
{
    partial class FrmAltaCurso
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
            btnConfirmar = new Button();
            cbxTurno = new ComboBox();
            cbxDia = new ComboBox();
            cbxAula = new ComboBox();
            cbxCuatrimestre = new ComboBox();
            cbxDivision = new ComboBox();
            cbxMateria = new ComboBox();
            tbxCupoMaximo = new TextBox();
            cbxHorario = new ComboBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblCupoMaximo = new Label();
            lblTurno = new Label();
            lblDia = new Label();
            lblAula = new Label();
            lblHorario = new Label();
            btnCancelar = new Button();
            lblCodigo = new Label();
            tbxCodigo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(74, 306);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cbxTurno
            // 
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Location = new Point(108, 128);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(121, 23);
            cbxTurno.TabIndex = 4;
            cbxTurno.SelectedIndexChanged += cbxTurno_SelectedIndexChanged;
            // 
            // cbxDia
            // 
            cbxDia.FormattingEnabled = true;
            cbxDia.Location = new Point(108, 157);
            cbxDia.Name = "cbxDia";
            cbxDia.Size = new Size(121, 23);
            cbxDia.TabIndex = 5;
            cbxDia.SelectedIndexChanged += cbxDia_SelectedIndexChanged;
            // 
            // cbxAula
            // 
            cbxAula.FormattingEnabled = true;
            cbxAula.Location = new Point(108, 186);
            cbxAula.Name = "cbxAula";
            cbxAula.Size = new Size(121, 23);
            cbxAula.TabIndex = 6;
            cbxAula.SelectedIndexChanged += cbxAula_SelectedIndexChanged;
            // 
            // cbxCuatrimestre
            // 
            cbxCuatrimestre.FormattingEnabled = true;
            cbxCuatrimestre.Location = new Point(108, 41);
            cbxCuatrimestre.Name = "cbxCuatrimestre";
            cbxCuatrimestre.Size = new Size(57, 23);
            cbxCuatrimestre.TabIndex = 7;
            cbxCuatrimestre.SelectedIndexChanged += cbxCuatrimestre_SelectedIndexChanged;
            // 
            // cbxDivision
            // 
            cbxDivision.FormattingEnabled = true;
            cbxDivision.Location = new Point(175, 41);
            cbxDivision.Name = "cbxDivision";
            cbxDivision.Size = new Size(54, 23);
            cbxDivision.TabIndex = 8;
            cbxDivision.SelectedIndexChanged += cbxDivision_SelectedIndexChanged;
            // 
            // cbxMateria
            // 
            cbxMateria.FormattingEnabled = true;
            cbxMateria.Location = new Point(108, 70);
            cbxMateria.Name = "cbxMateria";
            cbxMateria.Size = new Size(121, 23);
            cbxMateria.TabIndex = 9;
            cbxMateria.SelectedIndexChanged += cbxDescripcion_SelectedIndexChanged;
            // 
            // tbxCupoMaximo
            // 
            tbxCupoMaximo.Location = new Point(108, 99);
            tbxCupoMaximo.Name = "tbxCupoMaximo";
            tbxCupoMaximo.PlaceholderText = "(Máx. 120).";
            tbxCupoMaximo.Size = new Size(72, 23);
            tbxCupoMaximo.TabIndex = 10;
            // 
            // cbxHorario
            // 
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(108, 215);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(121, 23);
            cbxHorario.TabIndex = 11;
            cbxHorario.SelectedIndexChanged += cbxHorario_SelectedIndexChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 73);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblCupoMaximo
            // 
            lblCupoMaximo.AutoSize = true;
            lblCupoMaximo.Location = new Point(12, 102);
            lblCupoMaximo.Name = "lblCupoMaximo";
            lblCupoMaximo.Size = new Size(86, 15);
            lblCupoMaximo.TabIndex = 14;
            lblCupoMaximo.Text = "Cupo Máximo:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(12, 131);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(41, 15);
            lblTurno.TabIndex = 15;
            lblTurno.Text = "Turno:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(12, 160);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(27, 15);
            lblDia.TabIndex = 16;
            lblDia.Text = "Día:";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.Location = new Point(12, 189);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(34, 15);
            lblAula.TabIndex = 17;
            lblAula.Text = "Aula:";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(12, 218);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(50, 15);
            lblHorario.TabIndex = 18;
            lblHorario.Text = "Horario:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(175, 306);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 20;
            lblCodigo.Text = "Código:";
            // 
            // tbxCodigo
            // 
            tbxCodigo.Location = new Point(108, 12);
            tbxCodigo.Name = "tbxCodigo";
            tbxCodigo.PlaceholderText = "Código";
            tbxCodigo.Size = new Size(57, 23);
            tbxCodigo.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(171, 15);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 22;
            label1.Text = "*Máximo 3 caractéres";
            // 
            // FrmAltaCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 341);
            Controls.Add(label1);
            Controls.Add(tbxCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(lblHorario);
            Controls.Add(lblAula);
            Controls.Add(lblDia);
            Controls.Add(lblTurno);
            Controls.Add(lblCupoMaximo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(cbxHorario);
            Controls.Add(tbxCupoMaximo);
            Controls.Add(cbxMateria);
            Controls.Add(cbxDivision);
            Controls.Add(cbxCuatrimestre);
            Controls.Add(cbxAula);
            Controls.Add(cbxDia);
            Controls.Add(cbxTurno);
            Controls.Add(btnConfirmar);
            Name = "FrmAltaCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmAltaCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private ComboBox cbxTurno;
        private ComboBox cbxDia;
        private ComboBox cbxAula;
        private ComboBox cbxCuatrimestre;
        private ComboBox cbxDivision;
        private ComboBox cbxMateria;
        private TextBox tbxCupoMaximo;
        private ComboBox cbxHorario;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblCupoMaximo;
        private Label lblTurno;
        private Label lblDia;
        private Label lblAula;
        private Label lblHorario;
        private Button btnCancelar;
        private Label lblCodigo;
        private TextBox tbxCodigo;
        private Label label1;
    }
}