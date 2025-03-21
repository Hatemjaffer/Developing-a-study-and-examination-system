﻿using System;
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
using CCTT.DB_CCTTDataSet2TableAdapters;

namespace CCTT.Pages
{
    public partial class Page__StudentGrad : DevExpress.XtraEditors.XtraUserControl
    {
        // جلب قاعدة البيانات وجدول الاقسام
        DB_CCTTEntities db = new DB_CCTTEntities();
        Year tbYear = new Year();
        int ID;

        public Page__StudentGrad()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            txt_stdy_yere.DataSource = db.Year.Select(x => x.year_serch).ToList();
            txt_std_id.DataSource = db.students.Select(x => x.idColge).ToList();

        }


        // التاكد من فارغ الدخلات
        private void Add()
        {
            if (txt_std_id.Text == "" )
            {
                MessageBox.Show("الحقلول مطلوبة ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                AddData();
                LoadData();
            }
        }
        // دالة اضافة
        private void AddData()
        {
            try
            {
                var id4 = Convert.ToInt32(txt_std_id.SelectedItem.ToString());
                var id5 = txt_stdy_yere.SelectedItem.ToString();

                var idstd = db.students.Where(x => x.idColge == id4)
                    .Select(x => x.id)
                    .FirstOrDefault();
                var id7 = db.Year.Where(x => x.year_serch == id5)
                    .Select(x => x.id)
                    .FirstOrDefault();
                getResultStdBysemsterTableAdapter m = new getResultStdBysemsterTableAdapter();
                //new DB_CCTTDataSet2.checksemster_studentDataTable();
                m.Fill(new DB_CCTTDataSet1.getResultStdBysemsterDataTable(), idstd, id7);

                gridControl1.DataSource = m.GetData(idstd, id7);
                 }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btn_edt_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                if (ID > 0)
                {

                    tbYear = db.Year.Where(x => x.id == ID).FirstOrDefault();
                    tbYear.id = ID;
                  //  tbYear.season = txt_stadyyear_yeartype.SelectedItem.ToString();
                    if (txt_std_id.Text != "")
                        tbYear.year1 = Convert.ToInt32(txt_std_id.Text);

                  
                    db.Entry(tbYear).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("تم تعديل البيانات بالنجاح", "عملية تعديل", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }


            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

     

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لايمكن استرجاع البيانات", "اجراء حدف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {

                try
                {
                    ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                    if (ID > 0)
                    {
                        tbYear = db.Year.Where(x => x.id == ID).FirstOrDefault();

                        db.Entry(tbYear).State = EntityState.Deleted;
                        db.SaveChanges();

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحدفها");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
          //  txt_stadyyear.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idcolge").ToString();
         //   txt_stadyyear_yeartype.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "season").ToString();
            txt_std_id.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "year1").ToString();

        }

        private void txt_stadyyear_yearcode_Enter(object sender, EventArgs e)
        {
          //  txt_stadyyear.BackColor = Color.Yellow;

        }

        private void txt_stadyyear_yearcode_Leave(object sender, EventArgs e)
        {
            //txt_stadyyear.BackColor = Color.White;

        }

        private void txt_stady_year_year_Enter(object sender, EventArgs e)
        {
            txt_std_id.BackColor = Color.Yellow;

        }

        private void txt_stady_year_year_Leave(object sender, EventArgs e)
        {
            txt_std_id.BackColor = Color.White;

        }

        private void txt_stadyyear_yeartype_Enter(object sender, EventArgs e)
        {
            //txt_stadyyear_yeartype.BackColor = Color.Yellow;

        }

        private void txt_stadyyear_yeartype_Leave(object sender, EventArgs e)
        {
           // txt_stadyyear_yeartype.BackColor = Color.White;

        }

        private void txt_stadyyear_yearcode_MouseDown(object sender, MouseEventArgs e)
        {
           // eroer

        }

        private void txt_stadyyear_yearcode_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_stadyyear_yeartype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
