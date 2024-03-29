using FinalProject.App.Login;
using FinalProject.App.Admin;
using FinalProject.App.Main;

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
using FinalProject.App.Staff;

namespace FinalProject.App.Admin
{
    public partial class MainAdmin : Form
    {
        private string userIDLogin;
        Func Func;
        public MainAdmin()
        {
            InitializeComponent();
            Func = new Func(this);
        }
        public MainAdmin(string userIDLogin)
        {
            InitializeComponent();
            Func = new Func(this);
            this.userIDLogin = userIDLogin;
        }
        private void MainAdmin_Load(object sender, EventArgs e)
        {
            Func.togglePanel(pnlAdmin, "TK");
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnKM.Location.Y);
            Func.togglePanel(pnlAdmin, "KMAdmin");
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnTB.Location.Y);
            Func.togglePanel(pnlAdmin, "TBAdmin");
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnDT.Location.Y);
            Func.togglePanel(pnlAdmin, "DT");
        }

        private void btnTD_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnTD.Location.Y);
            Func.togglePanel(pnlAdmin, "TK");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
