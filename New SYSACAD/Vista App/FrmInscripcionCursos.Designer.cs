namespace Vista_App
{
    partial class FrmInscripcionCursos
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
            dgvListaCursos = new DataGridView();
            btnConfirmar = new Button();
            cbxCuatrimestre = new ComboBox();
            cbxMaterias = new ComboBox();
            btnFiltrar = new Button();
            cursoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCursos
            // 
            dgvListaCursos.AllowUserToAddRows = false;
            dgvListaCursos.AllowUserToDeleteRows = false;
            dgvListaCursos.AllowUserToResizeColumns = false;
            dgvListaCursos.AllowUserToResizeRows = false;
            dgvListaCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCursos.Location = new Point(12, 113);
            dgvListaCursos.Name = "dgvListaCursos";
            dgvListaCursos.RowTemplate.Height = 25;
            dgvListaCursos.Size = new Size(760, 176);
            dgvListaCursos.TabIndex = 0;
            dgvListaCursos.CellContentClick += dgvListaCursos_CellContentClick;
            dgvListaCursos.CellFormatting += dgvListaCursos_CellFormatting;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(189, 314);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(130, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cbxCuatrimestre
            // 
            cbxCuatrimestre.FormattingEnabled = true;
            cbxCuatrimestre.Location = new Point(39, 37);
            cbxCuatrimestre.Name = "cbxCuatrimestre";
            cbxCuatrimestre.Size = new Size(121, 23);
            cbxCuatrimestre.TabIndex = 2;
            cbxCuatrimestre.SelectedIndexChanged += cbxCuatrimestre_SelectedIndexChanged;
            // 
            // cbxMaterias
            // 
            cbxMaterias.FormattingEnabled = true;
            cbxMaterias.Location = new Point(189, 37);
            cbxMaterias.Name = "cbxMaterias";
            cbxMaterias.Size = new Size(121, 23);
            cbxMaterias.TabIndex = 3;
            cbxMaterias.SelectedIndexChanged += cbxMaterias_SelectedIndexChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(353, 42);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Logica_Sysacad.Curso);
            // 
            // FrmInscripcionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(btnFiltrar);
            Controls.Add(cbxMaterias);
            Controls.Add(cbxCuatrimestre);
            Controls.Add(btnConfirmar);
            Controls.Add(dgvListaCursos);
            Name = "FrmInscripcionCursos";
            Text = "FrmInscripcionCursos";
            Load += FrmInscripcionCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaCursos;
        private Button btnConfirmar;
        private ComboBox cbxCuatrimestre;
        private ComboBox cbxMaterias;
        private Button btnFiltrar;
        private BindingSource cursoBindingSource;
    }
}