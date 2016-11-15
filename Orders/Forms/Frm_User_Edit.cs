﻿using System;
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
    public partial class Frm_User_Edit : Form
    {
        public Frm_User_Edit()
        {
            InitializeComponent();
        }

        private void Frm_User_Edit_Load(object sender, EventArgs e)
        {

        }
        private void CanceBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            UserHelper hlp = new UserHelper();
            Result res = hlp.Create(
                new User {
                    UserName = UserNameText.Text,
                    Name = NameText.Text,
                    Password = PasswordText.Text,
                    
                });
        }

       
    }
}
