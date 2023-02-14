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
using System.Data.Entity;
using CCTT.DB_CCTTDataSet1TableAdapters;
using CCTT.Reports;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;

namespace CCTT.Pages
{
    public partial class Page_grades : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        semster_student_main_cours tbsemster_student_main_cours = new semster_student_main_cours();
        semster_student tbsemster_student = new semster_student();
        public get_main_cours_student_grade1_Result f;
        int ID;
        public Page_grades()
        {
            InitializeComponent();
           
            LoadData();
            }

        public void LoadData()
        {
            // gridControl1.DataSource = dbContext.get_main_cours_student(null);
             txt_yeare.DataSource = db.Year.Select(x => x.year_serch).ToList();
             txt_semester.DataSource = db.Semester.Select(x => x. semester1).ToList();
            txt_groupstady.DataSource = db.study_Group.Select(x => x.name).ToList();

             txt_department.DataSource = db.department.Select(x => x.name).ToList();
            var id3 = db.Semester.Where(x => x.semester1 == txt_semester.SelectedItem.ToString()).Select(x => x.id_num_semster_r).FirstOrDefault();

            getMainBysemseterTableAdapter m = new getMainBysemseterTableAdapter();

             m.Fill(new DB_CCTTDataSet1.getMainBysemseterDataTable(), id3);
             txt_maincourse.DataSource = m.GetData(id3);
             //  txt_maincourse.DataSource = db.main_course.Select(x => x.course_name).ToList();

             //var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

             // txt_semecter.DataSource = db.StloadDataPage_getsemster_by_dep(id3);


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var yearId = db.Year.Where(x => x.year_serch == txt_yeare.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            var coursId = db.main_course.Where(x => x.course_name == txt_maincourse.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            var t = db.main_course.Where(x => x.id == coursId).Select(x => x.type).FirstOrDefault();

            gridControl1.DataSource = get_main_cours_student_grade3TableAdapter.GetData(yearId,coursId);

             if (t==1)
            {
                gridView1.Columns.View.Columns["درجة العملي"].Visible = false;
            }
          
        }

        private void txt_yeare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_department_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_semester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_maincourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_groupstady_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_yeare_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_yeare_Enter(object sender, EventArgs e)
        {
            txt_yeare.BackColor = Color.Yellow;

        }

        private void txt_yeare_Leave(object sender, EventArgs e)
        {
            txt_yeare.BackColor = Color.White;

        }

        private void txt_department_Enter(object sender, EventArgs e)
        {
            txt_department.BackColor = Color.Yellow;

        }

        private void txt_department_Leave(object sender, EventArgs e)
        {
            txt_department.BackColor = Color.White;

        }

        private void txt_semester_Enter(object sender, EventArgs e)
        {
            txt_semester.BackColor = Color.Yellow;

        }

        private void txt_semester_Leave(object sender, EventArgs e)
        {
            txt_semester.BackColor = Color.White;

        }

        private void txt_maincourse_Enter(object sender, EventArgs e)
        {
            txt_maincourse.BackColor = Color.Yellow;

        }

        private void txt_maincourse_Leave(object sender, EventArgs e)
        {
            txt_maincourse.BackColor = Color.White;

        }

        private void txt_groupstady_Enter(object sender, EventArgs e)
        {
            txt_groupstady.BackColor = Color.Yellow;

        }

        private void txt_groupstady_Leave(object sender, EventArgs e)
        {
            txt_groupstady.BackColor = Color.White;

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            var yearId = db.Year.Where(x => x.year_serch == txt_yeare.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            var coursId = db.main_course.Where(x => x.course_name == txt_maincourse.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            Reports.XtraReport5 x1 = new Reports.XtraReport5();
           
            x1.DataSource= get_main_cours_student_grade1TableAdapter.GetData(yearId, coursId);

            x1.ShowPreview();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // LoadData();
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                var uid =Convert.ToInt32( gridView1.GetRowCellValue(i, "uid").ToString());
                var mid = Convert.ToInt32(gridView1.GetRowCellValue(i, "درجة اعمال الفصل ").ToString());
                //var finalLab = Convert.ToInt32(gridView1.GetRowCellValue(i, "درجة العملي").ToString());
                var final_only = Convert.ToInt32(gridView1.GetRowCellValue(i, "درجة الامتحان النهائي").ToString());
                var final = Convert.ToInt32(gridView1.GetRowCellValue(i, "الدرجة النهائية").ToString());

                var unit = Convert.ToInt32(db.semster_student_main_cours.Where(x => x.id == uid).Select(x => x.unit).FirstOrDefault());
                int rate = unit * final;
                //   .FirstOrDefault());
                db.tbl_insert_semster_student_main_cours_grade3(uid,final_only,mid,0,final,1, rate);
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
                // var id7= db.semster_student.

             var id7=   db.semster_student_main_cours.Where(x => x.id== uid).Select(x => x.semster_student_id).FirstOrDefault();
             var id8 = db.semster_student.Where(x => x.id == id7).Select(x => x.year_id).FirstOrDefault();
             var id9 = db.semster_student.Where(x => x.id == id7).Select(x => x.student_id).FirstOrDefault();

                db.rate_calculation(id8, id9);
            }
        }

        private void gridControl1_Leave(object sender, EventArgs e)
        {
            //gridView1.GetRowCellValue(e.GetValueSafe(), "المادة").ToString();
        }

        private void gridControl1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("bbbb");
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
          var mid= Convert.ToInt32( gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "درجة اعمال الفصل "));
          var final= Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "درجة الامتحان النهائي"));
          gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "الدرجة النهائية", mid+final);
          // MessageBox.Show(mid);
        }

        private void btn_edt_click_Click(object sender, EventArgs e)
        {

        }

        private void txt_semester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_semester_TextChanged(object sender, EventArgs e)
        {
            var id3 = db.Semester.Where(x => x.semester1 == txt_semester.SelectedItem.ToString()).Select(x => x.id_num_semster_r).FirstOrDefault();

            getMainBysemseterTableAdapter m = new getMainBysemseterTableAdapter();

            m.Fill(new DB_CCTTDataSet1.getMainBysemseterDataTable(), id3);
            txt_maincourse.DataSource = m.GetData(id3);

        }
    }
}
