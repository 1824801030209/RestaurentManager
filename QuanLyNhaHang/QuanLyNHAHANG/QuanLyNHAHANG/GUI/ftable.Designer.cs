namespace QuanLyNHAHANG.GUI
{
    partial class ftable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 405);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaDM);
            this.groupBox1.Controls.Add(this.btnSuaDM);
            this.groupBox1.Controls.Add(this.btnThemDM);
            this.groupBox1.Controls.Add(this.cbDanhMuc);
            this.groupBox1.Location = new System.Drawing.Point(53, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu Vực";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTable);
            this.groupBox2.Location = new System.Drawing.Point(53, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bàn ";
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clID,
            this.clTenBan,
            this.clTongCong,
            this.clTrangThai,
            this.colSTT});
            this.dgvTable.Location = new System.Drawing.Point(6, 19);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.Size = new System.Drawing.Size(357, 165);
            this.dgvTable.TabIndex = 1;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 50;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Visible = false;
            // 
            // clTenBan
            // 
            this.clTenBan.DataPropertyName = "TenBan";
            this.clTenBan.HeaderText = "Tên bàn";
            this.clTenBan.Name = "clTenBan";
            this.clTenBan.ReadOnly = true;
            // 
            // clTongCong
            // 
            this.clTongCong.DataPropertyName = "TongCong";
            this.clTongCong.HeaderText = "Tổng cộng";
            this.clTongCong.Name = "clTongCong";
            this.clTongCong.ReadOnly = true;
            // 
            // clTrangThai
            // 
            this.clTrangThai.DataPropertyName = "TrangThai";
            this.clTrangThai.HeaderText = "Trạng thái";
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.ReadOnly = true;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Visible = false;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(22, 38);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(197, 21);
            this.cbDanhMuc.TabIndex = 0;
            // 
            // btnThemDM
            // 
            this.btnThemDM.Location = new System.Drawing.Point(225, 36);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(75, 23);
            this.btnThemDM.TabIndex = 1;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.Location = new System.Drawing.Point(306, 36);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDM.TabIndex = 2;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Location = new System.Drawing.Point(393, 36);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDM.TabIndex = 3;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            // 
            // ftable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ftable";
            this.Text = "Quản lý danh sách bàn";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.ComboBox cbDanhMuc;
    }
}