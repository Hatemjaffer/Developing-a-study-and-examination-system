namespace CCTT.Pages
{
    partial class XtraForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm2));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.getMainCoursV2TableAdapter = new CCTT.DB_CCTTDataSet2TableAdapters.getMainCoursV2TableAdapter();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.colSUBJECT_SYM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_KIND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_STATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_CLASS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASS_GRADE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_HOUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_BERIF = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(721, 446);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSUBJECT_SYM,
            this.colSUBJECT_NAME,
            this.colSUBJECT_KIND,
            this.colSUBJECT_STATE,
            this.colSUBJECT_CLASS,
            this.colPASS_GRADE,
            this.colSUBJECT_HOUR,
            this.colSUBJECT_BERIF});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // getMainCoursV2TableAdapter
            // 
            this.getMainCoursV2TableAdapter.ClearBeforeFill = true;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "C:\\Users\\HPX\\Desktop\\SUBJECT_FILE.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "SUBJECT_SYM";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "SUBJECT_NAME";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "SUBJECT_KIND";
            fieldInfo3.Type = typeof(double);
            fieldInfo4.Name = "SUBJECT_STATE";
            fieldInfo4.Type = typeof(double);
            fieldInfo5.Name = "SUBJECT_CLASS";
            fieldInfo5.Type = typeof(double);
            fieldInfo6.Name = "PASS_GRADE";
            fieldInfo6.Type = typeof(double);
            fieldInfo7.Name = "SUBJECT_HOUR";
            fieldInfo7.Type = typeof(double);
            fieldInfo8.Name = "SUBJECT_BERIF";
            fieldInfo8.Type = typeof(string);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "SUBJECT_FILE";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // colSUBJECT_SYM
            // 
            this.colSUBJECT_SYM.FieldName = "SUBJECT_SYM";
            this.colSUBJECT_SYM.Name = "colSUBJECT_SYM";
            this.colSUBJECT_SYM.Visible = true;
            this.colSUBJECT_SYM.VisibleIndex = 0;
            // 
            // colSUBJECT_NAME
            // 
            this.colSUBJECT_NAME.FieldName = "SUBJECT_NAME";
            this.colSUBJECT_NAME.Name = "colSUBJECT_NAME";
            this.colSUBJECT_NAME.Visible = true;
            this.colSUBJECT_NAME.VisibleIndex = 1;
            // 
            // colSUBJECT_KIND
            // 
            this.colSUBJECT_KIND.FieldName = "SUBJECT_KIND";
            this.colSUBJECT_KIND.Name = "colSUBJECT_KIND";
            this.colSUBJECT_KIND.Visible = true;
            this.colSUBJECT_KIND.VisibleIndex = 2;
            // 
            // colSUBJECT_STATE
            // 
            this.colSUBJECT_STATE.FieldName = "SUBJECT_STATE";
            this.colSUBJECT_STATE.Name = "colSUBJECT_STATE";
            this.colSUBJECT_STATE.Visible = true;
            this.colSUBJECT_STATE.VisibleIndex = 3;
            // 
            // colSUBJECT_CLASS
            // 
            this.colSUBJECT_CLASS.FieldName = "SUBJECT_CLASS";
            this.colSUBJECT_CLASS.Name = "colSUBJECT_CLASS";
            this.colSUBJECT_CLASS.Visible = true;
            this.colSUBJECT_CLASS.VisibleIndex = 4;
            // 
            // colPASS_GRADE
            // 
            this.colPASS_GRADE.FieldName = "PASS_GRADE";
            this.colPASS_GRADE.Name = "colPASS_GRADE";
            this.colPASS_GRADE.Visible = true;
            this.colPASS_GRADE.VisibleIndex = 5;
            // 
            // colSUBJECT_HOUR
            // 
            this.colSUBJECT_HOUR.FieldName = "SUBJECT_HOUR";
            this.colSUBJECT_HOUR.Name = "colSUBJECT_HOUR";
            this.colSUBJECT_HOUR.Visible = true;
            this.colSUBJECT_HOUR.VisibleIndex = 6;
            // 
            // colSUBJECT_BERIF
            // 
            this.colSUBJECT_BERIF.FieldName = "SUBJECT_BERIF";
            this.colSUBJECT_BERIF.Name = "colSUBJECT_BERIF";
            this.colSUBJECT_BERIF.Visible = true;
            this.colSUBJECT_BERIF.VisibleIndex = 7;
            // 
            // XtraForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 446);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraForm2";
            this.Text = "XtraForm2";
            this.Load += new System.EventHandler(this.XtraForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DB_CCTTDataSet2TableAdapters.getMainCoursV2TableAdapter getMainCoursV2TableAdapter;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_SYM;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_KIND;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_STATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_CLASS;
        private DevExpress.XtraGrid.Columns.GridColumn colPASS_GRADE;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_HOUR;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_BERIF;
    }
}