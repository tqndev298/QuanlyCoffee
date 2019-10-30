namespace QuanLyCafe
{
    partial class fTableManger
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
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbcb = new System.Windows.Forms.ComboBox();
            this.btchuyenb = new System.Windows.Forms.Button();
            this.nmgg = new System.Windows.Forms.NumericUpDown();
            this.btgg = new System.Windows.Forms.Button();
            this.btthanhtoan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodcount = new System.Windows.Forms.NumericUpDown();
            this.btaddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmgg)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodcount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(304, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 278);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 275);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbcb);
            this.panel3.Controls.Add(this.btchuyenb);
            this.panel3.Controls.Add(this.nmgg);
            this.panel3.Controls.Add(this.btgg);
            this.panel3.Controls.Add(this.btthanhtoan);
            this.panel3.Location = new System.Drawing.Point(304, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 63);
            this.panel3.TabIndex = 2;
            // 
            // cbcb
            // 
            this.cbcb.FormattingEnabled = true;
            this.cbcb.Location = new System.Drawing.Point(3, 34);
            this.cbcb.Name = "cbcb";
            this.cbcb.Size = new System.Drawing.Size(74, 21);
            this.cbcb.TabIndex = 7;
            // 
            // btchuyenb
            // 
            this.btchuyenb.Location = new System.Drawing.Point(0, 3);
            this.btchuyenb.Name = "btchuyenb";
            this.btchuyenb.Size = new System.Drawing.Size(74, 25);
            this.btchuyenb.TabIndex = 6;
            this.btchuyenb.Text = "Chuyển bàn";
            this.btchuyenb.UseVisualStyleBackColor = true;
            // 
            // nmgg
            // 
            this.nmgg.Location = new System.Drawing.Point(102, 35);
            this.nmgg.Name = "nmgg";
            this.nmgg.Size = new System.Drawing.Size(61, 20);
            this.nmgg.TabIndex = 5;
            this.nmgg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btgg
            // 
            this.btgg.Location = new System.Drawing.Point(102, 3);
            this.btgg.Name = "btgg";
            this.btgg.Size = new System.Drawing.Size(61, 25);
            this.btgg.TabIndex = 4;
            this.btgg.Text = "Giảm giá";
            this.btgg.UseVisualStyleBackColor = true;
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.Location = new System.Drawing.Point(188, 10);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(58, 50);
            this.btthanhtoan.TabIndex = 3;
            this.btthanhtoan.Text = "Thanh toán";
            this.btthanhtoan.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodcount);
            this.panel4.Controls.Add(this.btaddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(304, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 61);
            this.panel4.TabIndex = 3;
            // 
            // nmFoodcount
            // 
            this.nmFoodcount.Location = new System.Drawing.Point(194, 25);
            this.nmFoodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodcount.Name = "nmFoodcount";
            this.nmFoodcount.Size = new System.Drawing.Size(49, 20);
            this.nmFoodcount.TabIndex = 3;
            this.nmFoodcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btaddFood
            // 
            this.btaddFood.Location = new System.Drawing.Point(130, 8);
            this.btaddFood.Name = "btaddFood";
            this.btaddFood.Size = new System.Drawing.Size(58, 50);
            this.btaddFood.TabIndex = 2;
            this.btaddFood.Text = "Thêm món";
            this.btaddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 37);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 21);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 10);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // flTable
            // 
            this.flTable.Location = new System.Drawing.Point(12, 37);
            this.flTable.Name = "flTable";
            this.flTable.Size = new System.Drawing.Size(286, 404);
            this.flTable.TabIndex = 4;
            // 
            // fTableManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 453);
            this.Controls.Add(this.flTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManger";
            this.Text = "Phầm mềm quản lý cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmgg)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbcb;
        private System.Windows.Forms.Button btchuyenb;
        private System.Windows.Forms.NumericUpDown nmgg;
        private System.Windows.Forms.Button btgg;
        private System.Windows.Forms.Button btthanhtoan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodcount;
        private System.Windows.Forms.Button btaddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flTable;
    }
}