﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNHAHANG.GUI
{
    public partial class fConnet : Form
    {
        public fConnet()
        {
            InitializeComponent();
        }

        private void fConnet_Load(object sender, EventArgs e)
        {
            cbXacThuc.Text= "Windows authentication";
            loadform();
            txbCSDL.Text= "QL_NhaHang";
        }
        void loadform()
        {
            txbTenMayChu.Text = Environment.MachineName + @"\SQLEXPRESS";
            if (cbXacThuc.Text == "Windows authentication")
            {
                lbTen.Enabled = false;
                lbMK.Enabled = false;
                txbTenNguoiDung.Enabled = false;
                txbMatKhau.Enabled = false;
            }
            else
            {
                lbTen.Enabled = true;
                lbMK.Enabled = true;
                txbTenNguoiDung.Enabled = true;
                txbMatKhau.Enabled = true;
            }
        }
        private void cbXacThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadform();
        }


        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                clsConnect conn = new clsConnect(txbTenMayChu.Text, txbCSDL.Text);
                conn.SqlConnectionWindowsAuthentication().Open();
                fLoading f = new fLoading(conn.SqlConnectionWindowsAuthentication());
                conn.SqlConnectionWindowsAuthentication().Close();
                this.Hide();
                f.ShowDialog();

                this.Close();

            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            clsConnect conn = new clsConnect(txbTenMayChu.Text, txbCSDL.Text);
            try
            {
                conn.SqlConnectionWindowsAuthentication().Open();
                MessageBox.Show("Kết nối thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.SqlConnectionWindowsAuthentication().Close();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
