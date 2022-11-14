namespace FileSorter
{
    partial class Settings
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
            this.LBL_IgnoreSetup = new System.Windows.Forms.Label();
            this.Check_IgnoreSet = new System.Windows.Forms.CheckBox();
            this.Check_AllFolders = new System.Windows.Forms.CheckBox();
            this.LBL_AllFolders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_IgnoreSetup
            // 
            this.LBL_IgnoreSetup.AutoSize = true;
            this.LBL_IgnoreSetup.Location = new System.Drawing.Point(12, 37);
            this.LBL_IgnoreSetup.Name = "LBL_IgnoreSetup";
            this.LBL_IgnoreSetup.Size = new System.Drawing.Size(79, 15);
            this.LBL_IgnoreSetup.TabIndex = 0;
            this.LBL_IgnoreSetup.Text = "Ignore Setups";
            // 
            // Check_IgnoreSet
            // 
            this.Check_IgnoreSet.AutoSize = true;
            this.Check_IgnoreSet.Location = new System.Drawing.Point(246, 29);
            this.Check_IgnoreSet.Name = "Check_IgnoreSet";
            this.Check_IgnoreSet.Size = new System.Drawing.Size(29, 19);
            this.Check_IgnoreSet.TabIndex = 1;
            this.Check_IgnoreSet.Text = " ";
            this.Check_IgnoreSet.UseVisualStyleBackColor = true;
            this.Check_IgnoreSet.CheckedChanged += new System.EventHandler(this.Check_IgnoreSet_CheckedChanged);
            // 
            // Check_AllFolders
            // 
            this.Check_AllFolders.AutoSize = true;
            this.Check_AllFolders.Location = new System.Drawing.Point(246, 9);
            this.Check_AllFolders.Name = "Check_AllFolders";
            this.Check_AllFolders.Size = new System.Drawing.Size(15, 14);
            this.Check_AllFolders.TabIndex = 2;
            this.Check_AllFolders.UseVisualStyleBackColor = true;
            // 
            // LBL_AllFolders
            // 
            this.LBL_AllFolders.AutoSize = true;
            this.LBL_AllFolders.Location = new System.Drawing.Point(12, 9);
            this.LBL_AllFolders.Name = "LBL_AllFolders";
            this.LBL_AllFolders.Size = new System.Drawing.Size(216, 15);
            this.LBL_AllFolders.TabIndex = 3;
            this.LBL_AllFolders.Text = "Sort all folders inside the selected folder";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 132);
            this.Controls.Add(this.LBL_AllFolders);
            this.Controls.Add(this.Check_AllFolders);
            this.Controls.Add(this.Check_IgnoreSet);
            this.Controls.Add(this.LBL_IgnoreSetup);
            this.Name = "Settings";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_IgnoreSetup;
        private CheckBox Check_IgnoreSet;
        private CheckBox Check_AllFolders;
        private Label LBL_AllFolders;
    }
}