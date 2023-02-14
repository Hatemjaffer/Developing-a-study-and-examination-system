using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CCTT.Reports
{
    public partial class XtraReport3 : DevExpress.XtraReports.UI.XtraReport
    {
         FRM_Setting setting = new FRM_Setting();
        public XtraReport3()
        {
            InitializeComponent();
            txt_amed.Text = setting.txt_president_name.Text;
            txt_manger.Text = setting.txt_developmeny_manager.Text;
        }

    }
}
