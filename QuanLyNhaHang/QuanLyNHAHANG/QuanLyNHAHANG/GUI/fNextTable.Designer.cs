namespace QuanLyNHAHANG.GUI
{
    partial class fNextTable
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.cbToTalbe = new System.Windows.Forms.ComboBox();
            this.lbBan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
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
            this.dgvHoaDon.Location = new System.Drawing.Point(107, 64);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.Size = new System.Drawing.Size(497, 231);
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
            // btnChuyen
            // 
            this.btnChuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChuyen.FlatAppearance.BorderSize = 0;
            this.btnChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyen.Image = global::QuanLyNHAHANG.Properties.Resources._500_F_315836598_QIFlda2800bzuvqEnir6nHdnmvGQolI5;
            this.btnChuyen.Location = new System.Drawing.Point(544, 313);
            this.btnChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(41, 33);
            this.btnChuyen.TabIndex = 16;
            this.btnChuyen.UseVisualStyleBackColor = false;
            // 
            // cbToTalbe
            // 
            this.cbToTalbe.BackColor = System.Drawing.Color.White;
            this.cbToTalbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToTalbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToTalbe.FormattingEnabled = true;
            this.cbToTalbe.Location = new System.Drawing.Point(178, 320);
            this.cbToTalbe.Margin = new System.Windows.Forms.Padding(4);
            this.cbToTalbe.Name = "cbToTalbe";
            this.cbToTalbe.Size = new System.Drawing.Size(181, 28);
            this.cbToTalbe.TabIndex = 15;
            // 
            // lbBan
            // 
            this.lbBan.BackColor = System.Drawing.Color.White;
            this.lbBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.Color.Red;
            this.lbBan.Location = new System.Drawing.Point(169, 20);
            this.lbBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(181, 28);
            this.lbBan.TabIndex = 14;
            this.lbBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Xác nhận chuyển:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đến bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Từ bàn:";
            // 
            // fNextTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 383);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.cbToTalbe);
            this.Controls.Add(this.lbBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "fNextTable";
            this.Text = "fNextTable";
            this.Load += new System.EventHandler(this.fNextTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.ComboBox cbToTalbe;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}