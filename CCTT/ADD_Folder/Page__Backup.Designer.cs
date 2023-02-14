namespace CCTT.Pages
{
    partial class Page__Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page__Backup));
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_restore = new DevExpress.XtraEditors.SimpleButton();
            this.btn_backup = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_save.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(40, 201);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(262, 59);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "حفظ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_restore);
            this.groupBox2.Controls.Add(this.btn_backup);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(610, 138);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اعدادات قاعدة البيانات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(173, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "يجب تشغيل البرنامج كامسؤل";
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_restore.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.Appearance.Options.UseFont = true;
            this.btn_restore.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_restore.Location = new System.Drawing.Point(7, 68);
            this.btn_restore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(278, 59);
            this.btn_restore.TabIndex = 5;
            this.btn_restore.Text = "استعادة النسخة الاحطياطية";
            // 
            // btn_backup
            // 
            this.btn_backup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_backup.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Appearance.Options.UseFont = true;
            this.btn_backup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_backup.Location = new System.Drawing.Point(318, 68);
            this.btn_backup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(262, 59);
            this.btn_backup.TabIndex = 5;
            this.btn_backup.Text = "اخد نسخة احطياطية";
            // 
            // Page__Backup
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 274);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Page__Backup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نسخ الاحطياطي";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton btn_restore;
        public DevExpress.XtraEditors.SimpleButton btn_backup;
    }
}