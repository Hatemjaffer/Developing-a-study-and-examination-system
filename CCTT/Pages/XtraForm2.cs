﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CCTT.Pages
{
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm2()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the ExcelDataSource asynchronously
            excelDataSource1.FillAsync();
        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CCTTDataSet21.getMainCoursV2' table. You can move, or remove it, as needed.
         //   this.getMainCoursV2TableAdapter.Fill(this.dB_CCTTDataSet21.getMainCoursV2);

        }
    }
}