
namespace CCTT.Pages
{
    partial class Page_Home
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
            this.txt_companytitle = new System.Windows.Forms.Label();
            this.txt_datetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_companytitle
            // 
            this.txt_companytitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_companytitle.AutoSize = true;
            this.txt_companytitle.Font = new System.Drawing.Font("29LT Bukra Regular", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companytitle.ForeColor = System.Drawing.Color.Black;
            this.txt_companytitle.Location = new System.Drawing.Point(77, 302);
            this.txt_companytitle.Name = "txt_companytitle";
            this.txt_companytitle.Size = new System.Drawing.Size(654, 60);
            this.txt_companytitle.TabIndex = 5;
            this.txt_companytitle.Text = "كلية تقنية الحاسوب طرابلس";
            // 
            // txt_datetime
            // 
            this.txt_datetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_datetime.AutoSize = true;
            this.txt_datetime.Font = new System.Drawing.Font("29LT Bukra Regular", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datetime.ForeColor = System.Drawing.Color.Black;
            this.txt_datetime.Location = new System.Drawing.Point(0, 459);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(498, 60);
            this.txt_datetime.TabIndex = 6;
            this.txt_datetime.Text = "تاريخ ووقت اليوم هو ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CCTT.Properties.Resources.تعاع;
            this.pictureBox1.Location = new System.Drawing.Point(272, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Page_Home
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_companytitle);
            this.Controls.Add(this.txt_datetime);
            this.Name = "Page_Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(805, 528);
            this.Load += new System.EventHandler(this.Page_Home_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_datetime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label txt_companytitle;
    }
}
