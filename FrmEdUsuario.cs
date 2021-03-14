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
                txtNombreUsuario.Text = user.Nombre.ToString();
                txtCedulaUsuario.Text = user.Cedula.ToString();
                txtCredito.Text = user.Limite_credito.ToString();
                txtFecha.Text = user.Fecha_Registro.ToString();
                CBTipoUsuario.SelectedValue = user.Id_TipoUser.ToString();

            }
            else
            {
                txtFecha.Text = DateTime.Now.ToString();
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

        private void GuardarUsuario_Click(object sender, EventArgs e)
        {
            USUARIOS us = entities.USUARIOS.Find(Int32.Parse(txtIDUsuario.Text));
            if(user != null)
            {
                us.Nombre = txtNombreUsuario.Text;
                us.Cedula = txtCedulaUsuario.Text;
                us.Limite_credito = decimal.Parse(txtCredito.Text);
                us.Id_TipoUser = Convert.ToInt32(CBTipoUsuario.SelectedValue);
                us.Activo = CheckActivo.Checked;
                MessageBox.Show("Actualizado con exito");
            }
            else {
                try
                {
                    entities.USUARIOS.Add(new USUARIOS
                    {
                        Nombre = txtNombreUsuario.Text,
                        Cedula = txtCedulaUsuario.Text,
                        Id_TipoUser = Convert.ToInt32(CBTipoUsuario.SelectedValue),
                        Limite_credito = decimal.Parse(txtCredito.Text),
                        Fecha_Registro = DateTime.Now,
                        Activo = CheckActivo.Checked

                    });
                    MessageBox.Show("Guardado con exito");
                }
                catch (Exception ex) { MessageBox.Show("No se guardo" + ex); }
            }
            entities.SaveChanges();
            this.Close();


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
    }
}
