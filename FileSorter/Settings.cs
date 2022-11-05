using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if (Form1.IgnoreSetup == true)
            {
                Check_IgnoreSet.Checked = true; 
            }
            else if (Form1.IgnoreSetup == false)
            {
                Check_IgnoreSet.Checked = false; 
            }
        }
        public static bool SetupIgnored;
        private void Check_IgnoreSet_CheckedChanged(object sender, EventArgs e)
        { 
            if (Check_IgnoreSet.Checked)
            {
                SetupIgnored = true;
            }
            else
            {
                SetupIgnored = false; 
            }
     
        }
    }
}
