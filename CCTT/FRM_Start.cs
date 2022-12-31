using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace CCTT.AddPage
{
    public partial class FRM_Start : SplashScreen
    {
        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "جميع الحقوق المحفوظة © " + DateTime.Now.Year.ToString();
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
    }
}