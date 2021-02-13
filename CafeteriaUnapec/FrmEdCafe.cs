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
    public partial class FrmEdCafe : Form
    {
       
        public CAFETERIAS Cafeteria { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmEdCafe()
        {
            InitializeComponent();
        }

       
        private void cargarDatosCB()
        {
            var lista = entities.CAMPUS.ToList();
            if(lista.Count>0)
            {
                CBCampus.DataSource = lista;
                CBCampus.DisplayMember = "Descripcion";
                CBCampus.ValueMember = "Id_Campus";
                if (CBCampus.Items.Count > 1)
                    CBCampus.SelectedIndex = -1;
            }
            var list = entities.EMPLEADOS.ToList();
            if (list.Count > 0)
            {
                cbEmpleado.DataSource = list;
                cbEmpleado.ValueMember = "Nombre";
                if (cbEmpleado.Items.Count > 1)
                    cbEmpleado.SelectedIndex = -1;
            }

        }

        private void FrmEdCafe_Load(object sender, EventArgs e)
        {
            cargarDatosCB();
            if (Cafeteria != null)
            {
                TxtIDcaf.Text = Cafeteria.Id_Cafeteria.ToString();
                CBCampus.SelectedValue = Cafeteria.Id_Campus.ToString();
                cbEmpleado.Text = Cafeteria.Encargado.ToString();
                TxtDesCafe.Text = Cafeteria.Descripción.ToString();
                CheckActCafe.Checked = Cafeteria.Activo;
            }
        }

        private void GuardarCafe_Click(object sender, EventArgs e)
        {
           CAFETERIAS Cafeteria = entities.CAFETERIAS.Find(Int32.Parse(TxtIDcaf.Text));
            if (Cafeteria != null)
            {
                  Cafeteria.Id_Campus = Convert.ToInt32(CBCampus.SelectedValue);
                  Cafeteria.Descripción = TxtDesCafe.Text;
                  Cafeteria.Encargado = Convert.ToString(cbEmpleado.SelectedValue);
                  Cafeteria.Activo = CheckActCafe.Checked;

            }

            else
            {
                entities.CAFETERIAS.Add(new CAFETERIAS
                {
                    Id_Campus = Convert.ToInt32(CBCampus.SelectedValue),
                    Descripción = TxtDesCafe.Text,
                    Encargado = Convert.ToString(cbEmpleado.SelectedValue),
                    Activo = CheckActCafe.Checked
                }
                ) ;

            }

            entities.SaveChanges();
            MessageBox.Show("Datos guardados con éxito");
            this.Close();
        }


        private void CBCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EliminarCafe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de querer eliminar?", "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            CAFETERIAS Cafeteria = entities.CAFETERIAS.Find(Int32.Parse(TxtIDcaf.Text));
            if (Cafeteria != null)
            {
                entities.CAFETERIAS.Remove(Cafeteria);
                entities.SaveChanges();
                MessageBox.Show("Cafeteria eliminada correctamente");
            }
            else
            {
                MessageBox.Show("Cafeteria no encontrada");
                
            }
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

  

}
