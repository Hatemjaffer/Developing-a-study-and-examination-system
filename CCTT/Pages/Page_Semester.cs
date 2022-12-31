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
            gridControl1.DataSource = dbContext.StloadDataPage_Semester12().ToList();
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
    }
}
