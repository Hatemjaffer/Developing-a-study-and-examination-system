using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCTT.Pages;
using CCTT.AddPage;


namespace CCTT
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private object lt_state;

        public Main()
        {
            InitializeComponent();
            LoadHomePage();
           
        }

        //load page
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                pn_container.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                pn_container.Controls.Add(Page);
            }
            catch
            {
            }

        }

        private void LoadHomePage()
        {
            Page_Home page = new Page_Home();
            LoadPage(page);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            
            LoadHomePage();
            lb_state.Text = btn_home.Text;
            lb_state.Visible = true;
        }

      
       
        private void btn_add_student_Click(object sender, EventArgs e)
        {
            Page_Student page = new Page_Student();
            LoadPage(page);
            lb_state.Text = btn_add_student.Text;
            lb_state.Visible = true;
        }

        private void btn_add_student_couress_Click(object sender, EventArgs e)
        {
            Page_CourseStudents page = new Page_CourseStudents();
            LoadPage(page);
            lb_state.Text = btn_add_student_couress.Text;
            lb_state.Visible = true;
        }

        private void btn_deparment_Click(object sender, EventArgs e)
        {
            Page_department page = new Page_department();
            LoadPage(page);
            lb_state.Text = btn_deparment.Text;
            lb_state.Visible = true;
        }

        private void btn_semester_Click(object sender, EventArgs e)
        {
            Page_Semester page = new Page_Semester();
            LoadPage(page);
            lb_state.Text = btn_semester.Text;
            lb_state.Visible = true;
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            Page_Subject page = new Page_Subject();
            LoadPage(page);
            lb_state.Text = btn_subject.Text;
            lb_state.Visible = true;
        } 
        
        private void btn_teacher_Click(object sender, EventArgs e)
        {
            Page_Teacher page = new Page_Teacher();
            LoadPage(page);
            lb_state.Text = btn_teacher.Text;
            lb_state.Visible = true;
        }

      

        private void btn_add_trainers_Click(object sender, EventArgs e)
        {
            Page_trainers page = new Page_trainers();
            LoadPage(page);
            lb_state.Text = btn_add_trainers.Text;
            lb_state.Visible = true;
        }

        private void btn_group_Click(object sender, EventArgs e)
        {
            Page__Group page = new Page__Group();
            LoadPage(page);
            lb_state.Text = btn_group.Text;
            lb_state.Visible = true;
        }

        
        private void btn_stadyyear_Click(object sender, EventArgs e)
        {
            Page__Stadyyear page = new Page__Stadyyear();
            LoadPage(page);
            lb_state.Text = btn_stadyyear.Text;
            lb_state.Visible = true;

        }

       
        private void btn_user_management_Click(object sender, EventArgs e)
        {
            Page__Users page = new Page__Users();
            LoadPage(page);
            lb_state.Text = btn_user_management.Text;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            FRM_About page = new FRM_About();
            page.Show();
            lb_state.Text = btn_about.Text;
            lb_state.Visible = true;
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            FRM_Setting page = new FRM_Setting();
            page.ShowDialog();
            lb_state.Text = btn_setting.Text;
            lb_state.Visible = true;
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            lb_state.Text = btn_department.Text;

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            //lb_state.Text = btn_report.Text;
           // lb_state.Visible = true;
        }

        private void btn_add_coures_Click(object sender, EventArgs e)
        {
            Page__Course page = new Page__Course();
            LoadPage(page);
            lb_state.Text = btn_add_coures.Text;
            lb_state.Visible = true;
        }

        private void btn_logou_Click(object sender, EventArgs e)
        {
            FRM_Login frm = new FRM_Login();
            frm.Show();
            this.Hide();
            //lb_state.Text = btn_logou.Text;
            //lb_state.Visible = true;

        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            lb_state.Text = btn_logou.Text;
            lb_state.Visible = true;
        }

        private void btn_Material_distribution_Click(object sender, EventArgs e)
        {
            Page_Material_distribution page = new Page_Material_distribution();
            LoadPage(page);
            lb_state.Text = btn_Material_distribution.Text;
            lb_state.Visible = true;
        }

        private void btn_Monitor_scores_Click(object sender, EventArgs e)
        {
            Page_grades page = new Page_grades();
            LoadPage(page);
            lb_state.Text = btn_Monitor_scores.Text;
            lb_state.Visible = true;
        }

        private void btn_Material_download_Click(object sender, EventArgs e)
        {
            Page_Material_download page = new Page_Material_download();
            LoadPage(page);
            lb_state.Text = btn_Material_download.Text;
            lb_state.Visible = true;
        }

        private void btn_add_id_Click(object sender, EventArgs e)
        {
            Page_ID_Student page = new Page_ID_Student();
            LoadPage(page);
            lb_state.Text = btn_add_id.Text;
            lb_state.Visible = true;
        }

        private void btn__Click(object sender, EventArgs e)
        {

        }
    }
}
