namespace GUI
{
    partial class frmThayDoiQuyDinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudTuoiMin = new System.Windows.Forms.NumericUpDown();
            this.nudTuoiMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudLop11 = new System.Windows.Forms.NumericUpDown();
            this.nudLop12 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLop10 = new System.Windows.Forms.NumericUpDown();
            this.nudSiSo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSLMon = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudDiemMax = new System.Windows.Forms.NumericUpDown();
            this.nudDiemDat = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDiemMin = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvQuyDinh = new System.Windows.Forms.DataGridView();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TUOIMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUOIMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMDAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoiMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoiMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLMon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemMin)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.dgvQuyDinh);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 561);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudTuoiMin);
            this.groupBox1.Controls.Add(this.nudTuoiMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(27, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 90);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qui định 1: Độ tuổi";
            // 
            // nudTuoiMin
            // 
            this.nudTuoiMin.Font = new System.Drawing.Font("Arial", 9F);
            this.nudTuoiMin.Location = new System.Drawing.Point(178, 47);
            this.nudTuoiMin.Name = "nudTuoiMin";
            this.nudTuoiMin.Size = new System.Drawing.Size(48, 21);
            this.nudTuoiMin.TabIndex = 4;
            // 
            // nudTuoiMax
            // 
            this.nudTuoiMax.Font = new System.Drawing.Font("Arial", 9F);
            this.nudTuoiMax.Location = new System.Drawing.Point(178, 24);
            this.nudTuoiMax.Name = "nudTuoiMax";
            this.nudTuoiMax.Size = new System.Drawing.Size(48, 21);
            this.nudTuoiMax.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tuổi tối thiểu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuổi tối đa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudLop11);
            this.groupBox2.Controls.Add(this.nudLop12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudLop10);
            this.groupBox2.Controls.Add(this.nudSiSo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(27, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 160);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quy định 2: Sĩ số";
            // 
            // nudLop11
            // 
            this.nudLop11.Font = new System.Drawing.Font("Arial", 9F);
            this.nudLop11.Location = new System.Drawing.Point(178, 80);
            this.nudLop11.Name = "nudLop11";
            this.nudLop11.Size = new System.Drawing.Size(48, 21);
            this.nudLop11.TabIndex = 8;
            // 
            // nudLop12
            // 
            this.nudLop12.Font = new System.Drawing.Font("Arial", 9F);
            this.nudLop12.Location = new System.Drawing.Point(178, 107);
            this.nudLop12.Name = "nudLop12";
            this.nudLop12.Size = new System.Drawing.Size(48, 21);
            this.nudLop12.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(23, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số lượng lớp khối 12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(24, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng lớp khối 11";
            // 
            // nudLop10
            // 
            this.nudLop10.Font = new System.Drawing.Font("Arial", 9F);
            this.nudLop10.Location = new System.Drawing.Point(178, 55);
            this.nudLop10.Name = "nudLop10";
            this.nudLop10.Size = new System.Drawing.Size(48, 21);
            this.nudLop10.TabIndex = 4;
            // 
            // nudSiSo
            // 
            this.nudSiSo.Font = new System.Drawing.Font("Arial", 9F);
            this.nudSiSo.Location = new System.Drawing.Point(178, 24);
            this.nudSiSo.Name = "nudSiSo";
            this.nudSiSo.Size = new System.Drawing.Size(48, 21);
            this.nudSiSo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng lớp khối 10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(23, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sĩ số tối đa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(22, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số lượng môn học";
            // 
            // nudSLMon
            // 
            this.nudSLMon.Font = new System.Drawing.Font("Arial", 9F);
            this.nudSLMon.Location = new System.Drawing.Point(178, 39);
            this.nudSLMon.Name = "nudSLMon";
            this.nudSLMon.Size = new System.Drawing.Size(48, 21);
            this.nudSLMon.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(22, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điểm tối đa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudSLMon);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(359, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 90);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Qui định 3: Số lượng môn";
            // 
            // nudDiemMax
            // 
            this.nudDiemMax.Font = new System.Drawing.Font("Arial", 9F);
            this.nudDiemMax.Location = new System.Drawing.Point(178, 29);
            this.nudDiemMax.Name = "nudDiemMax";
            this.nudDiemMax.Size = new System.Drawing.Size(48, 21);
            this.nudDiemMax.TabIndex = 3;
            // 
            // nudDiemDat
            // 
            this.nudDiemDat.Font = new System.Drawing.Font("Arial", 9F);
            this.nudDiemDat.Location = new System.Drawing.Point(178, 103);
            this.nudDiemDat.Name = "nudDiemDat";
            this.nudDiemDat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudDiemDat.Size = new System.Drawing.Size(48, 21);
            this.nudDiemDat.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F);
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(22, 109);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Điểm đạt";
            // 
            // nudDiemMin
            // 
            this.nudDiemMin.Font = new System.Drawing.Font("Arial", 9F);
            this.nudDiemMin.Location = new System.Drawing.Point(178, 66);
            this.nudDiemMin.Name = "nudDiemMin";
            this.nudDiemMin.Size = new System.Drawing.Size(48, 21);
            this.nudDiemMin.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(22, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Điểm tối thiểu";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(236, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "Thay đổi quy định";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(655, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudDiemDat);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudDiemMin);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.nudDiemMax);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(359, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 160);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Qui định4: Điểm";
            // 
            // dgvQuyDinh
            // 
            this.dgvQuyDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyDinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TUOIMAX,
            this.TUOIMIN,
            this.SISO,
            this.DIEMDAT,
            this.DIEMMAX,
            this.DIEMMIN,
            this.SLMON});
            this.dgvQuyDinh.Location = new System.Drawing.Point(7, 408);
            this.dgvQuyDinh.Name = "dgvQuyDinh";
            this.dgvQuyDinh.Size = new System.Drawing.Size(769, 150);
            this.dgvQuyDinh.TabIndex = 5;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(674, 242);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(75, 44);
            this.btnTrangChu.TabIndex = 22;
            this.btnTrangChu.Text = "Quay lại Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(253, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 32);
            this.label12.TabIndex = 23;
            this.label12.Text = "Quy định cũ";
            // 
            // TUOIMAX
            // 
            this.TUOIMAX.DataPropertyName = "TUOIMAX";
            this.TUOIMAX.HeaderText = "Tuổi tối đa";
            this.TUOIMAX.Name = "TUOIMAX";
            // 
            // TUOIMIN
            // 
            this.TUOIMIN.DataPropertyName = "TUOIMIN";
            this.TUOIMIN.HeaderText = "Tuổi tối thiểu";
            this.TUOIMIN.Name = "TUOIMIN";
            // 
            // SISO
            // 
            this.SISO.DataPropertyName = "SISO";
            this.SISO.HeaderText = "Sĩ số tối đa";
            this.SISO.Name = "SISO";
            // 
            // DIEMDAT
            // 
            this.DIEMDAT.DataPropertyName = "DIEMDAT";
            this.DIEMDAT.HeaderText = "Điểm đạt";
            this.DIEMDAT.Name = "DIEMDAT";
            // 
            // DIEMMAX
            // 
            this.DIEMMAX.DataPropertyName = "DIEMMAX";
            this.DIEMMAX.HeaderText = "Điểm cao nhất";
            this.DIEMMAX.Name = "DIEMMAX";
            this.DIEMMAX.Width = 110;
            // 
            // DIEMMIN
            // 
            this.DIEMMIN.DataPropertyName = "DIEMMIN";
            this.DIEMMIN.HeaderText = "Điểm thấp nhất";
            this.DIEMMIN.Name = "DIEMMIN";
            this.DIEMMIN.Width = 110;
            // 
            // SLMON
            // 
            this.SLMON.DataPropertyName = "SLMON";
            this.SLMON.HeaderText = "Số lượng môn";
            this.SLMON.Name = "SLMON";
            this.SLMON.Width = 110;
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "frmThayDoiQuyDinh";
            this.Load += new System.EventHandler(this.frmThayDoiQuyDinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoiMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoiMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLMon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemMin)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.DataGridView dgvQuyDinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudTuoiMin;
        private System.Windows.Forms.NumericUpDown nudTuoiMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudLop11;
        private System.Windows.Forms.NumericUpDown nudLop12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudLop10;
        private System.Windows.Forms.NumericUpDown nudSiSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudSLMon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudDiemDat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudDiemMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudDiemMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUOIMAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUOIMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMDAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMMAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLMON;
    }
}