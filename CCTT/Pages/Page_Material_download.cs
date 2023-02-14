using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCTT.DB_CCTTDataSet2TableAdapters;
using CCTT.Reports;
using DevExpress.DirectX.StandardInterop.Direct2D;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace CCTT.Pages
{
    public partial class Page_Material_download : DevExpress.XtraEditors.XtraUserControl
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        semster_student_main_cours tbsemster_student_main_cours = new semster_student_main_cours();
        semster_student tbsemster_student = new semster_student();

        CCTT.DB_CCTTEntities dbContext = new CCTT.DB_CCTTEntities();

        public Page_Material_download()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            gridControl1.DataSource = dbContext.get_main_cours_student(null);
            txt_semecter.DataSource = db.Year.Select(x => x.year_serch).ToList();
            txt_student.DataSource = db.students.Select(x => x.idColge).ToList();

            txt_deprment.DataSource = db.department.Select(x => x.name).ToList();
           // txt_subject.DataSource = db.main_course.Select(x => x.course_name).ToList();

            var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            comboBox1.DataSource = db.StloadDataPage_getsemster_by_dep(id3);
            txt_student.Text = null;

        }
        private void Add()
        {
            if (txt_student.Text == "")
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
            
                var id1 = db.Year.Where(x => x.year_serch == txt_semecter.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbsemster_student.year_id = id1;
                int idcolge = Convert.ToInt32(txt_student.SelectedItem.ToString());
                var id2 = db.students.Where(x => x.idColge == idcolge).Select(x => x.id).FirstOrDefault();
                tbsemster_student.student_id = id2;

                var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                tbsemster_student.department_id = id3;
                DB_CCTTDataSet2 d=new DB_CCTTDataSet2();

                checksemster_studentTableAdapter m = new checksemster_studentTableAdapter();
                //new DB_CCTTDataSet2.checksemster_studentDataTable();
                m.Fill(new DB_CCTTDataSet2.checksemster_studentDataTable(),id2,id1);
           var cc=     m.GetData(id2, id1)[0].Column1.ToString();

       // var cc = DB_CCTTDataSet2.checksemster_studentDataTable.;
               MessageBox.Show(cc+"");
           int ch=    Convert.ToInt16(cc);

           
            if (ch == 0)
            {
                int sumunit = 0;
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    sumunit += Convert.ToInt32(gridView1.GetRowCellValue(i, "عدد الوحدات").ToString());
                }
                var semid = db.Semester.Where(x => x.semester1 == comboBox1.SelectedItem.ToString()).Select(x => x.sem_id).FirstOrDefault();

                tbsemster_student.sem_id = semid;
                tbsemster_student.unit = sumunit;
                db.Entry(tbsemster_student).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة");

                // MessageBox.Show(id2+"  "+id1+" ");
                //  db.get_main_cours_student_year5(1,2);
                //  MessageBox.Show(db.get_main_cours_student_year5(1, 2)+" ");

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    var b = gridView1.GetRowCellValue(i, "المادة").ToString();
                    var id4 = Convert.ToInt32(db.main_course.Where(x => x.course_name == b).Select(x => x.id)
                        .FirstOrDefault());
                    db.tbl_insert_semster_student_main_cours(id1, id2, id4);
                    MessageBox.Show("تمت الاضافة بنجاح", "اضافة");
                   
                }

              //  db.rate_calculation()
            }
            else
                MessageBox.Show("هذا الطالب تم تنزيل مقرراته الدراسية مسبقا");


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_student.SelectedItem != null)
            {
                var id4 = Convert.ToInt32(txt_student.SelectedItem.ToString());
                var id5 = txt_semecter.SelectedItem.ToString();

                var id3 = db.students.Where(x => x.idColge == id4)
                    .Select(x => x.id)
                    .FirstOrDefault();
                var id7 = db.Year.Where(x => x.year_serch == id5)
                    .Select(x => x.id)
                    .FirstOrDefault();
                get_main_cours_studentV2TableAdapter m = new get_main_cours_studentV2TableAdapter();
                //new DB_CCTTDataSet2.checksemster_studentDataTable();
                m.Fill(new DB_CCTTDataSet2.get_main_cours_studentV2DataTable(), id3, id7);

                gridControl1.DataSource = m.GetData(id3,id7);

            }
            else
                MessageBox.Show("الرجاء ادخال اسم الطالب او رقم القيد");


        }
    

        private void simpleButton1_Click(object sender, EventArgs e)
        { 
              Add();
        

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            var id4 = Convert.ToInt32(txt_student.SelectedItem.ToString());
            var id3 = db.students.Where(x => x.idColge == id4)
                .Select(x => x.id)
                .FirstOrDefault();


           // gridControl1.DataSource = get_main_cours_studentTableAdapter.GetData(id3);
            //  gridControl1.DataSource = get_main_cours_studentTableAdapter.GetData(id3);
            //  Reports.XtraReport4_Material r = new XtraReport4_Material();
            Reports.XtraReport12 x1 = new Reports.XtraReport12();
            //  var id4 = Convert.ToInt32(txt_student.SelectedItem.ToString());
            var id1 = db.Year.Where(x => x.year_serch == txt_semecter.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            get_main_cours_student_reportTableAdapter m = new get_main_cours_student_reportTableAdapter();
            m.Fill(new DB_CCTTDataSet2.get_main_cours_student_reportDataTable(), id3, id1);

            x1.DataSource = m.GetData(id3, id1);

            x1.ShowPreview();
            // gridControl1.ShowPrintPreview();
        }

        private void txt_semecter_Enter(object sender, EventArgs e)
        {
            txt_semecter.BackColor = Color.Yellow;

        }

        private void txt_semecter_Leave(object sender, EventArgs e)
        {
            txt_semecter.BackColor = Color.White;

        }

        private void txt_student_Enter(object sender, EventArgs e)
        {

            txt_student.BackColor = Color.Yellow;
        }

        private void txt_student_Leave(object sender, EventArgs e)
        {
            txt_student.BackColor = Color.White;

        }

        private void txt_deprment_Enter(object sender, EventArgs e)
        {
            txt_deprment.BackColor = Color.Yellow;

        }

        private void txt_deprment_Leave(object sender, EventArgs e)
        {
            txt_deprment.BackColor = Color.White;

        }

        private void txt_deprment_TextChanged(object sender, EventArgs e)
        {
            var id3 = db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            comboBox1.DataSource = db.StloadDataPage_getsemster_by_dep(id3);

        }

        private void txt_student_TextChanged(object sender, EventArgs e)
        {
            if (txt_deprment.Text != null && txt_deprment.SelectedItem !=null)
            {
                int idcolge = Convert.ToInt32(txt_student.SelectedItem.ToString());
            

            var id2 = db.students.Where(x => x.idColge == idcolge).Select(x => x.state_sem).FirstOrDefault();
            var id3 = Convert.ToInt32(db.department.Where(x => x.name == txt_deprment.SelectedItem.ToString()).Select(x => x.id)
                .FirstOrDefault());

//  var id3 = db.students.Where(x => x.idColge == txt_deprment.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();

            comboBox1.DataSource = db.getStudentsemByDbSemnum2(id3, id2);
        }
    }
    }
}
