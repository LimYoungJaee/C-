using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_1team_Server
{
    public partial class Making_Form : Form
    {
        int seconds;
        public Making_Form()
        {
            InitializeComponent();
        }

        private void Making_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = seconds--.ToString();
            if (seconds < 0)
                timer1.Stop();
            if (progressBar1.Value == 8)
            {
                timer1.Enabled = false;
                MessageBox.Show("주문한 브리또 나왔습니다");
                this.Close();
            }
            else { progressBar1.Value += 1; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                timer1.Start();
                seconds = 8;

                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/또띠아.png");
                int i, j;
                i = 50;
                j = 231;
                pictureBox1.Location = new Point(i, j);
                pictureBox1.Visible = true;

                while (i < 159)
                {
                    i += 1;
                    Application.DoEvents();

                    Thread.Sleep(10);
                    pictureBox1.Location = new Point(i, j);
                }
            }

            {
                pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/고기.png");
                int i, j;
                i = 273;
                j = 33;
                pictureBox2.Location = new Point(i, j);
                pictureBox2.Visible = true;

                while (j < 146)
                {
                    j += 1;
                    Application.DoEvents();
                    Thread.Sleep(10);
                    pictureBox2.Location = new Point(i, j);
                }


            }

            {
                pictureBox1.Hide();
                pictureBox2.Hide();
                Application.DoEvents();
                pictureBox3.Image = Image.FromFile(System.Environment.CurrentDirectory + "/또띠아2.png");
                int i, j;
                i = 389;
                j = 230;
                pictureBox3.Location = new Point(i, j);
                pictureBox3.Visible = true;

                while (i < 510)
                {
                    i += 1;
                    Application.DoEvents();
                    Thread.Sleep(10);
                    pictureBox3.Location = new Point(i, j);
                }

            }


            {
                pictureBox5.Image = Image.FromFile(System.Environment.CurrentDirectory + "/소스.png");
                int i, j;
                i = 629;
                j = 33;
                pictureBox5.Location = new Point(i, j);
                pictureBox5.Visible = true;

                while (j < 146)
                {
                    j += 1;
                    Application.DoEvents();
                    Thread.Sleep(10);
                    pictureBox5.Location = new Point(i, j);
                }


            }


            {
                pictureBox3.Hide();
                pictureBox5.Hide();
                Application.DoEvents();
                pictureBox8.Image = Image.FromFile(System.Environment.CurrentDirectory + "/완성.png");
                int i, j;
                i = 740;
                j = 230;
                pictureBox8.Location = new Point(i, j);
                pictureBox8.Visible = true;

                while (i < 853)
                {
                    i += 1;
                    Application.DoEvents();
                    Thread.Sleep(10);
                    pictureBox8.Location = new Point(i, j);
                }
                timer1.Stop();
            }
        }
    
    }
}
