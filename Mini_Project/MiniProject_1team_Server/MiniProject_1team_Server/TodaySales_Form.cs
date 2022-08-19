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
    public partial class TodaySales_Form : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader rdr;
        int IdNum;
        string start_date;
        string last_date;
        string query;

        public TodaySales_Form()
        {
            InitializeComponent();
        }
        public TodaySales_Form(int number)
        {
            InitializeComponent();
            IdNum = number;
        }

        private void TodaySales_Form_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            OracleDataAdapter adapt = new OracleDataAdapter();

            query = $"select * from price where sales_date = TO_CHAR(SYSDATE, 'YYYYMMDD') order by order_num";
            
            adapt.SelectCommand = new OracleCommand(query, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleDataAdapter adapt = new OracleDataAdapter();
            start_date = textBox1.Text;
            last_date = textBox2.Text;

            query = $"select *  from price where '{start_date}' <= sales_date and sales_date <= '{last_date}' order by sales_date, order_num";

            adapt.SelectCommand = new OracleCommand(query, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Visible = true;
        }
    }
}
