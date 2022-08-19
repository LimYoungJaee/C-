namespace MiniProject_1team_Server
{
    partial class Statistics_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Detail = new System.Windows.Forms.Button();
            this.rb_SalesPrice = new System.Windows.Forms.RadioButton();
            this.rb_SalesNumber = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastDate = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.Statistics_Date = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Simple = new System.Windows.Forms.Button();
            this.btn_Panel_Detail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rb_SalesType = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Detail
            // 
            this.Detail.Location = new System.Drawing.Point(485, 371);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(277, 44);
            this.Detail.TabIndex = 16;
            this.Detail.Text = "자세한 통계보기";
            this.Detail.UseVisualStyleBackColor = true;
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // rb_SalesPrice
            // 
            this.rb_SalesPrice.AutoSize = true;
            this.rb_SalesPrice.Checked = true;
            this.rb_SalesPrice.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_SalesPrice.Location = new System.Drawing.Point(485, 47);
            this.rb_SalesPrice.Name = "rb_SalesPrice";
            this.rb_SalesPrice.Size = new System.Drawing.Size(121, 33);
            this.rb_SalesPrice.TabIndex = 14;
            this.rb_SalesPrice.TabStop = true;
            this.rb_SalesPrice.Text = "판매액";
            this.rb_SalesPrice.UseVisualStyleBackColor = true;
            // 
            // rb_SalesNumber
            // 
            this.rb_SalesNumber.AutoSize = true;
            this.rb_SalesNumber.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_SalesNumber.Location = new System.Drawing.Point(485, 116);
            this.rb_SalesNumber.Name = "rb_SalesNumber";
            this.rb_SalesNumber.Size = new System.Drawing.Size(162, 33);
            this.rb_SalesNumber.TabIndex = 15;
            this.rb_SalesNumber.Text = "판매 수량";
            this.rb_SalesNumber.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(490, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "마지막 날";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(490, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "시작 날";
            // 
            // LastDate
            // 
            this.LastDate.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LastDate.Location = new System.Drawing.Point(618, 262);
            this.LastDate.Name = "LastDate";
            this.LastDate.Size = new System.Drawing.Size(144, 32);
            this.LastDate.TabIndex = 11;
            this.LastDate.Text = "20220831";
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartDate.Location = new System.Drawing.Point(618, 205);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(144, 32);
            this.StartDate.TabIndex = 10;
            this.StartDate.Text = "20220801";
            // 
            // Statistics_Date
            // 
            this.Statistics_Date.Location = new System.Drawing.Point(485, 320);
            this.Statistics_Date.Name = "Statistics_Date";
            this.Statistics_Date.Size = new System.Drawing.Size(277, 44);
            this.Statistics_Date.TabIndex = 9;
            this.Statistics_Date.Text = "날짜별 통계보기";
            this.Statistics_Date.UseVisualStyleBackColor = true;
            this.Statistics_Date.Click += new System.EventHandler(this.Statistics_Date_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(444, 403);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_Simple);
            this.panel1.Controls.Add(this.btn_Panel_Detail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.rb_SalesType);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 451);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(455, 403);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.Visible = false;
            // 
            // btn_Simple
            // 
            this.btn_Simple.Location = new System.Drawing.Point(494, 388);
            this.btn_Simple.Name = "btn_Simple";
            this.btn_Simple.Size = new System.Drawing.Size(277, 44);
            this.btn_Simple.TabIndex = 25;
            this.btn_Simple.Text = "간략히 보기";
            this.btn_Simple.UseVisualStyleBackColor = true;
            this.btn_Simple.Click += new System.EventHandler(this.btn_Simple_Click);
            // 
            // btn_Panel_Detail
            // 
            this.btn_Panel_Detail.Location = new System.Drawing.Point(494, 338);
            this.btn_Panel_Detail.Name = "btn_Panel_Detail";
            this.btn_Panel_Detail.Size = new System.Drawing.Size(277, 44);
            this.btn_Panel_Detail.TabIndex = 24;
            this.btn_Panel_Detail.Text = "날짜별 통계보기";
            this.btn_Panel_Detail.UseVisualStyleBackColor = true;
            this.btn_Panel_Detail.Click += new System.EventHandler(this.btn_Panel_Detail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(501, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "마지막 날";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(501, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "시작 날";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(629, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 32);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "20220816";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(629, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 32);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "20220812";
            // 
            // rb_SalesType
            // 
            this.rb_SalesType.AutoSize = true;
            this.rb_SalesType.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_SalesType.Location = new System.Drawing.Point(494, 167);
            this.rb_SalesType.Name = "rb_SalesType";
            this.rb_SalesType.Size = new System.Drawing.Size(162, 33);
            this.rb_SalesType.TabIndex = 19;
            this.rb_SalesType.TabStop = true;
            this.rb_SalesType.Text = "고기 종류";
            this.rb_SalesType.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(494, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 33);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "판매액";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(494, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(162, 33);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "판매 수량";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Statistics_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.rb_SalesPrice);
            this.Controls.Add(this.rb_SalesNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Statistics_Date);
            this.Location = new System.Drawing.Point(200, 250);
            this.Name = "Statistics_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Statistics_Form";
            this.Load += new System.EventHandler(this.Statistics_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Detail;
        private System.Windows.Forms.RadioButton rb_SalesPrice;
        private System.Windows.Forms.RadioButton rb_SalesNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastDate;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.Button Statistics_Date;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Simple;
        private System.Windows.Forms.Button btn_Panel_Detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rb_SalesType;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}