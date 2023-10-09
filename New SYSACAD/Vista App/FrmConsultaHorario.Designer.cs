namespace Vista_App
{
    partial class FrmConsultaHorario
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
            cursoBindingSource = new BindingSource(components);
            lblHorariosSemanales = new Label();
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
            dgvListaCursos.Location = new Point(12, 36);
            dgvListaCursos.Name = "dgvListaCursos";
            dgvListaCursos.RowTemplate.Height = 25;
            dgvListaCursos.Size = new Size(749, 263);
            dgvListaCursos.TabIndex = 1;
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Logica_Sysacad.Curso);
            // 
            // lblHorariosSemanales
            // 
            lblHorariosSemanales.AutoSize = true;
            lblHorariosSemanales.Location = new Point(12, 18);
            lblHorariosSemanales.Name = "lblHorariosSemanales";
            lblHorariosSemanales.Size = new Size(114, 15);
            lblHorariosSemanales.TabIndex = 2;
            lblHorariosSemanales.Text = "Horarios Semanales:";
            // 
            // FrmConsultaHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 311);
            Controls.Add(lblHorariosSemanales);
            Controls.Add(dgvListaCursos);
            Name = "FrmConsultaHorario";
            //FormClosing += FrmConsultaHorario_FormClosing;
            Load += FrmConsultaHorario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvListaCursos;
        private Label lblHorariosSemanales;
        private BindingSource cursoBindingSource;
    }
}