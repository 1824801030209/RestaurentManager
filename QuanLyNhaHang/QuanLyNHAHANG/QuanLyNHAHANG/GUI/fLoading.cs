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

namespace QuanLyNHAHANG.GUI
{
    public partial class fLoading : Form
    {
        SqlConnection conn { get; set; }
        public fLoading()
        {
            InitializeComponent();
            this.conn = conn;
            timer1.Enabled = true;
        }
        void NextForm()
        {
            fLogin f = new fLogin(conn);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }


        private void fLoading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            NextForm();
        }
    }
}
