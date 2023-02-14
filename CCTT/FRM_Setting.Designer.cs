namespace CCTT
{
    partial class FRM_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Setting));
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_colloge_name = new System.Windows.Forms.TextBox();
            this.txt_president_name = new System.Windows.Forms.TextBox();
            this.txt_pic_logo = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pn_progress = new DevExpress.XtraWaitForm.ProgressPanel();
            this.txt_developmeny_manager = new System.Windows.Forms.TextBox();
            this.txt_courese_dep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_restore = new DevExpress.XtraEditors.SimpleButton();
            this.btn_backup = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pic_logo.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_save.Appearance.Font = new System.Drawing.Font("29LT Bukra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(27, 577);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(225, 48);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "حفظ الاعدادت";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الكلية ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "عميد الكلية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "الشعار  ";
            // 
            // txt_colloge_name
            // 
            this.txt_colloge_name.Font = new System.Drawing.Font("29LT Bukra Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_colloge_name.Location = new System.Drawing.Point(6, 53);
            this.txt_colloge_name.Name = "txt_colloge_name";
            this.txt_colloge_name.Size = new System.Drawing.Size(378, 24);
            this.txt_colloge_name.TabIndex = 0;
            this.txt_colloge_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_president_name
            // 
            this.txt_president_name.Font = new System.Drawing.Font("29LT Bukra Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_president_name.Location = new System.Drawing.Point(6, 106);
            this.txt_president_name.Name = "txt_president_name";
            this.txt_president_name.Size = new System.Drawing.Size(378, 24);
            this.txt_president_name.TabIndex = 1;
            this.txt_president_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_pic_logo
            // 
            this.txt_pic_logo.Location = new System.Drawing.Point(137, 241);
            this.txt_pic_logo.Name = "txt_pic_logo";
            this.txt_pic_logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.txt_pic_logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.txt_pic_logo.Size = new System.Drawing.Size(207, 181);
            this.txt_pic_logo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pn_progress);
            this.groupBox1.Controls.Add(this.txt_pic_logo);
            this.groupBox1.Controls.Add(this.txt_developmeny_manager);
            this.groupBox1.Controls.Add(this.txt_courese_dep);
            this.groupBox1.Controls.Add(this.txt_president_name);
            this.groupBox1.Controls.Add(this.txt_colloge_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("29LT Bukra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(27, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(530, 438);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " عــام";
            // 
            // pn_progress
            // 
            this.pn_progress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pn_progress.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_progress.Appearance.Options.UseBackColor = true;
            this.pn_progress.Appearance.Options.UseFont = true;
            this.pn_progress.Caption = "الرجاء الانتظار قليلا";
            this.pn_progress.Description = "";
            this.pn_progress.Location = new System.Drawing.Point(126, 241);
            this.pn_progress.Name = "pn_progress";
            this.pn_progress.Size = new System.Drawing.Size(258, 75);
            this.pn_progress.TabIndex = 6;
            this.pn_progress.Text = "ق";
            this.pn_progress.Visible = false;
            // 
            // txt_developmeny_manager
            // 
            this.txt_developmeny_manager.Font = new System.Drawing.Font("29LT Bukra Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_developmeny_manager.Location = new System.Drawing.Point(6, 207);
            this.txt_developmeny_manager.Name = "txt_developmeny_manager";
            this.txt_developmeny_manager.Size = new System.Drawing.Size(313, 24);
            this.txt_developmeny_manager.TabIndex = 2;
            this.txt_developmeny_manager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_courese_dep
            // 
            this.txt_courese_dep.Font = new System.Drawing.Font("29LT Bukra Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_courese_dep.Location = new System.Drawing.Point(6, 159);
            this.txt_courese_dep.Name = "txt_courese_dep";
            this.txt_courese_dep.Size = new System.Drawing.Size(313, 24);
            this.txt_courese_dep.TabIndex = 2;
            this.txt_courese_dep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "مدير تنمية الموارد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "رئيس قسم الدورات";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_restore);
            this.groupBox2.Controls.Add(this.btn_backup);
            this.groupBox2.Font = new System.Drawing.Font("29LT Bukra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(27, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 112);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اعدادات قاعدة البيانات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(148, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "يجب تشغيل البرنامج كامسؤل";
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_restore.Appearance.Font = new System.Drawing.Font("29LT Bukra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_restore.Appearance.Options.UseFont = true;
            this.btn_restore.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_restore.Location = new System.Drawing.Point(6, 55);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(238, 48);
            this.btn_restore.TabIndex = 5;
            this.btn_restore.Text = "استعادة النسخة الاحطياطية";
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_backup.Appearance.Font = new System.Drawing.Font("29LT Bukra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_backup.Appearance.Options.UseFont = true;
            this.btn_backup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_backup.Location = new System.Drawing.Point(305, 55);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(225, 48);
            this.btn_backup.TabIndex = 5;
            this.btn_backup.Text = "اخد نسخة احطياطية";
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // FRM_Setting
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_Setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاعدادت";
            this.Load += new System.EventHandler(this.FRM_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_pic_logo.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_colloge_name;
        private DevExpress.XtraEditors.PictureEdit txt_pic_logo;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_courese_dep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.SimpleButton btn_restore;
        public DevExpress.XtraEditors.SimpleButton btn_backup;
        private DevExpress.XtraWaitForm.ProgressPanel pn_progress;
        public System.Windows.Forms.TextBox txt_developmeny_manager;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_president_name;
    }
}