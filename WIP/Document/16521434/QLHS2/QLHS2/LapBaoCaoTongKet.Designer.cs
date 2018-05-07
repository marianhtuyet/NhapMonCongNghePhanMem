namespace QLHS2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lậpBáoCáoTổngKếtMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTổngKếtMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTổngKếtHọcKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpBáoCáoTổngKếtMônToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lậpBáoCáoTổngKếtMônToolStripMenuItem
            // 
            this.lậpBáoCáoTổngKếtMônToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoTổngKếtMônToolStripMenuItem,
            this.báoCáoTổngKếtHọcKỳToolStripMenuItem});
            this.lậpBáoCáoTổngKếtMônToolStripMenuItem.Name = "lậpBáoCáoTổngKếtMônToolStripMenuItem";
            this.lậpBáoCáoTổngKếtMônToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.lậpBáoCáoTổngKếtMônToolStripMenuItem.Text = "Lập Báo Cáo Tổng Kết";
            // 
            // báoCáoTổngKếtMônToolStripMenuItem
            // 
            this.báoCáoTổngKếtMônToolStripMenuItem.Name = "báoCáoTổngKếtMônToolStripMenuItem";
            this.báoCáoTổngKếtMônToolStripMenuItem.Size = new System.Drawing.Size(331, 30);
            this.báoCáoTổngKếtMônToolStripMenuItem.Text = "Lập Báo Cáo Tổng Kết Môn";
            this.báoCáoTổngKếtMônToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTổngKếtMônToolStripMenuItem_Click);
            // 
            // báoCáoTổngKếtHọcKỳToolStripMenuItem
            // 
            this.báoCáoTổngKếtHọcKỳToolStripMenuItem.Name = "báoCáoTổngKếtHọcKỳToolStripMenuItem";
            this.báoCáoTổngKếtHọcKỳToolStripMenuItem.Size = new System.Drawing.Size(331, 30);
            this.báoCáoTổngKếtHọcKỳToolStripMenuItem.Text = "Lập Báo Cáo Tổng Kết Học Kỳ";
            this.báoCáoTổngKếtHọcKỳToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTổngKếtHọcKỳToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lập Báo Cáo Tổng Kết";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lậpBáoCáoTổngKếtMônToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTổngKếtMônToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTổngKếtHọcKỳToolStripMenuItem;
    }
}

