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
    public partial class Inventory_Change_Form : Form
    {
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";

        // 오라클 연결
        OracleConnection conn;
        OracleCommand cmd;
        int IdNum;
        public Inventory_Change_Form()
        {
            InitializeComponent();
        }
        public Inventory_Change_Form(int number)
        {
            InitializeComponent();
            IdNum = number;
        }

        private void btn_Commit_Click(object sender, EventArgs e)
        {
            // Toti, Rice, Veg, Chi, Cow, Ten, MildS, NomS, HotS
            // PotPlus, Pot, Sausage, Che, Cola
            string Toti = textBasic.Text;
            string Rice = textBasic.Text;
            string Veg = textBasic.Text;
            string Chi = textMain.Text;
            string Cow = textMain.Text;
            string Ten = textMain.Text;
            string MildS = textSauce.Text;
            string NomS = textSauce.Text;
            string HotS = textSauce.Text;
            string PotPlus = textAny.Text;
            string Pot = textAny.Text;
            string Sausage = textAny.Text;
            string Che = textAny.Text;
            string Cola = textAny.Text;

            // Basic -> 또띠아, 밥, 야채
            if (Cb_Basic.SelectedIndex == 0) // 또띠아
            {
                if (textBasic.Text != "") // 값이 입력될 때
                {
                    cmd.CommandText = ($"UPDATE Inventory set Toti = {Toti} where Branch_Id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Basic.SelectedIndex == 1) // 밥
            {
                if (textBasic.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set Rice = {Rice} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Basic.SelectedIndex == 2) // 야채
            {
                if (textBasic.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set Veg = {Veg} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }

            // Main -> 닭, 소, 텐더
            if (Cb_Main.SelectedIndex == 0) // 닭
            {
                if (textMain.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set Chi = {Chi} where Branch_Id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Main.SelectedIndex == 1) // 소
            {
                if (textMain.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set Cow = {Cow} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Main.SelectedIndex == 2) // 텐더
            {
                if (textMain.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set Ten = {Ten} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }

            // Sauce -> 순한맛, 보통맛, 매운맛
            if (Cb_Sauce.SelectedIndex == 0) // 순한맛
            {
                if (textSauce.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set MildS = {MildS} where Branch_Id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Sauce.SelectedIndex == 1) // 보통맛
            {
                if (textSauce.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set NomS = {NomS} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Sauce.SelectedIndex == 2) // 매운맛
            {
                if (textSauce.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set HotS = {HotS} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }

            // Any -> 감자튀김, 감자추가, 소세지, 치즈, 콜라
            if (Cb_Any.SelectedIndex == 0) // 감자튀김
            {
                if (textAny.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set PotPlus = {PotPlus} where Branch_Id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Any.SelectedIndex == 1) // 감자추가
            {
                if (textAny.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set Pot = {Pot} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Any.SelectedIndex == 2) // 소세지
            {
                if (textAny.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set  Sausage = {Sausage} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Any.SelectedIndex == 3) // 치즈
            {
                if (textAny.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set Che = {Che} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }
            if (Cb_Any.SelectedIndex == 4) // 콜라
            {
                if (textAny.Text != "")
                {
                    cmd.CommandText = ($"UPDATE Inventory set Cola = {Cola} where branch_id = {IdNum}");
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("재고가 수정되었습니다.");
            Jaego_Clear();
            this.Close();
        }

        private void bnt_Rollback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventory_Change_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;

            //this.StartPosition = FormStartPosition.Manual;
            

            // 콤보박스 목록
            Cb_Basic.Items.Add("또띠아");
            Cb_Basic.Items.Add("밥");
            Cb_Basic.Items.Add("야채");

            Cb_Main.Items.Add("닭");
            Cb_Main.Items.Add("소");
            Cb_Main.Items.Add("텐더");

            Cb_Sauce.Items.Add("순한맛");
            Cb_Sauce.Items.Add("보통맛");
            Cb_Sauce.Items.Add("매운맛");

            Cb_Any.Items.Add("감자추가");
            Cb_Any.Items.Add("감자튀김");
            Cb_Any.Items.Add("소세지");
            Cb_Any.Items.Add("치즈");
            Cb_Any.Items.Add("콜라");
        }
        public void Jaego_Clear()
        {
            Cb_Basic.SelectedIndex = -1;
            Cb_Main.SelectedIndex = -1;
            Cb_Sauce.SelectedIndex = -1;
            Cb_Any.SelectedIndex = -1;

            textBasic.Text = ""; // 결과를 담을 textBox를 비운다.
            textMain.Text = "";
            textSauce.Text = "";
            textAny.Text = "";
        }
    }
}
