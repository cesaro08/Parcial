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
using System.Security.Cryptography;

namespace CafeteriaUnapec
{
    public partial class FrmUsuario : Form
    {
        private USUARIOS USUARIOS { get; set; }
        
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
       

        public FrmUsuario()
        {
            InitializeComponent();
            int tipo;
            tipo = Sesion.idTipo;

            if (tipo != 2)
            {
                Agregar.Enabled = false;
                DGVUsuarios.Enabled = false;
            }
        }

        

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            
                Consultar();
            DGVUsuarios.Columns[0].HeaderText = "ID";
            DGVUsuarios.Columns[1].HeaderText = "Nombre";
            DGVUsuarios.Columns[5].HeaderText = "Limite de Credito";
            DGVUsuarios.Columns[6].HeaderText = "Fecha de registro";



        }

        

        private void Consultar()
        {
            var consulta = from USUARIOS in entities.USUARIOS
                           join Tipo_usuarios in entities.Tipo_usuarios on USUARIOS.Id_TipoUser equals Tipo_usuarios.Id_TipoUser
                           select new
                           {
                               USUARIOS.Id_User,
                               USUARIOS.Nombre_Usuario,
                               USUARIOS.Usuario,
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
                           USUARIOS.Usuario.ToString().StartsWith(txtBuscar.Text) ||
                           USUARIOS.Nombre_Usuario.ToString().StartsWith(txtBuscar.Text) ||
                           USUARIOS.Cedula.ToString().StartsWith(txtBuscar.Text) ||
                           USUARIOS.Fecha_Registro.ToString().StartsWith(txtBuscar.Text)
                           )
                           select new
                           {
                               USUARIOS.Id_User,
                               USUARIOS.Nombre_Usuario,
                               USUARIOS.Usuario,
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
                user.Usuario= row.Cells[2].Value.ToString();
                user.Cedula = row.Cells[3].Value.ToString();
                user.Id_TipoUser = TUser.Id_TipoUser;
                user.Limite_credito = decimal.Parse(row.Cells[5].Value.ToString());
                user.Fecha_Registro = DateTime.Parse(row.Cells[6].Value.ToString());
                user.Activo = (Boolean)row.Cells[7].Value;
                
                

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
