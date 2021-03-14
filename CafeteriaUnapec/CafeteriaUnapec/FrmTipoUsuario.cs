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
    public partial class FrmTipoUsuario : Form
    {
        private Tipo_usuarios TUsuario { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ConsultarporCriterio();
        }
        private void Consultar()
        {
            var TUsuarios = from TU in entities.Tipo_usuarios
                            select new { TU.Id_TipoUser, TU.Descripcion, TU.Activo };
            DGVTUsuarios.DataSource = TUsuarios.ToList();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void ConsultarporCriterio()
        {
            var TUsuarios = from TU in entities.Tipo_usuarios
                            where (TU.Id_TipoUser.ToString().StartsWith(txtBuscar.Text) ||
                            TU.Descripcion.ToString().StartsWith(txtBuscar.Text) ||
                            TU.Activo.ToString().StartsWith(txtBuscar.Text)
                            )
                            select new { TU.Id_TipoUser,TU.Descripcion,TU.Activo };
            DGVTUsuarios.DataSource = TUsuarios.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmEdTipoUsuario frm = new FrmEdTipoUsuario();
            frm.Show();
        }

        private void DGVTUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DGVTUsuarios.SelectedRows[0];
                Tipo_usuarios tipo_Usuarios = new Tipo_usuarios();
                tipo_Usuarios.Id_TipoUser = Int32.Parse(row.Cells[0].Value.ToString());
                tipo_Usuarios.Descripcion = row.Cells[1].Value.ToString();
                tipo_Usuarios.Activo = (Boolean)row.Cells[2].Value;

                FrmEdTipoUsuario fet = new FrmEdTipoUsuario();
                fet.TUsuarios = tipo_Usuarios;
                fet.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex);
            }
        }

        private void FrmTipoUsuario_Activated(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
