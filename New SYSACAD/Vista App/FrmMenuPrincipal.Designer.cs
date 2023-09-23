namespace Vista_App
{
    partial class FrmMenuPrincipal
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
            pnlAdministrador = new Panel();
            btnCerrarSesion = new Button();
            btnGestionarCursos = new Button();
            btnRegistrarEstudiante = new Button();
            lblBienvenida = new Label();
            pnlAdministrador.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdministrador
            // 
            pnlAdministrador.Controls.Add(btnCerrarSesion);
            pnlAdministrador.Controls.Add(btnGestionarCursos);
            pnlAdministrador.Controls.Add(btnRegistrarEstudiante);
            pnlAdministrador.Controls.Add(lblBienvenida);
            pnlAdministrador.Dock = DockStyle.Fill;
            pnlAdministrador.Location = new Point(0, 0);
            pnlAdministrador.Name = "pnlAdministrador";
            pnlAdministrador.Size = new Size(484, 361);
            pnlAdministrador.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(190, 320);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(120, 30);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnGestionarCursos
            // 
            btnGestionarCursos.Location = new Point(145, 85);
            btnGestionarCursos.Name = "btnGestionarCursos";
            btnGestionarCursos.Size = new Size(210, 44);
            btnGestionarCursos.TabIndex = 2;
            btnGestionarCursos.Text = "Gestionar Cursos";
            btnGestionarCursos.UseVisualStyleBackColor = true;
            btnGestionarCursos.Click += btnGestionarCursos_Click;
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.Location = new Point(145, 39);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(210, 40);
            btnRegistrarEstudiante.TabIndex = 1;
            btnRegistrarEstudiante.Text = "Registrar Estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            btnRegistrarEstudiante.Click += btnRegistrarEstudiante_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(98, 21);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(0, 15);
            lblBienvenida.TabIndex = 0;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(pnlAdministrador);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FrmMenuPrincipal_FormClosing;
            pnlAdministrador.ResumeLayout(false);
            pnlAdministrador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdministrador;
        private Button btnCerrarSesion;
        private Button btnGestionarCursos;
        private Button btnRegistrarEstudiante;
        private Label lblBienvenida;
    }
}