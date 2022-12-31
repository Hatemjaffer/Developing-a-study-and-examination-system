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
    public partial class Page_ID_Student : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
       semster_student tbsemster_student = new semster_student();

        CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();

        public Page_ID_Student()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            gridControl1.DataSource = dbContext.get_main_cours_student(null);
          //  txt_semecter.DataSource = db.Year.Select(x => x.year_serch).ToList();
          //  txt_student.DataSource = db.students.Select(x => x.name).ToList();

            txt_deprment.DataSource = db.Year.Select(x => x.year_serch).ToList();
           // txt_subject.DataSource = db.main_course.Select(x => x.course_name).ToList();

            //var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            // txt_semecter.DataSource = db.StloadDataPage_getsemster_by_dep(id3);


        }
        private void Add()
        {
            if (txt_student.Text == "")
            {
                MessageBox.Show("الحقل مطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                AddData();
               
            }
        }
        // دالة اضافة
        private void AddData()
        {
            
            //    var id1 = db.Year.Where(x => x.year_serch == txt_semecter.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            //    tbsemster_student.year_id = id1;
                var id2 = db.students.Where(x => x.name == txt_student.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbsemster_student.student_id = id2;
                var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbsemster_student.department_id = id3;
                db.Entry(tbsemster_student).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");

               // MessageBox.Show(id2+"  "+id1+" ");
           //  db.get_main_cours_student_year5(1,2);
          //  MessageBox.Show(db.get_main_cours_student_year5(1, 2)+" ");
            
            for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var b = gridView1.GetRowCellValue(i, "المادة").ToString();
                    var id4 =Convert.ToInt32( db.main_course.Where(x => x.course_name == b).Select(x => x.id).FirstOrDefault());
                 //   db.tbl_insert_semster_student_main_cours(id1,id2, id4);
                      MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
                }

            

        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var id3 = db.students.Where(x => x.name == txt_student.SelectedItem.ToString()).Select(x => x.id)
                .FirstOrDefault();
            gridControl1.DataSource = dbContext.get_main_cours_student(id3);

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
            string day = txt_deprment.SelectedItem.ToString();
            day.ToCharArray();
            MessageBox.Show(day[0].ToString());
            
           
        }

        private void txt_student_Enter(object sender, EventArgs e)
        {
            txt_student.BackColor = Color.Yellow;

        }

        private void txt_student_Leave(object sender, EventArgs e)
        {
            txt_student.BackColor = Color.White;

        }

        private void txt_deprment_Enter(object sender, EventArgs e)
        {
            txt_deprment.BackColor = Color.Yellow;

        }

        private void txt_deprment_Leave(object sender, EventArgs e)
        {
            txt_deprment.BackColor = Color.White;

        }
    }
}
