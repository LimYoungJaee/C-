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
using System.Windows.Forms.DataVisualization.Charting;

namespace MiniProject_1team_Server
{
    public partial class Statistics_Form : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader rdr;
        string query_date; // 날짜 쿼리
        string query_perc; // 판매액 쿼리
        string what; // 통계종류
        string query;
        int IdNum;
        public Statistics_Form()
        {
            InitializeComponent();
        }
        public Statistics_Form(int num)
        {
            InitializeComponent();
            IdNum = num;
        }

        private void Statistics_Date_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            string start_str = StartDate.Text;
            string last_str = LastDate.Text;
            int start = int.Parse(StartDate.Text);
            int last = int.Parse(LastDate.Text);
            int num = last - start + 1;


            double[] arr_per = new double[num];
            int i = 0;
            // 라디오버튼 체크종류에 따라 다른 쿼리
            if (rb_SalesPrice.Checked)
            {
                query_perc = $"select round((sales_ttotal / sum(sales_ttotal) over()) * 100,2) as perc from sales where '{start_str}' <= sales_date and sales_date <= '{last_str}' and branch_id = {IdNum} order by sales_date";
                what = "판매액";
            }
            if (rb_SalesNumber.Checked)
            {
                query_perc = $"select round(count(order_num) / (select count(order_num) from price where '{start_str}' <= sales_date and sales_date <= '{last_str}') * 100,2) as total_perc from price where '{start_str}' <= sales_date and sales_date <= '{last_str}' group by sales_date order by sales_date";
                what = "판매량";
            }
            cmd.CommandText = query_perc;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                arr_per[i] = rdr.GetDouble(0);
                i++;
            }
            // 차트 그리기
            DrowPieChart(chart1, what, arr_per);
        }

        private void DrowPieChart(Chart chart, string title, double[] arr_per)
        {
            int num = arr_per.Length;
            int i = 0;
            string start_str = StartDate.Text;  // 시작 날짜
            string last_str = LastDate.Text;    // 끝 날짜
            // 날짜쿼리
            query_date = $"select to_char(sales_date) as mday from sales where '{start_str}' <= sales_date and sales_date <= '{last_str}' and branch_id = {IdNum} order by sales_date";

            string[] arr_date = new string[num];

            cmd.CommandText = query_date;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                arr_date[i] = rdr["mday"] as string;
                i++;
            }

            chart.Series.Clear();
            chart.Legends.Clear();

            chart.Legends.Add("MyLegend");
            chart.Legends[0].LegendStyle = LegendStyle.Table;
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].Title = title;
            chart.Legends[0].BorderColor = Color.Black;

            string seriesname = "MySeriesName";
            chart.Series.Add(seriesname);
            chart.Series[seriesname].ChartType = SeriesChartType.Pie;

            for (int j = 0; j < arr_per.Length; j++)
            {
                chart.Series[seriesname].Points.AddXY(arr_date[j], arr_per[j]);
            }
        }

        private void Statistics_Form_Load(object sender, EventArgs e)
        {

            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=hr;Password=hr;";
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            chart1.Visible = false;
        }

        private void btn_Panel_Detail_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string start_str = textBox2.Text;  // 시작 날짜
            string last_str = textBox1.Text;    // 끝 날짜


            OracleDataAdapter adapt = new OracleDataAdapter();
            if (radioButton1.Checked)
            {
                query = $"select sales_date as 날짜, sales_ttotal as 가격, round((sales_ttotal / sum(sales_ttotal) over())*100,2) as 퍼센트 from sales where '{start_str}' <= sales_date and sales_date <= '{last_str}' and branch_id = {IdNum} order by sales_date";
            }
            if (radioButton2.Checked)
            {
                query = $"select sales_date, count(order_num) as 갯수, round(count(order_num) / (select count(order_num) as 퍼센트 from price where '{start_str}' <= sales_date and sales_date <= '{last_str}') * 100,2) as total_perc from price where '{start_str}' <= sales_date and sales_date <= '{last_str}' group by sales_date order by sales_date";
            }
            if (rb_SalesType.Checked)
            {
                query = $"select sales_date as 날짜, count(order_num) as 총판매, sum(chi) as 닭, round(sum(chi)/count(order_num) * 100,2) as 닭비율, sum(cow) as 소, round(sum(cow)/count(order_num) * 100,2) as 소비율, sum(ten) as 텐더, round(sum(ten)/count(order_num) * 100,2) as 텐더비율 from order_list where '{start_str}' <= sales_date and sales_date <= '{last_str}' and branch_id = {IdNum} group by sales_date order by sales_date";
            }
            adapt.SelectCommand = new OracleCommand(query, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void btn_Simple_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
