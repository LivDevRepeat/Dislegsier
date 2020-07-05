namespace WindowsFormsApp1
{
    partial class FRM_Level_2Layout
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PNL_InnerEdge = new System.Windows.Forms.Panel();
            this.PNL_Inner_Window = new System.Windows.Forms.Panel();
            this.LBL_SearchedWord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PNL_InnerEdge.SuspendLayout();
            this.PNL_Inner_Window.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.PNL_InnerEdge);
            this.panel1.Location = new System.Drawing.Point(250, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 200);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(833, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PNL_InnerEdge
            // 
            this.PNL_InnerEdge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PNL_InnerEdge.Controls.Add(this.PNL_Inner_Window);
            this.PNL_InnerEdge.Location = new System.Drawing.Point(129, 93);
            this.PNL_InnerEdge.Name = "PNL_InnerEdge";
            this.PNL_InnerEdge.Size = new System.Drawing.Size(120, 40);
            this.PNL_InnerEdge.TabIndex = 1;
            // 
            // PNL_Inner_Window
            // 
            this.PNL_Inner_Window.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PNL_Inner_Window.Controls.Add(this.LBL_SearchedWord);
            this.PNL_Inner_Window.Location = new System.Drawing.Point(2, 2);
            this.PNL_Inner_Window.Name = "PNL_Inner_Window";
            this.PNL_Inner_Window.Size = new System.Drawing.Size(116, 36);
            this.PNL_Inner_Window.TabIndex = 2;
            // 
            // LBL_SearchedWord
            // 
            this.LBL_SearchedWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_SearchedWord.AutoEllipsis = true;
            this.LBL_SearchedWord.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_SearchedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LBL_SearchedWord.Location = new System.Drawing.Point(0, 0);
            this.LBL_SearchedWord.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_SearchedWord.Name = "LBL_SearchedWord";
            this.LBL_SearchedWord.Size = new System.Drawing.Size(116, 36);
            this.LBL_SearchedWord.TabIndex = 0;
            this.LBL_SearchedWord.Text = "war";
            this.LBL_SearchedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Level_2Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 699);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FRM_Level_2Layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Level_2Layout";
            this.panel1.ResumeLayout(false);
            this.PNL_InnerEdge.ResumeLayout(false);
            this.PNL_Inner_Window.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PNL_InnerEdge;
        private System.Windows.Forms.Panel PNL_Inner_Window;
        private System.Windows.Forms.Label LBL_SearchedWord;
    }
}