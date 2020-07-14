namespace QuanLyNHAHANG.GUI
{
    partial class fAddFood
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
            this.lbBan = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBan
            // 
            this.lbBan.BackColor = System.Drawing.Color.White;
            this.lbBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.Color.Red;
            this.lbBan.Location = new System.Drawing.Point(118, 29);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(137, 25);
            this.lbBan.TabIndex = 8;
            this.lbBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(83, 36);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(29, 13);
            this.lable.TabIndex = 9;
            this.lable.Text = "Bàn:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTen,
            this.clDonGia,
            this.clDonVi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 266);
            this.dataGridView1.TabIndex = 10;
            // 
            // clTen
            // 
            this.clTen.HeaderText = "Tên ";
            this.clTen.Name = "clTen";
            // 
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            // 
            // clDonVi
            // 
            this.clDonVi.HeaderText = "Đơn vị";
            this.clDonVi.Name = "clDonVi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(245, 83);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(112, 20);
            this.txtTimKiem.TabIndex = 12;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(26, 81);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(148, 24);
            this.cbDanhMuc.TabIndex = 13;
            // 
            // fAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.lbBan);
            this.Name = "fAddFood";
            this.Text = "fAddFood";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbDanhMuc;
    }
}