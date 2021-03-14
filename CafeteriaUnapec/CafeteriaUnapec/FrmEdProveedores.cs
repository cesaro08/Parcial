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
    public partial class FrmEdProveedores : Form
    {
        public PROVEEDORES prov { get; set; }
        CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmEdProveedores()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            PROVEEDORES pro = entities.PROVEEDORES.Find(Int32.Parse(TxtID.Text));
            if (pro != null)
            {
                pro.Nombre_Comercial = TxtNombre.Text;
                pro.RNC = txtRNC.Text;
                pro.Activo = ChkAct.Checked;
                pro.Fecha_Registro = dtFecha.Value;
            }
            else
            {
                entities.PROVEEDORES.Add(new PROVEEDORES
                {
                    Nombre_Comercial = TxtNombre.Text,
                    RNC= txtRNC.Text,
                    Fecha_Registro= dtFecha.Value,
                    Activo= ChkAct.Checked
                });

            }
            entities.SaveChanges();
            MessageBox.Show("Guardado con exito");
            this.Close();
        }

        private void FrmEdProveedores_Load(object sender, EventArgs e)
        {
            if (prov != null)
            {
                TxtID.Text = prov.Id_Proveedor.ToString();
                TxtNombre.Text = prov.Nombre_Comercial.ToString();
                txtRNC.Text = prov.RNC.ToString();
                dtFecha.Value = prov.Fecha_Registro;
                ChkAct.Checked = prov.Activo;
            }
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de querer eliminar?", "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            PROVEEDORES pro = entities.PROVEEDORES.Find(Int32.Parse(TxtID.Text));
            if(pro != null)
            {
                entities.PROVEEDORES.Remove(pro);
                entities.SaveChanges();
                MessageBox.Show("Proveedor eliminado con exito");
            }
            else { MessageBox.Show("Proveedor no encontrado"); }
            this.Close();
        }
    }
}
