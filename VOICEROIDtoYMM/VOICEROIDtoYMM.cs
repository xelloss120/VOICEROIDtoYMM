using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VOICEROIDtoYMM
{
    public partial class VOICEROIDtoYMM : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public VOICEROIDtoYMM()
        {
            InitializeComponent();

            StreamReader streamReader = new StreamReader(@"setting.txt");
            Text = streamReader.ReadLine();
            VoiceRoidTitleBox.Text = streamReader.ReadLine();
            FileNameBox.Text = streamReader.ReadLine();
            NumberBox.Text = streamReader.ReadLine();
            WaitBox.Text = streamReader.ReadLine();
            streamReader.Close();
        }

        private void VOICEROIDtoYMM_FormClosed(object sender, FormClosedEventArgs e)
        {
            string setting = "";
            setting += Text + "\n";
            setting += VoiceRoidTitleBox.Text + "\n";
            setting += FileNameBox.Text + "\n";
            setting += NumberBox.Text + "\n";
            setting += WaitBox.Text + "\n";

            StreamWriter streamWriter = new StreamWriter(@"setting.txt");
            streamWriter.Write(setting);
            streamWriter.Close();
        }

        private void FolderSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                Text = Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Process[] voiceroidProcess = Process.GetProcessesByName("VOICEROID");
            Process[] yukkuriMovieMakerProcess = Process.GetProcessesByName("YukkuriMovieMaker_v3");

            foreach(Process process in voiceroidProcess)
            {
                if(process.MainWindowTitle.IndexOf(VoiceRoidTitleBox.Text) != -1 &&
                    yukkuriMovieMakerProcess.Length > 0)
                {
                    Macro(process, yukkuriMovieMakerProcess[0]);
                }
            }
        }

        private void Macro(Process voiceroidProcess, Process yukkuriMovieMakerProcess)
        {
            string path = Text + "\\" + FileNameBox.Text + int.Parse(NumberBox.Text).ToString("D4") + ".wav";

            SetForegroundWindow(voiceroidProcess.MainWindowHandle);
            Send("^{TAB}");
            Send("{RIGHT}");
            Send("{RIGHT}");
            Send("{ENTER}");
            Send(path);
            Send("{ENTER}");
            Send("{BS 100}");

            SetForegroundWindow(yukkuriMovieMakerProcess.MainWindowHandle);
            Send("^{TAB}");
            Send("{ENTER}");
            Send(path);
            Send("{ENTER}");
            Send(" ");

            NumberBox.Text = (int.Parse(NumberBox.Text) + 1).ToString();
        }

        private void Send(string keys)
        {
            SendKeys.Send(keys);
            System.Threading.Thread.Sleep(int.Parse(WaitBox.Text));
        }
    }
}
