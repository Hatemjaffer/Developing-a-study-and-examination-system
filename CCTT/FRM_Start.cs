using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace CCTT.AddPage
{
    public partial class FRM_Start : SplashScreen
    {
        DB_CCTTEntities db;
        int state;
        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "جميع الحقوق المحفوظة © " + DateTime.Now.Year.ToString();
        }
        private int Chack_StartApp()
        {
            try
            {
                db = new DB_CCTTEntities();
                var usernameid = db.users.Select(x => x.id).FirstOrDefault();
                if (usernameid >= 1) // تأكد من وجود مستخدمين
                {
                    state = 1;
                }
                else
                {

                    state = 2;
                }
            }
            catch
            {
                state = 0;
            }

            return state;
        }
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private async void FRM_Start_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(2000));

            labelStatus.Text = ".......جاري الاتصال بقاعد البيانات";
            var st = await Task.Run(() => Chack_StartApp());
            if (st == 0)
            {
                MessageBox.Show("هنالك خظأ في الاتصال بالسيرفر");
                Application.Exit();
            }
            else if (st == 1)
            {
                //showLogin
                FRM_Login frm_user = new FRM_Login();
                frm_user.Show();
                this.Hide();


            }
        }
    }
}