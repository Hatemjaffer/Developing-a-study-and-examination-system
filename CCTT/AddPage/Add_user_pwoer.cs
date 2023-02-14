using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CCTT.AddPage
{
    public partial class Add_user_pwoer : DevExpress.XtraEditors.XtraForm
    {
         DB_CCTTEntities db;
        public Add_user_pwoer()
        {
            InitializeComponent();
           // txt_users.DataSource = db.users.Select(x => x.name).ToList();
        }
    }
}