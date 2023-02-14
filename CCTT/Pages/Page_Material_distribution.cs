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

namespace CCTT.Pages
{
   
    public partial class Page_Material_distribution : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        main_course_rel_semster tbmain_course_rel_semster = new main_course_rel_semster();

        public Page_Material_distribution()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
           
            //جلب البيانات من قاعد البيانات بكشل مباشر ولن يطهر في فرد كنترول الا با داتا ست
            gridControl1.DataSource = dbContext.main_course_rel_semster1();

            // جلب للكمبو بكس كلا من المادة والفصل والقسم للحقول
            try
            {
                txt_department.DataSource = db.department.Select(x => x.name).ToList();
                txt_Matter.DataSource = db.main_course.Select(x => x.course_name).ToList();

                var id3 = db.department.Where(x => x.name == txt_department.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                txt_semster.DataSource = db.StloadDataPage_getsemster_by_dep(id3);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           


        }
        // تأكد من المدخلات
        private void Add()
        {
            if (txt_Matter.Text == "" || txt_department.Text == "" || txt_semster.Text=="")
            {
                MessageBox.Show("الحقل مطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            try
            {
                // tbmain_course_rel_semster.name = txt_group_name.Text;

                var id1 = db.Semester.Where(x => x.semester1 == txt_semster.SelectedItem.ToString()).Select(x => x.sem_id).FirstOrDefault();
                tbmain_course_rel_semster.semster_id = id1;

                var id2 = db.main_course.Where(x => x.course_name == txt_Matter.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbmain_course_rel_semster.main_cours_id = id2;

                var id3 = db.department.Where(x => x.name == txt_department.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbmain_course_rel_semster.department_id = id3;

                db.Entry(tbmain_course_rel_semster).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txt_department_TextChanged(object sender, EventArgs e)
        {
            var id3 = db.department.Where(x => x.name == txt_department.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            txt_semster.DataSource = db.StloadDataPage_getsemster_by_dep(id3);

        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
        //--------------------------------------------------------------------Desing
        private void txt_Matter_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_Matter_Enter(object sender, EventArgs e)
        {
            txt_Matter.BackColor = Color.Yellow;

        }

        private void txt_Matter_Leave(object sender, EventArgs e)
        {
            txt_Matter.BackColor = Color.White;

        }

        private void txt_department_Enter(object sender, EventArgs e)
        {
            txt_department.BackColor = Color.Yellow;

        }

        private void txt_department_Leave(object sender, EventArgs e)
        {
            txt_department.BackColor = Color.White;

        }

        private void txt_semster_Enter(object sender, EventArgs e)
        {
            txt_semster.BackColor = Color.Yellow;

        }

        private void txt_semster_Leave(object sender, EventArgs e)
        {
            txt_semster.BackColor = Color.White;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
