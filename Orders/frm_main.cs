using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdersMigration.Helpers;
using OrdersMigration.Util;
using Orders.Forms;

namespace Orders
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            if(Sesion.UserName!= string.Empty)
            {
                UserLbl.Text = Sesion.UserName;
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void QuotationBtn_Click(object sender, EventArgs e)
        {

        }

        private void Articulo_Tipo_Click(object sender, EventArgs e)
        {
            var frm_RT = new Frm_ResourceType();
            frm_RT.Show();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_CM = new Frm_CompanyMaster();
            frm_CM.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_user = new Frm_User();
            frm_user.Show();

        }
    }
}
