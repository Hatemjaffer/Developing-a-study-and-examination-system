using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCTT.Reports;
using DevExpress.XtraReports.UI;

namespace CCTT.Pages
{
    public partial class Page_Subject : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        main_course tbmain_course = new main_course();
        int ID;
        public Page_Subject()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            //استجلاب البياانات  عن طريق stored pro
            gridControl1.DataSource = getMainCoursV2TableAdapter.GetData();


        }

        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_sub_articlecode.Text == "")
            {
                MessageBox.Show("الحقلول مطلوبة ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                AddData();
                LoadData();
                ClearData();
            }
        }
        // دالة اضافة
        private void AddData()
        {

            tbmain_course.course_name = txt_sub_articlename.Text;
            tbmain_course.code_id = txt_sub_articlecode.Text;
            // var iddep = db.main_course.Where(x => x.name == txt_sem_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            if (txt_sub_numberofunits.Text != "")
                tbmain_course.units = Convert.ToInt32(txt_sub_numberofunits.Text);
            if (txt_sub_houre.Text != "")
                tbmain_course.hours = Convert.ToInt32(txt_sub_houre.Text);
            
            if (txt_sub_material_type.Text == "نظري")
                tbmain_course.type = 1;
            if (txt_sub_material_type.Text == "عملي+نظري")
                tbmain_course.type = 2;

            
            db.Entry(tbmain_course).State = System.Data.Entity.EntityState.Added;

            db.SaveChanges();
            MessageBox.Show("تمت الاضافة بنجاح", "اضافة");

        }

        public void ClearData()
        {
            txt_sub_articlecode.Text = txt_sub_articlename.Text = txt_sub_houre.Text = txt_sub_material_type.Text =
                txt_sub_numberofunits.Text = txt_sub_reliability.Text = txt_sub_substitutefor.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Page_Subject_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_sub_articlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sub_numberofunits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sub_reliability_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sub_substitutefor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sub_articlecode_Enter(object sender, EventArgs e)
        {
            txt_sub_articlecode.BackColor = Color.Yellow;

        }

        private void txt_sub_articlecode_Leave(object sender, EventArgs e)
        {
            txt_sub_articlecode.BackColor = Color.White;

        }

        private void txt_sub_articlename_Enter(object sender, EventArgs e)
        {
            txt_sub_articlename.BackColor = Color.Yellow;

        }

        private void txt_sub_articlename_Leave(object sender, EventArgs e)
        {
            txt_sub_articlename.BackColor = Color.White;

        }

        private void txt_sub_numberofunits_Enter(object sender, EventArgs e)
        {
            txt_sub_numberofunits.BackColor = Color.Yellow;

        }

        private void txt_sub_numberofunits_Leave(object sender, EventArgs e)
        {
            txt_sub_numberofunits.BackColor = Color.White;

        }

        private void txt_sub_houre_Enter(object sender, EventArgs e)
        {
            txt_sub_houre.BackColor = Color.Yellow;

        }

        private void txt_sub_houre_Leave(object sender, EventArgs e)
        {
            txt_sub_houre.BackColor = Color.White;

        }

        private void txt_sub_reliability_Enter(object sender, EventArgs e)
        {
            txt_sub_reliability.BackColor = Color.Yellow;

        }

        private void txt_sub_reliability_Leave(object sender, EventArgs e)
        {
            txt_sub_reliability.BackColor = Color.White;

        }

        private void txt_sub_substitutefor_Enter(object sender, EventArgs e)
        {
            txt_sub_substitutefor.BackColor = Color.Yellow;

        }

        private void txt_sub_substitutefor_Leave(object sender, EventArgs e)
        {
            txt_sub_substitutefor.BackColor = Color.White;

        }

        private void txt_sub_material_type_Enter(object sender, EventArgs e)
        {
            txt_sub_material_type.BackColor = Color.Yellow;

        }

        private void txt_sub_material_type_Leave(object sender, EventArgs e)
        {
            txt_sub_material_type.BackColor = Color.White;

        }

        private void btn_edt_click_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("الرقم"));
                if (ID > 0)
                {

                    tbmain_course = db.main_course.Where(x => x.id == ID).FirstOrDefault();
                    tbmain_course.id = ID;
                    tbmain_course.course_name = txt_sub_articlename.Text;
                    tbmain_course.code_id = txt_sub_articlecode.Text;
                    // var iddep = db.main_course.Where(x => x.name == txt_sem_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

                    if (txt_sub_numberofunits.Text != "")
                        tbmain_course.units = Convert.ToInt32(txt_sub_numberofunits.Text);
                    if (txt_sub_houre.Text != "")
                        tbmain_course.hours = Convert.ToInt32(txt_sub_houre.Text);

                    if (txt_sub_material_type.Text == "نظري")
                        tbmain_course.type = 1;
                    if (txt_sub_material_type.Text == "عملي+نظري")
                        tbmain_course.type = 2;

                    //tbmain_course.code_id=txt
                    //\tbDepartment.name = txt_dep_departmentname.Text;
                    //tbDepartment.department_details = txt_departmentname_description.Text;

                    db.Entry(tbmain_course).State = EntityState.Modified;
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
            int ID;
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لايمكن استرجاع البيانات", "اجراء حدف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {

                try
                {
                    ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                    if (ID > 0)
                    {
                        tbmain_course = db.main_course.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbmain_course).State = EntityState.Deleted;
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

        private void btn_print_Click(object sender, EventArgs e)
        {
            //gridControl1.ShowPrintPreview();
            Reports.XtraReport3 m = new XtraReport3();
            m.ShowPreview();

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // جلب اسماء المطابقة من edmx
            txt_sub_articlecode.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "رمز المادة").ToString();
            txt_sub_articlename.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "اسم المادة").ToString();
            txt_sub_houre.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الساعات").ToString();
            // txt_sub_material_type.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "").ToString();
          
            //if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "عددالوحدات") ==null)
            //txt_sub_numberofunits.Text = "";
            //txt_sub_numberofunits.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "عددالوحدات").ToString();
          
            //  txt_sub_reliability.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "").ToString();
            //  txt_sub_substitutefor.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "").ToString();
            // .Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "").ToString();

        }
    }
}
