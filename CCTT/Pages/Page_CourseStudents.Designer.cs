
namespace CCTT.Pages
{
    partial class Page_CourseStudents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_CourseStudents));
            this.lable5 = new System.Windows.Forms.Label();
            this.txt_coursestudent_studentcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colالرقم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالاسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالميلاد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالجهةالتابعلها = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالرقمالوطني = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرقمالهاتف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالبريدالالكتروني = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_coursestudent_email = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_coursestudent_fullname = new System.Windows.Forms.TextBox();
            this.txt_couresstudent_ = new System.Windows.Forms.TextBox();
            this.txt_coursestudent_phone = new System.Windows.Forms.TextBox();
            this.txt_coursestudent_brithdayy = new System.Windows.Forms.DateTimePicker();
            this.linkLabel_follow = new System.Windows.Forms.LinkLabel();
            this.txt_coursestudent_follow = new System.Windows.Forms.ComboBox();
            this.dB_CCTTDataSet2 = new CCTT.DB_CCTTDataSet2();
            this.getstudentcoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getstudentcoursTableAdapter = new CCTT.DB_CCTTDataSet2TableAdapters.getstudentcoursTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getstudentcoursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lable5
            // 
            this.lable5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lable5.AutoSize = true;
            this.lable5.BackColor = System.Drawing.Color.White;
            this.lable5.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable5.ForeColor = System.Drawing.Color.Black;
            this.lable5.Location = new System.Drawing.Point(246, 77);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(73, 25);
            this.lable5.TabIndex = 6;
            this.lable5.Text = "الميلاد";
            // 
            // txt_coursestudent_studentcode
            // 
            this.txt_coursestudent_studentcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_coursestudent_studentcode.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursestudent_studentcode.Location = new System.Drawing.Point(3, 4);
            this.txt_coursestudent_studentcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_coursestudent_studentcode.Name = "txt_coursestudent_studentcode";
            this.txt_coursestudent_studentcode.ReadOnly = true;
            this.txt_coursestudent_studentcode.Size = new System.Drawing.Size(237, 28);
            this.txt_coursestudent_studentcode.TabIndex = 0;
            this.txt_coursestudent_studentcode.Enter += new System.EventHandler(this.txt_coursestudent_studentcode_Enter);
            this.txt_coursestudent_studentcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_coursestudent_studentcode_KeyDown);
            this.txt_coursestudent_studentcode.Leave += new System.EventHandler(this.txt_coursestudent_studentcode_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(246, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "رمز طالب";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(246, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "الاسم";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.27046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.72954F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1427, 886);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(3, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1004, 878);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colالرقم,
            this.colالاسم,
            this.colتاريخالميلاد,
            this.colالجهةالتابعلها,
            this.colالرقمالوطني,
            this.colرقمالهاتف,
            this.colالبريدالالكتروني});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "أدخل نص للبحث....";
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colالرقم
            // 
            this.colالرقم.FieldName = "الرقم";
            this.colالرقم.MinWidth = 25;
            this.colالرقم.Name = "colالرقم";
            this.colالرقم.OptionsColumn.AllowEdit = false;
            this.colالرقم.Visible = true;
            this.colالرقم.VisibleIndex = 0;
            this.colالرقم.Width = 123;
            // 
            // colالاسم
            // 
            this.colالاسم.FieldName = "الاسم";
            this.colالاسم.MinWidth = 25;
            this.colالاسم.Name = "colالاسم";
            this.colالاسم.OptionsColumn.AllowEdit = false;
            this.colالاسم.Visible = true;
            this.colالاسم.VisibleIndex = 1;
            this.colالاسم.Width = 123;
            // 
            // colتاريخالميلاد
            // 
            this.colتاريخالميلاد.FieldName = "تاريخ الميلاد";
            this.colتاريخالميلاد.MinWidth = 25;
            this.colتاريخالميلاد.Name = "colتاريخالميلاد";
            this.colتاريخالميلاد.OptionsColumn.AllowEdit = false;
            this.colتاريخالميلاد.Visible = true;
            this.colتاريخالميلاد.VisibleIndex = 2;
            this.colتاريخالميلاد.Width = 123;
            // 
            // colالجهةالتابعلها
            // 
            this.colالجهةالتابعلها.FieldName = "الجهة التابع لها";
            this.colالجهةالتابعلها.MinWidth = 25;
            this.colالجهةالتابعلها.Name = "colالجهةالتابعلها";
            this.colالجهةالتابعلها.OptionsColumn.AllowEdit = false;
            this.colالجهةالتابعلها.Visible = true;
            this.colالجهةالتابعلها.VisibleIndex = 3;
            this.colالجهةالتابعلها.Width = 164;
            // 
            // colالرقمالوطني
            // 
            this.colالرقمالوطني.FieldName = "الرقم الوطني";
            this.colالرقمالوطني.MinWidth = 25;
            this.colالرقمالوطني.Name = "colالرقمالوطني";
            this.colالرقمالوطني.OptionsColumn.AllowEdit = false;
            this.colالرقمالوطني.Visible = true;
            this.colالرقمالوطني.VisibleIndex = 4;
            this.colالرقمالوطني.Width = 171;
            // 
            // colرقمالهاتف
            // 
            this.colرقمالهاتف.FieldName = "رقم الهاتف";
            this.colرقمالهاتف.MinWidth = 25;
            this.colرقمالهاتف.Name = "colرقمالهاتف";
            this.colرقمالهاتف.OptionsColumn.AllowEdit = false;
            this.colرقمالهاتف.Visible = true;
            this.colرقمالهاتف.VisibleIndex = 5;
            this.colرقمالهاتف.Width = 135;
            // 
            // colالبريدالالكتروني
            // 
            this.colالبريدالالكتروني.FieldName = "البريد الالكتروني";
            this.colالبريدالالكتروني.MinWidth = 25;
            this.colالبريدالالكتروني.Name = "colالبريدالالكتروني";
            this.colالبريدالالكتروني.OptionsColumn.AllowEdit = false;
            this.colالبريدالالكتروني.Visible = true;
            this.colالبريدالالكتروني.VisibleIndex = 6;
            this.colالبريدالالكتروني.Width = 194;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lable5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_coursestudent_studentcode, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.txt_coursestudent_email, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.txt_coursestudent_fullname, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_couresstudent_, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txt_coursestudent_phone, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.txt_coursestudent_brithdayy, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel_follow, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txt_coursestudent_follow, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1013, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 878);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(246, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "الرقم الوطني";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(246, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "رقم الهاتف";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(246, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "البريد الاكتروني";
            // 
            // txt_coursestudent_email
            // 
            this.txt_coursestudent_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_coursestudent_email.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursestudent_email.Location = new System.Drawing.Point(3, 220);
            this.txt_coursestudent_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_coursestudent_email.Name = "txt_coursestudent_email";
            this.txt_coursestudent_email.Size = new System.Drawing.Size(237, 28);
            this.txt_coursestudent_email.TabIndex = 6;
            this.txt_coursestudent_email.Enter += new System.EventHandler(this.txt_coursestudent_email_Enter);
            this.txt_coursestudent_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_coursestudent_studentcode_KeyDown);
            this.txt_coursestudent_email.Leave += new System.EventHandler(this.txt_coursestudent_email_Leave);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.Controls.Add(this.btn_print, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_update, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_edt, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 256);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(405, 89);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // btn_print
            // 
            this.btn_print.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_print.Location = new System.Drawing.Point(3, 4);
            this.btn_print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(77, 81);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "طباعة";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(161, 4);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(72, 81);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حدف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_update.Location = new System.Drawing.Point(86, 4);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(69, 81);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_edt
            // 
            this.btn_edt.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edt.Appearance.Options.UseFont = true;
            this.btn_edt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt.ImageOptions.Image")));
            this.btn_edt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_edt.Location = new System.Drawing.Point(239, 4);
            this.btn_edt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edt.Name = "btn_edt";
            this.btn_edt.Size = new System.Drawing.Size(71, 81);
            this.btn_edt.TabIndex = 2;
            this.btn_edt.Text = "تعديل";
            this.btn_edt.Click += new System.EventHandler(this.btn_edt_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Add.Location = new System.Drawing.Point(316, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(86, 81);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_coursestudent_fullname
            // 
            this.txt_coursestudent_fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_coursestudent_fullname.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursestudent_fullname.Location = new System.Drawing.Point(3, 40);
            this.txt_coursestudent_fullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_coursestudent_fullname.Name = "txt_coursestudent_fullname";
            this.txt_coursestudent_fullname.Size = new System.Drawing.Size(237, 28);
            this.txt_coursestudent_fullname.TabIndex = 1;
            this.txt_coursestudent_fullname.Enter += new System.EventHandler(this.txt_coursestudent_fullname_Enter);
            this.txt_coursestudent_fullname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_coursestudent_studentcode_KeyDown);
            this.txt_coursestudent_fullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_coursestudent_fullname_KeyPress);
            this.txt_coursestudent_fullname.Leave += new System.EventHandler(this.txt_coursestudent_fullname_Leave);
            // 
            // txt_couresstudent_
            // 
            this.txt_couresstudent_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_couresstudent_.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_couresstudent_.Location = new System.Drawing.Point(3, 148);
            this.txt_couresstudent_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_couresstudent_.Name = "txt_couresstudent_";
            this.txt_couresstudent_.Size = new System.Drawing.Size(237, 28);
            this.txt_couresstudent_.TabIndex = 4;
            this.txt_couresstudent_.Tag = "";
            this.txt_couresstudent_.Enter += new System.EventHandler(this.txt_couresstudent__Enter);
            this.txt_couresstudent_.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_coursestudent_studentcode_KeyDown);
            this.txt_couresstudent_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_couresstudent__KeyPress);
            this.txt_couresstudent_.Leave += new System.EventHandler(this.txt_couresstudent__Leave);
            // 
            // txt_coursestudent_phone
            // 
            this.txt_coursestudent_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_coursestudent_phone.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursestudent_phone.Location = new System.Drawing.Point(3, 184);
            this.txt_coursestudent_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_coursestudent_phone.Name = "txt_coursestudent_phone";
            this.txt_coursestudent_phone.Size = new System.Drawing.Size(237, 28);
            this.txt_coursestudent_phone.TabIndex = 5;
            this.txt_coursestudent_phone.Enter += new System.EventHandler(this.txt_coursestudent_phone_Enter);
            this.txt_coursestudent_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_coursestudent_studentcode_KeyDown);
            this.txt_coursestudent_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_coursestudent_phone_KeyPress);
            this.txt_coursestudent_phone.Leave += new System.EventHandler(this.txt_coursestudent_phone_Leave);
            // 
            // txt_coursestudent_brithdayy
            // 
            this.txt_coursestudent_brithdayy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_coursestudent_brithdayy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursestudent_brithdayy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_coursestudent_brithdayy.Location = new System.Drawing.Point(3, 76);
            this.txt_coursestudent_brithdayy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_coursestudent_brithdayy.Name = "txt_coursestudent_brithdayy";
            this.txt_coursestudent_brithdayy.RightToLeftLayout = true;
            this.txt_coursestudent_brithdayy.Size = new System.Drawing.Size(237, 27);
            this.txt_coursestudent_brithdayy.TabIndex = 2;
            this.txt_coursestudent_brithdayy.Enter += new System.EventHandler(this.txt_coursestudent_brithdayy_Enter);
            this.txt_coursestudent_brithdayy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_coursestudent_studentcode_KeyDown);
            this.txt_coursestudent_brithdayy.Leave += new System.EventHandler(this.txt_coursestudent_brithdayy_Leave);
            // 
            // linkLabel_follow
            // 
            this.linkLabel_follow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel_follow.AutoSize = true;
            this.linkLabel_follow.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_follow.Location = new System.Drawing.Point(246, 113);
            this.linkLabel_follow.Name = "linkLabel_follow";
            this.linkLabel_follow.Size = new System.Drawing.Size(162, 25);
            this.linkLabel_follow.TabIndex = 22;
            this.linkLabel_follow.TabStop = true;
            this.linkLabel_follow.Text = "الجيهة التابع لها";
            this.linkLabel_follow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_follow_LinkClicked);
            // 
            // txt_coursestudent_follow
            // 
            this.txt_coursestudent_follow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_coursestudent_follow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_coursestudent_follow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_coursestudent_follow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursestudent_follow.FormattingEnabled = true;
            this.txt_coursestudent_follow.Location = new System.Drawing.Point(3, 111);
            this.txt_coursestudent_follow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_coursestudent_follow.Name = "txt_coursestudent_follow";
            this.txt_coursestudent_follow.Size = new System.Drawing.Size(237, 29);
            this.txt_coursestudent_follow.TabIndex = 3;
            this.txt_coursestudent_follow.Enter += new System.EventHandler(this.txt_coursestudent_follow_Enter);
            this.txt_coursestudent_follow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_coursestudent_studentcode_KeyDown);
            this.txt_coursestudent_follow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_coursestudent_follow_KeyPress);
            this.txt_coursestudent_follow.Leave += new System.EventHandler(this.txt_coursestudent_follow_Leave);
            // 
            // dB_CCTTDataSet2
            // 
            this.dB_CCTTDataSet2.DataSetName = "DB_CCTTDataSet2";
            this.dB_CCTTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getstudentcoursBindingSource
            // 
            this.getstudentcoursBindingSource.DataMember = "getstudentcours";
            this.getstudentcoursBindingSource.DataSource = this.dB_CCTTDataSet2;
            // 
            // getstudentcoursTableAdapter
            // 
            this.getstudentcoursTableAdapter.ClearBeforeFill = true;
            // 
            // Page_CourseStudents
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Page_CourseStudents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1427, 886);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getstudentcoursBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.TextBox txt_coursestudent_studentcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_coursestudent_email;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_edt;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.TextBox txt_coursestudent_fullname;
        private System.Windows.Forms.TextBox txt_couresstudent_;
        private System.Windows.Forms.TextBox txt_coursestudent_phone;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DateTimePicker txt_coursestudent_brithdayy;
        private System.Windows.Forms.LinkLabel linkLabel_follow;
        public System.Windows.Forms.ComboBox txt_coursestudent_follow;
        private DevExpress.XtraGrid.Columns.GridColumn colالرقم;
        private DevExpress.XtraGrid.Columns.GridColumn colالاسم;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالميلاد;
        private DevExpress.XtraGrid.Columns.GridColumn colالجهةالتابعلها;
        private DevExpress.XtraGrid.Columns.GridColumn colالرقمالوطني;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالهاتف;
        private DevExpress.XtraGrid.Columns.GridColumn colالبريدالالكتروني;
        private DB_CCTTDataSet2 dB_CCTTDataSet2;
        private System.Windows.Forms.BindingSource getstudentcoursBindingSource;
        private DB_CCTTDataSet2TableAdapters.getstudentcoursTableAdapter getstudentcoursTableAdapter;
    }
}
