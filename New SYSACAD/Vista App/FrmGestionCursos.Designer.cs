namespace Vista_App
{
    partial class FrmGestionCursos
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
            dgvListaCursos = new DataGridView();
            btnAgregarCurso = new Button();
            btnEditarCurso = new Button();
            btnEliminarCurso = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCursos
            // 
            dgvListaCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCursos.Location = new Point(52, 34);
            dgvListaCursos.Name = "dgvListaCursos";
            dgvListaCursos.Size = new Size(676, 232);
            dgvListaCursos.TabIndex = 0;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Location = new Point(77, 290);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(170, 35);
            btnAgregarCurso.TabIndex = 1;
            btnAgregarCurso.Text = "Agregar Nuevo Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // btnEditarCurso
            // 
            btnEditarCurso.Location = new Point(386, 290);
            btnEditarCurso.Name = "btnEditarCurso";
            btnEditarCurso.Size = new Size(140, 35);
            btnEditarCurso.TabIndex = 2;
            btnEditarCurso.Text = "Editar Curso";
            btnEditarCurso.UseVisualStyleBackColor = true;
            btnEditarCurso.Click += btnEditarCurso_Click;
            // 
            // btnEliminarCurso
            // 
            btnEliminarCurso.Location = new Point(558, 290);
            btnEliminarCurso.Name = "btnEliminarCurso";
            btnEliminarCurso.Size = new Size(140, 35);
            btnEliminarCurso.TabIndex = 3;
            btnEliminarCurso.Text = "Eliminar Curso";
            btnEliminarCurso.UseVisualStyleBackColor = true;
            btnEliminarCurso.Click += btnEliminarCurso_Click;
            // 
            // FrmGestionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 341);
            Controls.Add(btnEliminarCurso);
            Controls.Add(btnEditarCurso);
            Controls.Add(btnAgregarCurso);
            Controls.Add(dgvListaCursos);
            Name = "FrmGestionCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Cursos";
            FormClosing += FrmGestionCursos_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaCursos;
        private Button btnAgregarCurso;
        private Button btnEditarCurso;
        private Button btnEliminarCurso;
    }
}