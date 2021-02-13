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
    public partial class FrmEdEmpleados : Form
    {
        public EMPLEADOS em { get; set; }
        public CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmEdEmpleados()
        {
            InitializeComponent();
        }

        private void CBTandas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GuardarUsuario_Click(object sender, EventArgs e)
        {
            EMPLEADOS em = entities.EMPLEADOS.Find(Int32.Parse(txtIDUsuario.Text));
            if(em != null)
            {
                em.Nombre = txtNombreUsuario.Text;
                em.Cedula = txtCedulaUsuario.Text;
                em.Tanda_Labor = CBTandas.Text;
                em.Porciento_Comision = decimal.Parse(txtComision.Text);
                em.Activo = CheckActivo.Checked;

            }
            else
            {
                entities.EMPLEADOS.Add(new EMPLEADOS
                {
                    Nombre = txtNombreUsuario.Text,
                    Cedula = txtCedulaUsuario.Text,
                    Tanda_Labor = CBTandas.Text,
                    Porciento_Comision = decimal.Parse(txtComision.Text),
                    Fecha_Ingreso = DateTime.Parse(txtFecha.Text),
                    Activo = CheckActivo.Checked
                }) ;
            }
            entities.SaveChanges();
            MessageBox.Show("Guardado con exito");
            this.Close();
        }

        private void FrmEdEmpleados_Load(object sender, EventArgs e)
        {
            if(em != null)
            {
                txtIDUsuario.Text = em.Id_Empleado.ToString();
                txtNombreUsuario.Text = em.Nombre.ToString();
                txtCedulaUsuario.Text = em.Cedula.ToString();
                CBTandas.Text = em.Tanda_Labor.ToString();
                txtComision.Text = em.Porciento_Comision.ToString();
                txtFecha.Text = em.Fecha_Ingreso.ToString();
            }
            else { txtFecha.Text = DateTime.Now.ToString(); }
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de querer eliminar?", "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            EMPLEADOS empl = entities.EMPLEADOS.Find(Int32.Parse(txtIDUsuario.Text));
            if (empl != null)
            {
                entities.EMPLEADOS.Remove(empl);
                entities.SaveChanges();
                MessageBox.Show("Empleado eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Empleado no encontrada");
                this.Close();
            }
        }
    }
}
