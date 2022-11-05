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
            this.SuspendLayout();
            // 
            // LBL_IgnoreSetup
            // 
            this.LBL_IgnoreSetup.AutoSize = true;
            this.LBL_IgnoreSetup.Location = new System.Drawing.Point(12, 21);
            this.LBL_IgnoreSetup.Name = "LBL_IgnoreSetup";
            this.LBL_IgnoreSetup.Size = new System.Drawing.Size(79, 15);
            this.LBL_IgnoreSetup.TabIndex = 0;
            this.LBL_IgnoreSetup.Text = "Ignore Setups";
            // 
            // Check_IgnoreSet
            // 
            this.Check_IgnoreSet.AutoSize = true;
            this.Check_IgnoreSet.Location = new System.Drawing.Point(97, 21);
            this.Check_IgnoreSet.Name = "Check_IgnoreSet";
            this.Check_IgnoreSet.Size = new System.Drawing.Size(29, 19);
            this.Check_IgnoreSet.TabIndex = 1;
            this.Check_IgnoreSet.Text = " ";
            this.Check_IgnoreSet.UseVisualStyleBackColor = true;
            this.Check_IgnoreSet.CheckedChanged += new System.EventHandler(this.Check_IgnoreSet_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 132);
            this.Controls.Add(this.Check_IgnoreSet);
            this.Controls.Add(this.LBL_IgnoreSetup);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_IgnoreSetup;
        private CheckBox Check_IgnoreSet;
    }
}