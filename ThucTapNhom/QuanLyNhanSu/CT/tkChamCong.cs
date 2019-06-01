using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.ThongKe
{
    public partial class tkChamCong : UserControl
    {
        public tkChamCong()
        {
            InitializeComponent();
        }

        private void tkChamCong_Load(object sender, EventArgs e)
        {

        }

        private void rdNTT_CheckedChanged(object sender, EventArgs e)
        {
          
            pnLoad.Controls.Clear();
           
        }

        private void rdNCP_CheckedChanged(object sender, EventArgs e)
        {
            
            pnLoad.Controls.Clear();
           
        }

        private void rdKN_CheckedChanged(object sender, EventArgs e)
        {
           
            pnLoad.Controls.Clear();
           
        }

        private void rdNNN_CheckedChanged(object sender, EventArgs e)
        {
           
            pnLoad.Controls.Clear();
           
        }

        private void rdNCPNN_CheckedChanged(object sender, EventArgs e)
        {
          
            pnLoad.Controls.Clear();
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
            pnLoad.Controls.Clear();
          
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           
            pnLoad.Controls.Clear();
          
        }
    }
}
