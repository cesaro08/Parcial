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
    
    public partial class FrmEdUsuario : Form
    {
        
        public USUARIOS user { get;  set; }
        

        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();

        public FrmEdUsuario()
        {
            InitializeComponent();
        }

        private void FrmEdUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            if(user != null)
            {
                
                txtIDUsuario.Text = user.Id_User.ToString();
                txtNombreUsuario.Text = user.Nombre_Usuario.ToString();
                txtUsuario.Enabled = false;
                txtUsuario.Text = user.Usuario.ToString();
                txtCedulaUsuario.Text = user.Cedula.ToString();
                txtCredito.Text = user.Limite_credito.ToString();
                dtFecha.Value = user.Fecha_Registro;
                CBTipoUsuario.SelectedValue = user.Id_TipoUser.ToString();

            }
            
        }
        private void CargarDatos()
        {
            var elementos = entities.Tipo_usuarios.ToList();
            if(elementos.Count > 0)
            {
                CBTipoUsuario.DataSource = elementos;
                CBTipoUsuario.DisplayMember = "Descripcion";
                CBTipoUsuario.ValueMember = "id_TipoUser";
                CBTipoUsuario.SelectedItem = 0;
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
        private void GuardarUsuario_Click(object sender, EventArgs e)
        {
            USUARIOS sql = (from USUA in entities.USUARIOS
                            where (USUA.Usuario.Equals(txtUsuario.Text))
                            select USUA).FirstOrDefault();

            if (!validaCedula(txtCedulaUsuario.Text))
                MessageBox.Show("Credenciales erroneos");
            
            else
            {

                USUARIOS us = entities.USUARIOS.Find(Int32.Parse(txtIDUsuario.Text));
                if (decimal.Parse(txtCredito.Text) > 0)
                {
                    if (user != null)
                    {
                        txtUsuario.Enabled = false;
                        us.Nombre_Usuario = txtNombreUsuario.Text;
                        us.Usuario = txtUsuario.Text;
                        us.Contraseña = generarsha(txtContraseña.Text);
                        us.Cedula = txtCedulaUsuario.Text;
                        us.Limite_credito = decimal.Parse(txtCredito.Text);
                        us.Id_TipoUser = Convert.ToInt32(CBTipoUsuario.SelectedValue);
                        us.Activo = CheckActivo.Checked;
                        us.Fecha_Registro = dtFecha.Value;
                        entities.SaveChanges();
                        MessageBox.Show("Actualizado con exito");
                        this.Close();
                    }
                    else
                    {
                        if (sql != null)
                        {
                            MessageBox.Show("Usuario existente");
                        }
                        else
                        {
                            try
                            {
                                entities.USUARIOS.Add(new USUARIOS
                                {
                                    Nombre_Usuario = txtNombreUsuario.Text,
                                    Usuario = txtUsuario.Text,
                                    Contraseña = generarsha(txtContraseña.Text),
                                    Cedula = txtCedulaUsuario.Text,
                                    Id_TipoUser = Convert.ToInt32(CBTipoUsuario.SelectedValue),
                                    Limite_credito = decimal.Parse(txtCredito.Text),
                                    Fecha_Registro = dtFecha.Value,
                                    Activo = CheckActivo.Checked

                                });
                                entities.SaveChanges();
                                MessageBox.Show("Guardado con exito");
                                this.Close();
                            }
                            catch (Exception ex) { MessageBox.Show("No se guardo " + ex); }
                        }
                    }

                    
                }
                else MessageBox.Show("No se admiten valores negativos");
            }

        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de querer eliminar?", "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            USUARIOS user = entities.USUARIOS.Find(Int32.Parse(txtIDUsuario.Text));
            if (user != null)
            {
                entities.USUARIOS.Remove(user);
                entities.SaveChanges();
                MessageBox.Show("Usuario eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Cafeteria no encontrada");
                
            }
            this.Close();
        }
        public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
    }
}
