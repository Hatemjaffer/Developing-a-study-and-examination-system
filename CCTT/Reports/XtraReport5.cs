using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace CCTT.Reports
{
    public partial class XtraReport5 : DevExpress.XtraReports.UI.XtraReport
    {
        DB_CCTTEntities db = new DB_CCTTEntities();

        public XtraReport5()
        {
            InitializeComponent();
          //  efDataSource1.Fill(db.semster_student.);
        }

    }
}
