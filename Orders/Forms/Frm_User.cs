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
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {

        }
        private void NewBtn_Click(object sender, EventArgs e)
        {
            var frm_u = new Frm_User_Edit();
            frm_u.Show();
        }

        
    }
}
