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
using System.Data.Entity;
using CCTT.Reports;
using DevExpress.XtraReports.UI;

namespace CCTT.Pages
{
    public partial class Page_department : DevExpress.XtraEditors.XtraUserControl
    {
        // جلب قاعدة البيانات وجدول الاقسام
        DB_CCTTEntities db = new DB_CCTTEntities();
        department tbDepartment = new department();
        int ID;
        public Page_department()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            dbContext.department.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.department.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_dep_departmentname.Text == "" || txt_departmentname_description.Text=="")
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
            try
            {
                db = new DB_CCTTEntities();
                tbDepartment = new department();

                tbDepartment.name = txt_dep_departmentname.Text;
                tbDepartment.department_details = txt_departmentname_description.Text;
                db.Entry(tbDepartment).State = System.Data.Entity.EntityState.Added;
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

        private void btn_edt_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                if (ID > 0)
                {
                   
                    tbDepartment = db.department.Where(x => x.id == ID).FirstOrDefault();
                    tbDepartment.id = ID;

                    tbDepartment.name = txt_dep_departmentname.Text;
                    tbDepartment.department_details = txt_departmentname_description.Text;

                    db.Entry(tbDepartment).State = EntityState.Modified;
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
                        tbDepartment = db.department.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbDepartment).State = EntityState.Deleted;
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txt_dep_departmentname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "name").ToString();
            txt_departmentname_description.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "department_details").ToString();

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            XtraReport9 report4 = new XtraReport9();
            // report4.Parameters.
            //   report4.RequestParameters = false;
            
            report4.Parameters["@year_id"].Value = 2;
            report4.Parameters["@main_cours_id"].Value = 7;
            //report4.RequestParameters = false;
            //  report4.Parameters = false;

            // report4.
            report4.ShowPreview();
        }

        private void txt_dep_department_code_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_dep_departmentname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dep_department_code_Enter(object sender, EventArgs e)
        {
            txt_dep_department_code.BackColor = Color.Yellow;

        }

        private void txt_dep_department_code_Leave(object sender, EventArgs e)
        {
            txt_dep_department_code.BackColor = Color.White;

        }

        private void txt_dep_departmentname_Enter(object sender, EventArgs e)
        {
            txt_dep_departmentname.BackColor = Color.Yellow;

        }

        private void txt_dep_departmentname_Leave(object sender, EventArgs e)
        {
            txt_dep_departmentname.BackColor = Color.White;

        }

        private void txt_departmentname_description_Enter(object sender, EventArgs e)
        {
            txt_departmentname_description.BackColor = Color.Yellow;

        }

        private void txt_departmentname_description_Leave(object sender, EventArgs e)
        {
            txt_departmentname_description.BackColor = Color.White;

        }
    }
}
