using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
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
        permission tbPermission = new permission();
        int ID;
        public Page__Users()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            //استجلاب البياانات  عن طريق stored pro
           // gridControl1.DataSource = get_main_cours_student_grade3TableAdapter.GetData(yearId, coursId);

            gridControl1.DataSource = getUserV1TableAdapter.GetData();

            //txt_user_role.DataSource = db.permissions.Select(x => x.type).ToList();

            // تفعيل العلاقة
            // txt_sem_specialty.DataSource = db.department.Select(x => x.name).ToList();

        }

        private void Add()
        {
            if (txt_user_fullname.Text == "" || txt_user_password.Text=="")
            {
                MessageBox.Show("الحقل مطلوب ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            var iduser = db.permissions.Where(x => x.type == txt_user_role.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            tbuser.permioi_type = iduser;
            if (txt_user_role.Text == "مدير")
                tbuser.permioi_type = 1;
            if (txt_user_role.Text == "مستخدم")
                tbuser.permioi_type = 2;

            db.Entry(tbuser).State = System.Data.Entity.EntityState.Added;

            db.SaveChanges();
            MessageBox.Show("تمت الاضافة بنجاح", "اضافة");

        }
        private void btn_edt_click_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                if (ID > 0)
                {

                    tbuser = db.users.Where(x => x.id == ID).FirstOrDefault();

                    tbuser.id = ID;
                    tbuser.name = txt_user_fullname.Text;
                    tbuser.password = txt_user_password.Text;




                    // tbuser.permioi_type = txt_user_role.Text;
                    //tbuser.permioi_type = txt_user_role.SelectedItem.ToString();
                    //if (txt_stady_year_year.Text != "")
                    //    tbYear.year1 = Convert.ToInt32(txt_stady_year_year.Text);
                    db.Entry(tbuser).State = EntityState.Modified;
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
                        tbuser = db.users.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbuser).State = EntityState.Deleted;
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
        //
        private void txt_user_fullname_Enter(object sender, EventArgs e)
        {
            txt_user_fullname.BackColor = Color.Yellow;

        }

        private void txt_user_fullname_Leave(object sender, EventArgs e)
        {
            txt_user_fullname.BackColor = Color.White;

        }

        private void txt_user_role_Enter(object sender, EventArgs e)
        {
            txt_user_role.BackColor = Color.Yellow;

        }

        private void txt_user_role_Leave(object sender, EventArgs e)
        {
            txt_user_role.BackColor = Color.White;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //يحتاج الي تسوية اسماء من edmx
            txt_user_fullname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الأسم").ToString();
            txt_user_password.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الرمز السري").ToString();
          //
          // txt_user_role.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "نوع صلاحية").ToString();

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
    }
}
