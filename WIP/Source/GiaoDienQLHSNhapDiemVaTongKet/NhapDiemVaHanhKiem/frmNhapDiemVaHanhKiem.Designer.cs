﻿namespace NhapDiemVaHanhKiem
{
    partial class frmNhapDiemVaHanhKiem
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.nhậpĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpĐiểmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHạnhKiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHạnhKiểmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 57);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Location = new System.Drawing.Point(0, 33);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpĐiểmToolStripMenuItem,
            this.nhậpHạnhKiểmToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 33);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // nhậpĐiểmToolStripMenuItem
            // 
            this.nhậpĐiểmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpĐiểmToolStripMenuItem1});
            this.nhậpĐiểmToolStripMenuItem.Name = "nhậpĐiểmToolStripMenuItem";
            this.nhậpĐiểmToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.nhậpĐiểmToolStripMenuItem.Text = "Nhập Điểm";
            // 
            // nhậpĐiểmToolStripMenuItem1
            // 
            this.nhậpĐiểmToolStripMenuItem1.Name = "nhậpĐiểmToolStripMenuItem1";
            this.nhậpĐiểmToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.nhậpĐiểmToolStripMenuItem1.Text = "Nhập Điểm";
            this.nhậpĐiểmToolStripMenuItem1.Click += new System.EventHandler(this.nhậpĐiểmToolStripMenuItem1_Click_1);
            // 
            // nhậpHạnhKiểmToolStripMenuItem
            // 
            this.nhậpHạnhKiểmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHạnhKiểmToolStripMenuItem1});
            this.nhậpHạnhKiểmToolStripMenuItem.Name = "nhậpHạnhKiểmToolStripMenuItem";
            this.nhậpHạnhKiểmToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.nhậpHạnhKiểmToolStripMenuItem.Text = "Nhập Hạnh Kiểm";
            // 
            // nhậpHạnhKiểmToolStripMenuItem1
            // 
            this.nhậpHạnhKiểmToolStripMenuItem1.Name = "nhậpHạnhKiểmToolStripMenuItem1";
            this.nhậpHạnhKiểmToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.nhậpHạnhKiểmToolStripMenuItem1.Text = "Nhập Hạnh Kiểm";
            this.nhậpHạnhKiểmToolStripMenuItem1.Click += new System.EventHandler(this.nhậpHạnhKiểmToolStripMenuItem1_Click);
            // 
            // frmNhapDiemVaHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNhapDiemVaHanhKiem";
            this.Text = "Nhập Điểm Và Hạnh Kiểm";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem nhậpĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpĐiểmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhậpHạnhKiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHạnhKiểmToolStripMenuItem1;
    }
}

