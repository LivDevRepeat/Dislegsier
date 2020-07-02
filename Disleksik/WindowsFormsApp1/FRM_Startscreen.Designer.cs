namespace WindowsFormsApp1
{
    partial class FRM_Startscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Startscreen));
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.LBL_MainName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            resources.ApplyResources(this.BTN_Start, "BTN_Start");
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BTN_Exit, "BTN_Exit");
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.UseVisualStyleBackColor = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // LBL_MainName
            // 
            resources.ApplyResources(this.LBL_MainName, "LBL_MainName");
            this.LBL_MainName.BackColor = System.Drawing.Color.MidnightBlue;
            this.LBL_MainName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_MainName.ForeColor = System.Drawing.Color.White;
            this.LBL_MainName.Name = "LBL_MainName";
            // 
            // FRM_Startscreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.LBL_MainName);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Start);
            this.Name = "FRM_Startscreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Label LBL_MainName;
    }
}