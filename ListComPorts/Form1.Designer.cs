﻿namespace ListComPorts
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
           this.listBox1 = new System.Windows.Forms.ListBox();
           this.button1 = new System.Windows.Forms.Button();
           this.button2 = new System.Windows.Forms.Button();
           this.button3 = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // listBox1
           // 
           this.listBox1.FormattingEnabled = true;
           this.listBox1.Location = new System.Drawing.Point(12, 12);
           this.listBox1.Name = "listBox1";
           this.listBox1.Size = new System.Drawing.Size(75, 225);
           this.listBox1.TabIndex = 0;
           this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
           this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
           // 
           // button1
           // 
           this.button1.Location = new System.Drawing.Point(93, 12);
           this.button1.Name = "button1";
           this.button1.Size = new System.Drawing.Size(84, 29);
           this.button1.TabIndex = 1;
           this.button1.Text = "&Refresh";
           this.button1.UseVisualStyleBackColor = true;
           this.button1.Click += new System.EventHandler(this.button1_Click);
           // 
           // button2
           // 
           this.button2.Location = new System.Drawing.Point(93, 47);
           this.button2.Name = "button2";
           this.button2.Size = new System.Drawing.Size(84, 29);
           this.button2.TabIndex = 2;
           this.button2.Text = "&Config";
           this.button2.UseVisualStyleBackColor = true;
           this.button2.Click += new System.EventHandler(this.button2_Click);
           // 
           // button3
           // 
           this.button3.Location = new System.Drawing.Point(93, 208);
           this.button3.Name = "button3";
           this.button3.Size = new System.Drawing.Size(84, 29);
           this.button3.TabIndex = 3;
           this.button3.Text = "&Help";
           this.button3.UseVisualStyleBackColor = true;
           this.button3.Click += new System.EventHandler(this.button3_Click);
           // 
           // Form1
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(184, 253);
           this.Controls.Add(this.button1);
           this.Controls.Add(this.button2);
           this.Controls.Add(this.button3);
           this.Controls.Add(this.listBox1);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
           this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
           this.KeyPreview = true;
           this.MaximizeBox = false;
           this.MinimizeBox = false;
           this.Name = "Form1";
           this.Text = "Available COM Ports";
           this.Load += new System.EventHandler(this.Form1_Load);
           this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

