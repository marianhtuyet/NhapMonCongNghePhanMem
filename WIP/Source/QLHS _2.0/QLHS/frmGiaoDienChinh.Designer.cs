namespace QLHS
{
    partial class frmGiaoDienChinh
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsTiepNhanHocSinh = new System.Windows.Forms.ToolStripButton();
            this.tsTraCuuHocSinh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTiepNhanHocSinh,
            this.tsTraCuuHocSinh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(784, 63);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsTiepNhanHocSinh
            // 
            this.tsTiepNhanHocSinh.AutoSize = false;
            this.tsTiepNhanHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsTiepNhanHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsTiepNhanHocSinh.Image = global::QLHS.Properties.Resources._33848359_870842646433311_2473242104059396096_n;
            this.tsTiepNhanHocSinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTiepNhanHocSinh.Name = "tsTiepNhanHocSinh";
            this.tsTiepNhanHocSinh.Size = new System.Drawing.Size(60, 60);
            this.tsTiepNhanHocSinh.Text = "Hồ Sơ";
            this.tsTiepNhanHocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsTiepNhanHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsTiepNhanHocSinh.Click += new System.EventHandler(this.tsTiepNhanHocSinh_Click);
            // 
            // tsTraCuuHocSinh
            // 
            this.tsTraCuuHocSinh.AutoSize = false;
            this.tsTraCuuHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsTraCuuHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsTraCuuHocSinh.Image = global::QLHS.Properties.Resources.tải_xuống;
            this.tsTraCuuHocSinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTraCuuHocSinh.Name = "tsTraCuuHocSinh";
            this.tsTraCuuHocSinh.Size = new System.Drawing.Size(60, 60);
            this.tsTraCuuHocSinh.Text = "Tra Cứu";
            this.tsTraCuuHocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsTraCuuHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsTraCuuHocSinh.Click += new System.EventHandler(this.tsTraCuuHocSinh_Click);
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmGiaoDienChinh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HỌC SINH TRƯỜNG THPT TÂN TRỤ";
            this.Load += new System.EventHandler(this.frmGiaoDienChinh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsTiepNhanHocSinh;
        private System.Windows.Forms.ToolStripButton tsTraCuuHocSinh;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}