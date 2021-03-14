using System;
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
    public partial class FrmEdCam : Form
    {
        public CAMPUS Campus { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmEdCam()
        {
            InitializeComponent();
        }

        private void FrmEdCam_Load(object sender, EventArgs e)
        {
            if(Campus!=null)
            {
                TxtIDCam.Text = Campus.Id_Campus.ToString();
                TxtDesCamp.Text = Campus.Descripcion.ToString();
                CBCam.Checked = Campus.Activo;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            CAMPUS Campus = entities.CAMPUS.Find(Int32.Parse(TxtIDCam.Text));
            if(Campus!=null)
            {
                Campus.Descripcion = TxtDesCamp.Text;
                Campus.Activo = CBCam.Checked;
            }

            else
            {
                entities.CAMPUS.Add(new CAMPUS
                {
                    Descripcion = TxtDesCamp.Text,
                    Activo = CBCam.Checked
                }
                );



            }

            entities.SaveChanges();
            MessageBox.Show("Datos guardados con éxito");

            
            this.Close();

        }

        private void BtnEliminarCam_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de querer eliminar?", "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            CAMPUS Campus = entities.CAMPUS.Find(Int32.Parse(TxtIDCam.Text));
            if(Campus!=null)
            {
                entities.CAMPUS.Remove(Campus);
                entities.SaveChanges();
                MessageBox.Show("Campus eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Campus no encontrado");
                this.Close();
            }

        }

        private void FrmEdCam_FormClosed(object sender, FormClosedEventArgs e)
        {
            

           
            
        }
    }
}
