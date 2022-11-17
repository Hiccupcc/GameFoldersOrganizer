namespace FileSorter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Game = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.FolderBrowserDialog();
            this.BTN_Setup = new System.Windows.Forms.Button();
            this.Setup = new System.Windows.Forms.FolderBrowserDialog();
            this.PIC_Setup = new System.Windows.Forms.PictureBox();
            this.LBL_Setups = new System.Windows.Forms.Label();
            this.PIC_Game = new System.Windows.Forms.PictureBox();
            this.LBL_Game = new System.Windows.Forms.Label();
            this.BTN_Org = new System.Windows.Forms.Button();
            this.PIC_OpenSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Setup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_OpenSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Game
            // 
            this.BTN_Game.Location = new System.Drawing.Point(323, 259);
            this.BTN_Game.Name = "BTN_Game";
            this.BTN_Game.Size = new System.Drawing.Size(86, 33);
            this.BTN_Game.TabIndex = 0;
            this.BTN_Game.Text = "Game Folder";
            this.BTN_Game.UseVisualStyleBackColor = true;
            this.BTN_Game.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // BTN_Setup
            // 
            this.BTN_Setup.Location = new System.Drawing.Point(12, 259);
            this.BTN_Setup.Name = "BTN_Setup";
            this.BTN_Setup.Size = new System.Drawing.Size(86, 33);
            this.BTN_Setup.TabIndex = 1;
            this.BTN_Setup.Text = "Setups Folder";
            this.BTN_Setup.UseVisualStyleBackColor = true;
            this.BTN_Setup.Click += new System.EventHandler(this.BTN_Setup_Click);
            // 
            // PIC_Setup
            // 
            this.PIC_Setup.Image = ((System.Drawing.Image)(resources.GetObject("PIC_Setup.Image")));
            this.PIC_Setup.Location = new System.Drawing.Point(12, 31);
            this.PIC_Setup.Name = "PIC_Setup";
            this.PIC_Setup.Size = new System.Drawing.Size(50, 50);
            this.PIC_Setup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Setup.TabIndex = 2;
            this.PIC_Setup.TabStop = false;
            // 
            // LBL_Setups
            // 
            this.LBL_Setups.AutoSize = true;
            this.LBL_Setups.Location = new System.Drawing.Point(68, 48);
            this.LBL_Setups.Name = "LBL_Setups";
            this.LBL_Setups.Size = new System.Drawing.Size(211, 15);
            this.LBL_Setups.TabIndex = 3;
            this.LBL_Setups.Text = "Selected Setups Folder Will Show Here.";
            // 
            // PIC_Game
            // 
            this.PIC_Game.Image = ((System.Drawing.Image)(resources.GetObject("PIC_Game.Image")));
            this.PIC_Game.Location = new System.Drawing.Point(12, 161);
            this.PIC_Game.Name = "PIC_Game";
            this.PIC_Game.Size = new System.Drawing.Size(50, 50);
            this.PIC_Game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Game.TabIndex = 4;
            this.PIC_Game.TabStop = false;
            // 
            // LBL_Game
            // 
            this.LBL_Game.AutoSize = true;
            this.LBL_Game.Location = new System.Drawing.Point(68, 180);
            this.LBL_Game.Name = "LBL_Game";
            this.LBL_Game.Size = new System.Drawing.Size(207, 15);
            this.LBL_Game.TabIndex = 5;
            this.LBL_Game.Text = "Selected Game Folder Will Show Here.";
            // 
            // BTN_Org
            // 
            this.BTN_Org.Enabled = false;
            this.BTN_Org.Location = new System.Drawing.Point(132, 259);
            this.BTN_Org.Name = "BTN_Org";
            this.BTN_Org.Size = new System.Drawing.Size(157, 23);
            this.BTN_Org.TabIndex = 6;
            this.BTN_Org.Text = "Orgnaize Game Folder";
            this.BTN_Org.UseVisualStyleBackColor = true;
            this.BTN_Org.Click += new System.EventHandler(this.BTN_Org_Click);
            // 
            // PIC_OpenSettings
            // 
            this.PIC_OpenSettings.Image = ((System.Drawing.Image)(resources.GetObject("PIC_OpenSettings.Image")));
            this.PIC_OpenSettings.Location = new System.Drawing.Point(359, 3);
            this.PIC_OpenSettings.Name = "PIC_OpenSettings";
            this.PIC_OpenSettings.Size = new System.Drawing.Size(50, 50);
            this.PIC_OpenSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_OpenSettings.TabIndex = 7;
            this.PIC_OpenSettings.TabStop = false;
            this.PIC_OpenSettings.Click += new System.EventHandler(this.PIC_OpenSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 300);
            this.Controls.Add(this.PIC_OpenSettings);
            this.Controls.Add(this.BTN_Org);
            this.Controls.Add(this.LBL_Game);
            this.Controls.Add(this.PIC_Game);
            this.Controls.Add(this.LBL_Setups);
            this.Controls.Add(this.PIC_Setup);
            this.Controls.Add(this.BTN_Setup);
            this.Controls.Add(this.BTN_Game);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Setup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_OpenSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_Game;
        private FolderBrowserDialog Game;
        private Button BTN_Setup;
        private FolderBrowserDialog Setup;
        private PictureBox PIC_Setup;
        private Label LBL_Setups;
        private PictureBox PIC_Game;
        private Label LBL_Game;
        private Button BTN_Org;
        private PictureBox PIC_OpenSettings;
    }
}