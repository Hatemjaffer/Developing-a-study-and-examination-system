using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CCTT.DB_CCTTDataSet1TableAdapters;
using CCTT.DB_CCTTDataSet2TableAdapters;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.DataAccess.EntityFramework;
using DevExpress.XtraReports.UI;

namespace CCTT.Pages
{
    public partial class Page_Semester : DevExpress.XtraEditors.XtraUserControl
    {
        // جلب قاعدة البيانات وجدول الاقسام
        DB_CCTTEntities db = new DB_CCTTEntities();
        Semester tbSemester = new Semester();
        private department tbDepartment = new department();
        int ID;
        public Page_Semester()
        {
            InitializeComponent();
            LoadData();
           

        }

        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            //استجلاب البياانات  عن طريق stored pro 
         //   gridControl1.DataSource = get_main_cours_student_grade3TableAdapter.GetData(yearId, coursId);

            gridControl1.DataSource = stloadDataPage_Semester12TableAdapter.GetData();
            // تفعيل العلاقة
             txt_sem_specialty.DataSource = db.department.Select(x => x.name).ToList();
             nameClass.DataSource = db.num_semster.Select(x => x.name_sem).ToList();

        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (nameClass.Text == "" )
            {
                MessageBox.Show("الحقلول مطلوبة ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                AddData();
                LoadData();
            }
        }
        // دالة اضافة
        private void AddData()
        {
            var iddep1 = db.num_semster.Where(x => x.name_sem == nameClass.SelectedItem.ToString()).Select(x => x.id_num_semster).FirstOrDefault();
            tbSemester.id_num_semster_r = iddep1;

            tbSemester.semester1 = nameClass.SelectedItem.ToString();
           // tbSemester.sem_id = 10;

            var iddep = db.department.Where(x => x.name == txt_sem_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                 tbSemester.id = iddep;

                 db.Entry(tbSemester).State = System.Data.Entity.EntityState.Added;

                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
          
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void txt_sem_codeclass_Enter(object sender, EventArgs e)
        {
            txt_sem_codeclass.BackColor = Color.Yellow;

        }

        private void txt_sem_codeclass_Leave(object sender, EventArgs e)
        {
            txt_sem_codeclass.BackColor = Color.White;

        }

        private void nameClass_Enter(object sender, EventArgs e)
        {
            nameClass.BackColor = Color.Yellow;

        }

        private void nameClass_Leave(object sender, EventArgs e)
        {
            nameClass.BackColor = Color.White;

        }

        private void txt_sem_specialty_Enter(object sender, EventArgs e)
        {
            txt_sem_specialty.BackColor = Color.Yellow;

        }

        private void txt_sem_specialty_Leave(object sender, EventArgs e)
        {
            txt_sem_specialty.BackColor = Color.White;

        }

        private void txt_sem_codeclass_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_print_Click(object sender, EventArgs e)
        {
            Reports.XtraReport5 x1 = new Reports.XtraReport5();
            //  var id4 = Convert.ToInt32(txt_student.SelectedItem.ToString());
            //  var id1 = db.Year.Where(x => x.year_serch == txt_semecter.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            //   get_main_cours_student_reportTableAdapter m = new get_main_cours_student_reportTableAdapter();
            //  m.Fill(new DB_CCTTDataSet2.get_main_cours_student_reportDataTable(), id3, id1);
           // semster_student s = new semster_student();
          //  getSemTableAdapter m = new getSemTableAdapter();
            getTestTableAdapter h = new getTestTableAdapter();

            //  h.Fill(new DB_CCTTDataSet1.getTestDataTable(), 53);
            //  h.GetData(53);
            EFDataSource d = new EFDataSource();
            
           //  x1.DataSource = EFDataSource;
           // x1.DataSource = db.semster_student.Where(x => x.student_id == 53);
            ;


            //   x1.DataSource = h.GetData(53);
            //  x1.DataSource=s.
            x1.ShowPreview();

            //gridControl1.ShowPrintPreview();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_edt_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                if (ID > 0)
                {

                    tbDepartment = db.department.Where(x => x.id == ID).FirstOrDefault();
                    tbDepartment.id = ID;

                    //tbDepartment.name = txt_dep_departmentname.Text;
                    //tbDepartment.department_details = txt_departmentname_description.Text;

                    db.Entry(tbDepartment).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("تم تعديل البيانات بالنجاح", "عملية تعديل", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }


            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لايمكن استرجاع البيانات", "اجراء حدف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {

                try
                {
                    ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                    if (ID > 0)
                    {
                        db = new DB_CCTTEntities();
                        tbDepartment = db.department.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbDepartment).State = EntityState.Deleted;
                        db.SaveChanges();

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحدفها");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
