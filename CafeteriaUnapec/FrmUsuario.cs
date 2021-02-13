using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace CafeteriaUnapec
{
    public partial class FrmUsuario : Form
    {
        private USUARIOS USUARIOS { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                Consultar();
            }
        }

        private void Consultar()
        {
            var consulta = from USUARIOS in entities.USUARIOS
                           join Tipo_usuarios in entities.Tipo_usuarios on USUARIOS.Id_TipoUser equals Tipo_usuarios.Id_TipoUser
                           select new
                           {
                               USUARIOS.Id_User,
                               USUARIOS.Nombre_Usuario,
                               USUARIOS.Cedula,
                               Tipo_usuarios.Descripcion,
                               USUARIOS.Limite_credito,
                               USUARIOS.Fecha_Registro,
                               USUARIOS.Activo
                           };
            DGVUsuarios.DataSource = consulta.ToList();

        }

        private void consultarCriterio()
        {

            var consulta = from USUARIOS in entities.USUARIOS
                           join Tipo_usuarios in entities.Tipo_usuarios on USUARIOS.Id_TipoUser equals Tipo_usuarios.Id_TipoUser
                           where (Tipo_usuarios.Descripcion.ToString().StartsWith(txtBuscar.Text) ||
                           USUARIOS.Id_User.ToString().StartsWith(txtBuscar.Text) ||
                           USUARIOS.Nombre_Usuario.ToString().StartsWith(txtBuscar.Text) ||
                           USUARIOS.Cedula.ToString().StartsWith(txtBuscar.Text) ||
                           USUARIOS.Fecha_Registro.ToString().StartsWith(txtBuscar.Text)
                           )
                           select new
                           {
                               USUARIOS.Id_User,
                               USUARIOS.Nombre_Usuario,
                               USUARIOS.Cedula,
                               Tipo_usuarios.Descripcion,
                               USUARIOS.Limite_credito,
                               USUARIOS.Fecha_Registro,
                               USUARIOS.Activo
                           };


            DGVUsuarios.DataSource = consulta.ToList();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            consultarCriterio();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            FrmEdUsuario frm = new FrmEdUsuario();
            frm.ShowDialog();
        }

        private void DGVUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DGVUsuarios.SelectedRows[0];
                USUARIOS user = new USUARIOS();
                Tipo_usuarios TUser = new Tipo_usuarios();

                user.Id_User = Int32.Parse(row.Cells[0].Value.ToString());
                user.Nombre_Usuario = row.Cells[1].Value.ToString();
                user.Cedula = row.Cells[2].Value.ToString();
                user.Id_TipoUser = TUser.Id_TipoUser;
                user.Limite_credito = decimal.Parse(row.Cells[4].Value.ToString());
                user.Fecha_Registro = DateTime.Parse(row.Cells[5].Value.ToString());
                user.Activo = (Boolean)row.Cells[6].Value;

                FrmEdUsuario feu = new FrmEdUsuario();
                feu.user = user;
               
                feu.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex);
            }
        }
    }
}
