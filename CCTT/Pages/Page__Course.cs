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
using DevExpress.XtraEditors.Controls;

namespace CCTT.Pages
{
    public partial class Page__Course : DevExpress.XtraEditors.XtraUserControl
    {
        private extra_Course tbextra_Course = new extra_Course();
        private DB_CCTTEntities db = new DB_CCTTEntities();
        int ID;
        public Page__Course()
        {
            InitializeComponent();
            txt_course_trainers.DataSource=db.Trainer.Select(x => x.name).ToList();
            gridControl1.DataSource = get_std_main_courseTableAdapter.GetData();

        }

        public void LoadData()
        {
            txt_course_trainers.DataSource = db.Trainer.Select(x => x.name).ToList();
            gridControl1.DataSource = get_std_main_courseTableAdapter.GetData();
        }
        private void Add()
        {
            if (txt_course_name.Text == "")
            {
                MessageBox.Show("الحقل مطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                AddData();

            }
        }
        // دالة اضافة
        private void AddData()
        {

            tbextra_Course.course_code = txt_course_code.Text;

            tbextra_Course.course_name = txt_course_name.Text;

                tbextra_Course.course_information = txt_course_information.Text;
                tbextra_Course.price = Convert.ToInt32(txt_coures_pries.Text);
                
               // tbextra_Course.Email = txt_coursestudent_email.Text;

                if (txt_course_trainers.Text != "")
                {
                    var iddep = db.Trainer.Where(x => x.name == txt_course_trainers.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                    tbextra_Course.trainer_id = iddep;
                }
                tbextra_Course.max_student_count = Convert.ToInt32(txt_course_max_student.Text);
                tbextra_Course.start_date = txt_stratdate.Value;
                tbextra_Course.end_date = txt_enddate.Value;
               

            string day = "";
                for (int i = 0; i < 3; i++)
                    if (checkedComboBoxEdit1.Properties.Items[i].CheckState == CheckState.Checked)
                        day += "1";
                    else
                        day += "0";

                tbextra_Course.days = day;
                tbextra_Course.daysString = checkedComboBoxEdit1.Text;

            /*
             *1 لم تبداء
             *2 بدأت
             *3 مكتمله
             *
             */
            if (txt_course_state.Text == "لم تبدأ")
                tbextra_Course.course_status = 1;
            else  if (txt_course_state.Text == "بدأت")
                tbextra_Course.course_status = 2;
            else if (txt_course_state.Text == "مكتملة")
                    tbextra_Course.course_status = 3;
             
            db.Entry(tbextra_Course).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
           LoadData();
        }
        private void Page__Course_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لايمكن استرجاع البيانات", "اجراء حدف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {

                try
                {
                    ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("الرقم"));
                    if (ID > 0)
                    {
                        tbextra_Course = db.extra_Course.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbextra_Course).State = EntityState.Deleted;
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
            /*
             string day="101";
             day.ToCharArray() ;
             for (int i = 0; i < 3; i++)
                 if (day[i].ToString().Equals("1"))
                checkedComboBoxEdit1.Properties.Items[i].CheckState = CheckState.Checked;
        */
        }
       
       

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txt_coures_pries.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "السعر").ToString();
            txt_course_max_student.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "عددالطلبة الاقصي").ToString();

            txt_course_trainers.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "المدرب").ToString();
            txt_course_code.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "رمز الدورة").ToString();
            txt_course_houres.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "عدد الساعات").ToString();
            txt_course_information.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "معلومات عن الدورة").ToString();
            txt_course_name.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "اسم الدورة").ToString();
            txt_stratdate.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "تاريخ البداية").ToString();
           txt_stratdate.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "تاريخ نهاية").ToString();
            txt_course_state.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "حالة الدورة").ToString();
            string day = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "days").ToString();
            if (!(day==" "))
            
            {
                day.ToCharArray();
                for (int i = 0; i < 3; i++)
                    if (day[i].ToString().Equals("1"))
                        checkedComboBoxEdit1.Properties.Items[i].CheckState = CheckState.Checked;
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        } 
        
       

        private void btn_edt_click_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("الرقم"));
                if (ID > 0)
                {

                    tbextra_Course = db.extra_Course.Where(x => x.id == ID).FirstOrDefault();
                    tbextra_Course.id = ID;

                    tbextra_Course.course_name = txt_course_name.Text;
                    tbextra_Course.course_code = txt_course_code.Text;

                    tbextra_Course.course_information = txt_course_information.Text;
                    tbextra_Course.price = Convert.ToInt32(txt_coures_pries.Text);

                    // tbextra_Course.Email = txt_coursestudent_email.Text;

                    if (txt_course_trainers.Text != "")
                    {
                        var iddep = db.Trainer.Where(x => x.name == txt_course_trainers.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                        tbextra_Course.trainer_id = iddep;
                    }
                    tbextra_Course.max_student_count = Convert.ToInt32(txt_course_max_student.Text);
                    tbextra_Course.start_date = txt_stratdate.Value;
                    tbextra_Course.end_date = txt_enddate.Value;

                    string day = "";
                    for (int i = 0; i < 3; i++)
                        if (checkedComboBoxEdit1.Properties.Items[i].CheckState == CheckState.Checked)
                            day += "1";
                        else
                            day += "0";

                    tbextra_Course.days = day;
                    tbextra_Course.daysString = checkedComboBoxEdit1.Text;

                    db.Entry(tbextra_Course).State = EntityState.Modified;
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
        
        //  ضغط علي انتر لكل الحقول
        private void Page__Course_KeyDown(object sender, KeyEventArgs e)
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
        
        // 
        private void txt_course_code_Enter(object sender, EventArgs e)
        {
            txt_course_code.BackColor = Color.Yellow;

        }

        private void txt_course_code_Leave(object sender, EventArgs e)
        {
            txt_course_code.BackColor = Color.White;

        }

        private void txt_course_name_Enter(object sender, EventArgs e)
        {
            txt_course_name.BackColor = Color.Yellow;

        }

        private void txt_course_name_Leave(object sender, EventArgs e)
        {
            txt_course_name.BackColor = Color.White;

        }

        private void txt_course_information_Enter(object sender, EventArgs e)
        {
            txt_course_information.BackColor = Color.Yellow;

        }

        private void txt_course_information_Leave(object sender, EventArgs e)
        {
            txt_course_information.BackColor = Color.White;

        }

        private void txt_coures_pries_Enter(object sender, EventArgs e)
        {
            txt_coures_pries.BackColor = Color.Yellow;

        }

        private void txt_coures_pries_Leave(object sender, EventArgs e)
        {
            txt_coures_pries.BackColor = Color.White;

        }

        private void txt_course_trainers_Enter(object sender, EventArgs e)
        {
            txt_course_trainers.BackColor = Color.Yellow;

        }

        private void txt_course_trainers_Leave(object sender, EventArgs e)
        {
            txt_course_trainers.BackColor = Color.White;

        }

        private void txt_course_max_student_Enter(object sender, EventArgs e)
        {
            txt_course_max_student.BackColor = Color.Yellow;

        }

        private void txt_course_max_student_Leave(object sender, EventArgs e)
        {
            txt_course_max_student.BackColor = Color.White;

        }

        private void txt_course_houres_Enter(object sender, EventArgs e)
        {
            txt_course_houres.BackColor = Color.Yellow;

        }

        private void txt_course_houres_Leave(object sender, EventArgs e)
        {
            txt_course_houres.BackColor = Color.White;

        }

        private void checkedComboBoxEdit1_Enter(object sender, EventArgs e)
        {
            checkedComboBoxEdit1.BackColor = Color.Yellow;

        }

        private void checkedComboBoxEdit1_Leave(object sender, EventArgs e)
        {
            checkedComboBoxEdit1.BackColor = Color.White;

        }

        private void txt_course_state_Enter(object sender, EventArgs e)
        {
            txt_course_state.BackColor = Color.Yellow;

        }

        private void txt_course_state_Leave(object sender, EventArgs e)
        {
            txt_course_state.BackColor = Color.White;

        }
        // Pries Just Nomber
        private void txt_coures_pries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
        // Pries Just Nomber
        private void txt_course_max_student_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txt_course_houres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddData();
        }
    }
}
