using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CCTT.AddPage;
using CCTT.Pages;
using CCTT.Pages_LinkLable;
//using CCTT.PageTest;

namespace CCTT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            //Page_major(page_trainers1: new Page_trainers()
        }
    }
}