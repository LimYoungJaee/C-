using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_1team_client
{
    public partial class Menu_Form : Form
    {
        Socket socket;
        Thread recvThread;
        string message4 = "";
        string[] arr = new string[11];
        void Recv()
        {
            while (true)
            {
                byte[] recvBytes = new byte[1024];
                socket.Receive(recvBytes);

                string txt = Encoding.UTF8.GetString(recvBytes);
                MessageBox.Show(txt);
            }
        }
        public Menu_Form()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void btn_Order_Send_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "0, ";
            }
            // 닭 주문
            if (comboBox1.SelectedIndex == 0)
            {
                arr[0] = "1, ";
            }
            //소 주문
            if (comboBox1.SelectedIndex == 1)
            {
                arr[1] = "1, ";
            }
            // 텐더 주문
            if (comboBox1.SelectedIndex == 2)
            {
                arr[2] = "1, ";
            }
            //순한소스
            if (comboBox2.SelectedIndex == 2)
            {
                arr[5] = "1, ";
            }
            //중간소스
            if (comboBox2.SelectedIndex == 1)
            {
                arr[4] = "1, ";
            }
            //매운소스
            if (comboBox2.SelectedIndex == 0)
            {
                arr[3] = "1, ";
            }
            //감자추가
            if (checkBox1.Checked == true)
            {
                arr[6] = "1, ";
            }
            //감자튀김
            if (checkBox2.Checked == true)
            {
                arr[7] = "1, ";
            }
            //치즈추가
            if (checkBox3.Checked == true)
            {
                arr[8] = "1, ";
            }
            //소세지추가
            if (checkBox4.Checked == true)
            {
                arr[9] = "1, ";
            }
            //콜라추가
            if (checkBox5.Checked == true)
            {
                arr[10] = "1)";
            }
            else if(checkBox5.Checked == false)
            {
                arr[10] = "0)";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                message4 += arr[i];
            }

            //// 1. 소켓만들기
            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //// 2. 연결
            //IPEndPoint serverEp = new IPEndPoint(IPAddress.Loopback, 10000); // 내컴퓨터에서 할 때
            //socket.Connect(serverEp);

            //recvThread = new Thread(new ThreadStart(Recv));
            //recvThread.IsBackground = true;
            //recvThread.Start();

            byte[] buffer4 = Encoding.UTF8.GetBytes((message4).Trim());
            socket.Send(buffer4);
            message4 = "";
        }

        private void btn_Order_Back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("닭");
            comboBox1.Items.Add("소");
            comboBox1.Items.Add("텐더");

            comboBox2.Items.Add("매운소스");
            comboBox2.Items.Add("중간소스");
            comboBox2.Items.Add("순한소스");

            // 1. 소켓만들기
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 2. 연결
            IPEndPoint serverEp = new IPEndPoint(IPAddress.Loopback, 10000); // 내컴퓨터에서 할 때
            socket.Connect(serverEp);

            recvThread = new Thread(new ThreadStart(Recv));
            recvThread.IsBackground = true;
            recvThread.Start();
        }
    }
}
