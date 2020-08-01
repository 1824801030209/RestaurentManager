using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNHAHANG.GUI
{
    public partial class fFood : Form
    {
        SqlConnection conn { get; set; }
        public fFood(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void dgvThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fFood_Load(object sender, EventArgs e)
        {
            BUS.clsDanhMuc DM = new BUS.clsDanhMuc();
            DataTable table = DM.LoadDSDanhMuc(conn);
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.DataSource = table;
            loadThucDon();
        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            fUpdate f = new fUpdate(conn, "addDM");
            f.ShowDialog();
            fFood_Load(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
            fUpdate f = new fUpdate(conn, cbDanhMuc.Text, id, "editDM");
            f.ShowDialog();
            fFood_Load(sender, e);
        }
        void loadThucDon()
        {
            BUS.clsThucDon TD = new BUS.clsThucDon();
            int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
            dgvThucDon.DataSource = TD.LoadThucDonByID(conn, id);
            for (int i = 0; i < dgvThucDon.Rows.Count; i++)
            {
                dgvThucDon.Rows[i].Cells["clSTT"].Value = i + 1;
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (dgvThucDon.Rows.Count > 0)
            {
                MessageBox.Show("Danh mục còn dữ liệu không thể xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Xác nhận xóa!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    BUS.clsDanhMuc DM = new BUS.clsDanhMuc();
                    int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
                    DM.DeleteDanhMuc(conn, id);
                    MessageBox.Show("Xóa hoàn tất!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fFood_Load(sender, e);
                }
            }
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThucDon();
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cbDanhMuc.SelectedValue);
            fAddMenu f = new fAddMenu(conn, ID);
            f.ShowDialog();
            fFood_Load(sender, e);
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cbDanhMuc.SelectedValue);
            string Ten = dgvThucDon.Rows[dgvThucDon.CurrentCell.RowIndex].Cells["clTenMonAn"].Value.ToString();
            string Gia = dgvThucDon.Rows[dgvThucDon.CurrentCell.RowIndex].Cells["clGia"].Value.ToString();
            string DonVi = dgvThucDon.Rows[dgvThucDon.CurrentCell.RowIndex].Cells["clDonVi"].Value.ToString();
            fAddMenu f = new fAddMenu(conn, Ten, Gia, DonVi, ID);
            f.ShowDialog();
            fFood_Load(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                BUS.clsThucDon TD = new BUS.clsThucDon();
                int ID = Convert.ToInt32(cbDanhMuc.SelectedValue);
                string Ten = dgvThucDon.Rows[dgvThucDon.CurrentCell.RowIndex].Cells["clTenMonAn"].Value.ToString();
                TD.DeleteThucDon(conn, Ten, ID);
                MessageBox.Show("Xóa hoàn tất", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fFood_Load(sender, e);
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
