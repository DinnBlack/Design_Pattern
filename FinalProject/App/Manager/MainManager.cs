using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.MainUser;

namespace FinalProject.App.Manager
{
    public partial class MainManager : Form
    {
        public String userIDLogin;
        public MainManager()
        {
            InitializeComponent();
            Func.togglePanel(pnlManager, "NV");
        }
        public MainManager(string userIDLogin)
        {
            InitializeComponent();
            Func = new Func(this);
            this.userIDLogin = userIDLogin;
        }
        Func Func = new Func() ;
        private void btnNV_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlManager, "NV");
        }

        private void MainManager_Load(object sender, EventArgs e)
        {
            Func.togglePanel(pnlManager, "NV");
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlManager, "Luong");
            MessageBox.Show("Mua vip để mở tính năng này");
        }

        private void btnCH_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlManager, "DTManager");

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mua vip để mở tính năng này");
        }

        private void btnNL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mua vip để mở tính năng này");
        }
    }
}
