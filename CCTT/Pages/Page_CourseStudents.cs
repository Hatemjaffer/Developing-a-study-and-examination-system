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
using CCTT.Pages_LinkLable;

namespace CCTT.Pages
{
    public partial class Page_CourseStudents : DevExpress.XtraEditors.XtraUserControl
    {
        private DB_CCTTEntities db = new DB_CCTTEntities();
        course_student tbcourse_student = new course_student();

        public Page_CourseStudents()
        {
            InitializeComponent();
            LoadData();

        }


        public void LoadData()
        {
            //تعبئة حقل جيهة التابع لها
            txt_coursestudent_follow.DataSource = db.affiliated_entity.Select(x => x.affiliated_entity_name).ToList();

        }
        private void Add()
        {
            if (txt_coursestudent_fullname.Text == "")
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
            try
            {

                tbcourse_student.Name = txt_coursestudent_fullname.Text;
              
                tbcourse_student.BOD = txt_coursestudent_brithdayy.Value;
                tbcourse_student.Email = txt_coursestudent_email.Text;

                if (txt_coursestudent_follow.Text != "")
                {
                    var iddep = db.affiliated_entity
                        .Where(x => x.affiliated_entity_name == txt_coursestudent_follow.SelectedItem.ToString()).Select(x => x.id)
                        .FirstOrDefault();
                    tbcourse_student.affiliate_id = iddep;
                }

              
                if (txt_coursestudent_studentcode.Text != "")
                    tbcourse_student.national_id = Convert.ToInt32(txt_coursestudent_studentcode.Text);
                if (txt_coursestudent_phone.Text != "")
                    tbcourse_student.phone_num = Convert.ToInt32(txt_coursestudent_phone.Text);
              
                db.Entry(tbcourse_student).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void linkLabel_follow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_follow pageFollow = new Page_follow(this);
            pageFollow.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void txt_coursestudent_studentcode_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_coursestudent_fullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_couresstudent__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_coursestudent_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_coursestudent_studentcode_Enter(object sender, EventArgs e)
        {
            txt_coursestudent_studentcode.BackColor = Color.Yellow;

        }

        private void txt_coursestudent_studentcode_Leave(object sender, EventArgs e)
        {
            txt_coursestudent_studentcode.BackColor = Color.White;

        }

        private void txt_coursestudent_fullname_Enter(object sender, EventArgs e)
        {
            txt_coursestudent_fullname.BackColor = Color.Yellow;

        }

        private void txt_coursestudent_fullname_Leave(object sender, EventArgs e)
        {
            txt_coursestudent_fullname.BackColor = Color.White;

        }

        private void txt_coursestudent_brithdayy_Enter(object sender, EventArgs e)
        {
            txt_coursestudent_brithdayy.BackColor = Color.Yellow;

        }

        private void txt_coursestudent_brithdayy_Leave(object sender, EventArgs e)
        {
            txt_coursestudent_brithdayy.BackColor = Color.White;

        }

        private void txt_coursestudent_follow_Enter(object sender, EventArgs e)
        {
            txt_coursestudent_follow.BackColor = Color.Yellow;
        }

        private void txt_coursestudent_follow_Leave(object sender, EventArgs e)
        {
            txt_coursestudent_follow.BackColor = Color.White;

        }

        private void txt_coursestudent_follow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_couresstudent__Enter(object sender, EventArgs e)
        {
            txt_couresstudent_.BackColor = Color.Yellow;

        }

        private void txt_couresstudent__Leave(object sender, EventArgs e)
        {
            txt_couresstudent_.BackColor = Color.White;

        }

        private void txt_coursestudent_phone_Enter(object sender, EventArgs e)
        {
            txt_coursestudent_phone.BackColor = Color.Yellow;

        }

        private void txt_coursestudent_phone_Leave(object sender, EventArgs e)
        {
            txt_coursestudent_phone.BackColor = Color.White;

        }

        private void txt_coursestudent_email_Enter(object sender, EventArgs e)
        {
            txt_coursestudent_email.BackColor = Color.Yellow;

        }

        private void txt_coursestudent_email_Leave(object sender, EventArgs e)
        {
            txt_coursestudent_email.BackColor = Color.White;

        }
    }
}
