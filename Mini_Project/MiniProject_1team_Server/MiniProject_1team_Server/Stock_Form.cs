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
    public partial class Stock_Form : Form
    {
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";

        // 오라클 연결
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader rdr;
        int IdNum;
        public Stock_Form()
        {
            InitializeComponent();
        }
        public Stock_Form(int num)
        {
            InitializeComponent();
            IdNum = num;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            Inventory_Change_Form form = new Inventory_Change_Form(IdNum);
            form.ShowDialog();
            StockUpdate(); // -> 재고 내용 업데이트(수정)
        }

        private void Stock_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;

            //this.StartPosition = FormStartPosition.Manual;
            

            cmd.CommandText = $"SELECT * FROM Inventory where branch_id = {IdNum}"; // if문?
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int a1 = int.Parse(rdr["Toti"].ToString());
                textBox1.Text = $"{a1}";
                int a2 = int.Parse(rdr["Rice"].ToString());
                textBox2.Text = $"{a2}";
                int a3 = int.Parse(rdr["Veg"].ToString());
                textBox3.Text = $"{a3}";
                int a4 = int.Parse(rdr["Chi"].ToString());
                textBox4.Text = $"{a4}";
                int a5 = int.Parse(rdr["Cow"].ToString());
                textBox5.Text = $"{a5}";
                int a6 = int.Parse(rdr["Ten"].ToString());
                textBox6.Text = $"{a6}";
                int a7 = int.Parse(rdr["MildS"].ToString());
                textBox7.Text = $"{a7}";
                int a8 = int.Parse(rdr["NomS"].ToString());
                textBox8.Text = $"{a8}";
                int a9 = int.Parse(rdr["HotS"].ToString());
                textBox9.Text = $"{a9}";
                int a10 = int.Parse(rdr["PotPlus"].ToString()); // 감자추가
                textBox10.Text = $"{a10}";
                int a11 = int.Parse(rdr["Pot"].ToString()); // 감자튀김
                textBox11.Text = $"{a11}";
                int a12 = int.Parse(rdr["Cola"].ToString());
                textBox12.Text = $"{a12}";
                int a13 = int.Parse(rdr["Sausage"].ToString());
                textBox13.Text = $"{a13}";
                int a14 = int.Parse(rdr["Che"].ToString());
                textBox14.Text = $"{a14}";
            }
        }
        void StockUpdate() // -> 재고 내용 업데이트(수정, 주문)
        {
            // 오라클 연결
            cmd.CommandText = $"SELECT * from Inventory where Branch_Id = {IdNum}";

            // 결과 리더 객체 리턴
            OracleDataReader rdr1 = cmd.ExecuteReader();

            // 재고 현황
            while (rdr1.Read())
            {
                int a1 = int.Parse(rdr1["Toti"].ToString());
                int Toti = rdr1.GetInt32(2);
                textBox1.Text = $"{a1}";
                int a2 = int.Parse(rdr1["Rice"].ToString());
                int Rice = rdr1.GetInt32(1);
                textBox2.Text = $"{a2}";
                int a3 = int.Parse(rdr1["Veg"].ToString());
                int Veg = rdr1.GetInt32(3);
                textBox3.Text = $"{a3}";
                int a4 = int.Parse(rdr1["Chi"].ToString());
                int Chi = rdr1.GetInt32(4);
                textBox4.Text = $"{a4}";
                int a5 = int.Parse(rdr1["Cow"].ToString());
                int Cow = rdr1.GetInt32(5);
                textBox5.Text = $"{a5}";
                int a6 = int.Parse(rdr1["Ten"].ToString());
                int Ten = rdr1.GetInt32(6);
                textBox6.Text = $"{a6}";
                int a7 = int.Parse(rdr1["MildS"].ToString());
                int MildS = rdr1.GetInt32(9);
                textBox7.Text = $"{a7}";
                int a8 = int.Parse(rdr1["NomS"].ToString());
                int NomS = rdr1.GetInt32(8);
                textBox8.Text = $"{a8}";
                int a9 = int.Parse(rdr1["HotS"].ToString());
                int HotS = rdr1.GetInt32(7);
                textBox9.Text = $"{a9}";
                int a10 = int.Parse(rdr1["PotPlus"].ToString());
                int PotPlus = rdr1.GetInt32(10);
                textBox10.Text = $"{a10}";
                int a11 = int.Parse(rdr1["Pot"].ToString());
                int Pot = rdr1.GetInt32(11);
                textBox11.Text = $"{a11}";
                int a12 = int.Parse(rdr1["Cola"].ToString());
                int Cola = rdr1.GetInt32(14);
                textBox12.Text = $"{a12}";
                int a13 = int.Parse(rdr1["Sausage"].ToString());
                int Sausage = rdr1.GetInt32(13);
                textBox13.Text = $"{a13}";
                int a14 = int.Parse(rdr1["Che"].ToString());
                int Che = rdr1.GetInt32(12);
                textBox14.Text = $"{a14}";
            }
        }

        private void btn_Inventory_Order_Click(object sender, EventArgs e)
        {
            Inventory_Order_Form form1 = new Inventory_Order_Form(IdNum);
            form1.ShowDialog();
            StockUpdate(); // -> 재고 내용 업데이트(주문)
        }
    }
}
