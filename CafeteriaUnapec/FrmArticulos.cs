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
    public partial class FrmArticulos : Form
    {
        private ARTICULOS Articulo { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void BtnBuCafe_Click(object sender, EventArgs e)
        {
            consultarCriterio();
        }

        private void consultarCriterio()
        {
            var consulta = from art in entities.ARTICULOS
                           join mar in entities.MARCAS on art.Id_Marca equals mar.Id_Marca
                           join prov in entities.PROVEEDORES on art.Id_Proveedor equals prov.Id_Proveedor
                           where (art.Id_Articulo.ToString().StartsWith(TxtBusq.Text) ||
                           art.Descripcion.ToString().StartsWith(TxtBusq.Text) ||
                           mar.Descripcion_Marca.ToString().StartsWith(TxtBusq.Text) ||
                           art.Costo.ToString().StartsWith(TxtBusq.Text) ||
                           prov.Nombre_Comercial.ToString().StartsWith(TxtBusq.Text) ||
                           art.Existencia.ToString().StartsWith(TxtBusq.Text) ||
                           art.Activo.ToString().StartsWith(TxtBusq.Text))
                           select new
                           {
                               art.Id_Articulo,
                               art.Descripcion,
                               mar.Descripcion_Marca,
                               art.Costo,
                               prov.Nombre_Comercial,
                               art.Existencia,
                               art.Activo
                           };


            DGVArticulos.Columns[4].HeaderText = "Proveedor";
            DGVArticulos.DataSource = consulta.ToList();
           

        }
        private void consulta()
        {
            var consulta = from art in entities.ARTICULOS
                           join mar in entities.MARCAS on art.Id_Marca equals mar.Id_Marca
                           join prov in entities.PROVEEDORES on art.Id_Proveedor equals prov.Id_Proveedor
                           select new
                           {
                               art.Id_Articulo,
                               art.Descripcion,
                               mar.Descripcion_Marca,
                               art.Costo,
                               prov.Nombre_Comercial,
                               art.Existencia,
                               art.Activo
                           };
            DGVArticulos.DataSource = consulta.ToList();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            consulta();
            DGVArticulos.Columns[2].HeaderText = "Marca";
            DGVArticulos.Columns[4].HeaderText = "Proveedor";
        }

        private void BtnAgCafe_Click(object sender, EventArgs e)
        {
            FrmEdArticulos frm = new FrmEdArticulos();
            frm.ShowDialog();
        }

        private void DGVArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGVArticulos.SelectedRows[0];
            ARTICULOS art = new ARTICULOS();
            PROVEEDORES prov = new PROVEEDORES();
            MARCAS mar = new MARCAS();
            art.Id_Articulo = Convert.ToInt32(row.Cells[0].Value);
            art.Descripcion = row.Cells[1].Value.ToString();
            art.Id_Marca = mar.Id_Marca;
            art.Costo = Convert.ToDecimal(row.Cells[3].Value);
            art.Id_Proveedor = prov.Id_Proveedor;
            art.Existencia = Convert.ToInt32(row.Cells[5].Value);
            art.Activo = (Boolean)row.Cells[6].Value;

            FrmEdArticulos fea = new FrmEdArticulos();
            fea.art = art;
            fea.ShowDialog();
        }
    }
}
