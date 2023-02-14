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
using DevExpress.XtraEditors;

namespace CCTT.Pages
{
    public partial class Page__Group : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        study_Group tbstudy_Group = new study_Group();
        int ID;
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

              try
              {   //جلب مجال اسماء للكمبو بوكس سنة الدرسية
                  txt_group_stadyyear.DataSource = db.Year.Select(x => x.year_serch).ToList();
                  //فصل الدرسي
                  txt_group_class.DataSource = db.Semester.Select(x => x.semester1).ToList();
                  // قسم
                  txt_group_department.DataSource = db.department.Select(x => x.name).ToList();
            }
              catch (Exception e)
              {
                  Console.WriteLine(e);
                  throw;
              }

        }

        private void Add()
        {
            if (txt_group_name.Text == "" || txt_group_code.Text == "" || txt_group_class.Text==""||txt_group_department.Text == "")
            {
                MessageBox.Show("الحقل مطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                AddData();
                LoadData();
                ClearDaat();
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

        public void ClearDaat()
        {
            txt_group_class.Text = txt_group_code.Text = txt_group_department.Text =
                txt_group_max_student.Text = txt_group_name.Text = txt_group_stadyyear.Text = "";
        }
private void txt_group_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
       


        private void btn_edt_click_Click(object sender, EventArgs e)
        {

            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                if (ID > 0)
                {

                    tbstudy_Group = db.study_Group.Where(x => x.id == ID).FirstOrDefault();
                    tbstudy_Group.id = ID;
                  
                    //tbYear.season = txt_stadyyear_yeartype.SelectedItem.ToString();
                    //if (txt_stady_year_year.Text != "")
                    //    tbYear.year1 = Convert.ToInt32(txt_stady_year_year.Text);


                    db.Entry(tbstudy_Group).State = EntityState.Modified;
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
                        tbstudy_Group = db.study_Group.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbstudy_Group).State = EntityState.Deleted;
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
            gridControl1.ShowPrintPreview();
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {// يحتاج الي جلب الاسماء من edmx
            //txt_group_code.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "").ToString();
            txt_group_class.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الفصل").ToString();
            txt_group_department.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "القسم").ToString();
            txt_group_max_student.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "max_student_count").ToString();
            if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "yera")==null)
            txt_group_stadyyear.Text = "";
            else
            {
                txt_group_stadyyear.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "yera").ToString();
            }
            txt_group_name.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "name").ToString();
           

        }
    }
}
