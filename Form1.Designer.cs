﻿namespace LOTUS_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bit64 = new System.Windows.Forms.Button();
            this.bit32 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bit64
            // 
            this.bit64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bit64.Location = new System.Drawing.Point(12, 143);
            this.bit64.Name = "bit64";
            this.bit64.Size = new System.Drawing.Size(434, 42);
            this.bit64.TabIndex = 0;
            this.bit64.Text = "Run x86 LOTUS";
            this.bit64.UseVisualStyleBackColor = true;
            this.bit64.Click += new System.EventHandler(this.bit64_Click);
            // 
            // bit32
            // 
            this.bit32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bit32.Location = new System.Drawing.Point(12, 95);
            this.bit32.Name = "bit32";
            this.bit32.Size = new System.Drawing.Size(434, 42);
            this.bit32.TabIndex = 1;
            this.bit32.Text = "Run x64 LOTUS";
            this.bit32.UseVisualStyleBackColor = true;
            this.bit32.Click += new System.EventHandler(this.bit32_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to run the x86 or x64 Version of LOTUS?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Setup Program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bit32);
            this.Controls.Add(this.bit64);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOTUS-Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bit64;
        private System.Windows.Forms.Button bit32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
