namespace Vista_App
{
    partial class FrmMenuEstudiante
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
            panel1 = new Panel();
            btnCerrarSesion = new Button();
            btnRealizarPagos = new Button();
            btnConsultarHorario = new Button();
            btnInscripcionCursos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnRealizarPagos);
            panel1.Controls.Add(btnConsultarHorario);
            panel1.Controls.Add(btnInscripcionCursos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 361);
            panel1.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(169, 325);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(75, 23);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnRealizarPagos
            // 
            btnRealizarPagos.Location = new Point(144, 180);
            btnRealizarPagos.Name = "btnRealizarPagos";
            btnRealizarPagos.Size = new Size(157, 23);
            btnRealizarPagos.TabIndex = 2;
            btnRealizarPagos.Text = "Realizar Pagos";
            btnRealizarPagos.UseVisualStyleBackColor = true;
            // 
            // btnConsultarHorario
            // 
            btnConsultarHorario.Location = new Point(140, 118);
            btnConsultarHorario.Name = "btnConsultarHorario";
            btnConsultarHorario.Size = new Size(161, 23);
            btnConsultarHorario.TabIndex = 1;
            btnConsultarHorario.Text = "Consultar Horario";
            btnConsultarHorario.UseVisualStyleBackColor = true;
            btnConsultarHorario.Click += btnConsultarHorario_Click;
            // 
            // btnInscripcionCursos
            // 
            btnInscripcionCursos.Location = new Point(137, 62);
            btnInscripcionCursos.Name = "btnInscripcionCursos";
            btnInscripcionCursos.Size = new Size(164, 23);
            btnInscripcionCursos.TabIndex = 0;
            btnInscripcionCursos.Text = "Inscripcion de Cursos";
            btnInscripcionCursos.UseVisualStyleBackColor = true;
            btnInscripcionCursos.Click += btnInscripcionCursos_Click;
            // 
            // FrmMenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(panel1);
            Name = "FrmMenuEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuEstudiante";
            FormClosing += FrmMenuEstudiante_FormClosing;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRealizarPagos;
        private Button btnConsultarHorario;
        private Button btnInscripcionCursos;
        private Button btnCerrarSesion;
    }
}