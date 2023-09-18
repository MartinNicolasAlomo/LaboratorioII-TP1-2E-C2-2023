namespace Vista_App
{
    partial class FrmDatosEstudiante
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
            tbxNombres = new TextBox();
            tbxApellidos = new TextBox();
            tbxDNI = new TextBox();
            tbxDireccion = new TextBox();
            tbxTelefono = new TextBox();
            tbxCorreoElectronico = new TextBox();
            tbxContraseniaProvisional = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // tbxNombres
            // 
            tbxNombres.Location = new Point(80, 26);
            tbxNombres.Name = "tbxNombres";
            tbxNombres.Size = new Size(100, 23);
            tbxNombres.TabIndex = 0;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(80, 55);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.Size = new Size(100, 23);
            tbxApellidos.TabIndex = 1;
            // 
            // tbxDNI
            // 
            tbxDNI.Location = new Point(80, 84);
            tbxDNI.Name = "tbxDNI";
            tbxDNI.Size = new Size(100, 23);
            tbxDNI.TabIndex = 2;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(80, 113);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(100, 23);
            tbxDireccion.TabIndex = 3;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(80, 142);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(100, 23);
            tbxTelefono.TabIndex = 4;
            // 
            // tbxCorreoElectronico
            // 
            tbxCorreoElectronico.Location = new Point(80, 171);
            tbxCorreoElectronico.Name = "tbxCorreoElectronico";
            tbxCorreoElectronico.Size = new Size(100, 23);
            tbxCorreoElectronico.TabIndex = 5;
            // 
            // tbxContraseniaProvisional
            // 
            tbxContraseniaProvisional.Location = new Point(80, 200);
            tbxContraseniaProvisional.Name = "tbxContraseniaProvisional";
            tbxContraseniaProvisional.Size = new Size(100, 23);
            tbxContraseniaProvisional.TabIndex = 6;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(44, 312);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(212, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmDatosEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 361);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(tbxContraseniaProvisional);
            Controls.Add(tbxCorreoElectronico);
            Controls.Add(tbxTelefono);
            Controls.Add(tbxDireccion);
            Controls.Add(tbxDNI);
            Controls.Add(tbxApellidos);
            Controls.Add(tbxNombres);
            Name = "FrmDatosEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDatosEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNombres;
        private TextBox tbxApellidos;
        private TextBox tbxDNI;
        private TextBox tbxDireccion;
        private TextBox tbxTelefono;
        private TextBox tbxCorreoElectronico;
        private TextBox tbxContraseniaProvisional;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}