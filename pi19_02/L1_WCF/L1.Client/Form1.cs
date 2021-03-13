using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
      public bool Connected { get; }
      public Form1()
      {
         InitializeComponent();
         timer1.Interval = 1000;
         timer1.Enabled = true;
         timer1.Start();
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         if (Connected != false)
         {
            this.BackColor = Color.Red;
         }
         else this.BackColor = Color.Green;
      }

      static void GetConnected()
      {
         Console.WriteLine("Connected value is {0}", t.Connected);
      }

   }
}
