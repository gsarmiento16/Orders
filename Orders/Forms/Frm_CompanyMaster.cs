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
namespace Orders.Forms
{
    public partial class Frm_CompanyMaster : Form
    {
        public Frm_CompanyMaster()
        {
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            var frm = new Frm_CompanyMaster_Edit();
            frm.Show();
        }
    }
}
