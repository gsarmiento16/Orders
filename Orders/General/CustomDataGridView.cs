using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders.General
{
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            this.CurrentCellDirtyStateChanged += new EventHandler(grid_CurrentCellDirtyStateChanged);
        }
        public List<string> GetCheckedId(int ColumnId)
        {
            List<string> ids = new List<string>();
            foreach (DataGridViewRow row in this.Rows)
            {

                if (Convert.ToBoolean(row.Cells["check"].Value) == true)
                {
                    ids.Add(row.Cells[ColumnId].Value.ToString());
                }

            }

            return ids;
        }

        void grid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.IsCurrentCellDirty)
            {
                this.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        
    }
}
