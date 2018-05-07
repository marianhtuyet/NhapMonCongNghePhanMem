namespace QLHS2
{
    partial class frmLapBaoCaoTongKetMon
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(589, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lập Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "2014 - 2015",
            "2015 - 2016",
            "2016 - 2017",
            "2017 - 2018",
            "2018 - 2019"});
            this.comboBox4.Location = new System.Drawing.Point(184, 46);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(134, 27);
            this.comboBox4.TabIndex = 30;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "10A1",
            "10A2",
            "10A3",
            "11A1",
            "11A2",
            "11A3",
            "12A1",
            "12A2",
            "12A3"});
            this.comboBox3.Location = new System.Drawing.Point(549, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(134, 27);
            this.comboBox3.TabIndex = 29;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Toán ",
            "Ngữ Văn",
            "Ngoại Ngữ",
            "Sinh Học",
            "Hóa Học",
            "Vật Lý",
            "GDCD",
            "Lịch Sử",
            "Địa Lý",
            "Công Nghệ",
            "Tin Học",
            "Thể Dục",
            "GDQP"});
            this.comboBox2.Location = new System.Drawing.Point(549, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 27);
            this.comboBox2.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "I",
            "II"});
            this.comboBox1.Location = new System.Drawing.Point(184, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 27);
            this.comboBox1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(417, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Môn Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(49, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(417, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Năm Học";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(408, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 31;
            this.button2.Text = "Xuất File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(4, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 239);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học sinh";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên học sinh";
            this.columnHeader2.Width = 274;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điểm trung bình môn";
            this.columnHeader3.Width = 457;
            // 
            // frmLapBaoCaoTongKetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 427);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmLapBaoCaoTongKetMon";
            this.Text = "Lập Báo Cáo Tổng Kết Môn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}