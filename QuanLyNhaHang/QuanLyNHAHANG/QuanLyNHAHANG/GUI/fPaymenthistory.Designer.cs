namespace QuanLyNHAHANG.GUI
{
    partial class fPaymenthistory
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimeTu = new System.Windows.Forms.DateTimePicker();
            this.btnTheoKhoangNgay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTheoThang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNam = new System.Windows.Forms.DateTimePicker();
            this.grbTheoNgay = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTheoNgay = new System.Windows.Forms.Button();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInThongKe = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbTheoNgay.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Refresh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(986, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "In thống kê";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.BackColor = System.Drawing.Color.White;
            this.lbTongDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(911, 52);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(192, 31);
            this.lbTongDoanhThu.TabIndex = 11;
            this.lbTongDoanhThu.Text = "0.VNĐ";
            this.lbTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(911, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng doanh thu:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Controls.Add(this.dateTimeTu);
            this.groupBox3.Controls.Add(this.btnTheoKhoangNgay);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimeDen);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(567, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 163);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // dateTimeTu
            // 
            this.dateTimeTu.CustomFormat = "MM/dd/yyyy";
            this.dateTimeTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTu.Location = new System.Drawing.Point(106, 25);
            this.dateTimeTu.Name = "dateTimeTu";
            this.dateTimeTu.Size = new System.Drawing.Size(117, 20);
            this.dateTimeTu.TabIndex = 1;
            this.dateTimeTu.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // btnTheoKhoangNgay
            // 
            this.btnTheoKhoangNgay.BackColor = System.Drawing.Color.Tomato;
            this.btnTheoKhoangNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheoKhoangNgay.ImageIndex = 0;
            this.btnTheoKhoangNgay.Location = new System.Drawing.Point(0, 101);
            this.btnTheoKhoangNgay.Name = "btnTheoKhoangNgay";
            this.btnTheoKhoangNgay.Size = new System.Drawing.Size(307, 62);
            this.btnTheoKhoangNgay.TabIndex = 4;
            this.btnTheoKhoangNgay.Text = "Thống kê theo khoảng ngày";
            this.btnTheoKhoangNgay.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày:";
            // 
            // dateTimeDen
            // 
            this.dateTimeDen.CustomFormat = "MM/dd/yyyy";
            this.dateTimeDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDen.Location = new System.Drawing.Point(106, 73);
            this.dateTimeDen.Name = "dateTimeDen";
            this.dateTimeDen.Size = new System.Drawing.Size(117, 20);
            this.dateTimeDen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.cbThang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTheoThang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateNam);
            this.groupBox2.Location = new System.Drawing.Point(290, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 163);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(148, 21);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(107, 21);
            this.cbThang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lựa chọn năm:";
            // 
            // btnTheoThang
            // 
            this.btnTheoThang.BackColor = System.Drawing.Color.Tomato;
            this.btnTheoThang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheoThang.ImageIndex = 2;
            this.btnTheoThang.Location = new System.Drawing.Point(0, 101);
            this.btnTheoThang.Name = "btnTheoThang";
            this.btnTheoThang.Size = new System.Drawing.Size(271, 62);
            this.btnTheoThang.TabIndex = 4;
            this.btnTheoThang.Text = "Thống kê theo tháng";
            this.btnTheoThang.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lựa chọn tháng:";
            // 
            // dateNam
            // 
            this.dateNam.CustomFormat = "yyyy";
            this.dateNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNam.Location = new System.Drawing.Point(148, 68);
            this.dateNam.Name = "dateNam";
            this.dateNam.Size = new System.Drawing.Size(107, 20);
            this.dateNam.TabIndex = 0;
            // 
            // grbTheoNgay
            // 
            this.grbTheoNgay.BackColor = System.Drawing.SystemColors.Highlight;
            this.grbTheoNgay.Controls.Add(this.label3);
            this.grbTheoNgay.Controls.Add(this.btnTheoNgay);
            this.grbTheoNgay.Controls.Add(this.dateNgay);
            this.grbTheoNgay.Location = new System.Drawing.Point(12, 7);
            this.grbTheoNgay.Name = "grbTheoNgay";
            this.grbTheoNgay.Size = new System.Drawing.Size(272, 163);
            this.grbTheoNgay.TabIndex = 10;
            this.grbTheoNgay.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lựa chọn ngày:";
            // 
            // btnTheoNgay
            // 
            this.btnTheoNgay.BackColor = System.Drawing.Color.Tomato;
            this.btnTheoNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheoNgay.ImageIndex = 1;
            this.btnTheoNgay.Location = new System.Drawing.Point(0, 98);
            this.btnTheoNgay.Name = "btnTheoNgay";
            this.btnTheoNgay.Size = new System.Drawing.Size(272, 62);
            this.btnTheoNgay.TabIndex = 4;
            this.btnTheoNgay.Text = "Thống kê theo ngày";
            this.btnTheoNgay.UseVisualStyleBackColor = false;
            // 
            // dateNgay
            // 
            this.dateNgay.CustomFormat = "MM/dd/yyyy";
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgay.Location = new System.Drawing.Point(139, 24);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(127, 20);
            this.dateNgay.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLichSu);
            this.panel1.Location = new System.Drawing.Point(0, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 427);
            this.panel1.TabIndex = 7;
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clKhuVuc,
            this.clTenBan,
            this.clNgay,
            this.clThoiGian,
            this.clTongCong,
            this.clNguoiThanhToan,
            this.clGhiChu});
            this.dgvLichSu.GridColor = System.Drawing.Color.Chocolate;
            this.dgvLichSu.Location = new System.Drawing.Point(12, 5);
            this.dgvLichSu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.Size = new System.Drawing.Size(1346, 422);
            this.dgvLichSu.TabIndex = 1;
            // 
            // clSTT
            // 
            this.clSTT.DataPropertyName = "STT";
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 50;
            // 
            // clKhuVuc
            // 
            this.clKhuVuc.DataPropertyName = "KhuVuc";
            this.clKhuVuc.HeaderText = "Khu vực";
            this.clKhuVuc.Name = "clKhuVuc";
            this.clKhuVuc.ReadOnly = true;
            this.clKhuVuc.Width = 150;
            // 
            // clTenBan
            // 
            this.clTenBan.DataPropertyName = "TenBan";
            this.clTenBan.HeaderText = "Tên bàn";
            this.clTenBan.Name = "clTenBan";
            this.clTenBan.ReadOnly = true;
            this.clTenBan.Width = 150;
            // 
            // clNgay
            // 
            this.clNgay.DataPropertyName = "Ngay";
            this.clNgay.HeaderText = "Ngày";
            this.clNgay.Name = "clNgay";
            this.clNgay.ReadOnly = true;
            this.clNgay.Width = 150;
            // 
            // clThoiGian
            // 
            this.clThoiGian.DataPropertyName = "ThoiGian";
            this.clThoiGian.HeaderText = "Thời gian";
            this.clThoiGian.Name = "clThoiGian";
            this.clThoiGian.ReadOnly = true;
            this.clThoiGian.Width = 150;
            // 
            // clTongCong
            // 
            this.clTongCong.DataPropertyName = "TongCong";
            this.clTongCong.HeaderText = "Tổng cộng";
            this.clTongCong.Name = "clTongCong";
            this.clTongCong.ReadOnly = true;
            this.clTongCong.Width = 150;
            // 
            // clNguoiThanhToan
            // 
            this.clNguoiThanhToan.DataPropertyName = "NguoiThanhToan";
            this.clNguoiThanhToan.HeaderText = "Trực ca";
            this.clNguoiThanhToan.Name = "clNguoiThanhToan";
            this.clNguoiThanhToan.ReadOnly = true;
            this.clNguoiThanhToan.Width = 200;
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            this.clGhiChu.Width = 300;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::QuanLyNHAHANG.Properties.Resources.Reset_icon;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(12, 176);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 52);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnInThongKe
            // 
            this.btnInThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnInThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInThongKe.FlatAppearance.BorderSize = 0;
            this.btnInThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInThongKe.Image = global::QuanLyNHAHANG.Properties.Resources.Save_icon;
            this.btnInThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInThongKe.Location = new System.Drawing.Point(911, 108);
            this.btnInThongKe.Name = "btnInThongKe";
            this.btnInThongKe.Size = new System.Drawing.Size(69, 56);
            this.btnInThongKe.TabIndex = 13;
            this.btnInThongKe.UseVisualStyleBackColor = false;
            // 
            // fPaymenthistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 679);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInThongKe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbTheoNgay);
            this.Controls.Add(this.panel1);
            this.Name = "fPaymenthistory";
            this.Text = "fPaymenthistory";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbTheoNgay.ResumeLayout(false);
            this.grbTheoNgay.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInThongKe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimeTu;
        private System.Windows.Forms.Button btnTheoKhoangNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTheoThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNam;
        private System.Windows.Forms.GroupBox grbTheoNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTheoNgay;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
    }
}