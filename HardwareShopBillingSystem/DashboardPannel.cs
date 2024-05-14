using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareShopBillingSystem
{
    public partial class DashboardPannel : Form
    {
        public DashboardPannel()
        {
            InitializeComponent();
        }

        private void btnWindowClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
