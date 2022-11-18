namespace FileSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool GameSelected = false;
        private bool SetupSelected = false;
        private string FolderSelectedTwice = "Please select two different folders.";
        private string SelectSetupLabel = "Selected Setups Folder Will Show Here.";
        private string[] SetupFolderKeywords = { "Setup", "FitGirl" };
        public static bool IgnoreSetup;
        public static bool AllFoldersForm;
        private void BTN_Load_Click(object sender, EventArgs e)
        {
            Game.ShowDialog();
            string SelectedGame = Game.SelectedPath;
            LBL_Game.Text = SelectedGame;
            GameSelected = true;
            if (SetupSelected == true && GameSelected == true && Game.SelectedPath != Setup.SelectedPath)
            {
                BTN_Org.Enabled = true;
            }
            else if (GameSelected == true && Settings.SetupIgnored == true)
            {
                BTN_Org.Enabled = true;
            }
            else if (Game.SelectedPath == Setup.SelectedPath)
            {
                BTN_Org.Enabled = false;
                MessageBox.Show(FolderSelectedTwice);
                LBL_Game.Text = "Selected Game Folder Will Show Here.";
                LBL_Setups.Text = "Selected Setups Folder Will Show Here.";
                SelectedGame = "!";
                SetupSelected = false;
                GameSelected = false;
            }
            



        }

        private void BTN_Setup_Click(object sender, EventArgs e)
        {
            Setup.ShowDialog();
            string SelectedSetup = Setup.SelectedPath;
            LBL_Setups.Text = SelectedSetup;
            SetupSelected = true;
            if (SetupSelected == true && GameSelected == true && Game.SelectedPath != Setup.SelectedPath)
            {
                BTN_Org.Enabled = true;
            }
            else if (Game.SelectedPath == Setup.SelectedPath)
            {
                BTN_Org.Enabled = false;
                MessageBox.Show(FolderSelectedTwice);
                LBL_Game.Text = "Selected Game Folder Will Show Here.";
                LBL_Setups.Text = SelectSetupLabel;
                SelectedSetup = "";
                SetupSelected = false;
                GameSelected = false;
            }
        }

        private void BTN_Org_Click(object sender, EventArgs e)
        {
            if (Settings.SetupIgnored == false)
            {
                string[] roots = Directory.GetDirectories(Game.SelectedPath, "*", SearchOption.TopDirectoryOnly);
                foreach (var item in roots)
                {
                    string? FoundFolder = Path.GetFullPath(item);
                    DirectoryInfo MoveFullSetupPath = new DirectoryInfo(Setup.SelectedPath + FoundFolder);
                    if (FoundFolder.Contains(SetupFolderKeywords[1]))
                    {
                        if (MoveFullSetupPath.Exists == false)
                        {
                            DirectoryInfo MoveSetup = new DirectoryInfo(FoundFolder);
                            MoveSetup.MoveTo(Setup.SelectedPath + @"\" + MoveSetup.Name);
                        }
                    }
                }
                MoveGameFiles();
            }
            else if (Settings.SetupIgnored == true)
            {
                MoveGameFiles();
            }

        }





        private void PIC_OpenSettings_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.ShowDialog();
            if (Settings.SetupIgnored == true)
            {
                BTN_Setup.Enabled = false;
                LBL_Setups.Text = "Ignore Setups is checked.";
                IgnoreSetup = true;
            }
            if (Settings.SetupIgnored == false)
            {
                BTN_Setup.Enabled = true;
                LBL_Setups.Text = SelectSetupLabel;
                IgnoreSetup = false;
            }
        }

        public void MoveGameFiles()
        {
            DirectoryInfo GameDirectory = new DirectoryInfo(Game.SelectedPath);
            string GameContentsPath = Game.SelectedPath + @"\" + GameDirectory.Name;
            DirectoryInfo DuplicateFolderCheck = new DirectoryInfo(GameContentsPath);
            if (DuplicateFolderCheck.Exists)
            {
                string[] GameFiles = Directory.GetFiles(GameContentsPath);
                foreach (string GameFile in GameFiles)
                {
                    FileInfo CopyGameFile = new FileInfo(GameFile);
                    if (new FileInfo(GameDirectory + @"\" + CopyGameFile.Name).Exists == false)
                    {
                        CopyGameFile.MoveTo(GameDirectory + @"\" + CopyGameFile.Name);
                    }
                }
                string[] GameFolders = Directory.GetDirectories(GameContentsPath);
                foreach (string GameFolder in GameFolders)
                {
                    DirectoryInfo CopyGameFolder = new DirectoryInfo(GameFolder);
                    if (new DirectoryInfo(GameDirectory + @"\" + CopyGameFolder.Name).Exists == false)
                    {
                        if (!CopyGameFolder.Name.Contains(SetupFolderKeywords[0]) || !CopyGameFolder.Name.Contains(SetupFolderKeywords[1]))
                        {
                            CopyGameFolder.MoveTo(GameDirectory + @"\" + CopyGameFolder.Name);
                        }
                    }
                }
                Directory.Delete(GameContentsPath);
            }
            else if (!DuplicateFolderCheck.Exists)
            {
                DirectoryInfo SelectedGamePath = new DirectoryInfo(Game.SelectedPath);
                string[] nonDuplicateDir = Directory.GetDirectories(Game.SelectedPath);
                foreach (string nonDuplicateDir1 in nonDuplicateDir)
                {
                    string[] GameFiles = Directory.GetFiles(nonDuplicateDir1);
                    foreach (string GameFile in GameFiles)
                    {
                        FileInfo CopyGameFile = new FileInfo(GameFile);
                        if (new FileInfo(GameDirectory + @"\" + CopyGameFile.Name).Exists == false)
                        {
                            CopyGameFile.MoveTo(GameDirectory + @"\" + CopyGameFile.Name);
                        }
                    }
                    string[] GameFolders = Directory.GetDirectories(nonDuplicateDir1);
                    foreach (string GameFolder in GameFolders)
                    {
                        DirectoryInfo CopyGameFolder = new DirectoryInfo(GameFolder);
                        if (new DirectoryInfo(GameDirectory + @"\" + CopyGameFolder.Name).Exists == false)
                        {
                            if (!CopyGameFolder.Name.Contains(SetupFolderKeywords[0]) || !CopyGameFolder.Name.Contains(SetupFolderKeywords[1]))
                            {
                                CopyGameFolder.MoveTo(GameDirectory + @"\" + CopyGameFolder.Name);
                            }
                        }
                    }
                    Directory.Delete(nonDuplicateDir1);
                }
       }
    }





}

}