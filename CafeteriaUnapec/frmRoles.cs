using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeteriaUnapec
{
    public partial class frmRoles : Form
    {
        CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        ROLES rol = new ROLES();
        public frmRoles()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void Consultar()
        {
            var campus = from cam in entities.ROLES
                         where (cam.idRol.ToString().StartsWith(txtBuscar.Text) ||
                         cam.Rol.ToString().StartsWith(txtBuscar.Text) 
                         
                         )
                         select new { cam.idRol, cam.Rol};

            DGVRoles.DataSource = campus.ToList();

        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            Consultar();
            FrmPrincipal frm = new FrmPrincipal();
            if (!frm.rol)
            {
                Agregar.Enabled = false;

                DGVRoles.Enabled = false;

            }
        }
    }
}
