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
    public partial class Page_Teacher : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        Faculty_member tbFaculty_member = new Faculty_member();

        public Page_Teacher()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
               // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.StloadDataPage_Faculty_member31();

                //تعبئة حقل الجنسية
            txt_teacher_nationality.DataSource = db.nationality.Select(x => x.nationilty).ToList();

            //تعبئة حقل التخصص
            txt_teacher_specialty.DataSource = db.major.Select(x => x.major1).ToList();

            //تعيئة حقل المؤهلات
            txt_teacher_qualification.DataSource = db.qualification.Select(x => x.qualification1).ToList();

            //تعبئة حقل الدرجة العبمية
            txt_teacher_degree.DataSource = db.degree.Select(x => x.degree1).ToList();

        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_teacher_fullname.Text == "")
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

                tbFaculty_member.name = txt_teacher_fullname.Text;
                tbFaculty_member.BOD = txt_teacher_birth.Value;
                tbFaculty_member.start_work_Date = txt_teacher_stratdate.Value;

                var id1 = db.major.Where(x => x.major1 == txt_teacher_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbFaculty_member.Major = id1;
                var id2 = db.qualification.Where(x => x.qualification1 == txt_teacher_qualification.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbFaculty_member.qualification = id2;
                var id3 = db.degree.Where(x => x.degree1 == txt_teacher_degree.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbFaculty_member.degree = id3;
                tbFaculty_member.email = txt_teacher_email.Text;
                if (txt_teacher_phone.Text != "")
                 tbFaculty_member.phone_num = Convert.ToInt32(txt_teacher_phone.Text);

                tbFaculty_member.address = txt_teacher_address.Text;
                if (txt_teacher_ceritificate_no.Text != "")
                    tbFaculty_member.National_id = Convert.ToInt32(txt_teacher_ceritificate_no.Text);
                if (txt_teacher_job_number.Text != "")
                    tbFaculty_member.job_id = Convert.ToInt32(txt_teacher_job_number.Text);

                //tbFaculty_member.graduation_date = txt_teacher_graduation_year.Text;
                tbFaculty_member.certificate_place_of_origin = txt_teacher_destination.Text;
                tbFaculty_member.passport_id = txt_teacher_passport_number.Text;
                tbFaculty_member.personal_id = txt_teacher_card_number.Text;

                var iddep = db.nationality.Where(x => x.nationilty == txt_teacher_nationality.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbFaculty_member.nationality = iddep;


                //علاش مديرها انتجر في داتا بيز
                if (txt_teacher_sex.Text == "ذكر")
                    tbFaculty_member.gender = 1;
                if (txt_teacher_sex.Text == "انثي")
                    tbFaculty_member.gender = 2;

                if (txt_teacher_marital_status.Text == "متزوج")
                    tbFaculty_member.martial_status = 1;
                if (txt_teacher_marital_status.Text == "اعزب")
                    tbFaculty_member.martial_status = 2;



                db.Entry(tbFaculty_member).State = System.Data.Entity.EntityState.Added;
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
            Page_nationality page = new Page_nationality(this);
           page.ShowDialog();
        }

        private void link_Address_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_Address page = new Page_Address();
            page.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_darge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          //  Page_degree page = new Page_degree();
           // page.ShowDialog();
        }

        private void txt_teacher_fullname_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_teacher_fullname_Enter(object sender, EventArgs e)
        {
            txt_teacher_fullname.BackColor = Color.Yellow;

        }

        private void txt_teacher_fullname_Leave(object sender, EventArgs e)
        {
            txt_teacher_fullname.BackColor = Color.White;

        }

        private void txt_teacher_job_number_Enter(object sender, EventArgs e)
        {
            txt_teacher_job_number.BackColor = Color.Yellow;

        }

        private void txt_teacher_job_number_Leave(object sender, EventArgs e)
        {
            txt_teacher_job_number.BackColor = Color.White;

        }

        private void txt_teacher_address_Enter(object sender, EventArgs e)
        {
            txt_teacher_address.BackColor = Color.Yellow;

        }

        private void txt_teacher_address_Leave(object sender, EventArgs e)
        {
            txt_teacher_address.BackColor = Color.White;

        }

        private void txt_teacher_phone_Enter(object sender, EventArgs e)
        {
            txt_teacher_phone.BackColor = Color.Yellow;

        }

        private void txt_teacher_phone_Leave(object sender, EventArgs e)
        {
            txt_teacher_phone.BackColor = Color.White;

        }

        private void txt_teacher_passport_number_Enter(object sender, EventArgs e)
        {
            txt_teacher_passport_number.BackColor = Color.Yellow;

        }

        private void txt_teacher_passport_number_Leave(object sender, EventArgs e)
        {
            txt_teacher_passport_number.BackColor = Color.White;

        }

        private void txt_teacher_card_number_Enter(object sender, EventArgs e)
        {
            txt_teacher_card_number.BackColor = Color.Yellow;

        }

        private void txt_teacher_card_number_Leave(object sender, EventArgs e)
        {
            txt_teacher_card_number.BackColor = Color.White;

        }

        private void txt_teacher_ceritificate_no_Enter(object sender, EventArgs e)
        {
            txt_teacher_ceritificate_no.BackColor = Color.Yellow;

        }

        private void txt_teacher_ceritificate_no_Leave(object sender, EventArgs e)
        {
            txt_teacher_ceritificate_no.BackColor = Color.White;

        }

        private void txt_teacher_nationality_Enter(object sender, EventArgs e)
        {
            txt_teacher_nationality.BackColor = Color.Yellow;

        }

        private void txt_teacher_nationality_Leave(object sender, EventArgs e)
        {
            txt_teacher_nationality.BackColor = Color.White;

        }

        private void txt_teacher_sex_Enter(object sender, EventArgs e)
        {
            txt_teacher_sex.BackColor = Color.Yellow;

        }

        private void txt_teacher_sex_Leave(object sender, EventArgs e)
        {
            txt_teacher_sex.BackColor = Color.White;

        }

        private void txt_teacher_qualification_Enter(object sender, EventArgs e)
        {
            txt_teacher_qualification.BackColor = Color.Yellow;

        }

        private void txt_teacher_qualification_Leave(object sender, EventArgs e)
        {
            txt_teacher_qualification.BackColor = Color.White;

        }

        private void txt_teacher_degree_Enter(object sender, EventArgs e)
        {
            txt_teacher_degree.BackColor = Color.Yellow;

        }

        private void txt_teacher_degree_Leave(object sender, EventArgs e)
        {
            txt_teacher_degree.BackColor = Color.White;

        }

        private void txt_teacher_graduation_year_Enter(object sender, EventArgs e)
        {
            txt_teacher_graduation_year.BackColor = Color.Yellow;

        }

        private void txt_teacher_graduation_year_Leave(object sender, EventArgs e)
        {
            txt_teacher_graduation_year.BackColor = Color.White;

        }

        private void txt_teacher_specialty_Enter(object sender, EventArgs e)
        {
            txt_teacher_specialty.BackColor = Color.Yellow;

        }

        private void txt_teacher_specialty_Leave(object sender, EventArgs e)
        {
            txt_teacher_specialty.BackColor = Color.White;

        }

        private void txt_teacher_destination_Enter(object sender, EventArgs e)
        {
            txt_teacher_destination.BackColor = Color.Yellow;

        }

        private void txt_teacher_destination_Leave(object sender, EventArgs e)
        {
            txt_teacher_destination.BackColor = Color.White;

        }

        private void txt_teacher_email_Enter(object sender, EventArgs e)
        {
            txt_teacher_email.BackColor = Color.Yellow;

        }

        private void txt_teacher_email_Leave(object sender, EventArgs e)
        {
            txt_teacher_email.BackColor = Color.White;

        }

        private void txt_teacher_marital_status_Enter(object sender, EventArgs e)
        {
            txt_teacher_marital_status.BackColor = Color.Yellow;

        }

        private void txt_teacher_marital_status_Leave(object sender, EventArgs e)
        {
            txt_teacher_marital_status.BackColor = Color.White;

        }
    }
}
