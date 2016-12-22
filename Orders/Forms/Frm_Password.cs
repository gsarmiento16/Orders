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
    public partial class Frm_Password : Form
    {
        public Frm_Password()
        {
            InitializeComponent();
        }

        private void Frm_Password_Load(object sender, EventArgs e)
        {
            UserNameTxt.Text = "super";
            PasswordTxt.Text = "123456";
            login();

        }
        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            Cursor = Cursors.WaitCursor;
            Result res;
            if (UserNameTxt.Text != string.Empty && PasswordTxt.Text != string.Empty)
            {
                SesionHelper shlp = new SesionHelper();
                res = shlp.Login(new User { UserName = UserNameTxt.Text, Password = PasswordTxt.Text });
                Cursor = Cursors.Default;

                if (res.type == ResultType.SUCCESS)
                {
                    this.Hide();
                    var frm = new frm_main();
                    frm.Show();
                }
                else if (res.type == ResultType.USER_FAIL)
                {
                    var msg = MessageBox.Show("Los datos no coinciden", "Entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (res.type == ResultType.FAILED)
                {
                    var msg = MessageBox.Show(res.message, "Entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
