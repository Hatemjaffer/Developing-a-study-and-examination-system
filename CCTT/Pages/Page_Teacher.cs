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
using CCTT.Pages_LinkLable;

namespace CCTT.Pages
{
    public partial class Page_Teacher : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        Faculty_member tbFaculty_member = new Faculty_member();
         int ID;
        public Page_Teacher()
        {
            InitializeComponent();
            LoadData();
            ClearData();
        }
        public void LoadData()
        {
            CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();
            // Bind data to control when loading complete
                gridControl1.DataSource = stloadDataPage_Faculty_memberV2TableAdapter.GetData();

                try
                {
                    //تعبئة حقل الجنسية
                    txt_teacher_nationality.DataSource = db.nationality.Select(x => x.nationilty).ToList();

                    //تعبئة حقل التخصص
                    txt_teacher_specialty.DataSource = db.major.Select(x => x.major1).ToList();

                    //تعيئة حقل المؤهلات
                    txt_teacher_qualification.DataSource = db.qualification.Select(x => x.qualification1).ToList();

                    //تعبئة حقل الدرجة العبمية
                    txt_teacher_degree.DataSource = db.degree.Select(x => x.degree1).ToList();

                    txt_teacher_address.DataSource = db.place_of_birth.Select(x => x.place).ToList();


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                

        }

        //public void crareData()
        //{
        //    txt_teacher_stadysystem.Text = txt_teacher_address.Text = txt_teacher_birth.Text =
        //        txt_teacher_card_number.Text = txt_teacher_ceritificate_no.Text = txt_teacher_degree.Text =
        //            txt_teacher_destination.Text = txt_teacher_email.Text = txt_teacher_fullname.Text =
        //                txt_teacher_graduation_year.Text = txt_teacher_job_number.Text =
        //                    txt_teacher_marital_status.Text = txt_teacher_passport_number.Text =
        //                        txt_teacher_nationality.Text = txt_teacher_phone.Text = txt_teacher_qualification.Text =
        //                            txt_teacher_sex.Text = txt_teacher_specialty.Text = "";
        //}
        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_teacher_fullname.Text == "")
            {
                MessageBox.Show("الحقل مطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            try
            {

                tbFaculty_member.name = txt_teacher_fullname.Text;
                tbFaculty_member.BOD = txt_teacher_birth.Value;
                tbFaculty_member.start_work_Date = txt_teacher_stratdate.Value;

                var id1 = db.major.Where(x => x.major1 == txt_teacher_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbFaculty_member.Major = id1;

                var id2 = db.qualification.Where(x => x.qualification1 == txt_teacher_qualification.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbFaculty_member.qualification = id2;

                var id3 = db.degree.Where(x => x.degree1 == txt_teacher_degree.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbFaculty_member.degree = id3;

                tbFaculty_member.email = txt_teacher_email.Text;

                if (txt_teacher_phone.Text != "")
                 tbFaculty_member.phone_num = Convert.ToInt32(txt_teacher_phone.Text);

                tbFaculty_member.address = txt_teacher_address.Text;

                if (txt_teacher_ceritificate_no.Text != "")
                    tbFaculty_member.National_id = Convert.ToInt64(txt_teacher_ceritificate_no.Text);

                if (txt_teacher_job_number.Text != "")
                    tbFaculty_member.job_id = Convert.ToInt32(txt_teacher_job_number.Text);

                //tbFaculty_member.graduation_date = txt_teacher_graduation_year.Text;
                tbFaculty_member.certificate_place_of_origin = txt_teacher_destination.Text;
                tbFaculty_member.passport_id = txt_teacher_passport_number.Text;
                tbFaculty_member.personal_id = txt_teacher_card_number.Text;

                var iddep = db.nationality.Where(x => x.nationilty == txt_teacher_nationality.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbFaculty_member.nationality = iddep;


                if (txt_teacher_sex.Text == "ذكر")
                    tbFaculty_member.gender = 1;
                if (txt_teacher_sex.Text == "انثي")
                    tbFaculty_member.gender = 2;

                if (txt_teacher_marital_status.Text == "متزوج")
                    tbFaculty_member.martial_status = 1;

                if (txt_teacher_marital_status.Text == "اعزب")
                    tbFaculty_member.martial_status = 2;



                db.Entry(tbFaculty_member).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
                ClearData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        // تعديل
        private void btn_edt_click_Click(object sender, EventArgs e)
        {

            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));

                if (ID > 0)
                {
                    tbFaculty_member = db.Faculty_member.Where(x => x.idFac == ID).FirstOrDefault();
                   tbFaculty_member.idFac = ID;

                    tbFaculty_member.name = txt_teacher_fullname.Text;
                    tbFaculty_member.BOD = txt_teacher_birth.Value;
                    tbFaculty_member.start_work_Date = txt_teacher_stratdate.Value;

                    var id1 = db.major.Where(x => x.major1 == txt_teacher_specialty.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                    tbFaculty_member.Major = id1;

                    var id2 = db.qualification.Where(x => x.qualification1 == txt_teacher_qualification.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                    tbFaculty_member.qualification = id2;

                    var id3 = db.degree.Where(x => x.degree1 == txt_teacher_degree.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                    tbFaculty_member.degree = id3;

                    tbFaculty_member.email = txt_teacher_email.Text;

                    if (txt_teacher_phone.Text != "")
                        tbFaculty_member.phone_num = Convert.ToInt32(txt_teacher_phone.Text);

                    tbFaculty_member.address = txt_teacher_address.Text;

                    if (txt_teacher_ceritificate_no.Text != "")
                        tbFaculty_member.National_id = Convert.ToInt64(txt_teacher_ceritificate_no.Text);

                    if (txt_teacher_job_number.Text != "")
                        tbFaculty_member.job_id = Convert.ToInt32(txt_teacher_job_number.Text);

                    //tbFaculty_member.graduation_date = txt_teacher_graduation_year.Text;
                    tbFaculty_member.certificate_place_of_origin = txt_teacher_destination.Text;
                    tbFaculty_member.passport_id = txt_teacher_passport_number.Text;
                    tbFaculty_member.personal_id = txt_teacher_card_number.Text;

                    var iddep = db.nationality.Where(x => x.nationilty == txt_teacher_nationality.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                    tbFaculty_member.nationality = iddep;


                    if (txt_teacher_sex.Text == "ذكر")
                        tbFaculty_member.gender = 1;
                    if (txt_teacher_sex.Text == "انثي")
                        tbFaculty_member.gender = 2;

                    if (txt_teacher_marital_status.Text == "متزوج")
                        tbFaculty_member.martial_status = 1;

                    if (txt_teacher_marital_status.Text == "اعزب")
                        tbFaculty_member.martial_status = 2;


                    db.Entry(tbFaculty_member).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("تم تعديل البيانات بالنجاح", "عملية تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearData();
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
        // تنطيف الحقول
        public void ClearData()
        {
            txt_teacher_address.Text = txt_teacher_birth.Text = txt_teacher_card_number.Text =
                txt_teacher_ceritificate_no.Text = txt_teacher_degree.Text = txt_teacher_destination.Text =
                    txt_teacher_email.Text = txt_teacher_fullname.Text = txt_teacher_graduation_year.Text =
                        txt_teacher_job_number.Text = txt_teacher_marital_status.Text = txt_teacher_nationality.Text =
                            txt_teacher_passport_number.Text = txt_teacher_phone.Text = txt_teacher_sex.Text =
                                txt_teacher_qualification.Text =
                                    txt_teacher_stadysystem.Text = txt_teacher_stratdate.Text = "";
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
                        tbFaculty_member = db.Faculty_member.Where(x => x.idFac == ID).FirstOrDefault();

                        db.Entry(tbFaculty_member).State = EntityState.Deleted;
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
        // ربط لنك باصفحات
        private void link_nationality_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
              Page_major page = new Page_major(this);
              page.ShowDialog();
        }

        private void link_Address_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_qualification page = new Page_qualification(this);
            page.ShowDialog();
        }
        private void linkLabel_darge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_degree page = new Page_degree(this);
            page.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        

        private void txt_teacher_fullname_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_teacher_fullname_Enter(object sender, EventArgs e)
        {
            txt_teacher_fullname.BackColor = Color.Yellow;

        }

        private void txt_teacher_fullname_Leave(object sender, EventArgs e)
        {
            txt_teacher_fullname.BackColor = Color.White;

        }

        private void txt_teacher_job_number_Enter(object sender, EventArgs e)
        {
            txt_teacher_job_number.BackColor = Color.Yellow;

        }

        private void txt_teacher_job_number_Leave(object sender, EventArgs e)
        {
            txt_teacher_job_number.BackColor = Color.White;

        }

        private void txt_teacher_address_Enter(object sender, EventArgs e)
        {
            txt_teacher_address.BackColor = Color.Yellow;

        }

        private void txt_teacher_address_Leave(object sender, EventArgs e)
        {
            txt_teacher_address.BackColor = Color.White;

        }

        private void txt_teacher_phone_Enter(object sender, EventArgs e)
        {
            txt_teacher_phone.BackColor = Color.Yellow;

        }

        private void txt_teacher_phone_Leave(object sender, EventArgs e)
        {
            txt_teacher_phone.BackColor = Color.White;

        }

        private void txt_teacher_passport_number_Enter(object sender, EventArgs e)
        {
            txt_teacher_passport_number.BackColor = Color.Yellow;

        }

        private void txt_teacher_passport_number_Leave(object sender, EventArgs e)
        {
            txt_teacher_passport_number.BackColor = Color.White;

        }

        private void txt_teacher_card_number_Enter(object sender, EventArgs e)
        {
            txt_teacher_card_number.BackColor = Color.Yellow;

        }

        private void txt_teacher_card_number_Leave(object sender, EventArgs e)
        {
            txt_teacher_card_number.BackColor = Color.White;

        }

        private void txt_teacher_ceritificate_no_Enter(object sender, EventArgs e)
        {
            txt_teacher_ceritificate_no.BackColor = Color.Yellow;

        }

        private void txt_teacher_ceritificate_no_Leave(object sender, EventArgs e)
        {
            txt_teacher_ceritificate_no.BackColor = Color.White;

        }

        private void txt_teacher_nationality_Enter(object sender, EventArgs e)
        {
            txt_teacher_nationality.BackColor = Color.Yellow;

        }

        private void txt_teacher_nationality_Leave(object sender, EventArgs e)
        {
            txt_teacher_nationality.BackColor = Color.White;

        }

        private void txt_teacher_sex_Enter(object sender, EventArgs e)
        {
            txt_teacher_sex.BackColor = Color.Yellow;

        }

        private void txt_teacher_sex_Leave(object sender, EventArgs e)
        {
            txt_teacher_sex.BackColor = Color.White;

        }

        private void txt_teacher_qualification_Enter(object sender, EventArgs e)
        {
            txt_teacher_qualification.BackColor = Color.Yellow;

        }

        private void txt_teacher_qualification_Leave(object sender, EventArgs e)
        {
            txt_teacher_qualification.BackColor = Color.White;

        }

        private void txt_teacher_degree_Enter(object sender, EventArgs e)
        {
            txt_teacher_degree.BackColor = Color.Yellow;

        }

        private void txt_teacher_degree_Leave(object sender, EventArgs e)
        {
            txt_teacher_degree.BackColor = Color.White;

        }

        private void txt_teacher_graduation_year_Enter(object sender, EventArgs e)
        {
            txt_teacher_graduation_year.BackColor = Color.Yellow;

        }

        private void txt_teacher_graduation_year_Leave(object sender, EventArgs e)
        {
            txt_teacher_graduation_year.BackColor = Color.White;

        }

        private void txt_teacher_specialty_Enter(object sender, EventArgs e)
        {
            txt_teacher_specialty.BackColor = Color.Yellow;

        }

        private void txt_teacher_specialty_Leave(object sender, EventArgs e)
        {
            txt_teacher_specialty.BackColor = Color.White;

        }

        private void txt_teacher_destination_Enter(object sender, EventArgs e)
        {
            txt_teacher_destination.BackColor = Color.Yellow;

        }

        private void txt_teacher_destination_Leave(object sender, EventArgs e)
        {
            txt_teacher_destination.BackColor = Color.White;

        }

        private void txt_teacher_email_Enter(object sender, EventArgs e)
        {
            txt_teacher_email.BackColor = Color.Yellow;

        }

        private void txt_teacher_email_Leave(object sender, EventArgs e)
        {
            txt_teacher_email.BackColor = Color.White;

        }

        private void txt_teacher_marital_status_Enter(object sender, EventArgs e)
        {
            txt_teacher_marital_status.BackColor = Color.Yellow;

        }

        private void txt_teacher_marital_status_Leave(object sender, EventArgs e)
        {
            txt_teacher_marital_status.BackColor = Color.White;

        }

        private void txt_teacher_fullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_job_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_card_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_ceritificate_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_qualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_degree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_graduation_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_teacher_specialty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           

            txt_teacher_fullname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الاسم").ToString();
            if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "تاريخ الميلاد")==null)
            txt_teacher_birth.Text = "";
            else
            {
                txt_teacher_birth.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "تاريخ الميلاد").ToString();
            }
            txt_teacher_address.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "العنوان").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "رقم الوظيفي")==null)
            txt_teacher_job_number.Text = "";
            else
            {
                txt_teacher_job_number.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "رقم الوظيفي").ToString();
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "رقم الهاتف")==null)
            txt_teacher_phone.Text = "";
            else
            {
                txt_teacher_phone.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "رقم الهاتف").ToString();
            }

            if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "رقم الجواز")==null)
            txt_teacher_passport_number.Text = "";
            else
            {
                txt_teacher_passport_number.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "رقم الجواز").ToString();
            }
            //txt_teacher_card_number.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BOD").ToString();
            if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الرقم الوطني")==null)
            txt_teacher_ceritificate_no.Text = "";
            else
            {
                txt_teacher_ceritificate_no.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الرقم الوطني").ToString();
            }
            //graduation_date  Major  certificate_place_of_origin
            txt_teacher_nationality.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الجنسية").ToString();

            txt_teacher_sex.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الجنس").ToString();

            txt_teacher_qualification.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "المؤهل").ToString();
            if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الدرجة العلمية")==null)
            txt_teacher_degree.Text = "";
            else
            {
                txt_teacher_degree.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "الدرجة العلمية").ToString();
            }
            //txt_teacher_graduation_year.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BOD").ToString();
            txt_teacher_specialty.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "التخصص").ToString();
            //txt_teacher_destination.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BOD").ToString();
            txt_teacher_email.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ايميل").ToString();
            if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "بداية العمل")==null)
            txt_teacher_stratdate.Text = "";
            else
            {
                txt_teacher_stratdate.Text =
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "بداية العمل").ToString();
            }
            //txt_teacher_marital_status.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "martial_status").ToString();
            //txt_teacher_image.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "picture").ToString();



            //if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id") == null)
            //    txt_teacher_.Text = "";
            //else
            //{
            //    txt_student_id.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString();
            //}

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_teacher_stadysystem.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
