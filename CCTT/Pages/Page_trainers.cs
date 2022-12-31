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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System.Data.Entity;

namespace CCTT.Pages
{
    public partial class Page_trainers : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        Trainer tbTrainer = new Trainer();

        public Page_trainers()
        {
            InitializeComponent();
            LoadData();

            
        }
        // تحميل البيانات في الفورم
        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            dbContext.Trainer.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.StloadDataPage_trainer1();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());



            //تعبئة حقل الجنسية
            txt_trainer_nationality.DataSource = db.nationality.Select(x => x.nationilty).ToList();

            //تعبئة حقل التخصص
            txt_trainer_specialty.DataSource = db.major.Select(x => x.major1).ToList();

            //تعيئة حقل المؤهلات
            txt_trainer_qualifications.DataSource = db.qualification.Select(x => x.qualification1).ToList();

            //تعبئة حقل الدرجة العبمية
            txt_trainer_Degree.DataSource = db.degree.Select(x => x.degree1).ToList();

        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_trainer_fullname.Text == "")
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

                  tbTrainer.name = txt_trainer_fullname.Text;
                  tbTrainer.BOD = txt_trainer_brithday.Value;

                 // tbTrainer.major = txt_trainer_specialty.SelectedItem.ToString();
                var id1 = db.major.Where(x => x.major1 == txt_trainer_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbTrainer.major = id1;
                var id2 = db.qualification.Where(x => x.qualification1 == txt_trainer_qualifications.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

                tbTrainer.qualification = id2;
                var id3 = db.degree.Where(x => x.degree1 == txt_trainer_Degree.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

                tbTrainer.degree = id3;

                tbTrainer.email = txt_trainer_email.Text;
                  if (txt_trainer_phone.Text != "")
                      tbTrainer.phone_num = Convert.ToInt32(txt_trainer_phone.Text);

                  tbTrainer.address = txt_trainer_address.Text;
                  if (txt_trainer_id.Text != "")
                      tbTrainer.national_id = Convert.ToInt32(txt_trainer_id.Text);

                  var iddep = db.nationality.Where(x => x.nationilty == txt_trainer_nationality.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                  tbTrainer.nationality = iddep;


                //علاش مديرها انتجر في داتا بيز
                if(txt_trainer_sex.Text=="ذكر")
                tbTrainer.gender = 1;
                if (txt_trainer_sex.Text == "انثي")
                tbTrainer.gender = 2;



                db.Entry(tbTrainer).State = System.Data.Entity.EntityState.Added;
                  db.SaveChanges();
                  MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
              }
              catch (Exception e)
              {
                  MessageBox.Show(e.Message);
              }
          }

             private void btn_Add_Click(object sender, EventArgs e)
             {
                 Add();

              }







        private void linkLabel_nationality_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_nationality page = new Page_nationality(this);
            page.ShowDialog();
        }

        private void linkLabel_major_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_major pageMajor = new Page_major(this);
            pageMajor.ShowDialog();
        }

        private void linkLabel_qualifications_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_qualification pageQualification = new Page_qualification(this);
            pageQualification.ShowDialog();
        }

        private void linkLabel_Degree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_degree page = new Page_degree(this);
            page.ShowDialog();
        }

        private void txt_trainer_fullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_trainer_sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_trainer_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_trainer_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_trainer_code_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_trainer_code_Enter(object sender, EventArgs e)
        {
            txt_trainer_code.BackColor = Color.Yellow;

        }

        private void txt_trainer_code_Leave(object sender, EventArgs e)
        {
            txt_trainer_code.BackColor = Color.White;

        }

        private void txt_trainer_fullname_Enter(object sender, EventArgs e)
        {
            txt_trainer_fullname.BackColor = Color.Yellow;

        }

        private void txt_trainer_fullname_Leave(object sender, EventArgs e)
        {
            txt_trainer_fullname.BackColor = Color.White;

        }

        private void txt_trainer_brithday_Enter(object sender, EventArgs e)
        {
            txt_trainer_brithday.BackColor = Color.Yellow;

        }

        private void txt_trainer_brithday_Leave(object sender, EventArgs e)
        {
            txt_trainer_brithday.BackColor = Color.White;

        }

        private void txt_trainer_sex_Enter(object sender, EventArgs e)
        {
            txt_trainer_sex.BackColor = Color.Yellow;

        }

        private void txt_trainer_sex_Leave(object sender, EventArgs e)
        {
            txt_trainer_sex.BackColor = Color.White;

        }

        private void txt_trainer_nationality_Enter(object sender, EventArgs e)
        {
            txt_trainer_nationality.BackColor = Color.Yellow;

        }

        private void txt_trainer_nationality_Leave(object sender, EventArgs e)
        {
            txt_trainer_nationality.BackColor = Color.White;

        }

        private void txt_trainer_id_Enter(object sender, EventArgs e)
        {
            txt_trainer_id.BackColor = Color.Yellow;

        }

        private void txt_trainer_id_Leave(object sender, EventArgs e)
        {
            txt_trainer_id.BackColor = Color.White;

        }

        private void txt_trainer_phone_Enter(object sender, EventArgs e)
        {
            txt_trainer_phone.BackColor = Color.Yellow;

        }

        private void txt_trainer_phone_Leave(object sender, EventArgs e)
        {
            txt_trainer_phone.BackColor = Color.White;

        }

        private void txt_trainer_address_Enter(object sender, EventArgs e)
        {
            txt_trainer_address.BackColor = Color.Yellow;

        }

        private void txt_trainer_address_Leave(object sender, EventArgs e)
        {
            txt_trainer_address.BackColor = Color.White;

        }

        private void txt_trainer_specialty_Enter(object sender, EventArgs e)
        {
            txt_trainer_specialty.BackColor = Color.Yellow;

        }

        private void txt_trainer_specialty_Leave(object sender, EventArgs e)
        {
            txt_trainer_specialty.BackColor = Color.White;

        }

        private void txt_trainer_Degree_Enter(object sender, EventArgs e)
        {
            txt_trainer_Degree.BackColor = Color.Yellow;

        }

        private void txt_trainer_Degree_Leave(object sender, EventArgs e)
        {
            txt_trainer_Degree.BackColor = Color.White;

        }

        private void txt_trainer_qualifications_Enter(object sender, EventArgs e)
        {
            txt_trainer_qualifications.BackColor = Color.Yellow;

        }

        private void txt_trainer_qualifications_Leave(object sender, EventArgs e)
        {
            txt_trainer_qualifications.BackColor = Color.White;

        }

        private void txt_trainer_email_Enter(object sender, EventArgs e)
        {
            txt_trainer_email.BackColor = Color.Yellow;

        }

        private void txt_trainer_email_Leave(object sender, EventArgs e)
        {
            txt_trainer_email.BackColor = Color.White;

        }
    }
}
