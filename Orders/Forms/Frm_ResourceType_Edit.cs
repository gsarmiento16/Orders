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
using OrdersMigration.Models;
using OrdersMigration.Util;

namespace Orders.Forms
{
    public partial class Frm_ResourceType_Edit : Form
    {
        public Frm_ResourceType_Edit()
        {
            InitializeComponent();
        }

        private void Frm_ResourceType_Edit_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ResourceType resourceType = new ResourceType();
            ResourceTypeHelper hlp = new ResourceTypeHelper();
            Result<ResourceType> res = new Result<ResourceType>();
            resourceType.Name = NameText.Text;
            res = hlp.Create(resourceType);

         }
    }
}
