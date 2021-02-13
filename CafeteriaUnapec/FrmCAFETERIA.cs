﻿using System;
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
    public partial class FrmCAFETERIA : Form
    {
        private CAFETERIAS Cafeteria { get; set; }
        private CAFETERIAEntities1 entities = new CAFETERIAEntities1();
        public FrmCAFETERIA()
        {
            InitializeComponent();
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            consultarCriterio();
        }

        private void consultarCriterio()
        {
          
            var query = from cafe in entities.CAFETERIAS
                       join campus in entities.CAMPUS on cafe.Id_Campus equals campus.Id_Campus
                                 where (campus.Descripcion.ToString().StartsWith(TxtBusq.Text) ||
                                  cafe.Id_Campus.ToString().StartsWith(TxtBusq.Text) ||
                                  cafe.Descripción.ToString().StartsWith(TxtBusq.Text) ||
                                  cafe.Encargado.ToString().StartsWith(TxtBusq.Text) ||
                                  cafe.Activo.ToString().StartsWith(TxtBusq.Text)
                                  )
                        select new { cafe.Id_Cafeteria, cafe.Descripción,
                                      cafe.Encargado, cafe.Activo, campus.Descripcion 
                         };


            
            DGVCaf.DataSource = query.ToList();
            DGVCaf.Columns[4].HeaderText = "Campus";
                                }


private void BtnAñadir_Click(object sender, EventArgs e)
        {
            FrmEdCafe frm = new FrmEdCafe();
            frm.ShowDialog();
        }

       
      

        private void FrmCAFETERIA_Load(object sender, EventArgs e)
        {
            consultarCriterio();
        }

        private void DGVCaf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DGVCaf.SelectedRows[0];
                CAFETERIAS Cafeteria = new CAFETERIAS();
                CAMPUS Campus = new CAMPUS();

                Cafeteria.Id_Cafeteria = Int32.Parse(row.Cells[0].Value.ToString());
                Campus.Descripcion =  row.Cells[4].Value.ToString();
                Cafeteria.Descripción = row.Cells[1].Value.ToString();
                Cafeteria.Encargado = row.Cells[2].Value.ToString();
                Cafeteria.Activo = (Boolean)row.Cells[3].Value;

                FrmEdCafe fec = new FrmEdCafe();
                fec.Cafeteria = Cafeteria;
                fec.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
