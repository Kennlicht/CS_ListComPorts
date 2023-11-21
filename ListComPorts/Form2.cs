using System;
using System.Windows.Forms;
using System.IO;
using ListComPorts.Properties;

namespace ListComPorts
{
   public partial class Form2 : Form
   {
      string pathToPuTTY;
      string pathToTeraTerm;

      public Form2()
      {
         InitializeComponent();
      }

      private void Form2_Load(object sender, EventArgs e)
      {
         Settings settings = new Settings();

         pathToPuTTY = settings.PuTTY;
         pathToTeraTerm = settings.TeraTerm;

         if (settings.UseTeraTerm)
         {
            radioButtonTeraTerm.Select();
            groupBox1.Text = "TeraTerm";
            pathTextBox.Text = pathToTeraTerm;
         }
         else
         {
            radioButtonPuTTY.Select();
            groupBox1.Text = "PuTTY";
            pathTextBox.Text = pathToPuTTY;
         }
         
         baudrateTextBox.Text = settings.Baudrate;
         databitsComboBox.Text = settings.Databits;
         stopbitsComboBox.Text = settings.Stopbits;

         if (settings.Parity == "n")
            parityComboBox.Text = "None";
         else if (settings.Parity == "o")
            parityComboBox.Text = "Odd";
         else if (settings.Parity == "e")
            parityComboBox.Text = "Even";
         else if (settings.Parity == "m")
            parityComboBox.Text = "Mark";
         else if (settings.Parity == "s")
            parityComboBox.Text = "Space";

         if (settings.Flowcontrol == "N")
            flowcontrolComboBox.Text = "None";
         else if (settings.Flowcontrol == "X")
            flowcontrolComboBox.Text = "XON/XOFF";
         else if (settings.Flowcontrol == "R")
            flowcontrolComboBox.Text = "RTS/CTS";
         else if (settings.Flowcontrol == "D")
            flowcontrolComboBox.Text = "DSR/DTR";
      }

      private void browseButton_Click(object sender, EventArgs e)
      {
         FileDialog fileDialog = new OpenFileDialog();
         fileDialog.CheckFileExists = true;
         fileDialog.CheckPathExists = true;
         fileDialog.DefaultExt = "exe";
         fileDialog.Filter = "Executable (*.exe)|*.exe";
         if (radioButtonTeraTerm.Checked)
            fileDialog.Title = "Select Path to ttermpro.exe";
         else
            fileDialog.Title = "Select Path to putty.exe";
         
         if (pathTextBox.Text.Length != 0)
         {
            fileDialog.InitialDirectory = Path.GetDirectoryName(pathTextBox.Text);
            fileDialog.FileName = Path.GetFileName(pathTextBox.Text);
         }
         else
         {
            fileDialog.InitialDirectory = @"C:\";
            fileDialog.FileName = null;
         }
         DialogResult fileResult = fileDialog.ShowDialog(this);
         if (fileResult == DialogResult.OK)
         {
            pathTextBox.Text = fileDialog.FileName;
            if (radioButtonTeraTerm.Checked)
               pathToTeraTerm = fileDialog.FileName;
            else
               pathToPuTTY = fileDialog.FileName;
         }
         fileDialog.Dispose();
      }

      private void okButton_Click(object sender, EventArgs e)
      {
         Settings settings = new Settings();

         settings.PuTTY = pathToPuTTY;
         settings.TeraTerm = pathToTeraTerm;
         settings.UseTeraTerm = radioButtonTeraTerm.Checked;
         settings.Baudrate = baudrateTextBox.Text;
         settings.Databits = databitsComboBox.Text;
         settings.Stopbits = stopbitsComboBox.Text;

         if (parityComboBox.Text == "None")
            settings.Parity = "n";
         else if (parityComboBox.Text == "Odd")
            settings.Parity = "o";
         else if (parityComboBox.Text == "Even")
            settings.Parity = "e";
         else if (parityComboBox.Text == "Mark")
            settings.Parity = "m";
         else if (parityComboBox.Text == "Space")
            settings.Parity = "s";

         if (flowcontrolComboBox.Text == "None")
            settings.Flowcontrol = "N";
         else if (flowcontrolComboBox.Text == "XON/XOFF")
            settings.Flowcontrol = "X";
         else if (flowcontrolComboBox.Text == "RTS/CTS")
            settings.Flowcontrol = "R";
         else if (flowcontrolComboBox.Text == "DSR/DTR")
            settings.Flowcontrol = "D";

         settings.Save();
      }

      private void radioButtonTeraTerm_CheckedChanged(object sender, EventArgs e)
      {
         Settings settings = new Settings();

         if (radioButtonTeraTerm.Checked)
         {
            groupBox1.Text = "TeraTerm";
            pathTextBox.Text = pathToTeraTerm;
            databitsComboBox.Enabled = false;
            stopbitsComboBox.Enabled = false;
            parityComboBox.Enabled = false;
            flowcontrolComboBox.Enabled = false;
         }
      }

      private void radioButtonPuTTY_CheckedChanged(object sender, EventArgs e)
      {
         Settings settings = new Settings();

         if (radioButtonPuTTY.Checked)
         {
            groupBox1.Text = "PuTTY";
            pathTextBox.Text = pathToPuTTY;
            databitsComboBox.Enabled = true;
            stopbitsComboBox.Enabled = true;
            parityComboBox.Enabled = true;
            flowcontrolComboBox.Enabled = true;
         }
      }


   }
}
