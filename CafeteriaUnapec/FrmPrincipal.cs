﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaUnapec
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        private void AbrirForm(object formH)
        {

            if (this.PnlSubF.Controls.Count > 0)
            
                this.PnlSubF.Controls.RemoveAt(0);
                Form fh = formH as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PnlSubF.Controls.Add(fh);
                this.PnlSubF.Tag = fh;
                fh.Show();

        }

        private void BtnCafeteria_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmCAFETERIA());
        }

        private void BtnUni_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmCam());
        }

        private void PnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmArticulos());
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmMARCAS());
        }

        private void BtnTipoUser_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmTipoUsuario());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmUsuario());
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmEmpleados());
        }

        private void BtnProvee_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmProveedores());
        }

        private void BtnFact_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFactura());
        }

        private void PnlSubF_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
