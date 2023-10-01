﻿namespace Vista_App
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
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCursos
            // 
            dgvListaCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCursos.Location = new Point(12, 35);
            dgvListaCursos.Name = "dgvListaCursos";
            dgvListaCursos.Size = new Size(941, 232);
            dgvListaCursos.TabIndex = 0;
            dgvListaCursos.CellClick += dgvListaCursos_CellClick;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Location = new Point(238, 290);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(170, 35);
            btnAgregarCurso.TabIndex = 1;
            btnAgregarCurso.Text = "Agregar Nuevo Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // btnEditarCurso
            // 
            btnEditarCurso.Location = new Point(482, 290);
            btnEditarCurso.Name = "btnEditarCurso";
            btnEditarCurso.Size = new Size(140, 35);
            btnEditarCurso.TabIndex = 2;
            btnEditarCurso.Text = "Editar Curso";
            btnEditarCurso.UseVisualStyleBackColor = true;
            btnEditarCurso.Click += btnEditarCurso_Click;
            // 
            // btnEliminarCurso
            // 
            btnEliminarCurso.Location = new Point(654, 290);
            btnEliminarCurso.Name = "btnEliminarCurso";
            btnEliminarCurso.Size = new Size(140, 35);
            btnEliminarCurso.TabIndex = 3;
            btnEliminarCurso.Text = "Eliminar Curso";
            btnEliminarCurso.UseVisualStyleBackColor = true;
            btnEliminarCurso.Click += btnEliminarCurso_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(38, 295);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(32, 15);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "*****";
            // 
            // FrmGestionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 366);
            Controls.Add(lblInfo);
            Controls.Add(btnEliminarCurso);
            Controls.Add(btnEditarCurso);
            Controls.Add(btnAgregarCurso);
            Controls.Add(dgvListaCursos);
            Name = "FrmGestionCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Cursos";
            FormClosing += FrmGestionCursos_FormClosing;
            Load += FrmGestionCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaCursos;
        private Button btnAgregarCurso;
        private Button btnEditarCurso;
        private Button btnEliminarCurso;
        private Label lblInfo;
    }
}