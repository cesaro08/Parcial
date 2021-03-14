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
    public partial class FrmEdFactura : Form
    {
        public Facturacion_Articulos fact { get; set; }
        CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmEdFactura()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void carga ()
        {
            var empleado = entities.EMPLEADOS.ToList();
            if (empleado.Count > 0)
            {
                cbEmpleado.DataSource = empleado.ToList();
                cbEmpleado.DisplayMember = "Nombre";
                cbEmpleado.ValueMember = "Id_Empleado";
            }

            var usuario = entities.USUARIOS.ToList();
            if (usuario.Count > 0)
            {
                cbUsuario.DataSource = usuario.ToList();
                cbUsuario.DisplayMember = "Nombre_Usuario";
                cbUsuario.ValueMember = "Id_User";
            }
            
            var art = entities.ARTICULOS.ToList();
            if (art.Count > 0)
            {
                cbArticulo.DataSource = art.ToList();
                cbArticulo.DisplayMember = "Descripcion";
                cbArticulo.ValueMember = "Id_Articulo";
            }

        }
        

        private void Guardar_Click(object sender, EventArgs e)
        {
            Facturacion_Articulos fact = entities.Facturacion_Articulos.Find(Int32.Parse(txtFactura.Text));
            try
            {
                if (fact != null)
                {
                    fact.Id_Articulo = Convert.ToInt32(cbArticulo.SelectedValue);
                    fact.Id_Empleado = Convert.ToInt32(cbEmpleado.SelectedValue);
                    fact.Fecha_Venta = dtFecha.Value;
                    fact.Monto_Articulo = Convert.ToDecimal(txtMonto.Text);
                    fact.Unidades_Vendidas = Convert.ToInt32(txtUnidades.Text);
                    fact.Activo = chkAct.Checked;
                    fact.Comentario = txtComentario.Text;
                    fact.Id_User = Convert.ToInt32(cbUsuario.SelectedValue);


                }
                else
                {
                    entities.Facturacion_Articulos.Add(new Facturacion_Articulos
                    {
                        Id_Articulo = Convert.ToInt32(cbArticulo.SelectedValue),
                        Id_Empleado = Convert.ToInt32(cbEmpleado.SelectedValue),
                        Fecha_Venta = dtFecha.Value,
                        Monto_Articulo = Convert.ToInt32(txtMonto.Text),
                        Unidades_Vendidas = Convert.ToInt32(txtUnidades.Text),
                        Activo = chkAct.Checked,
                        Comentario = txtComentario.Text,
                        Id_User = Convert.ToInt32(cbUsuario.SelectedValue)
                    });
                }
                entities.SaveChanges();
                MessageBox.Show("Guardado con exito");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ ex);
            }
            this.Close();
        }

        private void FrmEdFactura_Load(object sender, EventArgs e)
        {
            carga();
            //cargar2();
            if(fact != null)
            {
                txtFactura.Text = fact.No_Factura.ToString();
                txtComentario.Text = fact.Comentario.ToString();
                txtMonto.Text = fact.Monto_Articulo.ToString();
                txtUnidades.Text = fact.Unidades_Vendidas.ToString();
                chkAct.Checked = fact.Activo;
                cbArticulo.SelectedValue = fact.Id_Articulo;
                cbEmpleado.SelectedValue = fact.Id_Empleado;
                cbUsuario.SelectedValue = fact.Id_User;


            }

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Facturacion_Articulos fact = entities.Facturacion_Articulos.Find(Int32.Parse(txtFactura.Text));
            if (MessageBox.Show("Está seguro de querer eliminar?", "Alerta", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (fact != null)
            {
                entities.Facturacion_Articulos.Remove(fact);
                MessageBox.Show("Eliminado con exito");
            }
            else { MessageBox.Show("Factura no existente"); }
            entities.SaveChanges();
            this.Close();
        }
        
    }
    
}
