namespace TPC_Report
{
    partial class frmDayFeeder
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayFeeder));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.cbxFeeder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Point = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Pie = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Bar = new System.Windows.Forms.Button();
            this.colorProgressBar1 = new PowerReport.ColorProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 155);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "饋線日報表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "日期：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 95);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClick);
            this.groupBox1.Controls.Add(this.cbxFeeder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(268, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(785, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(345, 45);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "查詢";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // cbxFeeder
            // 
            this.cbxFeeder.FormattingEnabled = true;
            this.cbxFeeder.Location = new System.Drawing.Point(205, 45);
            this.cbxFeeder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFeeder.Name = "cbxFeeder";
            this.cbxFeeder.Size = new System.Drawing.Size(121, 25);
            this.cbxFeeder.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "饋線名稱";
            // 
            // btn_Point
            // 
            this.btn_Point.Image = global::TPC_Report.Properties.Resources.print;
            this.btn_Point.Location = new System.Drawing.Point(980, 0);
            this.btn_Point.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Point.Name = "btn_Point";
            this.btn_Point.Size = new System.Drawing.Size(46, 46);
            this.btn_Point.TabIndex = 38;
            this.btn_Point.UseVisualStyleBackColor = true;
            // 
            // btn_Excel
            // 
            this.btn_Excel.Image = global::TPC_Report.Properties.Resources.Excel1;
            this.btn_Excel.Location = new System.Drawing.Point(925, 0);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(46, 46);
            this.btn_Excel.TabIndex = 37;
            this.btn_Excel.UseVisualStyleBackColor = true;
            // 
            // btn_Pie
            // 
            this.btn_Pie.Image = global::TPC_Report.Properties.Resources.pie;
            this.btn_Pie.Location = new System.Drawing.Point(760, 0);
            this.btn_Pie.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Pie.Name = "btn_Pie";
            this.btn_Pie.Size = new System.Drawing.Size(46, 46);
            this.btn_Pie.TabIndex = 51;
            this.btn_Pie.UseVisualStyleBackColor = true;
            // 
            // btn_Line
            // 
            this.btn_Line.Image = ((System.Drawing.Image)(resources.GetObject("btn_Line.Image")));
            this.btn_Line.Location = new System.Drawing.Point(815, 0);
            this.btn_Line.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(46, 46);
            this.btn_Line.TabIndex = 50;
            this.btn_Line.UseVisualStyleBackColor = true;
            // 
            // btn_Bar
            // 
            this.btn_Bar.Image = global::TPC_Report.Properties.Resources.Bar;
            this.btn_Bar.Location = new System.Drawing.Point(870, 0);
            this.btn_Bar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Bar.Name = "btn_Bar";
            this.btn_Bar.Size = new System.Drawing.Size(46, 46);
            this.btn_Bar.TabIndex = 49;
            this.btn_Bar.UseVisualStyleBackColor = true;
            // 
            // colorProgressBar1
            // 
            this.colorProgressBar1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colorProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.colorProgressBar1.FillStyle = PowerReport.ColorProgressBar.FillStyles.Solid;
            this.colorProgressBar1.Location = new System.Drawing.Point(13, 501);
            this.colorProgressBar1.Maximum = 100;
            this.colorProgressBar1.Minimum = 0;
            this.colorProgressBar1.Name = "colorProgressBar1";
            this.colorProgressBar1.Size = new System.Drawing.Size(1040, 33);
            this.colorProgressBar1.Step = 10;
            this.colorProgressBar1.TabIndex = 52;
            this.colorProgressBar1.Text = "colorProgressBar1";
            this.colorProgressBar1.Value = 0;
            // 
            // frmDayFeeder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.colorProgressBar1);
            this.Controls.Add(this.btn_Pie);
            this.Controls.Add(this.btn_Line);
            this.Controls.Add(this.btn_Bar);
            this.Controls.Add(this.btn_Point);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDayFeeder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1056, 560);
            this.Load += new System.EventHandler(this.frmDayFeeder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxFeeder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Point;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Pie;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Bar;
        private System.Windows.Forms.Button btnClick;
        private PowerReport.ColorProgressBar colorProgressBar1;
    }
}
