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
        private bool esUnRNCValido(string pRNC)

        {

            int vnTotal = 0;

            int[] digitoMult = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };

            string vcRNC = pRNC.Replace("-", "").Replace(" ", "");

            string vDigito = vcRNC.Substring(8, 1);

            if (vcRNC.Length.Equals(9))

                if (!"145".Contains(vcRNC.Substring(0, 1)))

                    return false;

            for (int vDig = 1; vDig <= 8; vDig++)

            {

                int vCalculo = Int32.Parse(vcRNC.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                vnTotal += vCalculo;

            }

            if (vnTotal % 11 == 0 && vDigito == "1" || vnTotal % 11 == 1 && vDigito == "1" ||

                (11 - (vnTotal % 11)).Equals(vDigito))

                return true;

            else

                return false;

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
                        RNC = txtRNC.Text,
                        Fecha_Registro = dtFecha.Value,
                        Activo = ChkAct.Checked
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
