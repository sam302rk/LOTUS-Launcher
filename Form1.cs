using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace LOTUS_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bit32_Click(object sender, EventArgs e) // x64
        {
            open("64");
        }

        private void bit64_Click(object sender, EventArgs e) // x86
        {
            if (MessageBox.Show(getTranslation("x86Question"),
                getTranslation("Name"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes) open("32");
        }

        private void open(string type)
        {
            if (!Directory.Exists("LAUNCHER")) return;
            File.Delete("LOTUS.exe");
            File.Copy("LAUNCHER/LOTUS-" + type + ".exe", "LOTUS.exe");
            Process.Start("steam://rungameid/370350");
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
                bit64.Enabled = false;
                bit32.Enabled = false;
                Directory.CreateDirectory("LAUNCHER");
                File.Move("LOTUS.exe", "LAUNCHER/LOTUS-64.exe");
                File.Move("LOTUS_32.exe", "LAUNCHER/LOTUS-32.exe");
                Application.Exit();
            }
        }

        private string getTranslation(string key)
        {
            if (CultureInfo.CurrentCulture.Name.Equals("de-DE")) return Properties.Resources_German.ResourceManager.GetString(key);
            return Properties.Resources.ResourceManager.GetString(key);
        }
    }
}
