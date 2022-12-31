namespace CCTT.EPL
{
    partial class Diailog
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_capation
            // 
            this.txt_capation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_capation.Font = new System.Drawing.Font("29LT Bukra Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_capation.ForeColor = System.Drawing.Color.Gray;
            this.txt_capation.Location = new System.Drawing.Point(0, 0);
            this.txt_capation.Name = "txt_capation";
            this.txt_capation.Size = new System.Drawing.Size(486, 76);
            this.txt_capation.TabIndex = 9;
            this.txt_capation.Text = "الرسالة";
            this.txt_capation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_capation.Click += new System.EventHandler(this.txt_capation_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Diailog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 76);
            this.Controls.Add(this.txt_capation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diailog";
            this.Text = "Diailog";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label txt_capation;
        private System.Windows.Forms.Timer timer1;
    }
}