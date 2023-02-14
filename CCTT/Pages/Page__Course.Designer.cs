namespace CCTT.Pages
{
    partial class Page__Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page__Course));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getstdmaincourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CCTTDataSet2 = new CCTT.DB_CCTTDataSet2();
            this.btn_edt_click = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_coures_pries = new System.Windows.Forms.TextBox();
            this.txt_course_trainers = new System.Windows.Forms.ComboBox();
            this.txt_course_max_student = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_coures_Maximum_number_of_students = new System.Windows.Forms.Label();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_course_code = new System.Windows.Forms.TextBox();
            this.txt_course_name = new System.Windows.Forms.TextBox();
            this.txt_course_information = new System.Windows.Forms.TextBox();
            this.txt_stratdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_enddate = new System.Windows.Forms.DateTimePicker();
            this.txt_course_houres = new System.Windows.Forms.TextBox();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_course_state = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.get_std_main_courseTableAdapter = new CCTT.DB_CCTTDataSet2TableAdapters.get_std_main_courseTableAdapter();
            this.getstdmaincourseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getstdmaincourseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.colالرقم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرمزالدورة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالدورة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colمعلوماتعنالدورة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالسعر = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمدرب = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colعددالطلبةالاقصي = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالبداية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخنهاية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colعددالساعات = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالايام = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colحالةالدورة = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getstdmaincourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getstdmaincourseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getstdmaincourseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colالرقم,
            this.colرمزالدورة,
            this.colاسمالدورة,
            this.colمعلوماتعنالدورة,
            this.colالسعر,
            this.colالمدرب,
            this.colعددالطلبةالاقصي,
            this.colتاريخالبداية,
            this.colتاريخنهاية,
            this.colعددالساعات,
            this.coldays,
            this.colالايام,
            this.colحالةالدورة});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "أدخل نص للبحث....";
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.getstdmaincourseBindingSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(3, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(962, 878);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // getstdmaincourseBindingSource
            // 
            this.getstdmaincourseBindingSource.DataMember = "get_std_main_course";
            this.getstdmaincourseBindingSource.DataSource = this.dB_CCTTDataSet2;
            // 
            // dB_CCTTDataSet2
            // 
            this.dB_CCTTDataSet2.DataSetName = "DB_CCTTDataSet2";
            this.dB_CCTTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_edt_click
            // 
            this.btn_edt_click.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edt_click.Appearance.Options.UseFont = true;
            this.btn_edt_click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edt_click.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt_click.ImageOptions.Image")));
            this.btn_edt_click.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_edt_click.Location = new System.Drawing.Point(245, 4);
            this.btn_edt_click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edt_click.Name = "btn_edt_click";
            this.btn_edt_click.Size = new System.Drawing.Size(88, 75);
            this.btn_edt_click.TabIndex = 2;
            this.btn_edt_click.Text = "تعديل";
            this.btn_edt_click.Click += new System.EventHandler(this.btn_edt_click_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Add.Location = new System.Drawing.Point(339, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(105, 75);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "السعر ";
            // 
            // txt_coures_pries
            // 
            this.txt_coures_pries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_coures_pries.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coures_pries.Location = new System.Drawing.Point(3, 179);
            this.txt_coures_pries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_coures_pries.Name = "txt_coures_pries";
            this.txt_coures_pries.Size = new System.Drawing.Size(246, 28);
            this.txt_coures_pries.TabIndex = 3;
            this.txt_coures_pries.Enter += new System.EventHandler(this.txt_coures_pries_Enter);
            this.txt_coures_pries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.txt_coures_pries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_coures_pries_KeyPress);
            this.txt_coures_pries.Leave += new System.EventHandler(this.txt_coures_pries_Leave);
            // 
            // txt_course_trainers
            // 
            this.txt_course_trainers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_course_trainers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_course_trainers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_course_trainers.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course_trainers.FormattingEnabled = true;
            this.txt_course_trainers.Items.AddRange(new object[] {
            ""});
            this.txt_course_trainers.Location = new System.Drawing.Point(3, 215);
            this.txt_course_trainers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_course_trainers.Name = "txt_course_trainers";
            this.txt_course_trainers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_course_trainers.Size = new System.Drawing.Size(246, 29);
            this.txt_course_trainers.TabIndex = 4;
            this.txt_course_trainers.Enter += new System.EventHandler(this.txt_course_trainers_Enter);
            this.txt_course_trainers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.txt_course_trainers.Leave += new System.EventHandler(this.txt_course_trainers_Leave);
            // 
            // txt_course_max_student
            // 
            this.txt_course_max_student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_course_max_student.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course_max_student.Location = new System.Drawing.Point(3, 252);
            this.txt_course_max_student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_course_max_student.Name = "txt_course_max_student";
            this.txt_course_max_student.Size = new System.Drawing.Size(246, 28);
            this.txt_course_max_student.TabIndex = 5;
            this.txt_course_max_student.Enter += new System.EventHandler(this.txt_course_max_student_Enter);
            this.txt_course_max_student.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.txt_course_max_student.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_course_max_student_KeyPress);
            this.txt_course_max_student.Leave += new System.EventHandler(this.txt_course_max_student_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم الدورة ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "معلومات عن الدورة ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "المدرب ";
            // 
            // txt_coures_Maximum_number_of_students
            // 
            this.txt_coures_Maximum_number_of_students.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_coures_Maximum_number_of_students.AutoSize = true;
            this.txt_coures_Maximum_number_of_students.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coures_Maximum_number_of_students.Location = new System.Drawing.Point(255, 253);
            this.txt_coures_Maximum_number_of_students.Name = "txt_coures_Maximum_number_of_students";
            this.txt_coures_Maximum_number_of_students.Size = new System.Drawing.Size(184, 25);
            this.txt_coures_Maximum_number_of_students.TabIndex = 6;
            this.txt_coures_Maximum_number_of_students.Text = "عدد الطلبة الأقصي";
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
            this.btn_print.Size = new System.Drawing.Size(77, 75);
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
            this.btn_delete.Location = new System.Drawing.Point(163, 4);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 75);
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
            this.btn_update.Size = new System.Drawing.Size(71, 75);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "تاريخ البداية";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "عدد الساعات";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "الايام";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.Controls.Add(this.btn_print, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_update, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_edt_click, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 476);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(447, 83);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_course_code, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_course_name, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_course_information, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txt_coures_pries, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txt_course_trainers, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txt_coures_Maximum_number_of_students, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txt_course_max_student, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.txt_stratdate, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.txt_enddate, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.txt_course_houres, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.checkedComboBoxEdit1, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.txt_course_state, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 13);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(971, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 16;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(453, 878);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "رمز الدورة";
            // 
            // txt_course_code
            // 
            this.txt_course_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_course_code.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course_code.Location = new System.Drawing.Point(3, 4);
            this.txt_course_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_course_code.Name = "txt_course_code";
            this.txt_course_code.Size = new System.Drawing.Size(246, 28);
            this.txt_course_code.TabIndex = 0;
            this.txt_course_code.Enter += new System.EventHandler(this.txt_course_code_Enter);
            this.txt_course_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.txt_course_code.Leave += new System.EventHandler(this.txt_course_code_Leave);
            // 
            // txt_course_name
            // 
            this.txt_course_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_course_name.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course_name.Location = new System.Drawing.Point(3, 40);
            this.txt_course_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_course_name.Name = "txt_course_name";
            this.txt_course_name.Size = new System.Drawing.Size(246, 28);
            this.txt_course_name.TabIndex = 1;
            this.txt_course_name.Enter += new System.EventHandler(this.txt_course_name_Enter);
            this.txt_course_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.txt_course_name.Leave += new System.EventHandler(this.txt_course_name_Leave);
            // 
            // txt_course_information
            // 
            this.txt_course_information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_course_information.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course_information.Location = new System.Drawing.Point(3, 76);
            this.txt_course_information.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_course_information.Multiline = true;
            this.txt_course_information.Name = "txt_course_information";
            this.txt_course_information.Size = new System.Drawing.Size(246, 95);
            this.txt_course_information.TabIndex = 2;
            this.txt_course_information.Enter += new System.EventHandler(this.txt_course_information_Enter);
            this.txt_course_information.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.txt_course_information.Leave += new System.EventHandler(this.txt_course_information_Leave);
            // 
            // txt_stratdate
            // 
            this.txt_stratdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_stratdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stratdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_stratdate.Location = new System.Drawing.Point(3, 288);
            this.txt_stratdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_stratdate.Name = "txt_stratdate";
            this.txt_stratdate.RightToLeftLayout = true;
            this.txt_stratdate.Size = new System.Drawing.Size(246, 27);
            this.txt_stratdate.TabIndex = 6;
            this.txt_stratdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(255, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "تاريخ نهاية";
            // 
            // txt_enddate
            // 
            this.txt_enddate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_enddate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_enddate.Location = new System.Drawing.Point(3, 323);
            this.txt_enddate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_enddate.Name = "txt_enddate";
            this.txt_enddate.RightToLeftLayout = true;
            this.txt_enddate.Size = new System.Drawing.Size(246, 27);
            this.txt_enddate.TabIndex = 6;
            this.txt_enddate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            // 
            // txt_course_houres
            // 
            this.txt_course_houres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_course_houres.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course_houres.Location = new System.Drawing.Point(3, 358);
            this.txt_course_houres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_course_houres.Name = "txt_course_houres";
            this.txt_course_houres.Size = new System.Drawing.Size(246, 28);
            this.txt_course_houres.TabIndex = 7;
            this.txt_course_houres.Enter += new System.EventHandler(this.txt_course_houres_Enter);
            this.txt_course_houres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.txt_course_houres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_course_houres_KeyPress);
            this.txt_course_houres.Leave += new System.EventHandler(this.txt_course_houres_Leave);
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(3, 396);
            this.checkedComboBoxEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.AllowMultiSelect = true;
            this.checkedComboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedComboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.DropDownRows = 8;
            this.checkedComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("1", "السبت"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("2", "الأحد"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "الاثنين"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "الثلاثاء"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "الاربعاء"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "الخميس")});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(246, 28);
            this.checkedComboBoxEdit1.TabIndex = 8;
            this.checkedComboBoxEdit1.Enter += new System.EventHandler(this.checkedComboBoxEdit1_Enter);
            this.checkedComboBoxEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.checkedComboBoxEdit1.Leave += new System.EventHandler(this.checkedComboBoxEdit1_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "حالة الدورة";
            // 
            // txt_course_state
            // 
            this.txt_course_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_course_state.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course_state.FormattingEnabled = true;
            this.txt_course_state.Items.AddRange(new object[] {
            "مكتملة",
            "بدأت",
            "لم تبداء"});
            this.txt_course_state.Location = new System.Drawing.Point(3, 437);
            this.txt_course_state.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_course_state.Name = "txt_course_state";
            this.txt_course_state.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_course_state.Size = new System.Drawing.Size(246, 29);
            this.txt_course_state.TabIndex = 9;
            this.txt_course_state.Enter += new System.EventHandler(this.txt_course_state_Enter);
            this.txt_course_state.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            this.txt_course_state.Leave += new System.EventHandler(this.txt_course_state_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.21586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.78413F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1427, 886);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // get_std_main_courseTableAdapter
            // 
            this.get_std_main_courseTableAdapter.ClearBeforeFill = true;
            // 
            // getstdmaincourseBindingSource1
            // 
            this.getstdmaincourseBindingSource1.DataMember = "get_std_main_course";
            this.getstdmaincourseBindingSource1.DataSource = this.dB_CCTTDataSet2;
            // 
            // getstdmaincourseBindingSource2
            // 
            this.getstdmaincourseBindingSource2.DataMember = "get_std_main_course";
            this.getstdmaincourseBindingSource2.DataSource = this.dB_CCTTDataSet2;
            // 
            // colالرقم
            // 
            this.colالرقم.FieldName = "الرقم";
            this.colالرقم.MinWidth = 25;
            this.colالرقم.Name = "colالرقم";
            this.colالرقم.Visible = true;
            this.colالرقم.VisibleIndex = 0;
            this.colالرقم.Width = 106;
            // 
            // colرمزالدورة
            // 
            this.colرمزالدورة.FieldName = "رمز الدورة";
            this.colرمزالدورة.MinWidth = 25;
            this.colرمزالدورة.Name = "colرمزالدورة";
            this.colرمزالدورة.Visible = true;
            this.colرمزالدورة.VisibleIndex = 1;
            this.colرمزالدورة.Width = 140;
            // 
            // colاسمالدورة
            // 
            this.colاسمالدورة.FieldName = "اسم الدورة";
            this.colاسمالدورة.MinWidth = 25;
            this.colاسمالدورة.Name = "colاسمالدورة";
            this.colاسمالدورة.Visible = true;
            this.colاسمالدورة.VisibleIndex = 2;
            this.colاسمالدورة.Width = 145;
            // 
            // colمعلوماتعنالدورة
            // 
            this.colمعلوماتعنالدورة.FieldName = "معلومات عن الدورة";
            this.colمعلوماتعنالدورة.MinWidth = 25;
            this.colمعلوماتعنالدورة.Name = "colمعلوماتعنالدورة";
            this.colمعلوماتعنالدورة.Visible = true;
            this.colمعلوماتعنالدورة.VisibleIndex = 3;
            this.colمعلوماتعنالدورة.Width = 206;
            // 
            // colالسعر
            // 
            this.colالسعر.FieldName = "السعر";
            this.colالسعر.MinWidth = 25;
            this.colالسعر.Name = "colالسعر";
            this.colالسعر.Visible = true;
            this.colالسعر.VisibleIndex = 4;
            this.colالسعر.Width = 120;
            // 
            // colالمدرب
            // 
            this.colالمدرب.FieldName = "المدرب";
            this.colالمدرب.MinWidth = 25;
            this.colالمدرب.Name = "colالمدرب";
            this.colالمدرب.Visible = true;
            this.colالمدرب.VisibleIndex = 5;
            this.colالمدرب.Width = 121;
            // 
            // colعددالطلبةالاقصي
            // 
            this.colعددالطلبةالاقصي.FieldName = "عددالطلبة الاقصي";
            this.colعددالطلبةالاقصي.MinWidth = 25;
            this.colعددالطلبةالاقصي.Name = "colعددالطلبةالاقصي";
            this.colعددالطلبةالاقصي.Visible = true;
            this.colعددالطلبةالاقصي.VisibleIndex = 6;
            this.colعددالطلبةالاقصي.Width = 225;
            // 
            // colتاريخالبداية
            // 
            this.colتاريخالبداية.FieldName = "تاريخ البداية";
            this.colتاريخالبداية.MinWidth = 25;
            this.colتاريخالبداية.Name = "colتاريخالبداية";
            this.colتاريخالبداية.Visible = true;
            this.colتاريخالبداية.VisibleIndex = 7;
            this.colتاريخالبداية.Width = 157;
            // 
            // colتاريخنهاية
            // 
            this.colتاريخنهاية.FieldName = "تاريخ نهاية";
            this.colتاريخنهاية.MinWidth = 25;
            this.colتاريخنهاية.Name = "colتاريخنهاية";
            this.colتاريخنهاية.Visible = true;
            this.colتاريخنهاية.VisibleIndex = 8;
            this.colتاريخنهاية.Width = 143;
            // 
            // colعددالساعات
            // 
            this.colعددالساعات.FieldName = "عدد الساعات";
            this.colعددالساعات.MinWidth = 25;
            this.colعددالساعات.Name = "colعددالساعات";
            this.colعددالساعات.Visible = true;
            this.colعددالساعات.VisibleIndex = 9;
            this.colعددالساعات.Width = 123;
            // 
            // coldays
            // 
            this.coldays.FieldName = "days";
            this.coldays.MinWidth = 25;
            this.coldays.Name = "coldays";
            this.coldays.Visible = true;
            this.coldays.VisibleIndex = 10;
            this.coldays.Width = 114;
            // 
            // colالايام
            // 
            this.colالايام.FieldName = "الايام";
            this.colالايام.MinWidth = 25;
            this.colالايام.Name = "colالايام";
            this.colالايام.Visible = true;
            this.colالايام.VisibleIndex = 11;
            this.colالايام.Width = 124;
            // 
            // colحالةالدورة
            // 
            this.colحالةالدورة.FieldName = "حالة الدورة";
            this.colحالةالدورة.MinWidth = 25;
            this.colحالةالدورة.Name = "colحالةالدورة";
            this.colحالةالدورة.Visible = true;
            this.colحالةالدورة.VisibleIndex = 12;
            this.colحالةالدورة.Width = 154;
            // 
            // Page__Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Page__Course";
            this.Size = new System.Drawing.Size(1427, 886);
            this.Load += new System.EventHandler(this.Page__Course_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page__Course_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getstdmaincourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getstdmaincourseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getstdmaincourseBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btn_edt_click;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_coures_pries;
        private System.Windows.Forms.ComboBox txt_course_trainers;
        private System.Windows.Forms.TextBox txt_course_max_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_coures_Maximum_number_of_students;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker txt_stratdate;
        private System.Windows.Forms.TextBox txt_course_name;
        private System.Windows.Forms.TextBox txt_course_information;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_course_code;
        private System.Windows.Forms.TextBox txt_course_houres;
        private System.Windows.Forms.ComboBox txt_course_state;
        public DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource getstdmaincourseBindingSource;
        private DB_CCTTDataSet2 dB_CCTTDataSet2;
        private DB_CCTTDataSet2TableAdapters.get_std_main_courseTableAdapter get_std_main_courseTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txt_enddate;
        private DevExpress.XtraGrid.Columns.GridColumn colالرقم;
        private DevExpress.XtraGrid.Columns.GridColumn colرمزالدورة;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالدورة;
        private DevExpress.XtraGrid.Columns.GridColumn colمعلوماتعنالدورة;
        private DevExpress.XtraGrid.Columns.GridColumn colالسعر;
        private DevExpress.XtraGrid.Columns.GridColumn colالمدرب;
        private DevExpress.XtraGrid.Columns.GridColumn colعددالطلبةالاقصي;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالبداية;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخنهاية;
        private DevExpress.XtraGrid.Columns.GridColumn colعددالساعات;
        private DevExpress.XtraGrid.Columns.GridColumn coldays;
        private DevExpress.XtraGrid.Columns.GridColumn colالايام;
        private DevExpress.XtraGrid.Columns.GridColumn colحالةالدورة;
        private System.Windows.Forms.BindingSource getstdmaincourseBindingSource2;
        private System.Windows.Forms.BindingSource getstdmaincourseBindingSource1;
    }
}
