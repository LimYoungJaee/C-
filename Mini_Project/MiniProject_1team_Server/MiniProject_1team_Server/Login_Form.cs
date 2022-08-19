using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_1team_Server
{
    public partial class Login_Form : Form
    {
        string strConn = "Data Source=(DESCRIPTION=" +
               "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
               "(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)" +
               "(SERVICE_NAME=xe)));" +
               "User Id=hr;Password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader rdr;
        Socket clientSock;
        Thread serverThread;
        string Name;
        string Pw;
        int IdNum;
        string login_Name;
        string recvquery;
        string query;
        int a1, b1;
        public Login_Form()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            cmd.CommandText = "select * from branch";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Name = rdr["branch_name"] as string;
                Pw = rdr["branch_pw"] as string;
                if (textBox1.Text == Name && textBox2.Text == Pw)
                {
                    login_Name = textBox1.Text;
                    IdNum = rdr.GetInt32(0);
                    panel1.Visible = true;
                    label4.Text = $"{login_Name}지점";
                    recvquery = $"INSERT INTO Order_List VALUES (((select max(order_num) from order_list)+1), {IdNum}, TO_CHAR(SYSDATE, 'YYYYMMDD'), 1, 1, 1,";
                    // 주문을 받기위한 서버 소켓 오픈
                    serverThread = new Thread(serverFunc);
                    serverThread.Start();
                    serverThread.IsBackground = true;
                }
                
            }
            if(login_Name == null)
            {
                MessageBox.Show("지점 이름과 비밀번호를 확인해주세요.");
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
        }

        private void Sales_statistics_Click(object sender, EventArgs e)
        {
            Statistics_Form sf = new Statistics_Form(IdNum);
            sf.ShowDialog();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Stock_Form form = new Stock_Form(IdNum);
            form.ShowDialog();
        }
        void serverFunc(object obj)
        {

            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 10000);
                socket.Bind(endPoint);
                socket.Listen(10);

                clientSock = socket.Accept();

                Thread receivethread = new Thread(new ThreadStart(Recv));
                receivethread.Start();
                receivethread.IsBackground = true;
                //byte[] send = Encoding.UTF8.GetBytes("주문이 완료되었습니다.".Trim());
                //clientSock.Send(send);
            }
        }
        private void Recv()
        {
            while (true)
            {
                byte[] recvBytes = new byte[1024];
                clientSock.Receive(recvBytes); // 소켓에서 읽어온다.
                string txt = Encoding.UTF8.GetString(recvBytes, 0, recvBytes.Length);
                recvquery += txt;
                label5.Text += "주문이 들어왔습니다.\r\n";
                byte[] send = Encoding.UTF8.GetBytes("주문이 접수되었습니다.".Trim());
                clientSock.Send(send);
                // 쿼리문 실행
                cmd.CommandText = recvquery;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "commit";
                cmd.ExecuteNonQuery();
                recvquery = $"INSERT INTO Order_List VALUES (((select max(order_num) from order_list)+1), {IdNum}, TO_CHAR(SYSDATE, 'YYYYMMDD'), 1, 1, 1,";
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            Order_Information sf = new Order_Information(recvquery, IdNum);
            sf.ShowDialog();
            label5.Text = "";
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            TodaySales_Form sf = new TodaySales_Form(IdNum);
            sf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
