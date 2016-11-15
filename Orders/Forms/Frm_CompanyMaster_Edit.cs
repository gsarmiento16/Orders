using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdersMigration.Models;
using OrdersMigration.Helpers;
using OrdersMigration.Util;



namespace Orders.Forms
{
    public partial class Frm_CompanyMaster_Edit : Form
    {
        public Frm_CompanyMaster_Edit()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            CompanyMasterHelper hlp = new CompanyMasterHelper();
            Result res = hlp.Create(new CompanyMaster
            {
                Name = NameText.Text,
                Code = CodeText.Text
            });

            if (res.type == ResultType.SUCCESS)
            {
                ClearForm();
                var msg = MessageBox.Show("Se guardaron los datos exitosamente.","Compañia - Grupo", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                var msg = MessageBox.Show(res.message, "Compañia - Grupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            NameText.Clear();
            CodeText.Clear();
        }

        private void CanceBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_CompanyMaster_Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
