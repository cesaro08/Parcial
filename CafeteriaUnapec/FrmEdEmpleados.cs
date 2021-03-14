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
        private void GuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!validaCedula(txtCedulaUsuario.Text))
            {
                MessageBox.Show("Credenciales erroneas");
            }
            else
            {
                EMPLEADOS em = entities.EMPLEADOS.Find(Int32.Parse(txtIDUsuario.Text));
                if (em != null)
                {
                    em.Nombre = txtNombreUsuario.Text;
                    em.Cedula = txtCedulaUsuario.Text;
                    em.Tanda_Labor = CBTandas.Text;
                    em.Porciento_Comision = decimal.Parse(txtComision.Text);
                    em.Activo = CheckActivo.Checked;
                    em.Fecha_Ingreso = txtFecha.Value;

                }
                else
                {
                    entities.EMPLEADOS.Add(new EMPLEADOS
                    {
                        Nombre = txtNombreUsuario.Text,
                        Cedula = txtCedulaUsuario.Text,
                        Tanda_Labor = CBTandas.Text,
                        Porciento_Comision = decimal.Parse(txtComision.Text),
                        Fecha_Ingreso = txtFecha.Value,
                        Activo = CheckActivo.Checked
                    });
                }
                entities.SaveChanges();
                MessageBox.Show("Guardado con exito");
                this.Close();
            }
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
                
            }
            this.Close();
        }
    }
}
