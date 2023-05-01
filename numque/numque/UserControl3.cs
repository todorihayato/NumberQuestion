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
    public partial class UserControl3 : Form
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form1.ctr1.Visible = true;
            Form1.ctr2.Visible = false;
            Form1.ctr3.Visible = false;
        }

        private void I1button_Click(object sender, EventArgs e)
        {
            string o1 = Boxb1.Text;
            string o2 = Boxb2.Text;
            string o3 = Boxb3.Text;
            string o4 = Boxa1.Text;
            string o5 = Boxa2.Text;
            string o6 = Boxa3.Text;
            int p1 = o1.Length;
            int p2 = o2.Length;
            int p3 = o3.Length;

            bool h = false;
            bool i = false;

            int eat = 0;
            int bite = 0;

            if (p1 == 1 && p2 == 1 && p3 == 1)
            {
                h = true;
            }

            if (o1 != o2 && o1 != o3 && o2 != o3)
            {
                i = true;
            }

            if (h == true && i == true)
            {
                if (o4 == o1)
                {
                    eat++;
                }
                else if (o4 == o2 || o4 == o3)
                {
                    bite++;
                }
                if (o5 == o2)
                {
                    eat++;
                }
                else if (o5 == o1 || o5 == o3)
                {
                    bite++;
                }
                if (o6 == o3)
                {
                    eat++;
                }
                else if (o6 == o1 || o6 == o2)
                {
                    bite++;
                }
                this.Box1e.Text = eat.ToString();
                this.Box1b.Text = bite.ToString();

                PlayerLavel.Text = "2Pの番です";
                I1button.Visible = false;
                I2button.Visible = true;

                if (eat == 3)
                {
                    Boxa1.Visible = true;
                    Boxa2.Visible = true;
                    Boxa3.Visible = true;
                }   
            }
            else
            {
                PlayerLavel.Text = "1Pの番です";
                I1button.Visible = true;
                I2button.Visible = false;
                Box1e.Text = "error";
                Box1b.Text = "error";
            }

            if (o1 == o2 || o1 == o3 || o2 == o3)
            {
                e1rBox.Visible = true;
            }
            else
            {
                e1rBox.Visible = false;
            }

            if (p1 >= 2 || p2 >= 2 || p3 >= 2)
            {
                e2rBox.Visible = true;
            }
            else
            {
                e2rBox.Visible = false;
            }
        }

        private void I2button_Click(object sender, EventArgs e)
        {
            string q1 = Boxb4.Text;
            string q2 = Boxb5.Text;
            string q3 = Boxb6.Text;
            string q4 = Boxa4.Text;
            string q5 = Boxa5.Text;
            string q6 = Boxa6.Text;
            int r1 = q1.Length;
            int r2 = q2.Length;
            int r3 = q3.Length;

            bool j = false;
            bool k = false;

            int eat = 0;
            int bite = 0;

            if (r1 == 1 && r2 == 1 && r3 == 1)
            {
                j = true;
            }

            if (q1 != q2 && q1 != q3 && q2 != q3)
            {
                k = true;
            }

            if (j == true && k == true)
            {
                if (q4 == q1)
                {
                    eat++;
                }
                else if (q4 == q2 || q4 == q3)
                {
                    bite++;
                }
                if (q5 == q2)
                {
                    eat++;
                }
                else if (q5 == q1 || q5 == q3)
                {
                    bite++;
                }
                if (q6 == q3)
                {
                    eat++;
                }
                else if (q6 == q1 || q6 == q2)
                {
                    bite++;
                }
                this.Box2e.Text = eat.ToString();
                this.Box2b.Text = bite.ToString();

                PlayerLavel.Text = "1Pの番です";
                I1button.Visible = true;
                I2button.Visible = false;

                if (eat == 3)
                {
                    Boxa4.Visible = true;
                    Boxa5.Visible = true;
                    Boxa6.Visible = true;
                }
            }
            else
            {
                PlayerLavel.Text = "2Pの番です";
                I1button.Visible = false;
                I2button.Visible = true;
                Box2e.Text = "error";
                Box2b.Text = "error";
            }

            if (q1 == q2 || q1 == q3 || q2 == q3)
            {
                e1rBox.Visible = true;
            }
            else
            {
                e1rBox.Visible = false;
            }

            if (r1 >= 2 || r2 >= 2 || r3 >= 2)
            {
                e2rBox.Visible = true;
            }
            else
            {
                e2rBox.Visible = false;
            }
        }

        private void hide1_Click(object sender, EventArgs e)
        {
            string o1 = Boxa1.Text;
            string o2 = Boxa2.Text;
            string o3 = Boxa3.Text;
            int p1 = o1.Length;
            int p2 = o2.Length;
            int p3 = o3.Length;
            bool h = false;
            bool i = false;

            if (o1 != o2 && o1 != o3 && o2 != o3)
            {
                h = true;
            }

            if (p1 == 1 && p2 == 1 && p3 == 1)
            {
                i = true;
            }
            
            if (h == false && i == false)
            {
                Boxa1.Visible = true;
                Boxa2.Visible = true;
                Boxa3.Visible = true;

                e1rBox.Visible = true;
                e2rBox.Visible = true;
            }
            else if(h == true && i == false)
            {
                Boxa1.Visible = true;
                Boxa2.Visible = true;
                Boxa3.Visible = true;

                e1rBox.Visible = false;
                e2rBox.Visible = true;
            }
            else if(h == false && i == true)
            {
                Boxa1.Visible = true;
                Boxa2.Visible = true;
                Boxa3.Visible = true;

                e1rBox.Visible = true;
                e2rBox.Visible = false;
            }
            else if(h == true && i == true)
            {
                Boxa1.Visible = false;
                Boxa2.Visible = false;
                Boxa3.Visible = false;

                e1rBox.Visible = false;
                e2rBox.Visible = false;
            }
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            string q1 = Boxa4.Text;
            string q2 = Boxa5.Text;
            string q3 = Boxa6.Text;
            int r1 = q1.Length;
            int r2 = q2.Length;
            int r3 = q3.Length;
            bool j = false;
            bool k = false;

            if (q1 != q2 && q1 != q3 && q2 != q3)
            {
                j = true;
            }

            if (r1 == 1 && r2 == 1 && r3 == 1)
            {
                k = true;
            }

            if (j == false && k == false)
            {
                Boxa4.Visible = true;
                Boxa5.Visible = true;
                Boxa6.Visible = true;

                e1rBox.Visible = true;
                e2rBox.Visible = true;
            }
            else if (j == true && k == false)
            {
                Boxa4.Visible = true;
                Boxa5.Visible = true;
                Boxa6.Visible = true;

                e1rBox.Visible = false;
                e2rBox.Visible = true;
            }
            else if (j == false && k == true)
            {
                Boxa4.Visible = true;
                Boxa5.Visible = true;
                Boxa6.Visible = true;

                e1rBox.Visible = true;
                e2rBox.Visible = false;
            }
            else if (j == true && k == true)
            {
                Boxa4.Visible = false;
                Boxa5.Visible = false;
                Boxa6.Visible = false;

                e1rBox.Visible = false;
                e2rBox.Visible = false;
            }
        }

        private void r2button_Click(object sender, EventArgs e)
        {
            int reset = 0;
            Boxa1.Text = reset.ToString();
            Boxa2.Text = reset.ToString();
            Boxa3.Text = reset.ToString();
            Boxa4.Text = reset.ToString();
            Boxa5.Text = reset.ToString();
            Boxa6.Text = reset.ToString();
            Boxb1.Text = reset.ToString();
            Boxb2.Text = reset.ToString();
            Boxb3.Text = reset.ToString();
            Boxb4.Text = reset.ToString();
            Boxb5.Text = reset.ToString();
            Boxb6.Text = reset.ToString();
            Box1e.Text = reset.ToString();
            Box1b.Text = reset.ToString();
            Box2e.Text = reset.ToString();
            Box2b.Text = reset.ToString();

            Boxa1.Visible = true;
            Boxa2.Visible = true;
            Boxa3.Visible = true;
            Boxa4.Visible = true;
            Boxa5.Visible = true;
            Boxa6.Visible = true;

            I1button.Visible = true;
            I2button.Visible = false;

            e1rBox.Visible = false;
            e2rBox.Visible = false;
        }
    }
}
