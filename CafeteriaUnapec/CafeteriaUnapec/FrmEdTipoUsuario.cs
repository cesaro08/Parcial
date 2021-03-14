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
    public partial class FrmEdTipoUsuario : Form
    {
        public Tipo_usuarios TUsuarios { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmEdTipoUsuario()
        {
            InitializeComponent();
        }

        private void GuardarCafe_Click(object sender, EventArgs e)
        {
            Tipo_usuarios tipo_Usuarios = entities.Tipo_usuarios.Find(Int32.Parse(TxtID.Text));
            if (TUsuarios != null)
            {
                tipo_Usuarios.Descripcion = TxtDescripcion.Text;
                tipo_Usuarios.Activo = CheckActTipo.Checked;
            }
            else
            {
                entities.Tipo_usuarios.Add(new Tipo_usuarios
                {
                    Descripcion = TxtDescripcion.Text,
                    Activo = CheckActTipo.Checked

                });

            }
            entities.SaveChanges();
            MessageBox.Show("Datos guardados con exito");
            this.Close();
        }

        private void FrmEdTipoUsuario_Load(object sender, EventArgs e)
        {
            if (TUsuarios != null)
            {

                TxtID.Text = TUsuarios.Id_TipoUser.ToString();
                TxtDescripcion.Text = TUsuarios.Descripcion.ToString();
                CheckActTipo.Checked = TUsuarios.Activo;
            }

        }

        private void EliminarCafe_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Tipo_usuarios tipo_Usuarios = entities.Tipo_usuarios.Find(Int32.Parse(TxtID.Text));
            if (tipo_Usuarios != null)
            {
                entities.Tipo_usuarios.Remove(tipo_Usuarios);
                entities.SaveChanges();
                MessageBox.Show("Tipo de usuario eliminado");
                
            }
            else
            {
                MessageBox.Show("Empleado no existe");
               
            }
            this.Close();
        }
    }
}
