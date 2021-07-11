﻿using System;
using System.Diagnostics;
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
            if (MessageBox.Show("Achtung:\nDie x86 Version von LOTUS ist nur für x86 Computer oder für das nutzen für Joysticks/Gamepads gedacht,\nda es zu gigantischen Performance-Verlusten führen kann.\n\nWillst du fortfahren?", 
                "LOTUS-Simulator", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes) open("32");
        }

        private void open(string type)
        {
            if (!Directory.Exists("LAUNCHER")) return;
            File.Delete("LOTUS.exe");
            File.Copy("LAUNCHER/LOTUS-" + type + ".exe", "LOTUS.exe");
            Process.Start("steam://rungameid/370350");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("LAUNCHER")) button1.Enabled = false;
            Directory.CreateDirectory("LAUNCHER");
            File.Move("LOTUS.exe", "LAUNCHER/LOTUS-64.exe");
            File.Move("LOTUS_32.exe", "LAUNCHER/LOTUS-32.exe");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("LAUNCHER")) button1.Enabled = false;
            if (!Directory.Exists("LAUNCHER")) bit32.Enabled = false;
            if (!Directory.Exists("LAUNCHER")) bit64.Enabled = false;
        }
    }
}