namespace QuanLyNHAHANG.GUI
{
    partial class fPutTable
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
            this.btnGop = new System.Windows.Forms.Button();
            this.cbGop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHoaDonGop = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonGop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGop
            // 
            this.btnGop.BackColor = System.Drawing.Color.Transparent;
            this.btnGop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGop.FlatAppearance.BorderSize = 0;
            this.btnGop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGop.Image = global::QuanLyNHAHANG.Properties.Resources.Save_icon1;
            this.btnGop.Location = new System.Drawing.Point(586, 190);
            this.btnGop.Name = "btnGop";
            this.btnGop.Size = new System.Drawing.Size(64, 57);
            this.btnGop.TabIndex = 23;
            this.btnGop.UseVisualStyleBackColor = false;
            // 
            // cbGop
            // 
            this.cbGop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGop.FormattingEnabled = true;
            this.cbGop.Location = new System.Drawing.Point(724, 73);
            this.cbGop.Name = "cbGop";
            this.cbGop.Size = new System.Drawing.Size(167, 21);
            this.cbGop.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gộp";
            // 
            // lbBan
            // 
            this.lbBan.BackColor = System.Drawing.Color.White;
            this.lbBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.Color.Red;
            this.lbBan.Location = new System.Drawing.Point(148, 66);
            this.lbBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(167, 30);
            this.lbBan.TabIndex = 21;
            this.lbBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Từ bàn:";
            // 
            // dgvHoaDonGop
            // 
            this.dgvHoaDonGop.AllowUserToAddRows = false;
            this.dgvHoaDonGop.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonGop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonGop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenMon,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvHoaDonGop.Location = new System.Drawing.Point(651, 100);
            this.dgvHoaDonGop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDonGop.Name = "dgvHoaDonGop";
            this.dgvHoaDonGop.ReadOnly = true;
            this.dgvHoaDonGop.RowHeadersVisible = false;
            this.dgvHoaDonGop.Size = new System.Drawing.Size(494, 284);
            this.dgvHoaDonGop.TabIndex = 18;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMonAn";
            this.TenMon.HeaderText = "Tên";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            this.TenMon.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 90;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clTenMon,
            this.clSoLuong,
            this.clDonGia,
            this.clThanhTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(90, 100);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.Size = new System.Drawing.Size(494, 284);
            this.dgvHoaDon.TabIndex = 17;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 50;
            // 
            // clTenMon
            // 
            this.clTenMon.DataPropertyName = "TenMonAn";
            this.clTenMon.HeaderText = "Tên";
            this.clTenMon.Name = "clTenMon";
            this.clTenMon.ReadOnly = true;
            this.clTenMon.Width = 150;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            this.clSoLuong.Width = 90;
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "DonGia";
            this.clDonGia.HeaderText = "Đơn Giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            // 
            // clThanhTien
            // 
            this.clThanhTien.DataPropertyName = "ThanhTien";
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // fPutTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 450);
            this.Controls.Add(this.btnGop);
            this.Controls.Add(this.cbGop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvHoaDonGop);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "fPutTable";
            this.Text = "fPutTable";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonGop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGop;
        private System.Windows.Forms.ComboBox cbGop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHoaDonGop;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
    }
}