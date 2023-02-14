
namespace CCTT.Pages
{
    partial class Page_trainers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_trainers));
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_trainer_code = new System.Windows.Forms.TextBox();
            this.txt_trainer_specialty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_trainer_phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_edt_click = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالمدرب = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالاسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريخالميلاد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتخصص = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمؤهل = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالدرجةالعلمية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colايميل = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرفمالهاتف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالعنوان = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالرقمالوطني = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالجنسية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالجنس = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stloadDataPagetrainer1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CCTTDataSet2 = new CCTT.DB_CCTTDataSet2();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_trainer_id = new System.Windows.Forms.TextBox();
            this.txt_trainer_sex = new System.Windows.Forms.ComboBox();
            this.txt_trainer_email = new System.Windows.Forms.TextBox();
            this.txt_trainer_Degree = new System.Windows.Forms.ComboBox();
            this.txt_trainer_qualifications = new System.Windows.Forms.ComboBox();
            this.txt_trainer_brithday = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel_nationality = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_trainer_fullname = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_trainer_address = new System.Windows.Forms.ComboBox();
            this.linkLabel_qualifications = new System.Windows.Forms.LinkLabel();
            this.txt_trainer_nationality = new System.Windows.Forms.ComboBox();
            this.linkLabel_Degree = new System.Windows.Forms.LinkLabel();
            this.linkLabel_major = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stloadDataPage_trainer1TableAdapter = new CCTT.DB_CCTTDataSet2TableAdapters.StloadDataPage_trainer1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stloadDataPagetrainer1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_print.Size = new System.Drawing.Size(77, 84);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "طباعة";
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
            this.btn_delete.Size = new System.Drawing.Size(72, 84);
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
            this.btn_update.Size = new System.Drawing.Size(69, 84);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "الميلاد";
            // 
            // txt_trainer_code
            // 
            this.txt_trainer_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_code.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_code.Location = new System.Drawing.Point(3, 4);
            this.txt_trainer_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_code.Name = "txt_trainer_code";
            this.txt_trainer_code.Size = new System.Drawing.Size(250, 28);
            this.txt_trainer_code.TabIndex = 0;
            this.txt_trainer_code.Enter += new System.EventHandler(this.txt_trainer_code_Enter);
            this.txt_trainer_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_code.Leave += new System.EventHandler(this.txt_trainer_code_Leave);
            // 
            // txt_trainer_specialty
            // 
            this.txt_trainer_specialty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_specialty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_trainer_specialty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_trainer_specialty.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_specialty.FormattingEnabled = true;
            this.txt_trainer_specialty.Items.AddRange(new object[] {
            ""});
            this.txt_trainer_specialty.Location = new System.Drawing.Point(3, 295);
            this.txt_trainer_specialty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_specialty.Name = "txt_trainer_specialty";
            this.txt_trainer_specialty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_trainer_specialty.Size = new System.Drawing.Size(250, 29);
            this.txt_trainer_specialty.TabIndex = 8;
            this.txt_trainer_specialty.Enter += new System.EventHandler(this.txt_trainer_specialty_Enter);
            this.txt_trainer_specialty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_specialty.Leave += new System.EventHandler(this.txt_trainer_specialty_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "رقم المدرب";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "الاسم";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(259, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "البريد الاكتروني";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "رقم الهاتف";
            // 
            // txt_trainer_phone
            // 
            this.txt_trainer_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_phone.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_phone.Location = new System.Drawing.Point(3, 221);
            this.txt_trainer_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_phone.Name = "txt_trainer_phone";
            this.txt_trainer_phone.Size = new System.Drawing.Size(250, 28);
            this.txt_trainer_phone.TabIndex = 6;
            this.txt_trainer_phone.Enter += new System.EventHandler(this.txt_trainer_phone_Enter);
            this.txt_trainer_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trainer_phone_KeyPress);
            this.txt_trainer_phone.Leave += new System.EventHandler(this.txt_trainer_phone_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "رقم الوطني";
            // 
            // btn_edt_click
            // 
            this.btn_edt_click.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edt_click.Appearance.Options.UseFont = true;
            this.btn_edt_click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edt_click.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt_click.ImageOptions.Image")));
            this.btn_edt_click.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_edt_click.Location = new System.Drawing.Point(239, 4);
            this.btn_edt_click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edt_click.Name = "btn_edt_click";
            this.btn_edt_click.Size = new System.Drawing.Size(77, 84);
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
            this.btn_Add.Location = new System.Drawing.Point(322, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 84);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colرقمالمدرب,
            this.colالاسم,
            this.colتاريخالميلاد,
            this.colالتخصص,
            this.colالمؤهل,
            this.colالدرجةالعلمية,
            this.colايميل,
            this.colرفمالهاتف,
            this.colالعنوان,
            this.colالرقمالوطني,
            this.colالجنسية,
            this.colالجنس});
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
            // colرقمالمدرب
            // 
            this.colرقمالمدرب.FieldName = "رقم المدرب";
            this.colرقمالمدرب.MinWidth = 25;
            this.colرقمالمدرب.Name = "colرقمالمدرب";
            this.colرقمالمدرب.Visible = true;
            this.colرقمالمدرب.VisibleIndex = 0;
            this.colرقمالمدرب.Width = 128;
            // 
            // colالاسم
            // 
            this.colالاسم.FieldName = "الاسم";
            this.colالاسم.MinWidth = 25;
            this.colالاسم.Name = "colالاسم";
            this.colالاسم.Visible = true;
            this.colالاسم.VisibleIndex = 1;
            this.colالاسم.Width = 211;
            // 
            // colتاريخالميلاد
            // 
            this.colتاريخالميلاد.FieldName = "تاريخ الميلاد";
            this.colتاريخالميلاد.MinWidth = 25;
            this.colتاريخالميلاد.Name = "colتاريخالميلاد";
            this.colتاريخالميلاد.Visible = true;
            this.colتاريخالميلاد.VisibleIndex = 2;
            this.colتاريخالميلاد.Width = 185;
            // 
            // colالتخصص
            // 
            this.colالتخصص.FieldName = "التخصص";
            this.colالتخصص.MinWidth = 25;
            this.colالتخصص.Name = "colالتخصص";
            this.colالتخصص.Visible = true;
            this.colالتخصص.VisibleIndex = 8;
            this.colالتخصص.Width = 117;
            // 
            // colالمؤهل
            // 
            this.colالمؤهل.FieldName = "المؤهل";
            this.colالمؤهل.MinWidth = 25;
            this.colالمؤهل.Name = "colالمؤهل";
            this.colالمؤهل.Visible = true;
            this.colالمؤهل.VisibleIndex = 10;
            this.colالمؤهل.Width = 141;
            // 
            // colالدرجةالعلمية
            // 
            this.colالدرجةالعلمية.FieldName = "الدرجة العلمية";
            this.colالدرجةالعلمية.MinWidth = 25;
            this.colالدرجةالعلمية.Name = "colالدرجةالعلمية";
            this.colالدرجةالعلمية.Visible = true;
            this.colالدرجةالعلمية.VisibleIndex = 9;
            this.colالدرجةالعلمية.Width = 124;
            // 
            // colايميل
            // 
            this.colايميل.Caption = "البريد الاكتروني";
            this.colايميل.FieldName = "ايميل";
            this.colايميل.MinWidth = 25;
            this.colايميل.Name = "colايميل";
            this.colايميل.Visible = true;
            this.colايميل.VisibleIndex = 11;
            this.colايميل.Width = 172;
            // 
            // colرفمالهاتف
            // 
            this.colرفمالهاتف.FieldName = "رفم الهاتف";
            this.colرفمالهاتف.MinWidth = 25;
            this.colرفمالهاتف.Name = "colرفمالهاتف";
            this.colرفمالهاتف.Visible = true;
            this.colرفمالهاتف.VisibleIndex = 6;
            this.colرفمالهاتف.Width = 144;
            // 
            // colالعنوان
            // 
            this.colالعنوان.FieldName = "العنوان";
            this.colالعنوان.MinWidth = 25;
            this.colالعنوان.Name = "colالعنوان";
            this.colالعنوان.Visible = true;
            this.colالعنوان.VisibleIndex = 7;
            this.colالعنوان.Width = 112;
            // 
            // colالرقمالوطني
            // 
            this.colالرقمالوطني.FieldName = "الرقم الوطني";
            this.colالرقمالوطني.MinWidth = 25;
            this.colالرقمالوطني.Name = "colالرقمالوطني";
            this.colالرقمالوطني.Visible = true;
            this.colالرقمالوطني.VisibleIndex = 5;
            this.colالرقمالوطني.Width = 165;
            // 
            // colالجنسية
            // 
            this.colالجنسية.FieldName = "الجنسية";
            this.colالجنسية.MinWidth = 25;
            this.colالجنسية.Name = "colالجنسية";
            this.colالجنسية.Visible = true;
            this.colالجنسية.VisibleIndex = 4;
            this.colالجنسية.Width = 104;
            // 
            // colالجنس
            // 
            this.colالجنس.FieldName = "الجنس";
            this.colالجنس.MinWidth = 25;
            this.colالجنس.Name = "colالجنس";
            this.colالجنس.Visible = true;
            this.colالجنس.VisibleIndex = 3;
            this.colالجنس.Width = 100;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stloadDataPagetrainer1BindingSource;
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
            // stloadDataPagetrainer1BindingSource
            // 
            this.stloadDataPagetrainer1BindingSource.DataMember = "StloadDataPage_trainer1";
            this.stloadDataPagetrainer1BindingSource.DataSource = this.dB_CCTTDataSet2;
            // 
            // dB_CCTTDataSet2
            // 
            this.dB_CCTTDataSet2.DataSetName = "DB_CCTTDataSet2";
            this.dB_CCTTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(259, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "الجنس";
            // 
            // txt_trainer_id
            // 
            this.txt_trainer_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_id.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_id.Location = new System.Drawing.Point(3, 185);
            this.txt_trainer_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_id.Name = "txt_trainer_id";
            this.txt_trainer_id.Size = new System.Drawing.Size(250, 28);
            this.txt_trainer_id.TabIndex = 5;
            this.txt_trainer_id.Enter += new System.EventHandler(this.txt_trainer_id_Enter);
            this.txt_trainer_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trainer_id_KeyPress);
            this.txt_trainer_id.Leave += new System.EventHandler(this.txt_trainer_id_Leave);
            // 
            // txt_trainer_sex
            // 
            this.txt_trainer_sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_sex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_trainer_sex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_trainer_sex.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_sex.FormattingEnabled = true;
            this.txt_trainer_sex.Items.AddRange(new object[] {
            "ذكر",
            "أنثي"});
            this.txt_trainer_sex.Location = new System.Drawing.Point(3, 111);
            this.txt_trainer_sex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_sex.Name = "txt_trainer_sex";
            this.txt_trainer_sex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_trainer_sex.Size = new System.Drawing.Size(250, 29);
            this.txt_trainer_sex.TabIndex = 3;
            this.txt_trainer_sex.Enter += new System.EventHandler(this.txt_trainer_sex_Enter);
            this.txt_trainer_sex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_sex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trainer_sex_KeyPress);
            this.txt_trainer_sex.Leave += new System.EventHandler(this.txt_trainer_sex_Leave);
            // 
            // txt_trainer_email
            // 
            this.txt_trainer_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_email.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_email.Location = new System.Drawing.Point(3, 419);
            this.txt_trainer_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_email.Name = "txt_trainer_email";
            this.txt_trainer_email.Size = new System.Drawing.Size(250, 28);
            this.txt_trainer_email.TabIndex = 11;
            this.txt_trainer_email.Enter += new System.EventHandler(this.txt_trainer_email_Enter);
            this.txt_trainer_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_email.Leave += new System.EventHandler(this.txt_trainer_email_Leave);
            // 
            // txt_trainer_Degree
            // 
            this.txt_trainer_Degree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_Degree.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_trainer_Degree.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_trainer_Degree.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_Degree.FormattingEnabled = true;
            this.txt_trainer_Degree.Items.AddRange(new object[] {
            "باكلوريس",
            "دكتوره",
            "ملجستير"});
            this.txt_trainer_Degree.Location = new System.Drawing.Point(3, 335);
            this.txt_trainer_Degree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_Degree.Name = "txt_trainer_Degree";
            this.txt_trainer_Degree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_trainer_Degree.Size = new System.Drawing.Size(250, 29);
            this.txt_trainer_Degree.TabIndex = 9;
            this.txt_trainer_Degree.Enter += new System.EventHandler(this.txt_trainer_Degree_Enter);
            this.txt_trainer_Degree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_Degree.Leave += new System.EventHandler(this.txt_trainer_Degree_Leave);
            // 
            // txt_trainer_qualifications
            // 
            this.txt_trainer_qualifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_qualifications.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_trainer_qualifications.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_trainer_qualifications.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_qualifications.FormattingEnabled = true;
            this.txt_trainer_qualifications.Items.AddRange(new object[] {
            ""});
            this.txt_trainer_qualifications.Location = new System.Drawing.Point(3, 377);
            this.txt_trainer_qualifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_qualifications.Name = "txt_trainer_qualifications";
            this.txt_trainer_qualifications.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_trainer_qualifications.Size = new System.Drawing.Size(250, 29);
            this.txt_trainer_qualifications.TabIndex = 10;
            this.txt_trainer_qualifications.Enter += new System.EventHandler(this.txt_trainer_qualifications_Enter);
            this.txt_trainer_qualifications.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_qualifications.Leave += new System.EventHandler(this.txt_trainer_qualifications_Leave);
            // 
            // txt_trainer_brithday
            // 
            this.txt_trainer_brithday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_brithday.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_brithday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_trainer_brithday.Location = new System.Drawing.Point(3, 76);
            this.txt_trainer_brithday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_brithday.Name = "txt_trainer_brithday";
            this.txt_trainer_brithday.RightToLeftLayout = true;
            this.txt_trainer_brithday.Size = new System.Drawing.Size(250, 27);
            this.txt_trainer_brithday.TabIndex = 2;
            this.txt_trainer_brithday.Enter += new System.EventHandler(this.txt_trainer_brithday_Enter);
            this.txt_trainer_brithday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_brithday.Leave += new System.EventHandler(this.txt_trainer_brithday_Leave);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.Controls.Add(this.btn_print, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_update, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_edt_click, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 458);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(405, 92);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // linkLabel_nationality
            // 
            this.linkLabel_nationality.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel_nationality.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel_nationality.AutoSize = true;
            this.linkLabel_nationality.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_nationality.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_nationality.Location = new System.Drawing.Point(259, 150);
            this.linkLabel_nationality.Name = "linkLabel_nationality";
            this.linkLabel_nationality.Size = new System.Drawing.Size(87, 25);
            this.linkLabel_nationality.TabIndex = 21;
            this.linkLabel_nationality.TabStop = true;
            this.linkLabel_nationality.Text = "الجنسية";
            this.linkLabel_nationality.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_nationality_LinkClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_code, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_brithday, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_fullname, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel1, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_address, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_sex, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel_qualifications, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel_nationality, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_qualifications, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_nationality, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel_Degree, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_Degree, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_id, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel_major, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_specialty, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_phone, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.txt_trainer_email, 1, 14);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 15);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1013, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 18;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 878);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txt_trainer_fullname
            // 
            this.txt_trainer_fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_fullname.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_fullname.Location = new System.Drawing.Point(3, 40);
            this.txt_trainer_fullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_fullname.Name = "txt_trainer_fullname";
            this.txt_trainer_fullname.Size = new System.Drawing.Size(250, 28);
            this.txt_trainer_fullname.TabIndex = 1;
            this.txt_trainer_fullname.Enter += new System.EventHandler(this.txt_trainer_fullname_Enter);
            this.txt_trainer_fullname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_fullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trainer_fullname_KeyPress);
            this.txt_trainer_fullname.Leave += new System.EventHandler(this.txt_trainer_fullname_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(259, 259);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 25);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "العنوان";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_nationality_LinkClicked);
            // 
            // txt_trainer_address
            // 
            this.txt_trainer_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_trainer_address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_trainer_address.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_address.FormattingEnabled = true;
            this.txt_trainer_address.Location = new System.Drawing.Point(3, 257);
            this.txt_trainer_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_address.Name = "txt_trainer_address";
            this.txt_trainer_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_trainer_address.Size = new System.Drawing.Size(250, 29);
            this.txt_trainer_address.TabIndex = 7;
            this.txt_trainer_address.Enter += new System.EventHandler(this.txt_trainer_address_Enter);
            this.txt_trainer_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_address.Leave += new System.EventHandler(this.txt_trainer_address_Leave);
            // 
            // linkLabel_qualifications
            // 
            this.linkLabel_qualifications.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel_qualifications.AutoSize = true;
            this.linkLabel_qualifications.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_qualifications.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_qualifications.Location = new System.Drawing.Point(259, 379);
            this.linkLabel_qualifications.Name = "linkLabel_qualifications";
            this.linkLabel_qualifications.Size = new System.Drawing.Size(97, 25);
            this.linkLabel_qualifications.TabIndex = 21;
            this.linkLabel_qualifications.TabStop = true;
            this.linkLabel_qualifications.Text = "المؤهلات";
            this.linkLabel_qualifications.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_qualifications_LinkClicked);
            // 
            // txt_trainer_nationality
            // 
            this.txt_trainer_nationality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trainer_nationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_trainer_nationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_trainer_nationality.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trainer_nationality.FormattingEnabled = true;
            this.txt_trainer_nationality.Location = new System.Drawing.Point(3, 148);
            this.txt_trainer_nationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trainer_nationality.Name = "txt_trainer_nationality";
            this.txt_trainer_nationality.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_trainer_nationality.Size = new System.Drawing.Size(250, 29);
            this.txt_trainer_nationality.TabIndex = 4;
            this.txt_trainer_nationality.Enter += new System.EventHandler(this.txt_trainer_nationality_Enter);
            this.txt_trainer_nationality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trainer_code_KeyDown);
            this.txt_trainer_nationality.Leave += new System.EventHandler(this.txt_trainer_nationality_Leave);
            // 
            // linkLabel_Degree
            // 
            this.linkLabel_Degree.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel_Degree.AutoSize = true;
            this.linkLabel_Degree.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Degree.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_Degree.Location = new System.Drawing.Point(259, 337);
            this.linkLabel_Degree.Name = "linkLabel_Degree";
            this.linkLabel_Degree.Size = new System.Drawing.Size(127, 25);
            this.linkLabel_Degree.TabIndex = 21;
            this.linkLabel_Degree.TabStop = true;
            this.linkLabel_Degree.Text = "درجة العلمية";
            this.linkLabel_Degree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Degree_LinkClicked);
            // 
            // linkLabel_major
            // 
            this.linkLabel_major.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel_major.AutoSize = true;
            this.linkLabel_major.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_major.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_major.Location = new System.Drawing.Point(259, 297);
            this.linkLabel_major.Name = "linkLabel_major";
            this.linkLabel_major.Size = new System.Drawing.Size(88, 25);
            this.linkLabel_major.TabIndex = 21;
            this.linkLabel_major.TabStop = true;
            this.linkLabel_major.Text = "التخصص";
            this.linkLabel_major.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_major_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.27046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.72954F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1427, 886);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // stloadDataPage_trainer1TableAdapter
            // 
            this.stloadDataPage_trainer1TableAdapter.ClearBeforeFill = true;
            // 
            // Page_trainers
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Page_trainers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1427, 886);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stloadDataPagetrainer1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_trainer_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_trainer_phone;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btn_edt_click;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_trainer_id;
        private System.Windows.Forms.ComboBox txt_trainer_sex;
        private System.Windows.Forms.TextBox txt_trainer_email;
        private System.Windows.Forms.DateTimePicker txt_trainer_brithday;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_trainer_fullname;
        private System.Windows.Forms.LinkLabel linkLabel_major;
        private System.Windows.Forms.LinkLabel linkLabel_nationality;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ComboBox txt_trainer_specialty;
        public System.Windows.Forms.ComboBox txt_trainer_nationality;
        public System.Windows.Forms.ComboBox txt_trainer_Degree;
        public System.Windows.Forms.ComboBox txt_trainer_qualifications;
        private System.Windows.Forms.LinkLabel linkLabel_qualifications;
        private System.Windows.Forms.LinkLabel linkLabel_Degree;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.ComboBox txt_trainer_address;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالمدرب;
        private DevExpress.XtraGrid.Columns.GridColumn colالاسم;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريخالميلاد;
        private DevExpress.XtraGrid.Columns.GridColumn colالتخصص;
        private DevExpress.XtraGrid.Columns.GridColumn colالمؤهل;
        private DevExpress.XtraGrid.Columns.GridColumn colالدرجةالعلمية;
        private DevExpress.XtraGrid.Columns.GridColumn colايميل;
        private DevExpress.XtraGrid.Columns.GridColumn colرفمالهاتف;
        private DevExpress.XtraGrid.Columns.GridColumn colالعنوان;
        private DevExpress.XtraGrid.Columns.GridColumn colالرقمالوطني;
        private DevExpress.XtraGrid.Columns.GridColumn colالجنسية;
        private DevExpress.XtraGrid.Columns.GridColumn colالجنس;
        private System.Windows.Forms.BindingSource stloadDataPagetrainer1BindingSource;
        private DB_CCTTDataSet2 dB_CCTTDataSet2;
        private DB_CCTTDataSet2TableAdapters.StloadDataPage_trainer1TableAdapter stloadDataPage_trainer1TableAdapter;
    }
}
