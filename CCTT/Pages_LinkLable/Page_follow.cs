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
    public partial class Page_follow : DevExpress.XtraEditors.XtraForm
    {
        // جلب قاعدة البيانات وجدول الجنسية
        DB_CCTTEntities db = new DB_CCTTEntities();
        affiliated_entity tbaffiliated_entity = new affiliated_entity();

       // Page_Student page_Studen = new Page_Student();
      //  Page_trainers page_trainers = new Page_trainers();
       Page_CourseStudents page = new Page_CourseStudents();

        int ID;
        public Page_follow(Page_CourseStudents pageCourseStudents)
        {
            InitializeComponent();
            LoadData();
            page = pageCourseStudents;
        }


        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            dbContext.affiliated_entity.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.affiliated_entity.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            txt_follow.Select();
        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_follow.Text == "")
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
                
                tbaffiliated_entity.affiliated_entity_name = txt_follow.Text;
                db.Entry(tbaffiliated_entity).State = System.Data.Entity.EntityState.Added;
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
                    tbaffiliated_entity = db.affiliated_entity.Where(x => x.id == ID).FirstOrDefault();
                    tbaffiliated_entity.id = ID;
                    tbaffiliated_entity.affiliated_entity_name = txt_follow.Text;

                    db.Entry(tbaffiliated_entity).State = EntityState.Modified;
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
                        tbaffiliated_entity = db.affiliated_entity.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbaffiliated_entity).State = EntityState.Deleted;
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
            txt_follow.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "follow_name").ToString();

        }
        
        private void Page_major_FormClosed(object sender, FormClosedEventArgs e)
        {
            page.txt_coursestudent_follow.DataSource = db.affiliated_entity.Select(x => x.affiliated_entity_name).ToList();

        }
        // مدخل في الحقل حروف فقط
        private void txt_follow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_follow_Enter(object sender, EventArgs e)
        {
            txt_follow.BackColor = Color.LightYellow;
        }

        private void txt_follow_Leave(object sender, EventArgs e)
        {
            txt_follow.BackColor = Color.White;
        }

        private void txt_follow_KeyDown(object sender, KeyEventArgs e)
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