using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orders.Forms;
using Orders.General;
using OrdersMigration.Util;
using OrdersMigration.Helpers;
using OrdersMigration.ViewModels;

namespace Orders.Forms
{
    public partial class Frm_CompanyMaster : Form
    {
        public Frm_CompanyMaster()
        {
            InitializeComponent();
        }

        private void Frm_CompanyMaster_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void NewBtn_Click(object sender, EventArgs e)
        {
            var frm = new Frm_CompanyMaster_Edit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<string> ids = grid.GetCheckedId(1);
            if (ids.Count() > 0)
            {
                DialogResult msg = MessageBox.Show("Desea eliminar el/los registros(s) seleccionado(s)?", "Eliminar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                    CompanyMasterHelper mcHlp = new CompanyMasterHelper();
                    if (mcHlp.Delete(ids).type == ResultType.SUCCESS)
                    {
                        loadData();
                    }
                }
            }
        }

        private void loadData()
        {
            CompanyMasterHelper cmhlp = new CompanyMasterHelper();
            ICollection<CompanyMasterViewModel> list;
            list = cmhlp.List();
            grid.DataSource = list;
        }


     

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentCell.ColumnIndex == 1 )
            {
                var frm = new Frm_CompanyMaster_Edit();
                frm.ShowDialog();
            }
        }
    }
}
