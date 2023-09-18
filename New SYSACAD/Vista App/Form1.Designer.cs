namespace Vista_App
{
    partial class frmIniciarSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            tbxContrasenia = new TextBox();
            tbxUsuario = new TextBox();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(90, 225);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(150, 40);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // tbxContrasenia
            // 
            tbxContrasenia.Location = new Point(91, 144);
            tbxContrasenia.Name = "tbxContrasenia";
            tbxContrasenia.Size = new Size(152, 23);
            tbxContrasenia.TabIndex = 1;
            // 
            // tbxUsuario
            // 
            tbxUsuario.Location = new Point(91, 68);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(153, 23);
            tbxUsuario.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(92, 50);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(91, 126);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(67, 15);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña";
            // 
            // frmIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 341);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(tbxUsuario);
            Controls.Add(tbxContrasenia);
            Controls.Add(btnIniciarSesion);
            Name = "frmIniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private TextBox tbxContrasenia;
        private TextBox tbxUsuario;
        private Label lblUsuario;
        private Label lblContrasenia;
    }
}