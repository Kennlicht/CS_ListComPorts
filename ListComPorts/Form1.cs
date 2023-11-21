using System;
using System.Windows.Forms;
using System.IO.Ports;
using ListComPorts.Properties;

namespace ListComPorts
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         RefreshPortList();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         RefreshPortList();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         Form2 configDialog = new Form2();
         if (configDialog.ShowDialog(this) == DialogResult.OK)
         {
            // Speichern
         }
         configDialog.Dispose();
      }

      private void button3_Click(object sender, EventArgs e)
      {
         ShowHelp();
      }

      private void Form1_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.F1)
            ShowHelp();
         if (e.KeyCode == Keys.F5)
            RefreshPortList();
      }

      private void ShowHelp()
      {
         Help.ShowHelp(this, "ListComPorts.chm");
      }

      private void RefreshPortList()
      {
         //show a list of valid com ports
         listBox1.Items.Clear();
         foreach (string s in SerialPort.GetPortNames())
         {
            listBox1.Items.Add(s);
         }
         listBox1.Select();
         listBox1.Focus();
      }

      private void listBox1_DoubleClick(object sender, EventArgs e)
      {
         if (listBox1.SelectedIndex >= 0)
         {
            CallTerminal();
         }
      }

      private void listBox1_KeyDown(object sender, KeyEventArgs e)
      {
         if ((e.KeyCode == Keys.Enter) && (listBox1.SelectedIndex >= 0))
         {
            CallTerminal();
         }
      }

      private void CallTerminal()
      {
         int selectedIndex = listBox1.SelectedIndex;
         Settings settings = new Settings();

         try
         {
            if (settings.UseTeraTerm)
            {
               System.Diagnostics.Process.Start(settings.TeraTerm,
                      "/C=" + listBox1.Items[selectedIndex].ToString()
                    + " /BAUD=" + settings.Baudrate);
            }
            else
            {
               System.Diagnostics.Process.Start(settings.PuTTY,
                      "-serial " + listBox1.Items[selectedIndex].ToString()
                    + " -sercfg " + settings.Baudrate
                    + "," + settings.Databits
                    + "," + settings.Parity
                    + "," + settings.Stopbits
                    + "," + settings.Flowcontrol);
            }
         }
         catch
         {
         }
      }


   }
}