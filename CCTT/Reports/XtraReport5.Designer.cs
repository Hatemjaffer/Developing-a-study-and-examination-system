namespace CCTT.Reports
{
    partial class XtraReport5
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.EntityFramework.EFConnectionParameters efConnectionParameters1 = new DevExpress.DataAccess.EntityFramework.EFConnectionParameters();
            DevExpress.DataAccess.EntityFramework.EFStoredProcedureInfo efStoredProcedureInfo1 = new DevExpress.DataAccess.EntityFramework.EFStoredProcedureInfo();
            DevExpress.DataAccess.EntityFramework.EFParameter efParameter1 = new DevExpress.DataAccess.EntityFramework.EFParameter();
            DevExpress.DataAccess.EntityFramework.EFParameter efParameter2 = new DevExpress.DataAccess.EntityFramework.EFParameter();
            DevExpress.DataAccess.EntityFramework.EFStoredProcedureInfo efStoredProcedureInfo2 = new DevExpress.DataAccess.EntityFramework.EFStoredProcedureInfo();
            DevExpress.DataAccess.EntityFramework.EFParameter efParameter3 = new DevExpress.DataAccess.EntityFramework.EFParameter();
            DevExpress.DataAccess.EntityFramework.EFParameter efParameter4 = new DevExpress.DataAccess.EntityFramework.EFParameter();
            DevExpress.DataAccess.EntityFramework.EFConnectionParameters efConnectionParameters2 = new DevExpress.DataAccess.EntityFramework.EFConnectionParameters();
            DevExpress.DataAccess.EntityFramework.EFStoredProcedureInfo efStoredProcedureInfo3 = new DevExpress.DataAccess.EntityFramework.EFStoredProcedureInfo();
            DevExpress.DataAccess.EntityFramework.EFParameter efParameter5 = new DevExpress.DataAccess.EntityFramework.EFParameter();
            DevExpress.DataAccess.EntityFramework.EFParameter efParameter6 = new DevExpress.DataAccess.EntityFramework.EFParameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.efDataSource1 = new DevExpress.DataAccess.EntityFramework.EFDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dB_CCTTDataSet21 = new CCTT.DB_CCTTDataSet2();
            this.get_main_cours_student_grade1TableAdapter = new CCTT.DB_CCTTDataSet2TableAdapters.get_main_cours_student_grade1TableAdapter();
            this.dB_CCTTDataSet22 = new CCTT.DB_CCTTDataSet2();
            this.get_main_cours_student_grade1TableAdapter1 = new CCTT.DB_CCTTDataSet1TableAdapters.get_main_cours_student_grade1TableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.std_idP = new DevExpress.XtraReports.Parameters.Parameter();
            this.efDataSource2 = new DevExpress.DataAccess.EntityFramework.EFDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // efDataSource1
            // 
            efConnectionParameters1.ConnectionString = "";
            efConnectionParameters1.ConnectionStringName = "DB_CCTTEntities";
            efConnectionParameters1.Source = typeof(CCTT.DB_CCTTEntities);
            this.efDataSource1.ConnectionParameters = efConnectionParameters1;
            this.efDataSource1.Name = "efDataSource1";
            efStoredProcedureInfo1.Name = "get_main_cours_student_year1";
            efParameter1.Name = "std_id";
            efParameter1.Type = typeof(int);
            efParameter1.ValueInfo = "0";
            efParameter2.Name = "year_id";
            efParameter2.Type = typeof(int);
            efParameter2.ValueInfo = "0";
            efStoredProcedureInfo1.Parameters.AddRange(new DevExpress.DataAccess.EntityFramework.EFParameter[] {
            efParameter1,
            efParameter2});
            efStoredProcedureInfo2.Name = "get_main_cours_student_year";
            efParameter3.Name = "std_id";
            efParameter3.Type = typeof(int);
            efParameter4.Name = "year_id";
            efParameter4.Type = typeof(int);
            efStoredProcedureInfo2.Parameters.AddRange(new DevExpress.DataAccess.EntityFramework.EFParameter[] {
            efParameter3,
            efParameter4});
            this.efDataSource1.StoredProcedures.AddRange(new DevExpress.DataAccess.EntityFramework.EFStoredProcedureInfo[] {
            efStoredProcedureInfo1,
            efStoredProcedureInfo2});
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // GroupCaption2
            // 
            this.GroupCaption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.GroupCaption2.BorderColor = System.Drawing.Color.White;
            this.GroupCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption2.BorderWidth = 2F;
            this.GroupCaption2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupCaption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption2.Name = "GroupCaption2";
            this.GroupCaption2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData2
            // 
            this.GroupData2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.GroupData2.BorderColor = System.Drawing.Color.White;
            this.GroupData2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData2.BorderWidth = 2F;
            this.GroupData2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupData2.ForeColor = System.Drawing.Color.White;
            this.GroupData2.Name = "GroupData2";
            this.GroupData2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupData2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailCaption2
            // 
            this.DetailCaption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.DetailCaption2.BorderColor = System.Drawing.Color.White;
            this.DetailCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption2.BorderWidth = 2F;
            this.DetailCaption2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DetailCaption2.ForeColor = System.Drawing.Color.White;
            this.DetailCaption2.Name = "DetailCaption2";
            this.DetailCaption2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData2
            // 
            this.DetailData2.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData2.BorderWidth = 2F;
            this.DetailData2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData2.ForeColor = System.Drawing.Color.Black;
            this.DetailData2.Name = "DetailData2";
            this.DetailData2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupFooterBackground3
            // 
            this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
            this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupFooterBackground3.BorderWidth = 2F;
            this.GroupFooterBackground3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupFooterBackground3.Name = "GroupFooterBackground3";
            this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // dB_CCTTDataSet21
            // 
            this.dB_CCTTDataSet21.DataSetName = "DB_CCTTDataSet2";
            this.dB_CCTTDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_main_cours_student_grade1TableAdapter
            // 
            this.get_main_cours_student_grade1TableAdapter.ClearBeforeFill = true;
            // 
            // dB_CCTTDataSet22
            // 
            this.dB_CCTTDataSet22.DataSetName = "DB_CCTTDataSet2";
            this.dB_CCTTDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_main_cours_student_grade1TableAdapter1
            // 
            this.get_main_cours_student_grade1TableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(CCTT.get_main_cours_student_grade1_Result);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(CCTT.get_main_cours_student_grade1_Result);
            // 
            // std_idP
            // 
            this.std_idP.Name = "std_idP";
            this.std_idP.Type = typeof(int);
            this.std_idP.ValueInfo = "0";
            // 
            // efDataSource2
            // 
            efConnectionParameters2.ConnectionString = "";
            efConnectionParameters2.ConnectionStringName = "DB_CCTTEntities";
            efConnectionParameters2.Source = typeof(CCTT.DB_CCTTEntities);
            this.efDataSource2.ConnectionParameters = efConnectionParameters2;
            this.efDataSource2.Name = "efDataSource2";
            efStoredProcedureInfo3.Name = "get_main_cours_student_year";
            efParameter5.Name = "std_id";
            efParameter5.Type = typeof(int);
            efParameter5.ValueInfo = "0";
            efParameter6.Name = "year_id";
            efParameter6.Type = typeof(int);
            efParameter6.ValueInfo = "0";
            efStoredProcedureInfo3.Parameters.AddRange(new DevExpress.DataAccess.EntityFramework.EFParameter[] {
            efParameter5,
            efParameter6});
            this.efDataSource2.StoredProcedures.AddRange(new DevExpress.DataAccess.EntityFramework.EFStoredProcedureInfo[] {
            efStoredProcedureInfo3});
            // 
            // XtraReport5
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.efDataSource1,
            this.dB_CCTTDataSet21,
            this.dB_CCTTDataSet22,
            this.bindingSource1,
            this.bindingSource2,
            this.efDataSource2});
            this.DataAdapter = this.get_main_cours_student_grade1TableAdapter;
            this.DataMember = "nationality";
            this.DataSource = this.efDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.std_idP});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption2,
            this.GroupData2,
            this.DetailCaption2,
            this.DetailData2,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.EntityFramework.EFDataSource efDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption2;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData2;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption2;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData2;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DB_CCTTDataSet2 dB_CCTTDataSet21;
        private DB_CCTTDataSet2TableAdapters.get_main_cours_student_grade1TableAdapter get_main_cours_student_grade1TableAdapter;
        private DB_CCTTDataSet2 dB_CCTTDataSet22;
        private DB_CCTTDataSet1TableAdapters.get_main_cours_student_grade1TableAdapter get_main_cours_student_grade1TableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraReports.Parameters.Parameter std_idP;
        private DevExpress.DataAccess.EntityFramework.EFDataSource efDataSource2;
    }
}
