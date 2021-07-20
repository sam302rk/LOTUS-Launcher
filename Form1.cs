using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace LOTUS_Launcher
{
    public partial class Form1 : Form
    {
        public bool DarkMode;

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("LAUNCHER/THEME"))
            {
                DarkMode = File.ReadAllText("LAUNCHER/THEME").Equals("True");
                button3_Click(null, null);
            }
        }

        private void bit32_Click(object sender, EventArgs e) // x64
        {
            Open("64");
        }

        private void bit64_Click(object sender, EventArgs e) // x86
        {
            if (MessageBox.Show(getTranslation("x86Question").Replace("!!", "\n"),
                getTranslation("Name"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes) Open("32");
        }

        private void Open(string type)
        {
            if (!Directory.Exists("LAUNCHER")) return;
            File.Delete("LOTUS.exe");
            File.Copy("LAUNCHER/LOTUS-" + type + ".exe", "LOTUS.exe");
            StartSteamApp(370350, false);

            Hide();

            while (Process.GetProcessesByName("LOTUS").Length == 0) ;
            while (Process.GetProcessesByName("LOTUS").Length > 0) ;
            
            File.Delete("LOTUS.exe");
            File.Copy("LAUNCHER/LOTUS-64.exe", "LOTUS.exe");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Properties.Resources.ResourceManager.GetString("Name");
            bit64.Text = getTranslation("RunLOTUS").Replace("%", "86");
            bit32.Text = getTranslation("RunLOTUS").Replace("%", "64");
            label1.Text = getTranslation("StartQuestion");

            if (!Directory.Exists("LAUNCHER"))
            {
                Directory.CreateDirectory("LAUNCHER");
                File.Copy("LOTUS.exe", "LAUNCHER/LOTUS-64.exe");
                File.Copy("LOTUS_32.exe", "LAUNCHER/LOTUS-32.exe");
            }
        }

        private string getTranslation(string key)
        {
            if (CultureInfo.CurrentCulture.Name.Equals("de-DE")) return Properties.Resources_German.ResourceManager.GetString(key);
            return Properties.Resources.ResourceManager.GetString(key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartSteamApp(870500, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartSteamApp(870490, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DarkMode = !DarkMode;
            button3.BackgroundImage = DarkMode ? Properties.Resources.LightMode : Properties.Resources.DarkMode;

            BackColor = DarkMode ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            ForeColor = DarkMode ? SystemColors.Control : SystemColors.ControlText;

            File.WriteAllText("LAUNCHER/THEME", DarkMode + "");
        }

        private static void StartSteamApp(int gameId, bool exit)
        {
            Process.Start("steam://rungameid/" + gameId);
            if(exit) Application.Exit();
        }
    }
}
