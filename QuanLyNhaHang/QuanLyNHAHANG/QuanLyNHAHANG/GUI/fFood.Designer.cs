namespace QuanLyNHAHANG.GUI
{
    partial class fFood
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 405);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThucDon);
            this.groupBox2.Location = new System.Drawing.Point(53, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thực Đơn ";
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
            // btnXoaDM
            // 
            this.btnXoaDM.Location = new System.Drawing.Point(393, 36);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDM.TabIndex = 3;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
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
            // btnThemDM
            // 
            this.btnThemDM.Location = new System.Drawing.Point(225, 36);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(75, 23);
            this.btnThemDM.TabIndex = 1;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(22, 38);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(197, 21);
            this.cbDanhMuc.TabIndex = 0;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clTenMonAn,
            this.clGia,
            this.clDonVi,
            this.clID});
            this.dgvThucDon.Location = new System.Drawing.Point(19, 19);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.Size = new System.Drawing.Size(281, 172);
            this.dgvThucDon.TabIndex = 1;
            this.dgvThucDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellContentClick);
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 50;
            // 
            // clTenMonAn
            // 
            this.clTenMonAn.DataPropertyName = "TenMonAn";
            this.clTenMonAn.HeaderText = "Tên";
            this.clTenMonAn.Name = "clTenMonAn";
            this.clTenMonAn.ReadOnly = true;
            this.clTenMonAn.Width = 170;
            // 
            // clGia
            // 
            this.clGia.DataPropertyName = "DonGia";
            this.clGia.HeaderText = "Đơn giá";
            this.clGia.Name = "clGia";
            this.clGia.ReadOnly = true;
            this.clGia.Width = 90;
            // 
            // clDonVi
            // 
            this.clDonVi.DataPropertyName = "DonVi";
            this.clDonVi.HeaderText = "Đơn vị";
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.ReadOnly = true;
            this.clDonVi.Width = 80;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Visible = false;
            // 
            // fFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fFood";
            this.Text = "Quản lý thực đơn";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
    }
}