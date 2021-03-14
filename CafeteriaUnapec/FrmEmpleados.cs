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
    public partial class FrmEmpleados : Form
    {
        private EMPLEADOS empl = new EMPLEADOS();
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmEmpleados()
        {
            InitializeComponent();
            int tipo;
            tipo = Sesion.idTipo;

            if (tipo != 2)
            {
                BtnAgregar.Enabled = false;
                DGVEmpleados.Enabled = false;
            }
        }

        private void BtnBuCafe_Click(object sender, EventArgs e)
        {
            consultaCriterio();
        }
        private void consultaCriterio()
        {
            var consulta = from empl in entities.EMPLEADOS

                           where (empl.Id_Empleado.ToString()).StartsWith(txtBuscar.Text) ||
                           empl.Nombre.ToString().StartsWith(txtBuscar.Text) ||
                           empl.Tanda_Labor.ToString().StartsWith(txtBuscar.Text) ||
                           empl.Fecha_Ingreso.ToString().StartsWith(txtBuscar.Text) ||
                           empl.Porciento_Comision.ToString().StartsWith(txtBuscar.Text) 

                           select new { empl.Id_Empleado, empl.Nombre, empl.Cedula, empl.Tanda_Labor, empl.Porciento_Comision,empl.Fecha_Ingreso,empl.Activo};


            DGVEmpleados.DataSource = consulta.ToList();

        }
        private void consulta()
        {
            var consulta = from empl in entities.EMPLEADOS
                           select new { empl.Id_Empleado, 
                               empl.Nombre, 
                               empl.Cedula, 
                               empl.Tanda_Labor, 
                               empl.Porciento_Comision, 
                               empl.Fecha_Ingreso, 
                               empl.Activo };


            DGVEmpleados.DataSource = consulta.ToList();

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            consulta();
            DGVEmpleados.Columns[0].HeaderText = "ID";
            DGVEmpleados.Columns[3].HeaderText = "Tanda Laboral";
            DGVEmpleados.Columns[4].HeaderText = "Porciento Comision";
            DGVEmpleados.Columns[5].HeaderText = "Fecha de Ingreso";

        }

        private void DGVEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGVEmpleados.SelectedRows[0];
            EMPLEADOS em = new EMPLEADOS();

            em.Id_Empleado = Int32.Parse(row.Cells[0].Value.ToString());
            em.Nombre = row.Cells[1].Value.ToString();
            em.Cedula = row.Cells[2].Value.ToString();
            em.Tanda_Labor = row.Cells[3].Value.ToString();
            em.Porciento_Comision = decimal.Parse(row.Cells[4].Value.ToString());
            em.Fecha_Ingreso = DateTime.Parse(row.Cells[5].Value.ToString());

            FrmEdEmpleados frm = new FrmEdEmpleados();
            frm.em = em;
            frm.ShowDialog();
        }

        private void BtnAgCafe_Click(object sender, EventArgs e)
        {
            FrmEdEmpleados frm = new FrmEdEmpleados();
            frm.ShowDialog();
        }

        private void FrmEmpleados_Activated(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
