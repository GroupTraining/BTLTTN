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
            this.pan_menu = new System.Windows.Forms.Panel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.menutrip.SuspendLayout();
            this.pan_menu.SuspendLayout();
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
            this.menu_hethong.Click += new System.EventHandler(this.menu_hethong_Click);
            // 
            // menu_view
            // 
            this.menu_view.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_view.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu_view.Name = "menu_view";
            this.menu_view.Size = new System.Drawing.Size(150, 25);
            this.menu_view.Text = "Tra cứu thông tin";
            this.menu_view.Click += new System.EventHandler(this.menu_view_Click);
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
            // pan_menu
            // 
            this.pan_menu.Controls.Add(this.btn_Edit);
            this.pan_menu.Controls.Add(this.btn_add);
            this.pan_menu.Location = new System.Drawing.Point(0, 32);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(894, 43);
            this.pan_menu.TabIndex = 3;
            this.pan_menu.Visible = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(324, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(86, 37);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Chỉnh sửa";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(232, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 37);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.images1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 426);
            this.Controls.Add(this.pan_menu);
            this.Controls.Add(this.menutrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menutrip;
            this.Name = "Main";
            this.Text = "Phần mềm quản lý nhân sự";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menutrip.ResumeLayout(false);
            this.menutrip.PerformLayout();
            this.pan_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menutrip;
        private System.Windows.Forms.ToolStripMenuItem menu_hethong;
        private System.Windows.Forms.ToolStripMenuItem menu_view;
        private System.Windows.Forms.ToolStripMenuItem menu_opt;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_add;
    }
}