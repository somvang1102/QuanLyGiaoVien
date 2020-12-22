﻿namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bộMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcHàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcVịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchGiảngDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBoMon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.taikhoan1;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(128, 68);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.dnhap;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoaToolStripMenuItem,
            this.bộMônToolStripMenuItem,
            this.họcHàmToolStripMenuItem,
            this.họcVịToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.thongke;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(127, 68);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.khoaToolStripMenuItem.Text = "Khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // bộMônToolStripMenuItem
            // 
            this.bộMônToolStripMenuItem.Name = "bộMônToolStripMenuItem";
            this.bộMônToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.bộMônToolStripMenuItem.Text = "Bộ Môn";
            this.bộMônToolStripMenuItem.Click += new System.EventHandler(this.bộMônToolStripMenuItem_Click);
            // 
            // họcHàmToolStripMenuItem
            // 
            this.họcHàmToolStripMenuItem.Name = "họcHàmToolStripMenuItem";
            this.họcHàmToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.họcHàmToolStripMenuItem.Text = "Học hàm";
            this.họcHàmToolStripMenuItem.Click += new System.EventHandler(this.họcHàmToolStripMenuItem_Click);
            // 
            // họcVịToolStripMenuItem
            // 
            this.họcVịToolStripMenuItem.Name = "họcVịToolStripMenuItem";
            this.họcVịToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.họcVịToolStripMenuItem.Text = "Học vị";
            this.họcVịToolStripMenuItem.Click += new System.EventHandler(this.họcVịToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchGiáoViênToolStripMenuItem,
            this.lịchGiảngDạyToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Quanly;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(113, 68);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // danhSáchGiáoViênToolStripMenuItem
            // 
            this.danhSáchGiáoViênToolStripMenuItem.Name = "danhSáchGiáoViênToolStripMenuItem";
            this.danhSáchGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.danhSáchGiáoViênToolStripMenuItem.Text = "Danh sách giáo viên";
            this.danhSáchGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchGiáoViênToolStripMenuItem_Click);
            // 
            // lịchGiảngDạyToolStripMenuItem
            // 
            this.lịchGiảngDạyToolStripMenuItem.Name = "lịchGiảngDạyToolStripMenuItem";
            this.lịchGiảngDạyToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.lịchGiảngDạyToolStripMenuItem.Text = "Thống kê giáo viên";
            this.lịchGiảngDạyToolStripMenuItem.Click += new System.EventHandler(this.lịchGiảngDạyToolStripMenuItem_Click);
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(21, 234);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(248, 24);
            this.comboBoxKhoa.TabIndex = 1;
            this.comboBoxKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxKhoa_SelectedIndexChanged);
            // 
            // data1
            // 
            this.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(12, 264);
            this.data1.Name = "data1";
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(1131, 262);
            this.data1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(474, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "In ra excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBoMon
            // 
            this.btnBoMon.Location = new System.Drawing.Point(1020, 217);
            this.btnBoMon.Name = "btnBoMon";
            this.btnBoMon.Size = new System.Drawing.Size(123, 47);
            this.btnBoMon.TabIndex = 4;
            this.btnBoMon.Text = "Tất cả";
            this.btnBoMon.UseVisualStyleBackColor = true;
            this.btnBoMon.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot__38_;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1134, 142);
            this.label1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Aqua;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1022, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 15);
            this.textBox1.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1155, 596);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoMon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.comboBoxKhoa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bộMônToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcHàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcVịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBoMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchGiảngDạyToolStripMenuItem;
    }
}