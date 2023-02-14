using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CCTT
{
    public partial class FRM_Setting : DevExpress.XtraEditors.XtraForm
    {
        MemoryStream ma;
        DB_CCTTEntities db = new DB_CCTTEntities();

        public FRM_Setting()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save_Setting();
            Close();

        }

        public void Set_Setting()
        {
            var collogename = Properties.Settings.Default.colloge_name;//اسم كلية
            var presidentname = Properties.Settings.Default.president_name;//اسم عميد
            var coursesdepartment = Properties.Settings.Default.courses_department;//رئيس قسم دورات
            var developmeny_manager = Properties.Settings.Default.developmeny_manager;//مدير تنمية الموارد

            txt_colloge_name.Text = collogename;
            txt_president_name.Text = presidentname;
            txt_courese_dep.Text = coursesdepartment;
            txt_developmeny_manager.Text = developmeny_manager;

            try
            {
                var imagebyt = Convert.FromBase64String(Properties.Settings.Default.pic_logo);
                ma = new MemoryStream(imagebyt);
                txt_pic_logo.Image = Image.FromStream(ma);
            }
            catch
            {
            }

        }

        private void Save_Setting()
        {
            Properties.Settings.Default.colloge_name = txt_colloge_name.Text;//اسم كلية
            Properties.Settings.Default.president_name = txt_president_name.Text;//اسم العميد
            Properties.Settings.Default.courses_department = txt_courese_dep.Text;//رئيس قسم دورات
            Properties.Settings.Default.developmeny_manager = txt_developmeny_manager.Text;//مدير تنمية الموارد

            try
            {
                ma = new MemoryStream();
                txt_pic_logo.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.pic_logo = Convert.ToBase64String(ma.ToArray());
            }
            catch
            {
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفط الاعدادات بانجاح");
        }

        private void FRM_Setting_Load(object sender, EventArgs e)
        {
            Set_Setting();
        }

        private async void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    pn_progress.Visible = true;

                    var result = await Task.Run(() => BackUp(folder)); //Time
                    if (result == true)
                    {
                        MessageBox.Show("تم النسخ الاحطياطي بنجاح");
                        pn_progress.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("خظأ, لا يمكن النسخ الاحطياطي الا في المسار المحدد , الرجاء تحديد مسار في المختلف , تذكر لا تحدد القرص C","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        pn_progress.Visible = false;

                    }
                }
            }
            catch
            {
                MessageBox.Show("C خظأ , لا يمكن النسخ الاحطياطي الا في المسار المحدد , الرجاء تحديد مسار المختلف , تذكر لا تحدد القرص C","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                pn_progress.Visible = false;
            }
        }
        //Backup
        private bool BackUp(FolderBrowserDialog folder)
        {
            try
            {
                String dbname = db.Database.Connection.Database;
                String dbBackup = "CCTTback" + DateTime.Now.ToString("yyyyMMddHHmm");//اسم مبدئي للباك اب     وتاريخ وقت 
                var fullpath = folder.SelectedPath.ToString() + dbBackup + ".bak";
                String sqlcommand = @"BACKUP DATABASE [{0}] TO DISK = '" + fullpath + "'WITH NOFORMAT , NOINIT , NAME = N'DBMDD' , SKIP , NOREWIND , NOUNLOAD , STATS = 10";
                int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, String.Format(sqlcommand, dbname, dbBackup));
                return true;
            }
            catch
            {
                return false; //لما يكون عندك خظأ
            }
        }
        //Restore
        private async void btn_restore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog folder = new OpenFileDialog();//......
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    pn_progress.Visible = true;

                    var result = await Task.Run(() => Restore(folder));//....
                    if (result == true)
                    {

                        pn_progress.Visible = false;
                        MessageBox.Show("تم اعادة النسخ الاحطياظي بنجاح");
                    }
                    else
                    {
                        pn_progress.Visible = false;
                        MessageBox.Show("  خظأ ,استعادة النسخة الاحطياطية , قم بتجربة تشغيل البرنامج كا مسؤول جتي تتمكن من اتمام العملية");


                    }
                }
            }
            catch (Exception ex)
            {
                pn_progress.Visible = false;
                MessageBox.Show("خظأ,استعادة النسخة الاحطياطية , قم بتجربة تشغيل البرنامج كا مسؤول جتي تتمكن من اتمام العملية" + ex);

            }
        }

        private bool Restore(OpenFileDialog folder)
        {
            try
            {
               
                String dbname = db.Database.Connection.Database;

                String sqlcommand = @"Use master;Restore DATABASE [{0}] From DISK = '" + folder.FileName + "'";
                int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, String.Format(sqlcommand, dbname));//int path لانها بترجع يا  0 , 1
                return true;
            }
            catch
            {
                return false; // لما يكون عندك خظأ يرجعلك 
            }
        }
       

    }
}