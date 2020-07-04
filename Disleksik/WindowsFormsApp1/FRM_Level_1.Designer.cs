namespace Disleksia
{
    partial class FRM_Level_1
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
            this.imput = new System.Windows.Forms.TextBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.lBx_MainWindow = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // imput
            // 
            this.imput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imput.Location = new System.Drawing.Point(0, 641);
            this.imput.Name = "imput";
            this.imput.Size = new System.Drawing.Size(984, 20);
            this.imput.TabIndex = 1;
            this.imput.Text = "test test";
            this.imput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imput_KeyPress);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(50, 50);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(137, 68);
            this.btn_test.TabIndex = 2;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // lBx_MainWindow
            // 
            this.lBx_MainWindow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lBx_MainWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBx_MainWindow.CausesValidation = false;
            this.lBx_MainWindow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lBx_MainWindow.HorizontalScrollbar = true;
            this.lBx_MainWindow.IntegralHeight = false;
            this.lBx_MainWindow.ItemHeight = 25;
            this.lBx_MainWindow.Location = new System.Drawing.Point(12, 193);
            this.lBx_MainWindow.Name = "lBx_MainWindow";
            this.lBx_MainWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lBx_MainWindow.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lBx_MainWindow.Size = new System.Drawing.Size(960, 423);
            this.lBx_MainWindow.TabIndex = 4;
            this.lBx_MainWindow.TabStop = false;
            this.lBx_MainWindow.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(200, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(50, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FRM_Level_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lBx_MainWindow);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.imput);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Level_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dyslekxic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Level_1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_test;
        public System.Windows.Forms.TextBox imput;
        private System.Windows.Forms.ListBox lBx_MainWindow;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

