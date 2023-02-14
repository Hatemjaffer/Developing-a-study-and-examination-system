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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace CCTT.Pages
{
    public partial class Page_Payments : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        Course_inStudent tbCourse_inStudent = new Course_inStudent();

        CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();

        public Page_Payments()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
          //  txt_semecter.DataSource = db.Year.Select(x => x.year_serch).ToList();
            txt_courscode.DataSource = db.extra_Course.Select(x => x.course_code).ToList();
            txt_course_name.DataSource = db.extra_Course.Select(x => x.course_name).ToList();
            txt_student.DataSource = db.course_student.Select(x => x.Name).ToList();

            //  txt_deprment.DataSource = db.Year.Select(x => x.year_serch).ToList();
            // txt_subject.DataSource = db.main_course.Select(x => x.course_name).ToList();

            //var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            // txt_semecter.DataSource = db.StloadDataPage_getsemster_by_dep(id3);


        }
        private void Add()
        {
            //if (txt_student.Text == "")
            //{
            //    MessageBox.Show("الحقل مطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //else
            //{

            //    AddData();
               
            //}
        }
        // دالة اضافة
        private void AddData()
        {
            
                var id1 = db.extra_Course.Where(x => x.course_code == txt_courscode.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                var id2 = db.course_student.Where(x => x.Name == txt_student.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

                tbCourse_inStudent.extra_Course_id = id1;
                tbCourse_inStudent.student_id = id2;
                tbCourse_inStudent.course_recipt1 = Convert.ToDecimal(txt_recipt_1.Text);
                tbCourse_inStudent.course_recipt2 = Convert.ToDecimal(txt_recipt_2.Text);
                tbCourse_inStudent.note = txt_note.Text;
                tbCourse_inStudent.grade = 0;
                

           
            db.Entry(tbCourse_inStudent).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                gridControl1.DataSource = getCourse_inStudentTableAdapter.GetData(id1);

            MessageBox.Show("تمت الاضافة بنجاح", "اضافة");

            
            

        }
        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        { 
              Add();
        

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
          // string day = txt_deprment.SelectedItem.ToString();
            //day.ToCharArray();
          //  MessageBox.Show(day[0].ToString());
            
           
        }

        private void txt_student_Enter(object sender, EventArgs e)
        {
          //  txt_student.BackColor = Color.Yellow;

        }

        private void txt_student_Leave(object sender, EventArgs e)
        {
       //     txt_student.BackColor = Color.White;

        }

        private void txt_deprment_Enter(object sender, EventArgs e)
        {
            //txt_deprment.BackColor = Color.Yellow;

        }

        private void txt_deprment_Leave(object sender, EventArgs e)
        {
          // txt_deprment.BackColor = Color.White;

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var id1 = db.extra_Course.Where(x => x.course_code == txt_courscode.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            gridControl1.DataSource = getCourse_inStudentTableAdapter.GetData(id1);

        }
    }
}
