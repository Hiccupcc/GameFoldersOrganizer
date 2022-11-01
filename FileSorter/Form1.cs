using System.Reflection.Emit;
using System.IO;
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
                LBL_Setups.Text = "Selected Setups Folder Will Show Here.";
                SelectedSetup = "";
                SetupSelected = false;
                GameSelected = false;
            }



        }

        private void BTN_Org_Click(object sender, EventArgs e)
        {
            try
            {
                string[] SetupFolderKeywords = { "Setup", "FitGirl" };
                string[] roots = Directory.GetDirectories(Game.SelectedPath, "*", SearchOption.TopDirectoryOnly);
                foreach (var item in roots)
                {
                    string? FoundFolder = Path.GetFullPath(item);
                    if (FoundFolder.Contains(SetupFolderKeywords[1]))
                    {
                        CopyDeleteFolder();
                    }
                    else if (FoundFolder.Contains(SetupFolderKeywords[0]))
                    {
                        CopyDeleteFolder();
                    }
                  
                }
             }
            catch (IOException ExpMoveFolder)
            {
                MessageBox.Show(ExpMoveFolder.Message);
            }


        }

        public void CopyDeleteFolder()
        {
            DirectoryInfo GameDirectory = new DirectoryInfo(Game.SelectedPath);
            string GameContentsPath = Game.SelectedPath + @"\" + GameDirectory.Name;
            string[] roots = Directory.GetDirectories(Game.SelectedPath, "*", SearchOption.TopDirectoryOnly);
            foreach (var item in roots)
            {
                string? FoundFolder = Path.GetFullPath(item);
                Directory.Move(FoundFolder, Path.GetFullPath(Setup.SelectedPath) + @"\" + Path.GetFileName(FoundFolder));
                if (Directory.Exists(GameContentsPath))
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
                     Directory.Delete(GameContentsPath);

                }

            }

        }
    }

}