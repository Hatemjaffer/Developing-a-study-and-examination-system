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

namespace CCTT.Pages
{
    public partial class Page_Subject : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        main_course tbmain_course = new main_course();
        int ID;
        public Page_Subject()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            //استجلاب البياانات  عن طريق stored pro
            gridControl1.DataSource = dbContext.main_course.ToList();
            
            // تفعيل العلاقة
            // txt_sem_specialty.DataSource = db.department.Select(x => x.name).ToList();

        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_sub_articlecode.Text == "")
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

            tbmain_course.course_name = txt_sub_articlename.Text;
            tbmain_course.code_id = txt_sub_articlecode.Text;
            // var iddep = db.main_course.Where(x => x.name == txt_sem_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            if (txt_sub_numberofunits.Text != "")
                tbmain_course.units = Convert.ToInt32(txt_sub_numberofunits.Text);
            if (txt_sub_houre.Text != "")
                tbmain_course.hours = Convert.ToInt32(txt_sub_houre.Text);
            
            if (txt_sub_material_type.Text == "نظري")
                tbmain_course.type = 1;
            if (txt_sub_material_type.Text == "عملي+نظري")
                tbmain_course.type = 2;

            
            db.Entry(tbmain_course).State = System.Data.Entity.EntityState.Added;

            db.SaveChanges();
            MessageBox.Show("تمت الاضافة بنجاح", "اضافة");

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Page_Subject_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_sub_articlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sub_numberofunits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sub_reliability_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sub_substitutefor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sub_articlecode_Enter(object sender, EventArgs e)
        {
            txt_sub_articlecode.BackColor = Color.Yellow;

        }

        private void txt_sub_articlecode_Leave(object sender, EventArgs e)
        {
            txt_sub_articlecode.BackColor = Color.White;

        }

        private void txt_sub_articlename_Enter(object sender, EventArgs e)
        {
            txt_sub_articlename.BackColor = Color.Yellow;

        }

        private void txt_sub_articlename_Leave(object sender, EventArgs e)
        {
            txt_sub_articlename.BackColor = Color.White;

        }

        private void txt_sub_numberofunits_Enter(object sender, EventArgs e)
        {
            txt_sub_numberofunits.BackColor = Color.Yellow;

        }

        private void txt_sub_numberofunits_Leave(object sender, EventArgs e)
        {
            txt_sub_numberofunits.BackColor = Color.White;

        }

        private void txt_sub_houre_Enter(object sender, EventArgs e)
        {
            txt_sub_houre.BackColor = Color.Yellow;

        }

        private void txt_sub_houre_Leave(object sender, EventArgs e)
        {
            txt_sub_houre.BackColor = Color.White;

        }

        private void txt_sub_reliability_Enter(object sender, EventArgs e)
        {
            txt_sub_reliability.BackColor = Color.Yellow;

        }

        private void txt_sub_reliability_Leave(object sender, EventArgs e)
        {
            txt_sub_reliability.BackColor = Color.White;

        }

        private void txt_sub_substitutefor_Enter(object sender, EventArgs e)
        {
            txt_sub_substitutefor.BackColor = Color.Yellow;

        }

        private void txt_sub_substitutefor_Leave(object sender, EventArgs e)
        {
            txt_sub_substitutefor.BackColor = Color.White;

        }

        private void txt_sub_material_type_Enter(object sender, EventArgs e)
        {
            txt_sub_material_type.BackColor = Color.Yellow;

        }

        private void txt_sub_material_type_Leave(object sender, EventArgs e)
        {
            txt_sub_material_type.BackColor = Color.White;

        }
    }
}
