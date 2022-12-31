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
    public partial class Page__Group : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        study_Group tbstudy_Group = new study_Group();

        public Page__Group()
        {
            InitializeComponent();
            LoadData();
        }


        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            // Bind data to control when loading complete
              gridControl1.DataSource = dbContext.StloadDataPage_study_Group1();

            txt_group_stadyyear.DataSource = db.Year.Select(x => x.year_serch).ToList();

            txt_group_class.DataSource = db.Semester.Select(x => x.semester1).ToList();

            txt_group_department.DataSource = db.department.Select(x => x.name).ToList();

        }

        private void Add()
        {
            if (txt_group_name.Text == "")
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

                tbstudy_Group.name = txt_group_name.Text;
               
                var id1 = db.Year.Where(x => x.year_serch == txt_group_stadyyear.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbstudy_Group.year = id1;
                var id2 = db.Semester.Where(x => x.semester1 == txt_group_class.SelectedItem.ToString()).Select(x => x.sem_id).FirstOrDefault();
                tbstudy_Group.semster = id2;
                var id3 = db.department.Where(x => x.name == txt_group_department.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbstudy_Group.department = id3;

                tbstudy_Group.max_student_count =
                    Convert.ToInt32(txt_group_max_student.Text);
                



                db.Entry(tbstudy_Group).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
private void txt_group_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
        // Deseing
        private void txt_group_code_Enter(object sender, EventArgs e)
        {
            txt_group_code.BackColor = Color.Yellow;

        }

        private void txt_group_code_Leave(object sender, EventArgs e)
        {
            txt_group_code.BackColor = Color.White;

        }

        private void txt_group_name_Enter(object sender, EventArgs e)
        {
            txt_group_name.BackColor = Color.Yellow;

        }

        private void txt_group_name_Leave(object sender, EventArgs e)
        {
            txt_group_name.BackColor = Color.White;

        }

        private void txt_group_stadyyear_Enter(object sender, EventArgs e)
        {
            txt_group_stadyyear.BackColor = Color.Yellow;

        }

        private void txt_group_stadyyear_Leave(object sender, EventArgs e)
        {
            txt_group_stadyyear.BackColor = Color.White;

        }

        private void txt_group_class_Enter(object sender, EventArgs e)
        {
            txt_group_class.BackColor = Color.Yellow;

        }

        private void txt_group_class_Leave(object sender, EventArgs e)
        {
            txt_group_class.BackColor = Color.White;

        }

        private void txt_group_department_Enter(object sender, EventArgs e)
        {
            txt_group_department.BackColor = Color.Yellow;

        }

        private void txt_group_department_Leave(object sender, EventArgs e)
        {
            txt_group_department.BackColor = Color.White;

        }

        private void txt_group_max_student_Enter(object sender, EventArgs e)
        {
            txt_group_max_student.BackColor = Color.Yellow;

        }

        private void txt_group_max_student_Leave(object sender, EventArgs e)
        {
            txt_group_max_student.BackColor = Color.White;

        }
        // Max Student just Nomber
        private void txt_group_max_student_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // كنابه جروف فقط بالمسافة
        private void txt_group_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // tap enter لكل الحقول
        private void txt_group_code_KeyDown(object sender, KeyEventArgs e)
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
