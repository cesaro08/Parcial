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
    public partial class FrmEdMARCAS : Form
    {
        public MARCAS Marca { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmEdMARCAS()
        {
            InitializeComponent();
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           MARCAS Marca = entities.MARCAS.Find(Int32.Parse(TxtIDMar.Text));
            if ( Marca != null)
            {
                Marca.Descripcion_Marca = TxtDesMar.Text;
                Marca.Activo = ChMar.Checked;
            }

            else
            {
                entities.MARCAS.Add(new MARCAS
                {
                    Descripcion_Marca = TxtDesMar.Text,
                    Activo = ChMar.Checked
                }
                );

            }

            entities.SaveChanges();
            MessageBox.Show("Datos guardados con éxito");
            FrmMARCAS frm = new FrmMARCAS();
           
            this.Close();
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de querer eliminar?", "Alerta", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            MARCAS Marca = entities.MARCAS.Find(Int32.Parse(TxtIDMar.Text));
            if (Marca != null)
            {
                entities.MARCAS.Remove(Marca);
                entities.SaveChanges();
                MessageBox.Show("Marca eliminada correctamente");
            }
            else
            {
                MessageBox.Show("Marca no encontrada");
                
            }
            this.Close();
        }

        private void FrmEdMARCAS_Load(object sender, EventArgs e)
        {
            if (Marca != null)
            {
                TxtIDMar.Text = Marca.Id_Marca.ToString();
                TxtDesMar.Text = Marca.Descripcion_Marca;
                ChMar.Checked = Marca.Activo;
            }
        }
    }
    
}
