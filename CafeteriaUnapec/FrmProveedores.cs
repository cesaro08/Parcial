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
    public partial class FrmProveedores : Form
    {
        PROVEEDORES pro = new PROVEEDORES();
        CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmProveedores()
        {
            InitializeComponent();
            int tipo;
            tipo = Sesion.idTipo;

            if (tipo != 2)
            {
                BtnAgregar.Enabled = false;
                DGVProveedores.Enabled = false;
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
           

            consulta();
            DGVProveedores.Columns[0].HeaderText = "ID";
            DGVProveedores.Columns[1].HeaderText = "Nombre Comercial";
            DGVProveedores.Columns[3].HeaderText = "Fecha de Registro";

        }

        private void consulta()
        {
            var consulta = from pro in entities.PROVEEDORES
                           select new { pro.Id_Proveedor, pro.Nombre_Comercial, pro.RNC, pro.Fecha_Registro, pro.Activo };

            DGVProveedores.DataSource = consulta.ToList();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            consultaCriterio();
        }

        private void consultaCriterio()
        {
            var consulta = from pro in entities.PROVEEDORES
                           where (pro.Id_Proveedor.ToString().StartsWith(TxtBuscar.Text) ||
                           pro.Nombre_Comercial.ToString().StartsWith(TxtBuscar.Text) ||
                           pro.RNC.ToString().StartsWith(TxtBuscar.Text) ||
                           pro.Fecha_Registro.ToString().StartsWith(TxtBuscar.Text))
                           select new { pro.Id_Proveedor,pro.Nombre_Comercial,pro.RNC,pro.Fecha_Registro,pro.Activo};

            DGVProveedores.DataSource = consulta.ToList();
                           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdProveedores frm = new FrmEdProveedores();
            frm.ShowDialog();
            
        }

        private void DGVProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGVProveedores.SelectedRows[0];
            PROVEEDORES pro = new PROVEEDORES();
            pro.Id_Proveedor = Convert.ToInt32(row.Cells[0].Value);
            pro.Nombre_Comercial = row.Cells[1].Value.ToString();
            pro.RNC = row.Cells[2].Value.ToString();
            pro.Fecha_Registro = DateTime.Parse(row.Cells[3].Value.ToString());
            pro.Activo = (Boolean)row.Cells[4].Value;

            FrmEdProveedores fep = new FrmEdProveedores();
            fep.prov = pro;
            fep.ShowDialog();
        }

        private void FrmProveedores_Activated(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
