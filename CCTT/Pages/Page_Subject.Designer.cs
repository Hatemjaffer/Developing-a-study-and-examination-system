
namespace CCTT.Pages
{
    partial class Page_Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Subject));
            this.btn_edt_click = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sub_articlecode = new System.Windows.Forms.TextBox();
            this.txt_sub_numberofunits = new System.Windows.Forms.TextBox();
            this.txt_sub_reliability = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sub_articlename = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_sub_substitutefor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sub_material_type = new System.Windows.Forms.ComboBox();
            this.txt_sub_houre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getMainCoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CCTTDataSet2 = new CCTT.DB_CCTTDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dBCCTTDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CCTTDataSet = new CCTT.DB_CCTTDataSet();
            this.dBCCTTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMainCoursTableAdapter = new CCTT.DB_CCTTDataSet2TableAdapters.getMainCoursTableAdapter();
            this.getMainCoursV2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMainCoursV2TableAdapter = new CCTT.DB_CCTTDataSet2TableAdapters.getMainCoursV2TableAdapter();
            this.getMainCoursV2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colالرقم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرمزالمادة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالمادة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colعددالوحدات = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالساعات = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMainCoursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCCTTDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCCTTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMainCoursV2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMainCoursV2BindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_edt_click.Size = new System.Drawing.Size(71, 92);
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
            this.btn_Add.Location = new System.Drawing.Point(316, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(86, 92);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(284, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "عدد الوحدات";
            // 
            // txt_sub_articlecode
            // 
            this.txt_sub_articlecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sub_articlecode.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_articlecode.Location = new System.Drawing.Point(3, 4);
            this.txt_sub_articlecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sub_articlecode.Name = "txt_sub_articlecode";
            this.txt_sub_articlecode.Size = new System.Drawing.Size(275, 28);
            this.txt_sub_articlecode.TabIndex = 0;
            this.txt_sub_articlecode.Enter += new System.EventHandler(this.txt_sub_articlecode_Enter);
            this.txt_sub_articlecode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            this.txt_sub_articlecode.Leave += new System.EventHandler(this.txt_sub_articlecode_Leave);
            // 
            // txt_sub_numberofunits
            // 
            this.txt_sub_numberofunits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sub_numberofunits.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_numberofunits.Location = new System.Drawing.Point(3, 76);
            this.txt_sub_numberofunits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sub_numberofunits.Name = "txt_sub_numberofunits";
            this.txt_sub_numberofunits.Size = new System.Drawing.Size(275, 28);
            this.txt_sub_numberofunits.TabIndex = 2;
            this.txt_sub_numberofunits.Enter += new System.EventHandler(this.txt_sub_numberofunits_Enter);
            this.txt_sub_numberofunits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            this.txt_sub_numberofunits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sub_numberofunits_KeyPress);
            this.txt_sub_numberofunits.Leave += new System.EventHandler(this.txt_sub_numberofunits_Leave);
            // 
            // txt_sub_reliability
            // 
            this.txt_sub_reliability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sub_reliability.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_reliability.Location = new System.Drawing.Point(3, 148);
            this.txt_sub_reliability.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sub_reliability.Name = "txt_sub_reliability";
            this.txt_sub_reliability.Size = new System.Drawing.Size(275, 28);
            this.txt_sub_reliability.TabIndex = 4;
            this.txt_sub_reliability.Enter += new System.EventHandler(this.txt_sub_reliability_Enter);
            this.txt_sub_reliability.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            this.txt_sub_reliability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sub_reliability_KeyPress);
            this.txt_sub_reliability.Leave += new System.EventHandler(this.txt_sub_reliability_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(284, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "رمز المادة";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(284, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم المادة";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(284, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "الساعات";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(284, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "الاعتمادية";
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
            this.btn_print.Size = new System.Drawing.Size(77, 92);
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
            this.btn_delete.Size = new System.Drawing.Size(72, 92);
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
            this.btn_update.Size = new System.Drawing.Size(69, 92);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(284, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "نوع المادة";
            // 
            // txt_sub_articlename
            // 
            this.txt_sub_articlename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sub_articlename.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_articlename.Location = new System.Drawing.Point(3, 40);
            this.txt_sub_articlename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sub_articlename.Name = "txt_sub_articlename";
            this.txt_sub_articlename.Size = new System.Drawing.Size(275, 28);
            this.txt_sub_articlename.TabIndex = 1;
            this.txt_sub_articlename.Enter += new System.EventHandler(this.txt_sub_articlename_Enter);
            this.txt_sub_articlename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            this.txt_sub_articlename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sub_articlename_KeyPress);
            this.txt_sub_articlename.Leave += new System.EventHandler(this.txt_sub_articlename_Leave);
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
            this.tableLayoutPanel4.Controls.Add(this.btn_edt_click, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 264);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(405, 100);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_sub_articlecode, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_sub_numberofunits, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_sub_reliability, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.txt_sub_articlename, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_sub_substitutefor, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txt_sub_material_type, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.txt_sub_houre, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1013, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 14;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 878);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txt_sub_substitutefor
            // 
            this.txt_sub_substitutefor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sub_substitutefor.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_substitutefor.Location = new System.Drawing.Point(3, 184);
            this.txt_sub_substitutefor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sub_substitutefor.Name = "txt_sub_substitutefor";
            this.txt_sub_substitutefor.Size = new System.Drawing.Size(275, 28);
            this.txt_sub_substitutefor.TabIndex = 5;
            this.txt_sub_substitutefor.Enter += new System.EventHandler(this.txt_sub_substitutefor_Enter);
            this.txt_sub_substitutefor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            this.txt_sub_substitutefor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sub_substitutefor_KeyPress);
            this.txt_sub_substitutefor.Leave += new System.EventHandler(this.txt_sub_substitutefor_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("29LT Bukra Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(284, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "بديلة عن";
            // 
            // txt_sub_material_type
            // 
            this.txt_sub_material_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sub_material_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_sub_material_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_sub_material_type.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_material_type.FormattingEnabled = true;
            this.txt_sub_material_type.Items.AddRange(new object[] {
            "نظري",
            "عملي+نظري"});
            this.txt_sub_material_type.Location = new System.Drawing.Point(3, 220);
            this.txt_sub_material_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sub_material_type.Name = "txt_sub_material_type";
            this.txt_sub_material_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_sub_material_type.Size = new System.Drawing.Size(275, 29);
            this.txt_sub_material_type.TabIndex = 6;
            this.txt_sub_material_type.Enter += new System.EventHandler(this.txt_sub_material_type_Enter);
            this.txt_sub_material_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            this.txt_sub_material_type.Leave += new System.EventHandler(this.txt_sub_material_type_Leave);
            // 
            // txt_sub_houre
            // 
            this.txt_sub_houre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sub_houre.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_houre.Location = new System.Drawing.Point(3, 112);
            this.txt_sub_houre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sub_houre.Name = "txt_sub_houre";
            this.txt_sub_houre.Size = new System.Drawing.Size(275, 28);
            this.txt_sub_houre.TabIndex = 3;
            this.txt_sub_houre.Enter += new System.EventHandler(this.txt_sub_houre_Enter);
            this.txt_sub_houre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            this.txt_sub_houre.Leave += new System.EventHandler(this.txt_sub_houre_Leave);
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
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1427, 886);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.getMainCoursV2BindingSource1;
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
            // getMainCoursBindingSource
            // 
            this.getMainCoursBindingSource.DataMember = "getMainCours";
            this.getMainCoursBindingSource.DataSource = this.dB_CCTTDataSet2;
            // 
            // dB_CCTTDataSet2
            // 
            this.dB_CCTTDataSet2.DataSetName = "DB_CCTTDataSet2";
            this.dB_CCTTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colرمزالمادة,
            this.colاسمالمادة,
            this.colعددالوحدات,
            this.colالساعات});
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
            // dBCCTTDataSet2BindingSource
            // 
            this.dBCCTTDataSet2BindingSource.DataSource = this.dB_CCTTDataSet2;
            this.dBCCTTDataSet2BindingSource.Position = 0;
            // 
            // dB_CCTTDataSet
            // 
            this.dB_CCTTDataSet.DataSetName = "DB_CCTTDataSet";
            this.dB_CCTTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBCCTTDataSetBindingSource
            // 
            this.dBCCTTDataSetBindingSource.DataSource = this.dB_CCTTDataSet;
            this.dBCCTTDataSetBindingSource.Position = 0;
            // 
            // getMainCoursTableAdapter
            // 
            this.getMainCoursTableAdapter.ClearBeforeFill = true;
            // 
            // getMainCoursV2BindingSource
            // 
            this.getMainCoursV2BindingSource.DataMember = "getMainCoursV2";
            this.getMainCoursV2BindingSource.DataSource = this.dBCCTTDataSet2BindingSource;
            // 
            // getMainCoursV2TableAdapter
            // 
            this.getMainCoursV2TableAdapter.ClearBeforeFill = true;
            // 
            // getMainCoursV2BindingSource1
            // 
            this.getMainCoursV2BindingSource1.DataMember = "getMainCoursV2";
            this.getMainCoursV2BindingSource1.DataSource = this.dBCCTTDataSet2BindingSource;
            // 
            // colالرقم
            // 
            this.colالرقم.FieldName = "الرقم";
            this.colالرقم.MinWidth = 25;
            this.colالرقم.Name = "colالرقم";
            this.colالرقم.Visible = true;
            this.colالرقم.VisibleIndex = 0;
            this.colالرقم.Width = 87;
            // 
            // colرمزالمادة
            // 
            this.colرمزالمادة.FieldName = "رمز المادة";
            this.colرمزالمادة.MinWidth = 25;
            this.colرمزالمادة.Name = "colرمزالمادة";
            this.colرمزالمادة.Visible = true;
            this.colرمزالمادة.VisibleIndex = 1;
            this.colرمزالمادة.Width = 87;
            // 
            // colاسمالمادة
            // 
            this.colاسمالمادة.FieldName = "اسم المادة";
            this.colاسمالمادة.MinWidth = 25;
            this.colاسمالمادة.Name = "colاسمالمادة";
            this.colاسمالمادة.Visible = true;
            this.colاسمالمادة.VisibleIndex = 2;
            this.colاسمالمادة.Width = 87;
            // 
            // colعددالوحدات
            // 
            this.colعددالوحدات.FieldName = "عدد الوحدات";
            this.colعددالوحدات.MinWidth = 25;
            this.colعددالوحدات.Name = "colعددالوحدات";
            this.colعددالوحدات.Visible = true;
            this.colعددالوحدات.VisibleIndex = 3;
            this.colعددالوحدات.Width = 87;
            // 
            // colالساعات
            // 
            this.colالساعات.FieldName = "الساعات";
            this.colالساعات.MinWidth = 25;
            this.colالساعات.Name = "colالساعات";
            this.colالساعات.Visible = true;
            this.colالساعات.VisibleIndex = 4;
            this.colالساعات.Width = 87;
            // 
            // Page_Subject
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Page_Subject";
            this.Size = new System.Drawing.Size(1427, 886);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Subject_KeyDown);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMainCoursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCCTTDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CCTTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCCTTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMainCoursV2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMainCoursV2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_edt_click;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sub_articlecode;
        private System.Windows.Forms.TextBox txt_sub_numberofunits;
        private System.Windows.Forms.TextBox txt_sub_reliability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sub_articlename;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_sub_substitutefor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txt_sub_material_type;
        private System.Windows.Forms.TextBox txt_sub_houre;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DB_CCTTDataSet2 dB_CCTTDataSet2;
        private System.Windows.Forms.BindingSource dBCCTTDataSet2BindingSource;
        private DB_CCTTDataSet dB_CCTTDataSet;
        private System.Windows.Forms.BindingSource dBCCTTDataSetBindingSource;
        private System.Windows.Forms.BindingSource getMainCoursBindingSource;
        private DB_CCTTDataSet2TableAdapters.getMainCoursTableAdapter getMainCoursTableAdapter;
        private System.Windows.Forms.BindingSource getMainCoursV2BindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colالرقم;
        private DevExpress.XtraGrid.Columns.GridColumn colرمزالمادة;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالمادة;
        private DevExpress.XtraGrid.Columns.GridColumn colعددالوحدات;
        private DevExpress.XtraGrid.Columns.GridColumn colالساعات;
        private System.Windows.Forms.BindingSource getMainCoursV2BindingSource;
        private DB_CCTTDataSet2TableAdapters.getMainCoursV2TableAdapter getMainCoursV2TableAdapter;
    }
}
