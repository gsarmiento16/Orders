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
    public partial class Frm_ResourceType : Form
    {
        public Frm_ResourceType()
        {
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            var frm = new Frm_ResourceType_Edit();
            frm.Show();

        }
    }
}
