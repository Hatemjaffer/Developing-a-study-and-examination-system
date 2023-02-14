using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCTT.Reports;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace CCTT.Pages
{
    public partial class Page_Std_efad : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
       semster_student tbsemster_student = new semster_student();

        CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();

        public Page_Std_efad()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData( )
        {
           
            txt_stuID.DataSource = db.students.Select(x => x.idColge).ToList();
            txt_stud.DataSource = db.students.Select(x => x.name).ToList();

            //var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            // txt_semecter.DataSource = db.StloadDataPage_getsemster_by_dep(id3);


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Reports.XtraReport3_Efad rp = new XtraReport3_Efad();
            rp.ShowPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Reports.XtraReport3 rp = new XtraReport3();
            rp.ShowPreview();
        }
    }
}

