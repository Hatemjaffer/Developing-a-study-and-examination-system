using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace CCTT.Pages
{
    public partial class Page_grades_Course : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        semster_student_main_cours tbsemster_student_main_cours = new semster_student_main_cours();
        semster_student tbsemster_student = new semster_student();
        public get_main_cours_student_grade1_Result f;
        public Page_grades_Course()
        {
            InitializeComponent();
           
            LoadData();
            }

        public void LoadData()
        {
            // gridControl1.DataSource = dbContext.get_main_cours_student(null);
             txt_yeare.DataSource = db.Year.Select(x => x.year_serch).ToList();
             txt_semester.DataSource = db.Semester.Select(x => x. semester1).ToList();
            txt_groupstady.DataSource = db.study_Group.Select(x => x.name).ToList();

             txt_department.DataSource = db.department.Select(x => x.name).ToList();
             txt_maincourse.DataSource = db.main_course.Select(x => x.course_name).ToList();

            //var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            // txt_semecter.DataSource = db.StloadDataPage_getsemster_by_dep(id3);


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var yearId = db.Year.Where(x => x.year_serch == txt_yeare.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            var coursId = db.main_course.Where(x => x.course_name == txt_maincourse.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            gridControl1.DataSource = get_main_cours_student_grade1TableAdapter.GetData(yearId,coursId);
    

        }

        private void txt_yeare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                return;
            }
        }
    }
}
