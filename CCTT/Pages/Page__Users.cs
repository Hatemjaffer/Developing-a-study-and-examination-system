using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCTT.AddPage;
using DevExpress.XtraEditors;

namespace CCTT.Pages
{
    public partial class Page__Users : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        user tbuser = new user();
        public Page__Users()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            //استجلاب البياانات  عن طريق stored pro
            //gridControl1.DataSource = dbContext.users.ToList();

            // تفعيل العلاقة
            // txt_sem_specialty.DataSource = db.department.Select(x => x.name).ToList();

        }

        private void Add()
        {
            if (txt_user_fullname.Text == "")
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

            tbuser.name = txt_user_fullname.Text;
            tbuser.password = txt_user_password.Text;
            // var iddep = db.main_course.Where(x => x.name == txt_sem_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
           // tbuser.password = txt_user_password.Text;


            db.Entry(tbuser).State = System.Data.Entity.EntityState.Added;

            db.SaveChanges();
            MessageBox.Show("تمت الاضافة بنجاح", "اضافة");

        }


        private void btn_role_Click(object sender, EventArgs e)
        {
            Add_user_pwoer page = new Add_user_pwoer();
            page.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void txt_user_fullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_user_role_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_user_fullname_KeyDown(object sender, KeyEventArgs e)
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


        private void txt_user_password_Enter(object sender, EventArgs e)
        {
            txt_user_password.BackColor = Color.Yellow;

        }

        private void txt_user_password_Leave(object sender, EventArgs e)
        {
            txt_user_password.BackColor = Color.White;

        }

       
        private void txt_user_role_Enter(object sender, EventArgs e)
        {
            txt_user_role.BackColor = Color.Yellow;

        }

        private void txt_user_role_Leave(object sender, EventArgs e)
        {
            txt_user_role.BackColor = Color.White;
        }

        private void txt_user_fullname_Enter(object sender, EventArgs e)
        {
            txt_user_fullname.BackColor = Color.Yellow;

        }

        private void txt_user_fullname_Leave(object sender, EventArgs e)
        {
            txt_user_fullname.BackColor = Color.White;

        }
    }
}
