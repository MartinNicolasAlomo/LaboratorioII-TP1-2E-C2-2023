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
            tbxEmail = new TextBox();
            tbxClave = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lblNombres = new Label();
            lblApellidos = new Label();
            lblDNI = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            label6 = new Label();
            lblClave = new Label();
            label1 = new Label();
            lblFechaNacimiento = new Label();
            tbxDia = new TextBox();
            tbxMes = new TextBox();
            tbxAnio = new TextBox();
            SuspendLayout();
            // 
            // tbxNombres
            // 
            tbxNombres.Location = new Point(80, 26);
            tbxNombres.Name = "tbxNombres";
            tbxNombres.PlaceholderText = "Ingrese los nombres";
            tbxNombres.Size = new Size(240, 23);
            tbxNombres.TabIndex = 0;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(80, 55);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.PlaceholderText = "Ingrese los apellidos";
            tbxApellidos.Size = new Size(240, 23);
            tbxApellidos.TabIndex = 1;
            // 
            // tbxDNI
            // 
            tbxDNI.Location = new Point(80, 84);
            tbxDNI.Name = "tbxDNI";
            tbxDNI.PlaceholderText = "Ingrese el DNI (solo números)";
            tbxDNI.Size = new Size(240, 23);
            tbxDNI.TabIndex = 2;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(80, 142);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.PlaceholderText = "Ingrese la dirección";
            tbxDireccion.Size = new Size(240, 23);
            tbxDireccion.TabIndex = 3;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(80, 171);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.PlaceholderText = "Ingrese el teléfono (solo números)";
            tbxTelefono.Size = new Size(240, 23);
            tbxTelefono.TabIndex = 4;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(80, 200);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Ingrese el Email";
            tbxEmail.Size = new Size(240, 23);
            tbxEmail.TabIndex = 5;
            // 
            // tbxClave
            // 
            tbxClave.Location = new Point(80, 229);
            tbxClave.Name = "tbxClave";
            tbxClave.PlaceholderText = "Ingrese la clave";
            tbxClave.Size = new Size(240, 23);
            tbxClave.TabIndex = 6;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(12, 321);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(150, 40);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(242, 321);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(9, 29);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(59, 15);
            lblNombres.TabIndex = 9;
            lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(11, 58);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(59, 15);
            lblApellidos.TabIndex = 10;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(9, 87);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(39, 15);
            lblDNI.TabIndex = 11;
            lblDNI.Text = "D.N.I.:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(7, 145);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(7, 174);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 203);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 14;
            label6.Text = "Email:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(7, 232);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(55, 15);
            lblClave.TabIndex = 15;
            lblClave.Text = "Clave (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 255);
            label1.Name = "label1";
            label1.Size = new Size(137, 13);
            label1.TabIndex = 16;
            label1.Text = "(*) La clave es provisional.";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(7, 116);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(106, 15);
            lblFechaNacimiento.TabIndex = 17;
            lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // tbxDia
            // 
            tbxDia.Location = new Point(80, 113);
            tbxDia.Name = "tbxDia";
            tbxDia.PlaceholderText = "Día";
            tbxDia.Size = new Size(40, 23);
            tbxDia.TabIndex = 18;
            // 
            // tbxMes
            // 
            tbxMes.Location = new Point(126, 113);
            tbxMes.Name = "tbxMes";
            tbxMes.PlaceholderText = "Mes";
            tbxMes.Size = new Size(40, 23);
            tbxMes.TabIndex = 19;
            // 
            // tbxAnio
            // 
            tbxAnio.Location = new Point(172, 113);
            tbxAnio.Name = "tbxAnio";
            tbxAnio.PlaceholderText = "Año";
            tbxAnio.Size = new Size(40, 23);
            tbxAnio.TabIndex = 20;
            // 
            // FrmDatosEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 373);
            Controls.Add(tbxAnio);
            Controls.Add(tbxMes);
            Controls.Add(tbxDia);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(label1);
            Controls.Add(lblClave);
            Controls.Add(label6);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblDNI);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombres);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(tbxClave);
            Controls.Add(tbxEmail);
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
        private TextBox tbxEmail;
        private TextBox tbxClave;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lblNombres;
        private Label lblApellidos;
        private Label lblDNI;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label label6;
        private Label lblClave;
        private Label label1;
        private Label lblFechaNacimiento;
        private TextBox tbxDia;
        private TextBox tbxMes;
        private TextBox tbxAnio;
    }
}