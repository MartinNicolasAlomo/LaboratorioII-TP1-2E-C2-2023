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
            dgvListaCursos = new DataGridView();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCursos
            // 
            dgvListaCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCursos.Location = new Point(107, 51);
            dgvListaCursos.Name = "dgvListaCursos";
            dgvListaCursos.RowTemplate.Height = 25;
            dgvListaCursos.Size = new Size(593, 250);
            dgvListaCursos.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(125, 362);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(130, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // FrmInscripcionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnConfirmar);
            Controls.Add(dgvListaCursos);
            Name = "FrmInscripcionCursos";
            Text = "FrmInscripcionCursos";
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaCursos;
        private Button btnConfirmar;
    }
}