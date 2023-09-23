﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_App
{
    public partial class FrmMensajeConfirmacion : Form
    {
        public FrmMensajeConfirmacion(string pregunta)
        {
            InitializeComponent();
            lblPregunta.Text = pregunta;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //private void FrmMensajeConfirmacion_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult = DialogResult.Cancel;
        //}
    }
}
