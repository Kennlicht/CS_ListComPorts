namespace ListComPorts
{
   partial class Form2
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
         this.okButton = new System.Windows.Forms.Button();
         this.cancelButton = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.browseButton = new System.Windows.Forms.Button();
         this.pathTextBox = new System.Windows.Forms.TextBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.flowcontrolComboBox = new System.Windows.Forms.ComboBox();
         this.parityComboBox = new System.Windows.Forms.ComboBox();
         this.stopbitsComboBox = new System.Windows.Forms.ComboBox();
         this.databitsComboBox = new System.Windows.Forms.ComboBox();
         this.baudrateTextBox = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.radioButtonPuTTY = new System.Windows.Forms.RadioButton();
         this.radioButtonTeraTerm = new System.Windows.Forms.RadioButton();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // okButton
         // 
         this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.okButton.Location = new System.Drawing.Point(50, 306);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(75, 23);
         this.okButton.TabIndex = 7;
         this.okButton.Text = "&OK";
         this.okButton.UseVisualStyleBackColor = true;
         this.okButton.Click += new System.EventHandler(this.okButton_Click);
         // 
         // cancelButton
         // 
         this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cancelButton.Location = new System.Drawing.Point(131, 306);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(75, 23);
         this.cancelButton.TabIndex = 8;
         this.cancelButton.Text = "&Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.browseButton);
         this.groupBox1.Controls.Add(this.pathTextBox);
         this.groupBox1.Location = new System.Drawing.Point(12, 51);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(230, 57);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "PuTTY";
         // 
         // browseButton
         // 
         this.browseButton.Location = new System.Drawing.Point(196, 22);
         this.browseButton.Name = "browseButton";
         this.browseButton.Size = new System.Drawing.Size(28, 20);
         this.browseButton.TabIndex = 1;
         this.browseButton.Text = "...";
         this.browseButton.UseVisualStyleBackColor = true;
         this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
         // 
         // pathTextBox
         // 
         this.pathTextBox.Location = new System.Drawing.Point(10, 22);
         this.pathTextBox.Name = "pathTextBox";
         this.pathTextBox.Size = new System.Drawing.Size(180, 20);
         this.pathTextBox.TabIndex = 0;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.flowcontrolComboBox);
         this.groupBox2.Controls.Add(this.parityComboBox);
         this.groupBox2.Controls.Add(this.stopbitsComboBox);
         this.groupBox2.Controls.Add(this.databitsComboBox);
         this.groupBox2.Controls.Add(this.baudrateTextBox);
         this.groupBox2.Controls.Add(this.label6);
         this.groupBox2.Controls.Add(this.label5);
         this.groupBox2.Controls.Add(this.label4);
         this.groupBox2.Controls.Add(this.label3);
         this.groupBox2.Controls.Add(this.label2);
         this.groupBox2.Location = new System.Drawing.Point(13, 114);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(229, 177);
         this.groupBox2.TabIndex = 3;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Configure the serial line";
         // 
         // flowcontrolComboBox
         // 
         this.flowcontrolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.flowcontrolComboBox.FormattingEnabled = true;
         this.flowcontrolComboBox.Items.AddRange(new object[] {
            "None",
            "XON/XOFF",
            "RTS/CTS",
            "DSR/DTR"});
         this.flowcontrolComboBox.Location = new System.Drawing.Point(123, 136);
         this.flowcontrolComboBox.Name = "flowcontrolComboBox";
         this.flowcontrolComboBox.Size = new System.Drawing.Size(100, 21);
         this.flowcontrolComboBox.TabIndex = 6;
         // 
         // parityComboBox
         // 
         this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.parityComboBox.FormattingEnabled = true;
         this.parityComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
         this.parityComboBox.Location = new System.Drawing.Point(123, 109);
         this.parityComboBox.Name = "parityComboBox";
         this.parityComboBox.Size = new System.Drawing.Size(100, 21);
         this.parityComboBox.TabIndex = 5;
         // 
         // stopbitsComboBox
         // 
         this.stopbitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.stopbitsComboBox.FormattingEnabled = true;
         this.stopbitsComboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
         this.stopbitsComboBox.Location = new System.Drawing.Point(123, 82);
         this.stopbitsComboBox.Name = "stopbitsComboBox";
         this.stopbitsComboBox.Size = new System.Drawing.Size(100, 21);
         this.stopbitsComboBox.TabIndex = 4;
         // 
         // databitsComboBox
         // 
         this.databitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.databitsComboBox.FormattingEnabled = true;
         this.databitsComboBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
         this.databitsComboBox.Location = new System.Drawing.Point(123, 55);
         this.databitsComboBox.Name = "databitsComboBox";
         this.databitsComboBox.Size = new System.Drawing.Size(100, 21);
         this.databitsComboBox.TabIndex = 3;
         // 
         // baudrateTextBox
         // 
         this.baudrateTextBox.Location = new System.Drawing.Point(123, 29);
         this.baudrateTextBox.Name = "baudrateTextBox";
         this.baudrateTextBox.Size = new System.Drawing.Size(100, 20);
         this.baudrateTextBox.TabIndex = 2;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(6, 144);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(64, 13);
         this.label6.TabIndex = 4;
         this.label6.Text = "Flow control";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(6, 117);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(33, 13);
         this.label5.TabIndex = 3;
         this.label5.Text = "Parity";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(6, 90);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(48, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "Stop bits";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 63);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(49, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Data bits";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 32);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Speed (baud)";
         // 
         // radioButtonPuTTY
         // 
         this.radioButtonPuTTY.AutoSize = true;
         this.radioButtonPuTTY.Location = new System.Drawing.Point(43, 18);
         this.radioButtonPuTTY.Name = "radioButtonPuTTY";
         this.radioButtonPuTTY.Size = new System.Drawing.Size(59, 17);
         this.radioButtonPuTTY.TabIndex = 9;
         this.radioButtonPuTTY.TabStop = true;
         this.radioButtonPuTTY.Text = "PuTTY";
         this.radioButtonPuTTY.UseVisualStyleBackColor = true;
         this.radioButtonPuTTY.CheckedChanged += new System.EventHandler(this.radioButtonPuTTY_CheckedChanged);
         // 
         // radioButtonTeraTerm
         // 
         this.radioButtonTeraTerm.AutoSize = true;
         this.radioButtonTeraTerm.Location = new System.Drawing.Point(142, 18);
         this.radioButtonTeraTerm.Name = "radioButtonTeraTerm";
         this.radioButtonTeraTerm.Size = new System.Drawing.Size(71, 17);
         this.radioButtonTeraTerm.TabIndex = 10;
         this.radioButtonTeraTerm.TabStop = true;
         this.radioButtonTeraTerm.Text = "TeraTerm";
         this.radioButtonTeraTerm.UseVisualStyleBackColor = true;
         this.radioButtonTeraTerm.CheckedChanged += new System.EventHandler(this.radioButtonTeraTerm_CheckedChanged);
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(256, 353);
         this.Controls.Add(this.radioButtonTeraTerm);
         this.Controls.Add(this.radioButtonPuTTY);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.cancelButton);
         this.Controls.Add(this.okButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form2";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Configuration";
         this.Load += new System.EventHandler(this.Form2_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button okButton;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button browseButton;
      private System.Windows.Forms.TextBox pathTextBox;
      private System.Windows.Forms.TextBox baudrateTextBox;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox databitsComboBox;
      private System.Windows.Forms.ComboBox flowcontrolComboBox;
      private System.Windows.Forms.ComboBox parityComboBox;
      private System.Windows.Forms.ComboBox stopbitsComboBox;
      private System.Windows.Forms.RadioButton radioButtonPuTTY;
      private System.Windows.Forms.RadioButton radioButtonTeraTerm;
   }
}