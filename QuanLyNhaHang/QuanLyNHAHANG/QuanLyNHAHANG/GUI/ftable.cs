using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNHAHANG.GUI
{
    public partial class ftable : Form
    {
        SqlConnection conn { get; set; }
        public ftable(object sender, EventArgs e)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {

        }
    }
}
