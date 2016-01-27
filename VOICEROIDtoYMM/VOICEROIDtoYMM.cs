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

            NumberBox.Text = streamReader.ReadLine();
            WaitBox.Text = streamReader.ReadLine();

            VoiceRoidTitleBox1.Text = streamReader.ReadLine();

            VoiceRoidTitleBox2.Text = streamReader.ReadLine();

            streamReader.Close();

            SendButton1.Text = VoiceRoidTitleBox1.Text;
            SendButton2.Text = VoiceRoidTitleBox2.Text;
        }

        private void VOICEROIDtoYMM_FormClosed(object sender, FormClosedEventArgs e)
        {
            string setting = "";
            setting += Text + "\n";
            setting += NumberBox.Text + "\n";
            setting += WaitBox.Text + "\n";

            setting += VoiceRoidTitleBox1.Text + "\n";

            setting += VoiceRoidTitleBox2.Text + "\n";

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

        private void Send(string keys)
        {
            SendKeys.Send(keys);
            System.Threading.Thread.Sleep(int.Parse(WaitBox.Text));
        }

        private void Macro(string name, Process voiceroidProcess, Process yukkuriMovieMakerProcess)
        {
            string path = Text + "\\" + name + int.Parse(NumberBox.Text).ToString("D4") + ".wav";

            SetForegroundWindow(voiceroidProcess.MainWindowHandle);
            Send("^{TAB}");
            Send("{RIGHT}");
            Send("{RIGHT}");
            Send("{ENTER}");
            Send(path);
            Send("{ENTER}");
            Send("+^{HOME}{DELETE}");

            SetForegroundWindow(yukkuriMovieMakerProcess.MainWindowHandle);
            Send("^{TAB}");
            Send("{ENTER}");
            Send(path);
            Send("{ENTER}");

            NumberBox.Text = (int.Parse(NumberBox.Text) + 1).ToString();
        }

        private void SendButton_Click(string name)
        {
            Process[] voiceroidProcess = Process.GetProcessesByName("VOICEROID");
            Process[] yukkuriMovieMakerProcess = Process.GetProcessesByName("YukkuriMovieMaker_v3");

            foreach (Process process in voiceroidProcess)
            {
                if (process.MainWindowTitle.IndexOf(name) != -1 &&
                    yukkuriMovieMakerProcess.Length > 0)
                {
                    Macro(name, process, yukkuriMovieMakerProcess[0]);
                }
            }
        }

        private void VoiceRoidTitleBox1_TextChanged(object sender, EventArgs e)
        {
            SendButton1.Text = VoiceRoidTitleBox1.Text;
        }

        private void VoiceRoidTitleBox2_TextChanged(object sender, EventArgs e)
        {
            SendButton2.Text = VoiceRoidTitleBox2.Text;
        }

        private void SendButton1_Click(object sender, EventArgs e)
        {
            SendButton_Click(VoiceRoidTitleBox1.Text);
        }

        private void SendButton2_Click(object sender, EventArgs e)
        {
            SendButton_Click(VoiceRoidTitleBox2.Text);
        }

        private void VOICEROIDtoYMM_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F1:
                    SendButton_Click(VoiceRoidTitleBox1.Text);
                    break;
                case Keys.F2:
                    SendButton_Click(VoiceRoidTitleBox2.Text);
                    break;
            }
        }
    }
}
