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

                           //where ()
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
    }
}
