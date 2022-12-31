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
using DevExpress.XtraEditors.Controls;

namespace CCTT.Pages
{
    public partial class Page__Course : DevExpress.XtraEditors.XtraUserControl
    {
        private extra_Course tbextra_Course = new extra_Course();
        private DB_CCTTEntities db = new DB_CCTTEntities();

        public Page__Course()
        {
            InitializeComponent();
        }
        private void Add()
        {
            if (txt_course_name.Text == "")
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

                tbextra_Course.course_name = txt_course_name.Text;

                tbextra_Course.course_information = txt_course_information.Text;
                tbextra_Course.price = Convert.ToInt32(txt_coures_pries.Text);
                
               // tbextra_Course.Email = txt_coursestudent_email.Text;

                if (txt_course_trainers.Text != "")
                {
                    var iddep = db.Trainer
                        .Where(x => x.name == txt_course_trainers.SelectedItem.ToString()).Select(x => x.id)
                        .FirstOrDefault();
                    tbextra_Course.trainer_id = iddep;
                }
                tbextra_Course.max_student_count = Convert.ToInt32(txt_course_max_student.Text);
                tbextra_Course.start_date = txt_stratdate.Value;
                string day = "";
                for (int i = 0; i < 3; i++)
                    if (checkedComboBoxEdit1.Properties.Items[i].CheckState == CheckState.Checked)
                        day += "1";
                    else
                        day += "0";

                tbextra_Course.days = day;
                
                db.Entry(tbextra_Course).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Page__Course_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           /*
            string day="101";
            day.ToCharArray() ;
            for (int i = 0; i < 3; i++)
                if (day[i].ToString().Equals("1"))
               checkedComboBoxEdit1.Properties.Items[i].CheckState = CheckState.Checked;
       */
    }
        // كود ضغط علي انتر لكل الحقول
        private void Page__Course_KeyDown(object sender, KeyEventArgs e)
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
         // 
        private void txt_course_code_Enter(object sender, EventArgs e)
        {
            txt_course_code.BackColor = Color.Yellow;

        }

        private void txt_course_code_Leave(object sender, EventArgs e)
        {
            txt_course_code.BackColor = Color.White;

        }

        private void txt_course_name_Enter(object sender, EventArgs e)
        {
            txt_course_name.BackColor = Color.Yellow;

        }

        private void txt_course_name_Leave(object sender, EventArgs e)
        {
            txt_course_name.BackColor = Color.White;

        }

        private void txt_course_information_Enter(object sender, EventArgs e)
        {
            txt_course_information.BackColor = Color.Yellow;

        }

        private void txt_course_information_Leave(object sender, EventArgs e)
        {
            txt_course_information.BackColor = Color.White;

        }

        private void txt_coures_pries_Enter(object sender, EventArgs e)
        {
            txt_coures_pries.BackColor = Color.Yellow;

        }

        private void txt_coures_pries_Leave(object sender, EventArgs e)
        {
            txt_coures_pries.BackColor = Color.White;

        }

        private void txt_course_trainers_Enter(object sender, EventArgs e)
        {
            txt_course_trainers.BackColor = Color.Yellow;

        }

        private void txt_course_trainers_Leave(object sender, EventArgs e)
        {
            txt_course_trainers.BackColor = Color.White;

        }

        private void txt_course_max_student_Enter(object sender, EventArgs e)
        {
            txt_course_max_student.BackColor = Color.Yellow;

        }

        private void txt_course_max_student_Leave(object sender, EventArgs e)
        {
            txt_course_max_student.BackColor = Color.White;

        }

        private void txt_course_houres_Enter(object sender, EventArgs e)
        {
            txt_course_houres.BackColor = Color.Yellow;

        }

        private void txt_course_houres_Leave(object sender, EventArgs e)
        {
            txt_course_houres.BackColor = Color.White;

        }

        private void checkedComboBoxEdit1_Enter(object sender, EventArgs e)
        {
            checkedComboBoxEdit1.BackColor = Color.Yellow;

        }

        private void checkedComboBoxEdit1_Leave(object sender, EventArgs e)
        {
            checkedComboBoxEdit1.BackColor = Color.White;

        }

        private void txt_course_state_Enter(object sender, EventArgs e)
        {
            txt_course_state.BackColor = Color.Yellow;

        }

        private void txt_course_state_Leave(object sender, EventArgs e)
        {
            txt_course_state.BackColor = Color.White;

        }
        // Pries Just Nomber
        private void txt_coures_pries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Pries Just Nomber
        private void txt_course_max_student_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
