﻿namespace WindowsFormsApp1
{
    partial class FRM_Level_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBX_Text = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_Text = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.PNL_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 112);
            this.button1.TabIndex = 1;
            this.button1.Text = "Okay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(414, 112);
            this.button2.TabIndex = 9;
            this.button2.Text = "Okay aber besser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 699);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 143);
            this.panel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(131, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 576);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LBX_Text
            // 
            this.LBX_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBX_Text.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LBX_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LBX_Text.FormattingEnabled = true;
            this.LBX_Text.IntegralHeight = false;
            this.LBX_Text.ItemHeight = 40;
            this.LBX_Text.Location = new System.Drawing.Point(20, 20);
            this.LBX_Text.Name = "LBX_Text";
            this.LBX_Text.Size = new System.Drawing.Size(804, 567);
            this.LBX_Text.TabIndex = 10;
            this.LBX_Text.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // PNL_Text
            // 
            this.PNL_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_Text.Controls.Add(this.LBX_Text);
            this.PNL_Text.Location = new System.Drawing.Point(260, 300);
            this.PNL_Text.Name = "PNL_Text";
            this.PNL_Text.Size = new System.Drawing.Size(695, 643);
            this.PNL_Text.TabIndex = 14;
            // 
            // FRM_Level_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(999, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PNL_Text);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Name = "FRM_Level_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LVL2";
            this.Load += new System.EventHandler(this.FRM_Level_2_Load);
            this.panel3.ResumeLayout(false);
            this.PNL_Text.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox LBX_Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PNL_Text;
    }
}