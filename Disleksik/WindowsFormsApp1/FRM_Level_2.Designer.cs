namespace WindowsFormsApp1
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
            this.button2 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBX_Text = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_Text = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.PNL_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 112);
            this.button2.TabIndex = 9;
            this.button2.Text = "Okay aber besser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 700);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 213);
            this.panel3.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(956, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 112);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ksen";
            this.button3.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PNL_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FRM_Level_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LVL2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Level_2_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Level_2_Load);
            this.Move += new System.EventHandler(this.FRM_Level_2_Move);
            this.panel3.ResumeLayout(false);
            this.PNL_Text.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        public  System.Windows.Forms.ListBox LBX_Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public  System.Windows.Forms.Panel PNL_Text;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}