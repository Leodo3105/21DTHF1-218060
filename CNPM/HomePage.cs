using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmQLSP qlsp = new frmQLSP();
            qlsp.ShowDialog();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmQLKH qLKH = new frmQLKH();
            qLKH.ShowDialog();
        }
        
    }
}
