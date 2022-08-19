namespace MiniProject_1team_Server
{
    partial class Inventory_Order_Form
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
            this.btn_RollBack = new System.Windows.Forms.Button();
            this.btn_Commit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textAny = new System.Windows.Forms.TextBox();
            this.Cb_Any = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textSauce = new System.Windows.Forms.TextBox();
            this.Cb_Sauce = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textMain = new System.Windows.Forms.TextBox();
            this.Cb_Main = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBasic = new System.Windows.Forms.TextBox();
            this.Cb_Basic = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_RollBack
            // 
            this.btn_RollBack.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_RollBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_RollBack.Location = new System.Drawing.Point(481, 240);
            this.btn_RollBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RollBack.Name = "btn_RollBack";
            this.btn_RollBack.Size = new System.Drawing.Size(134, 59);
            this.btn_RollBack.TabIndex = 7;
            this.btn_RollBack.Text = "취소";
            this.btn_RollBack.UseVisualStyleBackColor = true;
            this.btn_RollBack.Click += new System.EventHandler(this.btn_RollBack_Click);
            // 
            // btn_Commit
            // 
            this.btn_Commit.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Commit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Commit.Location = new System.Drawing.Point(481, 152);
            this.btn_Commit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Commit.Name = "btn_Commit";
            this.btn_Commit.Size = new System.Drawing.Size(134, 59);
            this.btn_Commit.TabIndex = 6;
            this.btn_Commit.Text = "주문";
            this.btn_Commit.UseVisualStyleBackColor = true;
            this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(449, 406);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "재고 주문";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textAny);
            this.groupBox5.Controls.Add(this.Cb_Any);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(232, 215);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(189, 160);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "기타";
            // 
            // textAny
            // 
            this.textAny.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textAny.Location = new System.Drawing.Point(69, 106);
            this.textAny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAny.Name = "textAny";
            this.textAny.Size = new System.Drawing.Size(106, 25);
            this.textAny.TabIndex = 3;
            // 
            // Cb_Any
            // 
            this.Cb_Any.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cb_Any.FormattingEnabled = true;
            this.Cb_Any.Location = new System.Drawing.Point(69, 43);
            this.Cb_Any.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Any.Name = "Cb_Any";
            this.Cb_Any.Size = new System.Drawing.Size(106, 25);
            this.Cb_Any.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "개수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(14, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "종류";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textSauce);
            this.groupBox4.Controls.Add(this.Cb_Sauce);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(15, 215);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(189, 160);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "소스";
            // 
            // textSauce
            // 
            this.textSauce.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textSauce.Location = new System.Drawing.Point(69, 106);
            this.textSauce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSauce.Name = "textSauce";
            this.textSauce.Size = new System.Drawing.Size(106, 25);
            this.textSauce.TabIndex = 3;
            // 
            // Cb_Sauce
            // 
            this.Cb_Sauce.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cb_Sauce.FormattingEnabled = true;
            this.Cb_Sauce.Location = new System.Drawing.Point(69, 43);
            this.Cb_Sauce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Sauce.Name = "Cb_Sauce";
            this.Cb_Sauce.Size = new System.Drawing.Size(106, 25);
            this.Cb_Sauce.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "개수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "종류";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textMain);
            this.groupBox3.Controls.Add(this.Cb_Main);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(232, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(189, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "메인";
            // 
            // textMain
            // 
            this.textMain.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textMain.Location = new System.Drawing.Point(69, 106);
            this.textMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMain.Name = "textMain";
            this.textMain.Size = new System.Drawing.Size(106, 25);
            this.textMain.TabIndex = 3;
            // 
            // Cb_Main
            // 
            this.Cb_Main.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cb_Main.FormattingEnabled = true;
            this.Cb_Main.Location = new System.Drawing.Point(69, 43);
            this.Cb_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Main.Name = "Cb_Main";
            this.Cb_Main.Size = new System.Drawing.Size(106, 25);
            this.Cb_Main.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "개수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "종류";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBasic);
            this.groupBox2.Controls.Add(this.Cb_Basic);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Location = new System.Drawing.Point(15, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(189, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "기본";
            // 
            // textBasic
            // 
            this.textBasic.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBasic.Location = new System.Drawing.Point(69, 106);
            this.textBasic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBasic.Name = "textBasic";
            this.textBasic.Size = new System.Drawing.Size(106, 25);
            this.textBasic.TabIndex = 3;
            // 
            // Cb_Basic
            // 
            this.Cb_Basic.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cb_Basic.FormattingEnabled = true;
            this.Cb_Basic.Location = new System.Drawing.Point(69, 43);
            this.Cb_Basic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Basic.Name = "Cb_Basic";
            this.Cb_Basic.Size = new System.Drawing.Size(106, 25);
            this.Cb_Basic.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl2.Location = new System.Drawing.Point(14, 110);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(39, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "개수";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(14, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "종류";
            // 
            // Inventory_Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(636, 440);
            this.Controls.Add(this.btn_RollBack);
            this.Controls.Add(this.btn_Commit);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(200, 250);
            this.Name = "Inventory_Order_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inventory_Order_Form";
            this.Load += new System.EventHandler(this.Inventory_Order_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RollBack;
        private System.Windows.Forms.Button btn_Commit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox textAny;
        private System.Windows.Forms.ComboBox Cb_Any;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox textSauce;
        private System.Windows.Forms.ComboBox Cb_Sauce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textMain;
        private System.Windows.Forms.ComboBox Cb_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBasic;
        private System.Windows.Forms.ComboBox Cb_Basic;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}