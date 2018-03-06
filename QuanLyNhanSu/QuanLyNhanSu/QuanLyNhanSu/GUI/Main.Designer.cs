namespace QuanLyNhanSu.GUI
{
    partial class Main
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
            this.menutrip = new System.Windows.Forms.MenuStrip();
            this.menu_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_opt = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menutrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutrip
            // 
            this.menutrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_hethong,
            this.menu_view,
            this.menu_opt,
            this.menu_help});
            this.menutrip.Location = new System.Drawing.Point(0, 0);
            this.menutrip.Name = "menutrip";
            this.menutrip.Size = new System.Drawing.Size(894, 29);
            this.menutrip.TabIndex = 2;
            this.menutrip.Text = "menu";
            // 
            // menu_hethong
            // 
            this.menu_hethong.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_hethong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu_hethong.Name = "menu_hethong";
            this.menu_hethong.Size = new System.Drawing.Size(90, 25);
            this.menu_hethong.Text = "Hệ thống";
            // 
            // menu_view
            // 
            this.menu_view.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_view.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu_view.Name = "menu_view";
            this.menu_view.Size = new System.Drawing.Size(150, 25);
            this.menu_view.Text = "Tra cứu thông tin";
            // 
            // menu_opt
            // 
            this.menu_opt.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_opt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu_opt.Name = "menu_opt";
            this.menu_opt.Size = new System.Drawing.Size(160, 25);
            this.menu_opt.Text = "Tác vụ - chức năng";
            this.menu_opt.Click += new System.EventHandler(this.menu_opt_Click);
            // 
            // menu_help
            // 
            this.menu_help.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_help.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(134, 25);
            this.menu_help.Text = "Liên hệ - hỗ trợ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 426);
            this.Controls.Add(this.menutrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menutrip;
            this.Name = "Main";
            this.Text = "Phần mềm quản lý nhân sự";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menutrip.ResumeLayout(false);
            this.menutrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menutrip;
        private System.Windows.Forms.ToolStripMenuItem menu_hethong;
        private System.Windows.Forms.ToolStripMenuItem menu_view;
        private System.Windows.Forms.ToolStripMenuItem menu_opt;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
    }
}