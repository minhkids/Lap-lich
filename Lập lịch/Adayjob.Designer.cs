﻿namespace Lập_lịch
{
    partial class Adayjob
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cbdone = new System.Windows.Forms.CheckBox();
            this.tbjob = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lbTo = new System.Windows.Forms.Label();
            this.nmTohours = new System.Windows.Forms.NumericUpDown();
            this.nmtoMin = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTohours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmtoMin)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cbdone);
            this.flowLayoutPanel1.Controls.Add(this.tbjob);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.Sua);
            this.flowLayoutPanel1.Controls.Add(this.Xoa);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(958, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Cbdone
            // 
            this.Cbdone.AutoSize = true;
            this.Cbdone.Location = new System.Drawing.Point(3, 3);
            this.Cbdone.Name = "Cbdone";
            this.Cbdone.Size = new System.Drawing.Size(18, 17);
            this.Cbdone.TabIndex = 0;
            this.Cbdone.UseVisualStyleBackColor = true;
            this.Cbdone.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbjob
            // 
            this.tbjob.Location = new System.Drawing.Point(27, 3);
            this.tbjob.Name = "tbjob";
            this.tbjob.Size = new System.Drawing.Size(351, 22);
            this.tbjob.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmtoMin);
            this.panel1.Controls.Add(this.nmTohours);
            this.panel1.Controls.Add(this.lbTo);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(384, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 35);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 1);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(48, 1);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 22);
            this.numericUpDown2.TabIndex = 1;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(109, 3);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(34, 17);
            this.lbTo.TabIndex = 2;
            this.lbTo.Text = "Đến";
            // 
            // nmTohours
            // 
            this.nmTohours.Location = new System.Drawing.Point(160, 1);
            this.nmTohours.Name = "nmTohours";
            this.nmTohours.Size = new System.Drawing.Size(39, 22);
            this.nmTohours.TabIndex = 3;
            // 
            // nmtoMin
            // 
            this.nmtoMin.Location = new System.Drawing.Point(205, 1);
            this.nmtoMin.Name = "nmtoMin";
            this.nmtoMin.Size = new System.Drawing.Size(39, 22);
            this.nmtoMin.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(660, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(787, 3);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(61, 24);
            this.Sua.TabIndex = 4;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(854, 3);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(61, 23);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // Adayjob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Adayjob";
            this.Size = new System.Drawing.Size(1300, 727);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTohours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmtoMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox Cbdone;
        private System.Windows.Forms.TextBox tbjob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmtoMin;
        private System.Windows.Forms.NumericUpDown nmTohours;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
    }
}
