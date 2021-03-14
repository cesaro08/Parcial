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
    public partial class FrmMARCAS : Form
    {
        private MARCAS Marcas { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmMARCAS()
        {
            InitializeComponent();
            int tipo;
            tipo = Sesion.idTipo;

            if (tipo != 2)
            {
                BtnAñadir.Enabled = false;
                DGVMarcas.Enabled = false;
            }
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            consultarCriterio();
        }

        private void consultarCriterio()
        {

            var query = from marca in entities.MARCAS
                        where (
                         marca.Id_Marca.ToString().StartsWith(TxtBusq.Text) ||
                         marca.Descripcion_Marca.ToString().StartsWith(TxtBusq.Text) ||
                         marca.Activo.ToString().StartsWith(TxtBusq.Text)
                         )
                        select new
                        {
                            marca.Id_Marca,
                            marca.Descripcion_Marca, 
                            marca.Activo
                        };

            DGVMarcas.DataSource = query.ToList();
           
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            FrmEdMARCAS Frm = new FrmEdMARCAS();
            Frm.ShowDialog();
        }

        private void DGVMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DGVMarcas.SelectedRows[0];
                MARCAS Marc = new MARCAS();

                Marc.Id_Marca = Int32.Parse(row.Cells[0].Value.ToString());
                Marc.Descripcion_Marca = row.Cells[1].Value.ToString();
                Marc.Activo = (Boolean)row.Cells[2].Value;

                FrmEdMARCAS femar = new FrmEdMARCAS();
                femar.Marca = Marc;
                femar.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void FrmMARCAS_Load(object sender, EventArgs e)
        {
           
            consulta();
            DGVMarcas.Columns[0].HeaderText = "ID";
            DGVMarcas.Columns[1].HeaderText = "Descripcion";

        }
        private void consulta()
        {
            var query = from marca in entities.MARCAS
                        select new
                        {
                            marca.Id_Marca,
                            marca.Descripcion_Marca,
                            marca.Activo
                        };
            DGVMarcas.DataSource = query.ToList();
        }
    }
}
