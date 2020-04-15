namespace TPC_Report
{
    partial class frmHistoryAlarm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClk = new System.Windows.Forms.Button();
            this.colorProgressBar1 = new PowerReport.ColorProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "(含)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "(含)";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(92, 112);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 25);
            this.dateTimePicker2.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "日期(迄)";
            // 
            // btnPoint
            // 
            this.btnPoint.Image = global::TPC_Report.Properties.Resources.print;
            this.btnPoint.Location = new System.Drawing.Point(980, 0);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(46, 46);
            this.btnPoint.TabIndex = 54;
            this.btnPoint.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::TPC_Report.Properties.Resources.Excel1;
            this.btnExcel.Location = new System.Drawing.Point(925, 0);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(46, 46);
            this.btnExcel.TabIndex = 53;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClk);
            this.groupBox1.Controls.Add(this.cbxLevel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(268, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(785, 98);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // cbxLevel
            // 
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Location = new System.Drawing.Point(205, 45);
            this.cbxLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(121, 25);
            this.cbxLevel.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "警報等級";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 64);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 25);
            this.dateTimePicker1.TabIndex = 51;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "日期(起)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "歷史警報報表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 155);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 340);
            this.dataGridView1.TabIndex = 47;
            // 
            // btnClk
            // 
            this.btnClk.Location = new System.Drawing.Point(365, 45);
            this.btnClk.Name = "btnClk";
            this.btnClk.Size = new System.Drawing.Size(75, 23);
            this.btnClk.TabIndex = 9;
            this.btnClk.Text = "查詢";
            this.btnClk.UseVisualStyleBackColor = false;
            this.btnClk.Click += new System.EventHandler(this.btnClk_Click);
            // 
            // colorProgressBar1
            // 
            this.colorProgressBar1.BarColor = System.Drawing.Color.LightSkyBlue;
            this.colorProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.colorProgressBar1.FillStyle = PowerReport.ColorProgressBar.FillStyles.Solid;
            this.colorProgressBar1.Location = new System.Drawing.Point(13, 501);
            this.colorProgressBar1.Maximum = 100;
            this.colorProgressBar1.Minimum = 0;
            this.colorProgressBar1.Name = "colorProgressBar1";
            this.colorProgressBar1.Size = new System.Drawing.Size(1040, 32);
            this.colorProgressBar1.Step = 10;
            this.colorProgressBar1.TabIndex = 58;
            this.colorProgressBar1.Text = "colorProgressBar1";
            this.colorProgressBar1.Value = 0;
            // 
            // frmHistoryAlarm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.colorProgressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmHistoryAlarm";
            this.Size = new System.Drawing.Size(1056, 560);
            this.Load += new System.EventHandler(this.frmHistoryAlarm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClk;
        private PowerReport.ColorProgressBar colorProgressBar1;
    }
}
