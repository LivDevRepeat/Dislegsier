namespace WindowsFormsApp1
{
    partial class FRM_Text
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBX_MainWindow = new System.Windows.Forms.ListBox();
            this.LBX_Awnsers = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LBX_MainWindow
            // 
            this.LBX_MainWindow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LBX_MainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBX_MainWindow.CausesValidation = false;
            this.LBX_MainWindow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LBX_MainWindow.HorizontalScrollbar = true;
            this.LBX_MainWindow.IntegralHeight = false;
            this.LBX_MainWindow.ItemHeight = 25;
            this.LBX_MainWindow.Location = new System.Drawing.Point(15, 50);
            this.LBX_MainWindow.Name = "LBX_MainWindow";
            this.LBX_MainWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBX_MainWindow.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LBX_MainWindow.Size = new System.Drawing.Size(960, 429);
            this.LBX_MainWindow.TabIndex = 4;
            this.LBX_MainWindow.TabStop = false;
            this.LBX_MainWindow.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // LBX_Awnsers
            // 
            this.LBX_Awnsers.BackColor = System.Drawing.SystemColors.MenuText;
            this.LBX_Awnsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBX_Awnsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Awnsers.ForeColor = System.Drawing.SystemColors.Window;
            this.LBX_Awnsers.FormattingEnabled = true;
            this.LBX_Awnsers.ItemHeight = 24;
            this.LBX_Awnsers.Items.AddRange(new object[] {
            "Antwort 1",
            "Antwort 2",
            "Antwort 3",
            "Antwort 4"});
            this.LBX_Awnsers.Location = new System.Drawing.Point(12, 498);
            this.LBX_Awnsers.Margin = new System.Windows.Forms.Padding(0);
            this.LBX_Awnsers.MultiColumn = true;
            this.LBX_Awnsers.Name = "LBX_Awnsers";
            this.LBX_Awnsers.Size = new System.Drawing.Size(963, 122);
            this.LBX_Awnsers.TabIndex = 5;
            this.LBX_Awnsers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.LBX_Awnsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LBX_Awnsers_KeyPress);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(951, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FRM_Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.LBX_Awnsers);
            this.Controls.Add(this.LBX_MainWindow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FRM_Text";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dyslekxic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Level_1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBX_MainWindow;
        private System.Windows.Forms.ListBox LBX_Awnsers;
        private System.Windows.Forms.Button button4;
    }
}

