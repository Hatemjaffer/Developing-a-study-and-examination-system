using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using CCTT.Pages;

namespace CCTT.Pages_LinkLable
{
    public partial class Page_nationality : DevExpress.XtraEditors.XtraForm
    {
        // جلب قاعدة البيانات وجدول الجنسية
        DB_CCTTEntities db = new DB_CCTTEntities();
        nationality tbNationality = new nationality();

        Page_Student page_Studen = new Page_Student();
        Page_Teacher page_Teacher = new Page_Teacher();
        Page_trainers page_trainers = new Page_trainers();

        int ID;
        public Page_nationality(Page_Student page_Studen1)
        {
            InitializeComponent();
            LoadData();
            page_Studen = page_Studen1;
        }
        public Page_nationality(Page_Teacher page_Teacher1)
        {
            InitializeComponent();
            LoadData();
            page_Teacher = page_Teacher1;
        }
        public Page_nationality(Page_trainers page_trainers1)
        {
            InitializeComponent();
            LoadData();
            page_trainers = page_trainers1;
        }

        public void LoadData()
        {
            // Instantiate a new DBContext
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
         
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.getnationality();
                txt_nationality.Select();
        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_nationality.Text == "")
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
                db = new DB_CCTTEntities();
                tbNationality = new nationality();

                tbNationality.nationilty = txt_nationality.Text;
                db.Entry(tbNationality).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        //اضافة
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        // تعديل
        private void btn_edt_click_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                if (ID > 0)
                {
                    tbNationality = db.nationality.Where(x => x.id == ID).FirstOrDefault();
                    tbNationality.id = ID;
                    tbNationality.nationilty = txt_nationality.Text;

                    db.Entry(tbNationality).State = EntityState.Modified;
                    // db.Set<TB_Student>().AddOrUpdate(tb);
                    db.SaveChanges();
                    MessageBox.Show("تم تعديل البيانات بالنجاح", "عملية تعديل", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }


            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // حدف
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لايمكن استرجاع البيانات", "اجراء حدف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                
                try
                {
                    ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                    if (ID > 0)
                    {
                        db = new DB_CCTTEntities();
                        tbNationality = db.nationality.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbNationality).State = EntityState.Deleted;
                        db.SaveChanges();

                        LoadData(); 
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحدفها");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //UpDate
        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //لجلب الحقول من جدول الي مربع النص
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txt_nationality.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nationilty").ToString();
        }

        // مدخل في الحقل ارقام فقط
        private void txt_nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Page_nationality_FormClosed(object sender, FormClosedEventArgs e)
        {
            page_Studen.txt_student_nationality.DataSource = db.nationality.Select(x => x.nationilty).ToList();
            page_Teacher.txt_teacher_nationality.DataSource = db.nationality.Select(x => x.nationilty).ToList();
            page_trainers.txt_trainer_specialty.DataSource = db.nationality.Select(x => x.nationilty).ToList();
            page_Teacher.txt_teacher_nationality.DataSource = db.nationality.Select(x => x.nationilty).ToList();


        }

        private void txt_nationality_Enter(object sender, EventArgs e)
        {
            txt_nationality.BackColor = Color.Yellow;

        }

        private void txt_nationality_Leave(object sender, EventArgs e)
        {
            txt_nationality.BackColor = Color.White;

        }
    }
}