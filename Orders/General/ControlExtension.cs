using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders.General
{
  public static  class ControlExtension
    {
        public static string getCheckboxValue(CheckBox chk)
        {
            string res = string.Empty;
            if (chk.GetType() == typeof(CheckBox))
            {
                res = ((CheckBox)chk).Checked.ToString();
            }
            return res;
        }
    }
}
