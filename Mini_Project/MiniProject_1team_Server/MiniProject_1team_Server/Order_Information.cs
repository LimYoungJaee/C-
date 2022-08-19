using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_1team_Server
{
    public partial class Order_Information : Form
    {
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";

        // 오라클 연결
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader rdr;
        String lastQuery;
        int IdNum;
        int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14;

        private void button2_Click(object sender, EventArgs e)
        {

            // order_list 테이블 삭제
            cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
            cmd.ExecuteReader();
            MessageBox.Show("주문이 취소되었습니다.");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO Price VALUES ((select max(order_num) from price) + 1, (select distinct order_list.sales_date from order_list,price where order_list.order_num = (select max(order_num) from price)+1) , (select(rice * 1000 + toti * 500 + veg * 500 + chi * 1000 + cow * 00 + ten * 1500 + potplus * 500 + pot * 1500 + che * 500 + sausage * 1000 + cola * 1000) from order_list  where order_num = (select max(order_num) from price)+1))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = ($"UPDATE Inventory set Toti = Toti - {a1},Rice = Rice - {a2}, Veg = Veg - {a3}, Chi = Chi - {a4}, Cow = Cow - {a5}, Ten = Ten - {a6}, MildS = MildS - {a7}, NomS = NomS - {a8}, HotS = HotS - {a9}, PotPlus = PotPlus - {a10}, Pot = Pot - {a11}, Cola = Cola - {a12}, Sausage = Sausage - {a13}, Che = Che - {a14} where Branch_Id = {IdNum}");
            cmd.ExecuteNonQuery();
            Making_Form sf = new Making_Form();
            sf.ShowDialog();
            this.Close();
        }

        int b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14;
        public Order_Information()
        {
            InitializeComponent();
        }
        public Order_Information(string query, int number)
        {
            InitializeComponent();
            lastQuery = query;
            IdNum = number;
        }

        private void Order_Information_Load(object sender, EventArgs e)
        {
            
            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;



            //this.StartPosition = FormStartPosition.Manual;
            
            cmd.CommandText = $"SELECT * FROM Order_List where Order_Num = (select max(Order_Num)+1 from price)"; // if문?
            rdr = cmd.ExecuteReader();

            

            while (rdr.Read())
            {
                a1 = int.Parse(rdr["Toti"].ToString());
                textBox1.Text = $"{a1}";
                a2 = int.Parse(rdr["Rice"].ToString());
                textBox2.Text = $"{a2}";
                a3 = int.Parse(rdr["Veg"].ToString());
                textBox3.Text = $"{a3}";
                a4 = int.Parse(rdr["Chi"].ToString());
                textBox4.Text = $"{a4}";
                a5 = int.Parse(rdr["Cow"].ToString());
                textBox5.Text = $"{a5}";
                a6 = int.Parse(rdr["Ten"].ToString());
                textBox6.Text = $"{a6}";
                a7 = int.Parse(rdr["MildS"].ToString());
                textBox7.Text = $"{a7}";
                a8 = int.Parse(rdr["NomS"].ToString());
                textBox8.Text = $"{a8}";
                a9 = int.Parse(rdr["HotS"].ToString());
                textBox9.Text = $"{a9}";
                a10 = int.Parse(rdr["PotPlus"].ToString()); // 감자추가
                textBox10.Text = $"{a10}";
                a11 = int.Parse(rdr["Pot"].ToString()); // 감자튀김
                textBox11.Text = $"{a11}";
                a12 = int.Parse(rdr["Cola"].ToString());
                textBox12.Text = $"{a12}";
                a13 = int.Parse(rdr["Sausage"].ToString());
                textBox13.Text = $"{a13}";
                a14 = int.Parse(rdr["Che"].ToString());
                textBox14.Text = $"{a14}";
                
            }

            cmd.CommandText = $"SELECT * FROM INVENTORY WHERE BRANCH_ID = {IdNum}"; // if문?
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                b1 = int.Parse(rdr["Toti"].ToString());
                b2 = int.Parse(rdr["Rice"].ToString());
                b3 = int.Parse(rdr["Veg"].ToString());
                b4 = int.Parse(rdr["Chi"].ToString());
                b5 = int.Parse(rdr["Cow"].ToString());
                b6 = int.Parse(rdr["Ten"].ToString());
                b7 = int.Parse(rdr["MildS"].ToString());
                b8 = int.Parse(rdr["NomS"].ToString());
                b9 = int.Parse(rdr["HotS"].ToString());
                b10 = int.Parse(rdr["PotPlus"].ToString());
                b11 = int.Parse(rdr["Pot"].ToString());
                b12 = int.Parse(rdr["Cola"].ToString());
                b13 = int.Parse(rdr["Sausage"].ToString());
                b14 = int.Parse(rdr["Che"].ToString());
            }

            if(a1 > b1)
            {
                MessageBox.Show("또띠아가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a2 > b2)
            {
                MessageBox.Show("밥이 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a3 > b3)
            {
                MessageBox.Show("야채가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a4 > b4)
            {
                MessageBox.Show("닭이 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a5 > b5)
            {
                MessageBox.Show("소가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a6 > b6)
            {
                MessageBox.Show("텐더가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a7 > b7)
            {
                MessageBox.Show("순한맛 소스가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if(a8 > b8)
            {
                MessageBox.Show("보통맛 소스가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a9 > b9)
            {
                MessageBox.Show("매운맛 소스가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a10 > b10)
            {
                MessageBox.Show("감자추가가 부족합니다."); 
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a11 > b11)
            {
                MessageBox.Show("감자튀김이 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a12 > b12)
            {
                MessageBox.Show("콜라가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a13 > b13)
            {
                MessageBox.Show("소세지가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }
            if (a14 > b14)
            {
                MessageBox.Show("치즈가 부족합니다.");
                cmd.CommandText = $"delete from order_list where order_num = (select max(order_num) from order_list) and branch_id = {IdNum}";
                cmd.ExecuteReader();
                this.Close();
            }

            cmd.CommandText = $"select (rice * 1000 + toti * 500 + veg * 500 + chi * 1000 + cow * 1500 +  ten * 1500 + potplus * 500 + pot * 1500 + che * 500 + sausage * 1000 + cola * 1000) as price from order_list  where order_num = (select max(order_num) from price)+1";
            OracleDataReader rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                int a15 = int.Parse(rdr1["price"].ToString());
                textBox15.Text = $"{a15}";
            }
            conn.Close();

            LoadChart();

        }
        void LoadChart()
        {
            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;

            int Toti_Order = 0;
            int Rice_Order = 0;
            int Veg_Order = 0;
            int Chi_Order = 0;
            int Cow_Order = 0;
            int Ten_Order = 0;
            int MildS_Order = 0;
            int NomS_Order = 0;
            int HotS_Order = 0;
            int PotPlus_Order = 0;
            int Pot_Order = 0;
            int Sausage_Order = 0;
            int Che_Order = 0;
            int Cola_Order = 0;

            cmd.CommandText = $"SELECT * FROM Order_List where Order_Num = (select max(Order_Num) from Order_List)"; // if문?
            OracleDataReader rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                // 주문 내역
                // 또띠아
                Rice_Order = rdr1.GetInt32(3);
                Toti_Order = rdr1.GetInt32(4);
                Veg_Order = rdr1.GetInt32(5);
                Chi_Order = rdr1.GetInt32(6);
                Cow_Order = rdr1.GetInt32(7);
                Ten_Order = rdr1.GetInt32(8);
                MildS_Order = rdr1.GetInt32(11);
                NomS_Order = rdr1.GetInt32(10);
                HotS_Order = rdr1.GetInt32(9);
                PotPlus_Order = rdr1.GetInt32(12);
                Pot_Order = rdr1.GetInt32(13);
                Che_Order = rdr1.GetInt32(14);
                Sausage_Order = rdr1.GetInt32(15);
                Cola_Order = rdr1.GetInt32(16);
            }

            // 데이터
            string[] x1 = { "또띠아", "밥", "야채", "닭", "소", "텐더", "순한맛", "보통맛", "매운맛",
                            "감자추가", "감자튀김", "소세지", "치즈", "콜라"};
            int[] x2 = { Toti_Order, Rice_Order, Veg_Order, Chi_Order, Cow_Order, Ten_Order,
                         MildS_Order, NomS_Order, HotS_Order, PotPlus_Order, Pot_Order, Sausage_Order,
                         Che_Order, Cola_Order};


            // 리스트 뷰
            listView1.View = View.Details;
            listView1.Columns.Add("종류", 105, HorizontalAlignment.Center);
            listView1.Columns.Add("수량", 110, HorizontalAlignment.Center);

            ListViewItem list1;

            // 합계 변수
            int sum = 0;

            for (int i = 0; i <= x2.Length - 1; i++)
            {
                if (x2[i] != 0)
                {
                    sum += x2[i];
                }
            }

            list1 = new ListViewItem("합계");
            list1.SubItems.Add($"{sum}");
            listView1.Items.Add(list1);

            for (int i = 0; i <= x2.Length - 1; i++)
            {
                if (x2[i] != 0)
                {
                    list1 = new ListViewItem($"{x1[i]}");
                    list1.SubItems.Add($"{x2[i]}");
                    listView1.Items.Add(list1);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
