namespace CCTT.Pages
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo10 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo11 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo12 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo13 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.getMainCoursV2TableAdapter = new CCTT.DB_CCTTDataSet2TableAdapters.getMainCoursV2TableAdapter();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.colSTD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOTHER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_PLACE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_SEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHADA_KIND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHADA_PLACE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHADA_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONY_KIND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_STATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_DFA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_GEN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.excelDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(899, 493);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTD_NO,
            this.colSTD_NAME,
            this.colMOTHER_NAME,
            this.colSTD_DATE,
            this.colSTD_PLACE,
            this.colSTD_SEX,
            this.colSHHADA_KIND,
            this.colSHHADA_PLACE,
            this.colSHHADA_DATE,
            this.colMONY_KIND,
            this.colSTD_STATE,
            this.colSTD_DFA,
            this.colSTD_GEN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // getMainCoursV2TableAdapter
            // 
            this.getMainCoursV2TableAdapter.ClearBeforeFill = true;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "C:\\Users\\HPX\\Desktop\\STD_FILE.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "STD_NO";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "STD_NAME";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "MOTHER_NAME";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "STD_DATE";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "STD_PLACE";
            fieldInfo5.Type = typeof(string);
            fieldInfo6.Name = "STD_SEX";
            fieldInfo6.Type = typeof(double);
            fieldInfo7.Name = "SHHADA_KIND";
            fieldInfo7.Type = typeof(double);
            fieldInfo8.Name = "SHHADA_PLACE";
            fieldInfo8.Type = typeof(string);
            fieldInfo9.Name = "SHHADA_DATE";
            fieldInfo9.Type = typeof(string);
            fieldInfo10.Name = "MONY_KIND";
            fieldInfo10.Type = typeof(double);
            fieldInfo11.Name = "STD_STATE";
            fieldInfo11.Type = typeof(double);
            fieldInfo12.Name = "STD_DFA";
            fieldInfo12.Type = typeof(double);
            fieldInfo13.Name = "STD_GEN";
            fieldInfo13.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9,
            fieldInfo10,
            fieldInfo11,
            fieldInfo12,
            fieldInfo13});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "STD_FILE";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // colSTD_NO
            // 
            this.colSTD_NO.FieldName = "STD_NO";
            this.colSTD_NO.Name = "colSTD_NO";
            this.colSTD_NO.Visible = true;
            this.colSTD_NO.VisibleIndex = 0;
            // 
            // colSTD_NAME
            // 
            this.colSTD_NAME.FieldName = "STD_NAME";
            this.colSTD_NAME.Name = "colSTD_NAME";
            this.colSTD_NAME.Visible = true;
            this.colSTD_NAME.VisibleIndex = 1;
            // 
            // colMOTHER_NAME
            // 
            this.colMOTHER_NAME.FieldName = "MOTHER_NAME";
            this.colMOTHER_NAME.Name = "colMOTHER_NAME";
            this.colMOTHER_NAME.Visible = true;
            this.colMOTHER_NAME.VisibleIndex = 2;
            // 
            // colSTD_DATE
            // 
            this.colSTD_DATE.FieldName = "STD_DATE";
            this.colSTD_DATE.Name = "colSTD_DATE";
            this.colSTD_DATE.Visible = true;
            this.colSTD_DATE.VisibleIndex = 3;
            // 
            // colSTD_PLACE
            // 
            this.colSTD_PLACE.FieldName = "STD_PLACE";
            this.colSTD_PLACE.Name = "colSTD_PLACE";
            this.colSTD_PLACE.Visible = true;
            this.colSTD_PLACE.VisibleIndex = 4;
            // 
            // colSTD_SEX
            // 
            this.colSTD_SEX.FieldName = "STD_SEX";
            this.colSTD_SEX.Name = "colSTD_SEX";
            this.colSTD_SEX.Visible = true;
            this.colSTD_SEX.VisibleIndex = 5;
            // 
            // colSHHADA_KIND
            // 
            this.colSHHADA_KIND.FieldName = "SHHADA_KIND";
            this.colSHHADA_KIND.Name = "colSHHADA_KIND";
            this.colSHHADA_KIND.Visible = true;
            this.colSHHADA_KIND.VisibleIndex = 6;
            // 
            // colSHHADA_PLACE
            // 
            this.colSHHADA_PLACE.FieldName = "SHHADA_PLACE";
            this.colSHHADA_PLACE.Name = "colSHHADA_PLACE";
            this.colSHHADA_PLACE.Visible = true;
            this.colSHHADA_PLACE.VisibleIndex = 7;
            // 
            // colSHHADA_DATE
            // 
            this.colSHHADA_DATE.FieldName = "SHHADA_DATE";
            this.colSHHADA_DATE.Name = "colSHHADA_DATE";
            this.colSHHADA_DATE.Visible = true;
            this.colSHHADA_DATE.VisibleIndex = 8;
            // 
            // colMONY_KIND
            // 
            this.colMONY_KIND.FieldName = "MONY_KIND";
            this.colMONY_KIND.Name = "colMONY_KIND";
            this.colMONY_KIND.Visible = true;
            this.colMONY_KIND.VisibleIndex = 9;
            // 
            // colSTD_STATE
            // 
            this.colSTD_STATE.FieldName = "STD_STATE";
            this.colSTD_STATE.Name = "colSTD_STATE";
            this.colSTD_STATE.Visible = true;
            this.colSTD_STATE.VisibleIndex = 10;
            // 
            // colSTD_DFA
            // 
            this.colSTD_DFA.FieldName = "STD_DFA";
            this.colSTD_DFA.Name = "colSTD_DFA";
            this.colSTD_DFA.Visible = true;
            this.colSTD_DFA.VisibleIndex = 11;
            // 
            // colSTD_GEN
            // 
            this.colSTD_GEN.FieldName = "STD_GEN";
            this.colSTD_GEN.Name = "colSTD_GEN";
            this.colSTD_GEN.Visible = true;
            this.colSTD_GEN.VisibleIndex = 12;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 493);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DB_CCTTDataSet2TableAdapters.getMainCoursV2TableAdapter getMainCoursV2TableAdapter;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colMOTHER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_PLACE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_SEX;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHADA_KIND;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHADA_PLACE;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHADA_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colMONY_KIND;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_STATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_DFA;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_GEN;
    }
}