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
    public partial class Page_degree : DevExpress.XtraEditors.XtraForm
    {
        // جلب قاعدة البيانات وجدول الجنسية
        DB_CCTTEntities db = new DB_CCTTEntities();
        degree tbdDegree = new degree();

        //Page_Student page_Studen = new Page_Student();
        Page_trainers page_trainers = new Page_trainers();

        int ID;
        public Page_degree(Page_trainers page_trainers1)
        {
            InitializeComponent();
            LoadData();
            page_trainers = page_trainers1;
           
           
        }


        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            dbContext.degree.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.degree.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            txt_degree.Select();
        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_degree.Text == "")
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
                tbdDegree = new degree();

                tbdDegree.degree1 = txt_degree.Text;
                db.Entry(tbdDegree).State = System.Data.Entity.EntityState.Added;
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
                    tbdDegree = db.degree.Where(x => x.id == ID).FirstOrDefault();
                    tbdDegree.id = ID;
                    tbdDegree.degree1 = txt_degree.Text;

                    db.Entry(tbdDegree).State = EntityState.Modified;
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
                        tbdDegree = db.degree.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbdDegree).State = EntityState.Deleted;
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
            txt_degree.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "degree1").ToString();
        }

        // مدخل في الحقل حروف فقط
        private void txt_degree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Page_degree_FormClosed(object sender, FormClosedEventArgs e)
        {
            page_trainers.txt_trainer_Degree.DataSource = db.degree.Select(x => x.degree1).ToList();

        }

        private void txt_degree_Enter(object sender, EventArgs e)
        {
            txt_degree.BackColor = Color.Yellow;
        }

        private void txt_degree_Leave(object sender, EventArgs e)
        {
            txt_degree.BackColor = Color.White;
        }

        private void txt_degree_KeyDown(object sender, KeyEventArgs e)
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