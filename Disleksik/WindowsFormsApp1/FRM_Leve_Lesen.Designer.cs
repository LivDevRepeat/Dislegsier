namespace WindowsFormsApp1
{
    partial class FRM_Level_Lesen
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBX_Input_help = new System.Windows.Forms.TextBox();
            this.LBX_Text = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_Text = new System.Windows.Forms.Panel();
            this.PNL_Kopie = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PNL_Text.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 213);
            this.panel3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 73);
            this.label2.TabIndex = 11;
            this.label2.Text = "Drücke \'Enter\'";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(956, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 32);
            this.button4.TabIndex = 1;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.TBX_Input_help);
            this.panel1.Location = new System.Drawing.Point(28, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 73);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // TBX_Input_help
            // 
            this.TBX_Input_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TBX_Input_help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBX_Input_help.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TBX_Input_help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TBX_Input_help.Location = new System.Drawing.Point(3, 20);
            this.TBX_Input_help.Name = "TBX_Input_help";
            this.TBX_Input_help.Size = new System.Drawing.Size(442, 13);
            this.TBX_Input_help.TabIndex = 1;
            this.TBX_Input_help.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input);
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
            this.LBX_Text.TabStop = false;
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
            this.PNL_Text.Controls.Add(this.PNL_Kopie);
            this.PNL_Text.Controls.Add(this.LBX_Text);
            this.PNL_Text.Location = new System.Drawing.Point(260, 300);
            this.PNL_Text.Name = "PNL_Text";
            this.PNL_Text.Size = new System.Drawing.Size(695, 643);
            this.PNL_Text.TabIndex = 14;
            // 
            // PNL_Kopie
            // 
            this.PNL_Kopie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_Kopie.Location = new System.Drawing.Point(0, 0);
            this.PNL_Kopie.Name = "PNL_Kopie";
            this.PNL_Kopie.Size = new System.Drawing.Size(695, 643);
            this.PNL_Kopie.TabIndex = 15;
            this.PNL_Kopie.Visible = false;
            this.PNL_Kopie.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Kopie_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Location = new System.Drawing.Point(-28, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 875);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // FRM_Level_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PNL_Text);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FRM_Level_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LVL2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Level_2_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Level_2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input);
            this.Move += new System.EventHandler(this.FRM_Level_2_Move);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PNL_Text.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        public  System.Windows.Forms.ListBox LBX_Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public  System.Windows.Forms.Panel PNL_Text;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TBX_Input_help;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel PNL_Kopie;
        public System.Windows.Forms.Panel panel2;
    }
}