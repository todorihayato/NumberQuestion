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
    public partial class UserControl2 : Form
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1.ctr1.Visible = true;
            Form1.ctr2.Visible = false;
            Form1.ctr3.Visible = false;

            int reset = 0;
            Box01.Text = reset.ToString();
            Box02.Text = reset.ToString();
            Box03.Text = reset.ToString();
            e1Box.Text = reset.ToString();
            b1Box.Text = reset.ToString();

            Box01.Visible = true;
            Box02.Visible = true;
            Box03.Visible = true;

            er1Box.Visible = false;
            er2Box.Visible = false;
        }

        private void Rbuttom_Click(object sender, EventArgs e)
        {
            Random num = new Random();

            int[] data = new int[10];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }
            for (int i = data.Length - 1; i > 0; i--)
            {
                int j = num.Next(i);
                int tmp = data[i];
                data[i] = data[j];
                data[j] = tmp;
            }
            this.Box01.Text = data[0].ToString();
            this.Box02.Text = data[1].ToString();
            this.Box03.Text = data[2].ToString();

            Box01.Visible = false;
            Box02.Visible = false;
            Box03.Visible = false;
        }

        private void Ibutton_Click(object sender, EventArgs e)
        {
            string s1 = Box01.Text;
            string s2 = Box02.Text;
            string s3 = Box03.Text;
            string s4 = Box11.Text;
            string s5 = Box12.Text;
            string s6 = Box13.Text;
            int i1 = s1.Length;
            int i2 = s2.Length;
            int i3 = s3.Length;
            int i4 = s4.Length;
            int i5 = s5.Length;
            int i6 = s6.Length;

            bool a = false;
            bool b = false;
            bool c = false;
            bool d = false;

            if (i1 == 1 && i2 == 1 && i3 == 1)
            {
                a = true;
            }

            if (s1 != s2 && s1 != s3 && s2 != s3)
            {
                b = true;
            }

            if (i4 == 1 && i5 == 1 && i6 == 1)
            {
                c = true;
            }

            if (s4 != s5 && s4 != s6 && s5 != s6)
            {
                d = true;
            }

            if (a == true && b == true)
            {
                if (c == true && d == true)
                {
                    int eat = 0;
                    int bite = 0;

                    if (s4 == s1)
                    {
                        eat++;
                    }
                    else if (s4 == s2 || s4 == s3)
                    {
                        bite++;
                    }
                    if (s5 == s2)
                    {
                        eat++;
                    }
                    else if (s5 == s1 || s5 == s3)
                    {
                        bite++;
                    }
                    if (s6 == s3)
                    {
                        eat++;
                    }
                    else if (s6 == s1 || s6 == s2)
                    {
                        bite++;
                    }
                    this.e1Box.Text = eat.ToString();
                    this.b1Box.Text = bite.ToString();
                    if (eat == 3)
                    {
                        Box01.Visible = true;
                        Box02.Visible = true;
                        Box03.Visible = true;
                    }
                }
                else
                {
                    e1Box.Text = "error";
                    b1Box.Text = "error";
                }
            }

            if (s4 == s5 || s4 == s6 || s5 == s6)
            {
                er1Box.Visible = true;
            }
            else
            {
                er1Box.Visible = false;
            }

            if (i4 >= 2 || i5 >= 2 || i6 >= 2)
            {
                er2Box.Visible = true;
            }
            else
            {
                er2Box.Visible = false;
            }
            
        }

        private void r1button_Click(object sender, EventArgs e)
        {
            int reset = 0;
            //Box01.Text = "0";
            Box01.Text = reset.ToString();
            Box02.Text = reset.ToString();
            Box03.Text = reset.ToString();
            e1Box.Text = reset.ToString();
            b1Box.Text = reset.ToString();

            Box01.Visible = true;
            Box02.Visible = true;
            Box03.Visible = true;

            er1Box.Visible = false;
            er2Box.Visible = false;
        }
    }
}
