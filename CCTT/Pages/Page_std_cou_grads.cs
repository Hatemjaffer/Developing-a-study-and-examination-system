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
using CCTT.Reports;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;

namespace CCTT.Pages
{
    public partial class Page_std_cou_grads : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        // semster_student_main_cours tbsemster_student_main_cours = new semster_student_main_cours();
        // semster_student tbsemster_student = new semster_student();
        private Course_inStudent tbCourseInStudent = new Course_inStudent();
        public get_main_cours_student_grade1_Result f;
        int ID;
        public Page_std_cou_grads()
        {
            InitializeComponent();
           
            LoadData();
            }

        public void LoadData()
        {
            
            // gridControl1.DataSource = dbContext.get_main_cours_student(null);
             txt_yeare.DataSource = db.extra_Course.Select(x => x.course_code).ToList();
            
             txt_name_course.DataSource = db.extra_Course.Select(x => x.course_name).ToList();

            //var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            // txt_semecter.DataSource = db.StloadDataPage_getsemster_by_dep(id3);


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            //var yearId = db.Year.Where(x => x.year_serch == txt_yeare.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            var coursId = db.extra_Course.Where(x => x.course_name == txt_name_course.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            //var t = db.main_course.Where(x => x.id == coursId).Select(x => x.type).FirstOrDefault();

            gridControl1.DataSource = getCourse_inStudent_Gread1TableAdapter.GetData(coursId);

            // if (t==1)
            //{
            //    gridView1.Columns.View.Columns["درجة العملي"].Visible = false;
            //}
          
        }

        private void txt_yeare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_department_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_semester_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_maincourse_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_groupstady_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void txt_yeare_Enter(object sender, EventArgs e)
        {
            txt_yeare.BackColor = Color.Yellow;

        }

        private void txt_yeare_Leave(object sender, EventArgs e)
        {
            txt_yeare.BackColor = Color.White;

        }

        private void txt_department_Enter(object sender, EventArgs e)
        {
            txt_name_course.BackColor = Color.Yellow;

        }

        private void txt_department_Leave(object sender, EventArgs e)
        {
            txt_name_course.BackColor = Color.White;

        }

        private void txt_semester_Enter(object sender, EventArgs e)
        {
           // txt_semester.BackColor = Color.Yellow;

        }

        private void txt_semester_Leave(object sender, EventArgs e)
        {
          //  txt_semester.BackColor = Color.White;

        }

        private void txt_maincourse_Enter(object sender, EventArgs e)
        {
       //     txt_maincourse.BackColor = Color.Yellow;

        }

        private void txt_maincourse_Leave(object sender, EventArgs e)
        {
          //  txt_maincourse.BackColor = Color.White;

        }

        private void txt_groupstady_Enter(object sender, EventArgs e)
        {
           // txt_groupstady.BackColor = Color.Yellow;

        }

        private void txt_groupstady_Leave(object sender, EventArgs e)
        {
         //   txt_groupstady.BackColor = Color.White;

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
          //  var yearId = db.Year.Where(x => x.year_serch == txt_yeare.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
           // var coursId = db.main_course.Where(x => x.course_name == txt_maincourse.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
          //  Reports.XtraReport5 x1 = new Reports.XtraReport5();
           
            //x1.DataSource= get_main_cours_student_grade1TableAdapter.GetData(yearId, coursId);

            //x1.ShowPreview();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // LoadData();
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                var id =Convert.ToInt32( gridView1.GetRowCellValue(i, "الرقم").ToString());
               // var mid = Convert.ToInt32(gridView1.GetRowCellValue(i, "درجة اعمال الفصل ").ToString());
                //var finalLab = Convert.ToInt32(gridView1.GetRowCellValue(i, "درجة العملي").ToString());
                //var final_only = Convert.ToInt32(gridView1.GetRowCellValue(i, "درجة الامتحان النهائي").ToString());
                var final = Convert.ToDecimal(gridView1.GetRowCellValue(i, "درجة").ToString());

                tbCourseInStudent  = db.Course_inStudent.Where(x => x.id == id).FirstOrDefault();
                tbCourseInStudent.id = id;
                tbCourseInStudent.grade = final;

                db.Entry(tbCourseInStudent).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("تم تعديل البيانات بالنجاح", "عملية تعديل", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                //  var unit = Convert.ToInt32(db.semster_student_main_cours.Where(x => x.id == uid).Select(x => x.unit).FirstOrDefault());
                // int rate = unit * final;
                //   .FirstOrDefault());
                // db.tbl_insert_semster_student_main_cours_grade3(uid,final_only,mid,0,final,1, rate);
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
                // var id7= db.semster_student.

          //   var id7=   db.semster_student_main_cours.Where(x => x.id== uid).Select(x => x.semster_student_id).FirstOrDefault();
         //    var id8 = db.semster_student.Where(x => x.id == id7).Select(x => x.year_id).FirstOrDefault();
          //   var id9 = db.semster_student.Where(x => x.id == id7).Select(x => x.student_id).FirstOrDefault();

           //     db.rate_calculation(id8, id9);
            }
        }

        private void gridControl1_Leave(object sender, EventArgs e)
        {
            //gridView1.GetRowCellValue(e.GetValueSafe(), "المادة").ToString();
        }

        private void gridControl1_TextChanged(object sender, EventArgs e)
        {
         //   MessageBox.Show("bbbb");
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
          var mid= Convert.ToInt32( gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "درجة اعمال الفصل "));
          var final= Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "درجة الامتحان النهائي"));
          gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "الدرجة النهائية", mid+final);
          // MessageBox.Show(mid);
        }

        private void btn_edt_click_Click(object sender, EventArgs e)
        {

        }
    }
}
