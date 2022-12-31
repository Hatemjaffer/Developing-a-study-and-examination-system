using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTT.Pages
{
    public partial class Page_Home : DevExpress.XtraEditors.XtraUserControl
    {
        MemoryStream ma;
        public Page_Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_datetime.Text = DateTime.Now.ToString();
        }

        private void Set_Setting()
        {
            var comp_name = Properties.Settings.Default.colloge_name;
          
            txt_companytitle.Text = comp_name;


            try  // يجب ان تضع كود الصورة دائما في تراي لتجنب الاخطاء ادا لم تضعها ستسبب في كراش للجهاز
            {
                var imagebyt = Convert.FromBase64String(Properties.Settings.Default.pic_logo);
                ma = new MemoryStream(imagebyt);
                pictureBox1.Image = Image.FromStream(ma);
            }
            catch { }

        }

         
        private void Page_Home_Load_1(object sender, EventArgs e)
        {
            Set_Setting();
           
        }
    }
}
