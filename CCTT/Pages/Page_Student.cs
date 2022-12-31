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
using CCTT.Pages;
using CCTT.AddPage;
using CCTT.Pages_LinkLable;
namespace CCTT.Pages
{
    public partial class Page_Student : DevExpress.XtraEditors.XtraUserControl
    {
        // جلب قاعدة البيانات وجدول الجنسية
        DB_CCTTEntities db = new DB_CCTTEntities();
        nationality tbNationality = new nationality();
        student tbstudent = new student();

        public Page_Student()
        {
            InitializeComponent();
            Load();
            if (txt_student_id.CanSelect)
            {
                txt_student_id.Select();
            }
        }

        public void Load()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            // Bind data to control when loading complete
            gridControl1.DataSource = dbContext.StloadDataPage_student1();

            txt_student_nationality.DataSource = db.nationality.Select(x => x.nationilty).ToList();
            txt_student_specialty.DataSource = db.department.Select(x => x.name).ToList();

            ActiveControl = txt_student_id;
            txt_student_name.Select();
            txt_student_id.Focus();
        }
        private void Add()
        {
            if (txt_student_name.Text == "")
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

                tbstudent.name = txt_student_name.Text;
                tbstudent.parent_name = txt_student_name_father.Text;

                tbstudent.BOD = txt_student_brithday.Value;
                if (txt_student_nationality.Text != "")
                {
                    var iddep = db.nationality
                        .Where(x => x.nationilty == txt_student_nationality.SelectedItem.ToString()).Select(x => x.id)
                        .FirstOrDefault();
                    tbstudent.nationality = iddep;
            }

            tbstudent.email = txt_student_email.Text;
              
                if (txt_student_nid.Text != "")
                    tbstudent.national_num = Convert.ToInt32(txt_student_nid.Text);
                if (txt_student_phone.Text != "")
                    tbstudent.phone_num =  Convert.ToInt32(txt_student_phone.Text);
                if (txt_student_phonefather.Text != "")
                    tbstudent.parent_phone_num= Convert.ToInt32(txt_student_phonefather.Text);

                //
                   if (txt_student_Certificate_ratio.Text != "")
                tbstudent.certifcate_grade = Convert.ToInt32(txt_student_Certificate_ratio.Text);
                tbstudent.certificate_place_of_origin = txt_student_goodtoget.Text;
                var iddep3 = db.department.Where(x => x.name == txt_student_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbstudent.nationality = iddep3;
                if (txt_student_year_of_enrollment.Text != "")
                    tbstudent.year_of_joining = Convert.ToInt32(txt_student_year_of_enrollment.Text);
                if (txt_student_yeare.Text != "")
                    tbstudent.year_of_graduation = Convert.ToInt32(txt_student_yeare.Text);
                tbstudent.learning_system = txt_student_stadysystem.Text;
                if (txt_student_file_no.Text != "")
                    tbstudent.file_id = Convert.ToInt32(txt_student_file_no.Text);



                //علاش مديرها انتجر في داتا بيز
                if (txt_student_sex.Text == "ذكر")
                    tbstudent.gender = 1;
                if (txt_student_sex.Text == "انثي")
                    tbstudent.gender = 2;
                tbstudent.state_sem = 0;
                db.students.Select(x=>x.id).Max();
                tbstudent.idColge = db.students.Select(x => x.id).Max()+1;
                db.Entry(tbstudent).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void link_nationality_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_britdate page = new Page_britdate(this);
            page.ShowDialog();
        }

        private void link_Adress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_Address page = new Page_Address();
            page.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(db.students.Select(x => x.id).Max().ToString());
          //  db.students.Select(x => x.id).Max();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_Address page = new Page_Address();
            page.ShowDialog();
        }

        private void txt_student_id_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_student_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_nid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_phonefather_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_name_father_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_certificatetype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_Certificate_ratio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_yeare_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_student_id_Enter(object sender, EventArgs e)
        {
            txt_student_id.BackColor = Color.Yellow;

        }

        private void txt_student_id_Leave(object sender, EventArgs e)
        {
            txt_student_id.BackColor = Color.White;

        }

        private void txt_student_name_Enter(object sender, EventArgs e)
        {
            txt_student_name.BackColor = Color.Yellow;

        }

        private void txt_student_name_Leave(object sender, EventArgs e)
        {
            txt_student_name.BackColor = Color.White;

        }

        private void txt_student_sex_Enter(object sender, EventArgs e)
        {
            txt_student_sex.BackColor = Color.Yellow;

        }

        private void txt_student_sex_Leave(object sender, EventArgs e)
        {
            txt_student_sex.BackColor = Color.White;

        }

        private void txt_student_nationality_Enter(object sender, EventArgs e)
        {
            txt_student_nationality.BackColor = Color.Yellow;

        }

        private void txt_student_nationality_Leave(object sender, EventArgs e)
        {
            txt_student_nationality.BackColor = Color.White;

        }

        private void txt_student_placeofbirth_Enter(object sender, EventArgs e)
        {
            txt_student_placeofbirth.BackColor = Color.Yellow;

        }

        private void txt_student_placeofbirth_Leave(object sender, EventArgs e)
        {
            txt_student_placeofbirth.BackColor = Color.White;

        }

        private void txt_student_nid_Enter(object sender, EventArgs e)
        {
            txt_student_nid.BackColor = Color.Yellow;

        }

        private void txt_student_nid_Leave(object sender, EventArgs e)
        {
            txt_student_nid.BackColor = Color.White;

        }

        private void txt_student_phone_Enter(object sender, EventArgs e)
        {
            txt_student_phone.BackColor = Color.Yellow;

        }

        private void txt_student_phone_Leave(object sender, EventArgs e)
        {
            txt_student_phone.BackColor = Color.White;

        }

        private void txt_student_phonefather_Enter(object sender, EventArgs e)
        {
            txt_student_phonefather.BackColor = Color.Yellow;

        }

        private void txt_student_phonefather_Leave(object sender, EventArgs e)
        {
            txt_student_phonefather.BackColor = Color.White;

        }

        private void txt_student_name_father_Enter(object sender, EventArgs e)
        {
            txt_student_name_father.BackColor = Color.Yellow;

        }

        private void txt_student_name_father_Leave(object sender, EventArgs e)
        {
            txt_student_name_father.BackColor = Color.White;

        }

        private void txt_student_address_Enter(object sender, EventArgs e)
        {
            txt_student_address.BackColor = Color.Yellow;

        }

        private void txt_student_address_Leave(object sender, EventArgs e)
        {
            txt_student_address.BackColor = Color.White;

        }

        private void txt_student_certificatetype_Enter(object sender, EventArgs e)
        {
            txt_student_certificatetype.BackColor = Color.Yellow;

        }

        private void txt_student_certificatetype_Leave(object sender, EventArgs e)
        {
            txt_student_certificatetype.BackColor = Color.White;

        }

        private void txt_student_Certificate_ratio_Enter(object sender, EventArgs e)
        {
            txt_student_Certificate_ratio.BackColor = Color.Yellow;

        }

        private void txt_student_Certificate_ratio_Leave(object sender, EventArgs e)
        {
            txt_student_Certificate_ratio.BackColor = Color.White;

        }

        private void txt_student_goodtoget_Enter(object sender, EventArgs e)
        {
            txt_student_goodtoget.BackColor = Color.Yellow;

        }

        private void txt_student_goodtoget_Leave(object sender, EventArgs e)
        {
            txt_student_goodtoget.BackColor = Color.White;

        }

        private void txt_student_specialty_Enter(object sender, EventArgs e)
        {
            txt_student_specialty.BackColor = Color.Yellow;

        }

        private void txt_student_specialty_Leave(object sender, EventArgs e)
        {
            txt_student_specialty.BackColor = Color.White;

        }

        private void txt_student_year_of_enrollment_Enter(object sender, EventArgs e)
        {
            txt_student_year_of_enrollment.BackColor = Color.Yellow;

        }

        private void txt_student_year_of_enrollment_Leave(object sender, EventArgs e)
        {
            txt_student_year_of_enrollment.BackColor = Color.White;

        }

        private void txt_student_semester_Enter(object sender, EventArgs e)
        {
            txt_student_semester.BackColor = Color.Yellow;

        }

        private void txt_student_semester_Leave(object sender, EventArgs e)
        {
            txt_student_semester.BackColor = Color.White;

        }

        private void txt_student_yeare_Enter(object sender, EventArgs e)
        {
            txt_student_yeare.BackColor = Color.Yellow;

        }

        private void txt_student_yeare_Leave(object sender, EventArgs e)
        {
            txt_student_yeare.BackColor = Color.White;

        }

        private void txt_student_stadysystem_Enter(object sender, EventArgs e)
        {
            txt_student_stadysystem.BackColor = Color.Yellow;

        }

        private void txt_student_stadysystem_Leave(object sender, EventArgs e)
        {
            txt_student_stadysystem.BackColor = Color.White;

        }

        private void txt_student_file_no_Enter(object sender, EventArgs e)
        {
            txt_student_file_no.BackColor = Color.Yellow;

        }

        private void txt_student_file_no_Leave(object sender, EventArgs e)
        {
            txt_student_file_no.BackColor = Color.White;

        }

        private void txt_student_email_Enter(object sender, EventArgs e)
        {
            txt_student_email.BackColor = Color.Yellow;

        }

        private void txt_student_email_Leave(object sender, EventArgs e)
        {
            txt_student_email.BackColor = Color.White;

        }

        private void txt_student_stadygroup_Enter(object sender, EventArgs e)
        {
            txt_student_stadygroup.BackColor = Color.Yellow;

        }

        private void txt_student_stadygroup_Leave(object sender, EventArgs e)
        {
            txt_student_stadygroup.BackColor = Color.White;

        }
    }
}
