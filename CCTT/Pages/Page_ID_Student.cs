using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
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
       student tbstudent = new student();

        CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();

        public Page_ID_Student()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            //gridControl1.DataSource = dbContext.get_main_cours_student(null);
          //  txt_semecter.DataSource = db.Year.Select(x => x.year_serch).ToList();
          //  txt_student.DataSource = db.students.Select(x => x.name).ToList();

           txt_year.DataSource = db.Year.Select(x => x.year_serch).ToList();
           // txt_subject.DataSource = db.main_course.Select(x => x.course_name).ToList();

            //var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            // txt_semecter.DataSource = db.StloadDataPage_getsemster_by_dep(id3);


        }
        private void Add()
        {
            if (txt_year.Text == "")
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
 
           var id1 = db.Year.Where(x => x.year_serch == txt_year.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
           
              for (int i = 0; i < gridView1.DataRowCount; i++)
              {
                 // var b = gridView1.GetRowCellValue(i, "المادة").ToString();

                int b = Convert.ToInt32(gridView1.GetRowCellValue(i,"الرقم").ToString());
                  db.idCollgeinsert(b, id1);
              }


              
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            /*var id3 = db.students.Where(x => x.name == txt_student.SelectedItem.ToString()).Select(x => x.id)
                .FirstOrDefault();
            gridControl1.DataSource = dbContext.get_main_cours_student(id3);*/
            gridControl1.DataSource = student_idcollgeTableAdapter.GetData();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        { 
              Add();
        

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        

        private void txt_student_Enter(object sender, EventArgs e)
        {
           // txt_student.BackColor = Color.Yellow;

        }

        private void txt_student_Leave(object sender, EventArgs e)
        {
          //  txt_student.BackColor = Color.White;

        }

        private void txt_deprment_Enter(object sender, EventArgs e)
        {
            txt_year.BackColor = Color.Yellow;

        }

        private void txt_deprment_Leave(object sender, EventArgs e)
        {
            txt_year.BackColor = Color.White;

        }

        private void btn_edt_click_Click(object sender, EventArgs e)
        {
           // AddData();
            Add();
        }
    }
}
