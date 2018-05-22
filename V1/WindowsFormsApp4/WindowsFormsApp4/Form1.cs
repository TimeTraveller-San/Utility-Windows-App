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


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelYO.Height = button3.Height;
            PanelYO.Top = button3.Top + 27;
            panel_1.BackColor = Color.FromArgb(21, 21, 21);
            panel_2.BackColor = Color.FromArgb(0, 0, 0);
            panel5.BackColor = Color.FromArgb(0, 0, 0);
            panel6.BackColor = Color.FromArgb(0, 0, 0);
            panel7.BackColor = Color.FromArgb(0, 0, 0);
            panel8.BackColor = Color.FromArgb(0, 0, 0);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelYO.Height = button4.Height;
            PanelYO.Top = button4.Top + 27;
            panel_2.BackColor = Color.FromArgb(21, 21, 21);
            panel_1.BackColor = Color.FromArgb(0, 0, 0);

            panel5.BackColor = Color.FromArgb(0, 0, 0);
            panel6.BackColor = Color.FromArgb(0, 0, 0);
            panel7.BackColor = Color.FromArgb(0, 0, 0);
            panel8.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelYO.Height = button5.Height;
            PanelYO.Top = button5.Top + 27;
            panel5.BackColor = Color.FromArgb(21, 21, 21);
            panel_1.BackColor = Color.FromArgb(0, 0, 0);
            panel_2.BackColor = Color.FromArgb(0, 0, 0);

            panel6.BackColor = Color.FromArgb(0, 0, 0);
            panel7.BackColor = Color.FromArgb(0, 0, 0);
            panel8.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PanelYO.Height = button6.Height;
            PanelYO.Top = button6.Top + 27;
            panel6.BackColor = Color.FromArgb(21, 21, 21);
            panel_1.BackColor = Color.FromArgb(0, 0, 0);
            panel_2.BackColor = Color.FromArgb(0, 0, 0);
            panel5.BackColor = Color.FromArgb(0, 0, 0);

            panel7.BackColor = Color.FromArgb(0, 0, 0);
            panel8.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PanelYO.Height = button7.Height;
            PanelYO.Top = button7.Top + 27;
            panel7.BackColor = Color.FromArgb(21, 21, 21);
            panel_1.BackColor = Color.FromArgb(0, 0, 0);
            panel_2.BackColor = Color.FromArgb(0, 0, 0);
            panel5.BackColor = Color.FromArgb(0, 0, 0);
            panel6.BackColor = Color.FromArgb(0, 0, 0);

            panel8.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PanelYO.Height = button8.Height;
            PanelYO.Top = button8.Top + 27;
            panel8.BackColor = Color.FromArgb(21, 21, 21);
            panel_1.BackColor = Color.FromArgb(0, 0, 0);
            panel_2.BackColor = Color.FromArgb(0, 0, 0);
            panel5.BackColor = Color.FromArgb(0, 0, 0);
            panel6.BackColor = Color.FromArgb(0, 0, 0);
            panel7.BackColor = Color.FromArgb(0, 0, 0);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"F:\Games\Nekopara\NEKOPARA Vol. 1\nekopara_vol1.exe");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Time Traveller\AppData\Local\Discord\app-0.0.298\Discord.exe");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Time Traveller\AppData\Roaming\uTorrent\uTorrent.exe");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\notepad.exe");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PL5qkXD5saywFHHwkGD6P_R3DaxVZG9qVC");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PL5qkXD5saywHYBwf6KA4oWtlwDd5qqohU");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PL5qkXD5saywFOi_YNCwUdIpIpEF2x0DPx");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PL5qkXD5saywGPiPJQrbATWIVN5YdMvNEe");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PL5qkXD5saywHQJ6FmdaMB1f2OZpU8LsCn");

        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv.exe");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Dev-Cpp\devcpp.exe");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Brackets\Brackets.exe");

        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Time Traveller\AppData\Local\atom\atom.exe");

        }

        private void button28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Adobe\Adobe After Effects CC 2017\Support Files\AfterFX.exe");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Live\Photo Gallery\WinMovieMaker.exe");

        }

        private void button29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Adobe\Adobe Photoshop CS6 (64 Bit)\Photoshop.exe");

        }

        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Adobe\Adobe Illustrator CC 2017\Support Files\Contents\Windows\Illustrator.exe");

        }

        private void button25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"F:\Games\SteamLibrary\steamapps\common\TEKKEN 7\TEKKEN 7.exe");

        }

        private void button24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"F:\Games\FortNite\Epic Games\Launcher\Portal\Binaries\Win32\EpicGamesLauncher.exe");

        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"F:\Games\Nier Automata\NieR - Automata\NieRAutomata.exe");

        }

        private void button33_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\");

        }

        private void button32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\");

        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"E:\");

        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"F:\");

        }

        private void button34_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"G:\");

        }

        int mouseX = 0, mouseY = 0;
        int mouseinX = 0, mouseinY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
            mouseDown = true;
        }
    }
}

