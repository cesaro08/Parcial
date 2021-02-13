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
    public partial class FrmCam : Form
    {
        private CAMPUS Campus { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();

        public FrmCam()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            consultarCriterio();
        }

      

        private void consultarCampus()
        {
            DGVCampus.DataSource = entities.CAMPUS.ToList();
        }

        private void consultarCriterio()
        {
            var campus = from cam in entities.CAMPUS
                         where (cam.Id_Campus.ToString().StartsWith(TxtBusquedaCam.Text) ||
                         cam.Descripcion.ToString().StartsWith(TxtBusquedaCam.Text) ||
                         cam.Activo.ToString().ToString().StartsWith(TxtBusquedaCam.Text)
                         )
                         select cam;

            DGVCampus.DataSource = campus.ToList();



        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FrmEdCam frm = new FrmEdCam();
            frm.ShowDialog();
        }

        private void FrmCam_Load_1(object sender, EventArgs e)
        {
            consultarCampus();
        }

        private void FrmCam_Activated(object sender, EventArgs e)
        {
            consultarCriterio();
           
        }

        private void DGVCampus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DGVCampus.SelectedRows[0];
                CAMPUS Campus = new CAMPUS();

                Campus.Id_Campus = Int32.Parse(row.Cells[0].Value.ToString());
                Campus.Descripcion = row.Cells[1].Value.ToString();
                Campus.Activo = (Boolean)row.Cells[2].Value;

                FrmEdCam fecam = new FrmEdCam();
                fecam.Campus = Campus;
                fecam.ShowDialog();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
