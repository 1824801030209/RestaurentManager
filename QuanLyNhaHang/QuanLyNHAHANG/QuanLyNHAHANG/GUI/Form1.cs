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
        public Form1(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            f.ShowDialog();
        }
    }
}
