using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orders.General;
using OrdersMigration.Models;
using OrdersMigration.Helpers;
using OrdersMigration.Util;



namespace Orders.Forms
{
    public partial class Frm_CompanyMaster_Edit : Form
    {
        string _Id;
        CompanyMaster entity;
        public Frm_CompanyMaster_Edit()
        {
            InitializeComponent();
        }

        public Frm_CompanyMaster_Edit(string Id)
        {
            _Id = Id;
            InitializeComponent();
            
            
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            CompanyMasterHelper hlp = new CompanyMasterHelper();
            if (entity != null)
            {
                res = hlp.Update(entity.Ext_Id);
            }
            else
            {
               res = hlp.Create(new CompanyMaster
                {
                    Name = NameText.Text,
                    Code = CodeText.Text
                });
            }

            if (res.type == ResultType.SUCCESS)
            {
                ClearForm();
                var msg = MessageBox.Show("Se guardaron los datos exitosamente.","Compañia - Grupo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
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
        
        private void loadData(string Ext_Id)
        {
            CompanyMasterHelper hlp = new CompanyMasterHelper();
            entity = hlp.Get(Ext_Id);
            if (entity != null)
            {
                NameText.Text = entity.Name;
                CodeText.Text = entity.Code;
            }
        }
    }
}
