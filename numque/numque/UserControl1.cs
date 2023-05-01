using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numque
{
    public partial class UserControl1 : Form
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ctr1.Visible = false;
            Form1.ctr2.Visible = true;
            Form1.ctr3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ctr1.Visible = false;
            Form1.ctr2.Visible = false;
            Form1.ctr3.Visible = true;
        }

        private void LButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ja.wikipedia.org/wiki/Numer0n");
        }

        private void rule_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamReader file = 
                new System.IO.StreamReader(@"..\..\ルール説明 2.txt"))
            {
                while (!file.EndOfStream)
                {
                    RBox.Text += file.ReadLine();

                }
            }
        }
    }
}
