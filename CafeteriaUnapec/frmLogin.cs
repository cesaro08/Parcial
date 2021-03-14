using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaUnapec
{
    public partial class frmLogin : Form
    {
        CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        USUARIOS user = new USUARIOS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Ingresar()
        {
            string contra = generarsha(txtContraseña.Text);
            USUARIOS login = (from USER in entities.USUARIOS
                         where (USER.Contraseña.Equals(contra) &&
                         USER.Usuario.Equals(txtUser.Text)
                         )
                         select USER).FirstOrDefault();

            if(login == null || login.Activo.Equals(false)) 
            {
                MessageBox.Show("Credenciales erroneas");
            }
            else
            {
                FrmPrincipal frm = new FrmPrincipal();
                
                Sesion.id = login.Id_User;
                Sesion.idTipo = login.Id_TipoUser;
                
                
                
                frm.useractivo = login;
                frm.Show();
                this.Hide();
            }
        }
        private string generarsha(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
