namespace CCTT.EPL
{
    partial class Toast_Succeed
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
            this.components = new System.ComponentModel.Container();
            this.txt_capation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_toast = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_toast)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_capation
            // 
            this.txt_capation.BackColor = System.Drawing.Color.White;
            this.txt_capation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_capation.Font = new System.Drawing.Font("29LT Bukra Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_capation.ForeColor = System.Drawing.Color.Black;
            this.txt_capation.Location = new System.Drawing.Point(94, 0);
            this.txt_capation.Name = "txt_capation";
            this.txt_capation.Size = new System.Drawing.Size(365, 62);
            this.txt_capation.TabIndex = 12;
            this.txt_capation.Text = "الرسالة";
            this.txt_capation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_capation.Click += new System.EventHandler(this.txt_capation_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(459, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 62);
            this.panel1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_toast
            // 
            this.pic_toast.BackColor = System.Drawing.Color.White;
            this.pic_toast.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_toast.Image = global::CCTT.Properties.Resources.ok_128px;
            this.pic_toast.Location = new System.Drawing.Point(0, 0);
            this.pic_toast.Name = "pic_toast";
            this.pic_toast.Size = new System.Drawing.Size(94, 62);
            this.pic_toast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_toast.TabIndex = 10;
            this.pic_toast.TabStop = false;
            // 
            // Toast_Succeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 62);
            this.Controls.Add(this.txt_capation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_toast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Toast_Succeed";
            this.Text = "Toast";
            ((System.ComponentModel.ISupportInitialize)(this.pic_toast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label txt_capation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pic_toast;
    }
}