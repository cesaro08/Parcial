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
    public partial class FrmFactura : Form
    {
        Facturacion_Articulos factura = new Facturacion_Articulos();
        CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            consulta();
            DGVFactura.Columns[0].HeaderText = "Numero de Factura";
            DGVFactura.Columns[3].HeaderText = "Fecha de Venta";
            DGVFactura.Columns[4].HeaderText = "Monto";
            DGVFactura.Columns[5].HeaderText = "Unidades";
            DGVFactura.Columns[8].HeaderText = "Usuario";
        }
        private void consulta()
        {
            var consulta = from fact in entities.Facturacion_Articulos
                           join empl in entities.EMPLEADOS on fact.Id_Empleado equals empl.Id_Empleado
                           join art in entities.ARTICULOS on fact.Id_Articulo equals art.Id_Articulo
                           join user in entities.USUARIOS on fact.Id_User equals user.Id_User

                           select new
                           {
                               fact.No_Factura,
                               empl.Nombre,
                               art.Descripcion,
                               fact.Fecha_Venta,
                               fact.Monto_Articulo,
                               fact.Unidades_Vendidas,
                               fact.Comentario,
                               fact.Activo,
                               user.Nombre_Usuario
                           };
            DGVFactura.DataSource = consulta.ToList();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            consultarCriterio();
        }
        private void consultarCriterio()
        {
            var consulta = from fact in entities.Facturacion_Articulos
                           join empl in entities.EMPLEADOS on fact.Id_Empleado equals empl.Id_Empleado
                           join art in entities.ARTICULOS on fact.Id_Articulo equals art.Id_Articulo
                           join user in entities.USUARIOS on fact.Id_User equals user.Id_User

                           where (fact.No_Factura.ToString().StartsWith(txtBuscar.Text) ||
                           fact.Fecha_Venta.ToString().StartsWith(txtBuscar.Text) ||
                           fact.Comentario.ToString().StartsWith(txtBuscar.Text) ||
                           fact.Monto_Articulo.ToString().StartsWith(txtBuscar.Text) ||
                           fact.Unidades_Vendidas.ToString().StartsWith(txtBuscar.Text) ||
                           empl.Nombre.ToString().StartsWith(txtBuscar.Text) ||
                           art.Descripcion.ToString().StartsWith(txtBuscar.Text) ||
                           user.Nombre_Usuario.ToString().StartsWith(txtBuscar.Text)

                           )
                           select new
                           {
                               fact.No_Factura,
                               empl.Nombre,
                               art.Descripcion,
                               fact.Fecha_Venta,
                               fact.Monto_Articulo,
                               fact.Unidades_Vendidas,
                               fact.Comentario,
                               fact.Activo,
                               user.Nombre_Usuario
                           };
            DGVFactura.DataSource = consulta.ToList();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            FrmEdFactura frm = new FrmEdFactura();
            frm.ShowDialog();
        }

        private void DGVFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGVFactura.SelectedRows[0];
            Facturacion_Articulos fact = new Facturacion_Articulos();
            USUARIOS user = new USUARIOS();
            ARTICULOS art = new ARTICULOS();
            EMPLEADOS empl = new EMPLEADOS();

            fact.No_Factura = Convert.ToInt32(row.Cells[0].Value);
            fact.Id_Empleado = empl.Id_Empleado;
            fact.Id_User = user.Id_User;
            fact.Id_Articulo = art.Id_Articulo;
            fact.Fecha_Venta = Convert.ToDateTime(row.Cells[3].Value);
            fact.Monto_Articulo = Convert.ToDecimal(row.Cells[4].Value);
            fact.Unidades_Vendidas = Convert.ToInt32(row.Cells[5].Value);
            fact.Comentario = row.Cells[6].Value.ToString();
            fact.Activo = (Boolean)row.Cells[7].Value;
            FrmEdFactura fef = new FrmEdFactura();
            fef.fact = fact;
            fef.ShowDialog();

        }

        private void FrmFactura_Activated(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
