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
    public partial class Form1 : Form
    {
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;
        public static UserControl3 ctr3;

        public Form1()
        {

            InitializeComponent();
            ctr1 = new UserControl1();
            ctr2 = new UserControl2();
            ctr3 = new UserControl3();
            ctr1.TopLevel = false;
            ctr2.TopLevel = false;
            ctr3.TopLevel = false;

            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            panel1.Controls.Add(ctr3);

            ctr1.Visible = true;
            ctr2.Visible = false;
            ctr3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
