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

namespace FinalProject.App.Staff
{
    public partial class MainStaff : Form
    {
        public string userIDLogin;
        Func Func = new Func();
        public MainStaff()
        {
            InitializeComponent();
        }
        public MainStaff(string userIDLogin)
        {
            InitializeComponent();
            Func = new Func(this);
            this.userIDLogin = userIDLogin;
        }
        private void btnTD_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnTD.Location.Y);
            Func.togglePanel(pnlMainStaff, "TDStaff");
        }

        private void MainStaff_Load(object sender, EventArgs e)
        {
            btnlogo.Select();
            Func.togglePanel(pnlMainStaff, "TDStaff");
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnKM.Location.Y);
            Func.togglePanel(pnlMainStaff, "KMStaff");
        }

        private void btnGH_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnGH.Location.Y);
            Func.togglePanel(pnlMainStaff, "GHStaff");

        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(1, btnCD.Location.Y);
            Func.togglePanel(pnlMainStaff, "CDStaff");

        }
    }
}
