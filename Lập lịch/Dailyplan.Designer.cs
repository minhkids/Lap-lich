namespace Lập_lịch
{
    partial class Dailyplan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNextday = new System.Windows.Forms.Button();
            this.btnpreviosday = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmviệc = new System.Windows.Forms.ToolStripMenuItem();
            this.homnay = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 620);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNextday);
            this.panel3.Controls.Add(this.btnpreviosday);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 37);
            this.panel3.TabIndex = 1;
            // 
            // btnNextday
            // 
            this.btnNextday.Location = new System.Drawing.Point(862, 2);
            this.btnNextday.Name = "btnNextday";
            this.btnNextday.Size = new System.Drawing.Size(104, 31);
            this.btnNextday.TabIndex = 3;
            this.btnNextday.Text = "Ngày mai";
            this.btnNextday.UseVisualStyleBackColor = true;
            this.btnNextday.Click += new System.EventHandler(this.btnNextday_Click);
            // 
            // btnpreviosday
            // 
            this.btnpreviosday.Location = new System.Drawing.Point(141, 2);
            this.btnpreviosday.Name = "btnpreviosday";
            this.btnpreviosday.Size = new System.Drawing.Size(98, 31);
            this.btnpreviosday.TabIndex = 2;
            this.btnpreviosday.Text = "Hôm qua";
            this.btnpreviosday.UseVisualStyleBackColor = true;
            this.btnpreviosday.Click += new System.EventHandler(this.btnpreviosday_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(410, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 572);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmviệc,
            this.homnay});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmviệc
            // 
            this.thêmviệc.Name = "thêmviệc";
            this.thêmviệc.Size = new System.Drawing.Size(90, 24);
            this.thêmviệc.Text = "Thêm việc";
            this.thêmviệc.Click += new System.EventHandler(this.thêmLịch_Click);
            // 
            // homnay
            // 
            this.homnay.Name = "homnay";
            this.homnay.Size = new System.Drawing.Size(83, 24);
            this.homnay.Text = "Hôm nay";
            // 
            // Dailyplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dailyplan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch trong ngày";
            this.Load += new System.EventHandler(this.Dailyplan_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmviệc;
        private System.Windows.Forms.ToolStripMenuItem homnay;
        private System.Windows.Forms.Button btnNextday;
        private System.Windows.Forms.Button btnpreviosday;
    }
}