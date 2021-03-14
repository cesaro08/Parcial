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
    public partial class FrmEdArticulos : Form
    {

        public FrmEdArticulos()
        {
            InitializeComponent();
        }

        public ARTICULOS art { get; internal set; }
        CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        private void Guardar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    ARTICULOS art = entities.ARTICULOS.Find(Int32.Parse(txtID.Text));
                if (Int32.Parse(txtCantidad.Text) >= 0 && decimal.Parse(txtCosto.Text) > 0)
                {
                    if (art != null)
                    {
                        art.Descripcion = txtDescripcion.Text;
                        art.Id_Marca = Convert.ToInt32(cbMarca.SelectedValue);
                        art.Costo = decimal.Parse(txtCosto.Text);
                        art.Id_Proveedor = Convert.ToInt32(cbProveedor.SelectedValue);
                        art.Existencia = Int32.Parse(txtCantidad.Text);
                        art.Activo = chkAct.Checked;
                    }
                    else
                    {
                        entities.ARTICULOS.Add(new ARTICULOS
                        {
                            Descripcion = txtDescripcion.Text,
                            Id_Marca = Convert.ToInt32(cbMarca.SelectedValue),
                            Costo = decimal.Parse(txtCosto.Text),
                            Id_Proveedor = Convert.ToInt32(cbProveedor.SelectedValue),
                            Existencia = Int32.Parse(txtCantidad.Text),
                            Activo = chkAct.Checked
                        });
                    }
                    entities.SaveChanges();
                    MessageBox.Show("Guardado exitoso");
                    this.Close();
                }
                else MessageBox.Show("No se aceptan valores negativos ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            
            
        }

        private void FrmEdArticulos_Load(object sender, EventArgs e)
        {
            
            cargarDatos();
            if(art != null)
            {
                txtID.Text = art.Id_Articulo.ToString();
                txtDescripcion.Text = art.Descripcion.ToString();
                cbMarca.SelectedValue = art.Id_Marca;
                txtCosto.Text = art.Costo.ToString();
                cbProveedor.SelectedValue = art.Id_Proveedor;
                txtCantidad.Text = art.Existencia.ToString();
                chkAct.Checked = art.Activo;
            }
        }
        private void cargarDatos()
        {
            var lista = entities.MARCAS.ToList();
            if (lista.Count > 0)
            {
                cbMarca.DataSource = lista.ToList();
                cbMarca.DisplayMember = "Descripcion_Marca";
                cbMarca.ValueMember = "Id_Marca";

            }

            var lista2 = entities.PROVEEDORES.ToList();
            if (lista2.Count > 0)
            {
                cbProveedor.DataSource = lista2.ToList();
                cbProveedor.DisplayMember = "Nombre_Comercial";
                cbProveedor.ValueMember = "Id_Proveedor";
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de querer eliminar?", "Alerta", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ARTICULOS art = entities.ARTICULOS.Find(Int32.Parse(txtID.Text));
            if(art != null)
            {
                entities.ARTICULOS.Remove(art);
                MessageBox.Show("Eliminado con exito");
            }
            else { MessageBox.Show("Articulo no existente"); }
            entities.SaveChanges();
            this.Close();
            
        }

        private void FrmEdArticulos_Deactivate(object sender, EventArgs e)
        {
            
        }
    }
}
