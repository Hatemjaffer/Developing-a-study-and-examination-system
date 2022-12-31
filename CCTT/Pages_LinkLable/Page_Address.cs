using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CCTT.Pages_LinkLable
{
    public partial class Page_Address : DevExpress.XtraEditors.XtraForm
    {
        public Page_Address()
        {
            InitializeComponent();
            txt_user_fullname.Select();
        }

        private void txt_user_fullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_user_fullname_Enter(object sender, EventArgs e)
        {
            txt_user_fullname.BackColor = Color.Yellow;
        }

        private void txt_user_fullname_Leave(object sender, EventArgs e)
        {
            txt_user_fullname.BackColor = Color.White;
        }
    }
}