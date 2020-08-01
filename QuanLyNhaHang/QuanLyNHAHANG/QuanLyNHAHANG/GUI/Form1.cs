using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNHAHANG.GUI;

namespace QuanLyNHAHANG
{
    public partial class Form1 : Form
    {
        private SqlConnection conn { get; set; }
        int STTBan = 0;
        private string pass { get; set; }
        public Form1(SqlConnection conn,string pass)
        {
            this.conn = conn;
            this.pass = pass;
            InitializeComponent();
        }
        void loadTable()
        {
            BUS.clsBan Ban = new BUS.clsBan();
            pnlTable.Controls.Clear();
            int ID = Convert.ToInt32(cbKhuVuc.SelectedValue);
            DataTable table = new DataTable();
            if (ID == 0)
            {
                table = Ban.LoadBan(conn);
            }
            else
            {
                table = Ban.LoadBanByID(conn, ID);
            }
            int x = 10;
            int y = 10;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Button btn = new Button()
                {
                    Name = "btnTable" + i,
                    Text = table.Rows[i]["TenBan"].ToString(), 
                    Tag = table.Rows[i]["TongCong"].ToString(), 
                    Width = 100,
                    Height = 50,
                    Location = new Point(x, y),
                };
                btn.BackColor = Color.White;
                btn.BackgroundImage = Properties.Resources.icons8_table_16;
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.TextAlign = ContentAlignment.BottomCenter;
                if (x < pnlTable.Width - 220)
                {
                    x += 110;
                }
                else
                {
                    x = 10;
                    y += 60;
                }
                if (table.Rows[i]["TrangThai"].ToString() == "TRỐNG")
                {
                    btn.BackColor = Color.White;
                    btn.ContextMenuStrip = CMSTrong;
                }
                else if (table.Rows[i]["TrangThai"].ToString() == "CÓ NGƯỜI")
                {
                    btn.BackColor = Color.LimeGreen;
                    btn.ContextMenuStrip = CMSCoNguoi;
                }
                else if (table.Rows[i]["TrangThai"].ToString() == "ĐẶT TRƯỚC")
                {
                    btn.BackColor = Color.Yellow;
                    btn.ContextMenuStrip = CMSDatTruoc;
                }
                btn.Click += btn_Click;
                btn.MouseHover += btn_MouseHover;
                pnlTable.Controls.Add(btn);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            loadChuot(sender, e);
        }
        private void btn_MouseHover(object sender, EventArgs e)
        {
            loadChuot(sender, e);
        }
        private float TongCong { get; set; }
        void loadChuot(object sender, EventArgs e)
        {
            BUS.clsBan ban = new BUS.clsBan();
            lbBan.Text = ((Button)sender).Text;
            STTBan = int.Parse(ban.LaySTTBan(conn, lbBan.Text).Rows[0][0].ToString());
            if (((Button)sender).BackColor == Color.White)
            {
                lbTrangThai.Text = "TRỐNG";
            }
            else if (((Button)sender).BackColor == Color.LimeGreen)
            {
                lbTrangThai.Text = "CÓ NGƯỜI";
            }
            else if (((Button)sender).BackColor == Color.Yellow)
            {
                lbTrangThai.Text = "ĐẶT TRƯỚC";
            }
            lbTongCong.Text = ((Button)sender).Tag.ToString() + " VNĐ";
            TongCong = float.Parse(((Button)sender).Tag.ToString());
            loadHoaDon();
            loadTenKV();
        }
        void loadTenKV()
        {
            BUS.clsKhuVuc KV = new BUS.clsKhuVuc();
            lbKhuVuc.Text = KV.LayTenKV(conn, lbBan.Text).Rows[0][0].ToString();
        }
        void loadHoaDon()
        {
            BUS.clsHoaDon HD = new BUS.clsHoaDon();
            dgvHoaDon.DataSource = HD.LoadHoaDon(conn, STTBan);
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                dgvHoaDon.Rows[i].Cells["clSTT"].Value = i + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadTable();
            loadConTrol();
            loadCBMuc();
            loadThucDon();
            lbTenQL.Text = "Tam cao ";
        }
        void loadThucDon()
        {
            BUS.clsThucDon TD = new BUS.clsThucDon();
            int ID = Convert.ToInt32(cbDanhMuc.SelectedValue);
            if (ID == 0)
            {
                dgvThucDon.DataSource = TD.LoadThucDon(conn);
            }
            else
            {
                dgvThucDon.DataSource = TD.LoadThucDonByID(conn, ID);
            }

        }
        void loadCBMuc()
        {
            BUS.clsKhuVuc KV = new BUS.clsKhuVuc();
            BUS.clsDanhMuc DM = new BUS.clsDanhMuc();
            DataTable table = KV.LoadKhuVuc(conn);
            cbKhuVuc.DisplayMember = "TenKhuVuc";
            cbKhuVuc.ValueMember = "ID";
            cbKhuVuc.DataSource = table;
            DataTable table2 = DM.LoadDanhMuc(conn);
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DataSource = table2;
        }
        void loadConTrol()
        {
            cbPhuPhi.Text = "VNĐ";
            cbGiamGia.Text = "VNĐ";
            lbBan.Text = "";
            lbKhuVuc.Text = "";
            lbTrangThai.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien(conn);
            f.ShowDialog();
        }

        private void pnlTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThucDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (CheckThanhToan())
            {
                fPay f = new fPay(conn, lbKhuVuc.Text, lbBan.Text, date.Text.ToString(), lbTime.Text, TongCong, lbTenQL.Text, STTBan);
                f.ShowDialog();
                Form1_Load(sender, e);
            }
        }
        bool CheckThanhToan()
        {
            if (lbKhuVuc.Text == "" && lbBan.Text == "" && lbTrangThai.Text == "")
            {
                MessageBox.Show("Bạn chưa lựa chọn bàn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (lbTrangThai.Text == "TRỐNG" || lbTrangThai.Text == "ĐẶT TRƯỚC")
            {
                MessageBox.Show("Bàn hiện tại trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFood f = new fFood(conn);
            f.ShowDialog();
            Form1_Load(sender, e);
        }

        private void quảnLýDanhSáchBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
