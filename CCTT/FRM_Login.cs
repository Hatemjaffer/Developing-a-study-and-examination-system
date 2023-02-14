using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;

namespace CCTT.AddPage
{
    public partial class FRM_Login : DevExpress.XtraEditors.XtraForm
    {
        DB_CCTTEntities db = new DB_CCTTEntities();
        user add = new user();
        Main main = new Main();

        public FRM_Login()
        {
            InitializeComponent();
        }

        //-------------------------------------------------Desing Login

        private void text_Name_Enter(object sender, EventArgs e)
        {
            if (text_Name.Text == "اسم المستخدم")
            {
                text_Name.Text = "";
                text_Name.ForeColor = Color.Black;
            }
        }

        private void text_Name_MouseLeave(object sender, EventArgs e)
        {
            if (text_Name.Text == "")
            {
                text_Name.Text = "اسم المستخدم";
                text_Name.ForeColor = Color.Black;
            }

        }

        private void text_pass_Enter(object sender, EventArgs e)
        {
            if (text_pass.Text == "كلمة المرور")
            {
                text_pass.Text = "";
                text_pass.ForeColor = Color.Black;
                text_pass.UseSystemPasswordChar = true;
            }
        }

        private void text_pass_MouseLeave(object sender, EventArgs e)
        {
            if (text_pass.Text == "")
            {
                text_pass.Text = "كلمة المرور";
                text_pass.ForeColor = Color.Black;
                text_pass.UseSystemPasswordChar = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            btn_login.ForeColor = Color.CornflowerBlue;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.ForeColor = Color.Black;

        }

        //-----------------------------------------------------------End Desing Login
        private void btn_login_Click(object sender, EventArgs e)
        {
            //Chack filed
            if (text_Name.Text == "" || text_pass.Text == "" || text_Name.Text == "اسم المستخدم" || text_pass.Text == "كلمة المرور")
               
            {
                MessageBox.Show("جميع الحقول مطلوبة", "خطأ في دخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    add = db.users.Where(x => x.name == text_Name.Text && x.password == text_pass.Text)
                        .FirstOrDefault();

                    if (add != null)
                    {
                        //Login صلاحيات
                       // if (add.permioi_type == "مستخدم") // تحتاج تحويل لان حقل هذا int
                       // {
                            //  main.ٍbtn.....Visible = false;

                       // }
                        // ادا كان مدير


                        add.name = add.name;
                        add.password = add.password;
                        add.permioi_type = add.permioi_type;
                        db.Entry(add).State = System.Data.Entity.EntityState.Modified;



                        main.txt_username.Caption = add.name;

                       // main.txt_role.Caption = add.permioi_type;

                        db.SaveChanges();
                        main.Show();
                        Hide();

                    }
                    else
                    {
                        MessageBox.Show("معلومات تسجيل الدخول خاظئة");

                    }
                }
                catch
                {
                    MessageBox.Show("فقد الاتصال باقاعدة البيانات", "حظأ في الاتصال", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                }
            }




        }

        private void text_Name_KeyDown(object sender, KeyEventArgs e)
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