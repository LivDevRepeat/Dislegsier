namespace Disleksia
{
    partial class FRM_Level_Schreiben
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
            this.TBX_Input = new System.Windows.Forms.TextBox();
            this.LBX_MainWindow = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // TBX_Input
            // 
            this.TBX_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBX_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Input.Location = new System.Drawing.Point(15, 595);
            this.TBX_Input.Name = "TBX_Input";
            this.TBX_Input.Size = new System.Drawing.Size(970, 19);
            this.TBX_Input.TabIndex = 1;
            this.TBX_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imput_KeyPress);
            // 
            // LBX_MainWindow
            // 
            this.LBX_MainWindow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LBX_MainWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBX_MainWindow.CausesValidation = false;
            this.LBX_MainWindow.ColumnWidth = 470;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(801, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "FEHLER :     0";
            this.label2.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(951, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FRM_Level_Schreiben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBX_MainWindow);
            this.Controls.Add(this.TBX_Input);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1015, 738);
            this.Name = "FRM_Level_Schreiben";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dyslekxic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TBX_Input;
        private System.Windows.Forms.ListBox LBX_MainWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}

