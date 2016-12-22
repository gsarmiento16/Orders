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
            grid.CurrentCellDirtyStateChanged += new EventHandler(grid_CurrentCellDirtyStateChanged);
            loadData();
        }
        private void NewBtn_Click(object sender, EventArgs e)
        {
            var frm = new Frm_CompanyMaster_Edit();
            frm.Show();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string ids = getIds(1);
            Console.WriteLine(ids);
        }

        private void loadData()
        {
            CompanyMasterHelper cmhlp = new CompanyMasterHelper();
            ICollection<CompanyMasterViewModel> list;
            list = cmhlp.List();
            grid.DataSource = list;
        }


        private string getIds(int ColumnId)
        {
            string ids = "";
            int index = 0;
            foreach(DataGridViewRow row in grid.Rows)
            {

                if (Convert.ToBoolean(row.Cells["check"].Value) == true)
                {
                    Console.WriteLine(row.Cells[ColumnId].Value);
                    ids +=(index>=1)? ",'":"'" + row.Cells[ColumnId].Value.ToString()+"'";

                    index++;
                }
                 
            }

            return ids;
        }


        void grid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (grid.IsCurrentCellDirty)
            {
                grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
