using FinalProject.App;
using FinalProject.App.Admin;
using FinalProject.App.Admin.ThongBao;
using FinalProject.App.Login;
using FinalProject.App.Main;
using FinalProject.App.Main.CaiDat;
using FinalProject.App.Main.GioHang;
using FinalProject.App.Main.ThucDon;
using FinalProject.App.Manager;
using FinalProject.App.Staff.GioHang;
using FinalProject.App.Staff.KhuyenMai;
using FinalProject.App.Staff.ThucDon;
using FinalProject.DTO;
using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.App.Staff;
using FinalProject.App.Staff.CaiDat;
using FinalProject.App.Manager.DoanhThu;
using FinalProject.App.Manager.ThucDon;

namespace FinalProject
{
    public partial class MainUser : Form
    {
        private string userIDLogin; 
        Func func;
        public MainUser()
        {
            File ehe = new File();
            string lang = ehe.readLanguage();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            InitializeComponent();
            func = new Func(this);
        }
        public MainUser(string userIDLogin)
        {
            File ehe = new File();
            string lang = ehe.readLanguage();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            InitializeComponent();
            func = new Func(this);
            this.userIDLogin = userIDLogin;
        }
        private void btnTD_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnTD.Location.Y);
            func.togglePanel(panel_main, "TD");
        }
        private void btnKM_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnKM.Location.Y);
            func.togglePanel(panel_main, "KM");
        }
        private void btnCH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnCH.Location.Y);
            func.togglePanel(panel_main, "CH");
        }
        private void btnGH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnGH.Location.Y);
            func.togglePanel(panel_main, "GH");
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnTB.Location.Y);
            func.togglePanel(panel_main, "TB");
        }
        private void btnCD_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnCD.Location.Y);
            func.togglePanel(panel_main, "CD");
        }
        private void btnlogo_Click(object sender, EventArgs e)
        {
            func.togglePanel(panel_main, "Main");
        }
        private void Main_Load(object sender, EventArgs e)
        {
            btnlogo.Select();
            func.togglePanel(panel_main, "Main");
        }
        public class Func
        {
            private MainAdmin mainAdmin;
            private MainStaff mainStaff;
            private MainManager mainManager;
            private MainUser main;
            public Func(MainUser main)
            {
                this.main = main;
            }
            public Func(MainAdmin main)
            {
                this.mainAdmin = main;
            }
            public Func(MainStaff main)
            {
                this.mainStaff = main;
            }
            public Func(MainManager main)
            {
                this.mainManager = main;
            }
            public Func( )
            {

            }
            //User
            private static UCTD uCTD;
            private static UCMain uCMain;
            private static UCKM uCKM;
            private static UCCD uCCD;
            private static UCGH uCGH;
            private static UCCH uCCH;
            private static UCTB uCTB;
            private static UCDN uCDN;
            private static UCDK uCDK;
            private static CardTD cardTD;
            private static CardDH cardDH;
            private static CardKM cardKM;
            //Admin
            private static UCTK uCTK;
            private static UCKMAdmin uCKMAdmin;
            private static UCDTAdmin uCDT;
            private static UCTBAdmin uCTBAdmin;
            //Staff
            private static UCTDStaff uCTDStaff;
            private static UCKMStaff uCKMStaff;
            private static UCGHStaff uCGHStaff;
            private static UCCDStaff uCCDStaff;
            //Manager
            private static UCNV uCNV;
            private static UCLuong uCLuong;
            private static UCDTManager uCDTManager;
            public void togglePanel(Panel panel, String panelName)
            {
                
                panel.Controls.Clear();
                panel.AutoScroll = true;
                switch (panelName)
                {
                    case "Main":
                        uCMain = null;
                        if (uCMain == null)
                        {
                            uCMain = new UCMain(main.userIDLogin);
                            panel.Controls.Add(uCMain);
                            uCMain.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCMain.Location = new System.Drawing.Point(0, 0);
                            uCMain.TabIndex = 0;
                            uCMain.AutoScroll = true;
                        }
                        else
                        {
                            panel.Controls.Add(uCMain);
                        }
                        break;
                    case "TD":
                        uCTD = null;
                        if (uCTD == null)
                        {
                            uCTD = new UCTD(main.userIDLogin);
                            panel.Controls.Add(uCTD);
                            uCTD.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTD.Location = new System.Drawing.Point(0, 0);
                            uCTD.TabIndex = 0;
                            uCTD.AutoScroll = true;
                        }
                        else
                        {
                            panel.Controls.Add(uCTD);
                        }
                        break;
                    case "KM":
                        if (uCKM == null)
                        {
                            uCKM = new UCKM();
                            panel.Controls.Add(uCKM);
                            uCKM.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCKM.Location = new System.Drawing.Point(0, 0);
                            uCKM.Name = "uCKM";
                            uCKM.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCKM);
                        }
                        break;
                    case "TB":
                        if (uCTB == null)
                        {
                            uCTB = new UCTB();
                            panel.Controls.Add(uCTB);
                            uCTB.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTB.Location = new System.Drawing.Point(0, 0);
                            uCTB.Name = "uCTB";
                            uCTB.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCTB);
                        }
                        break;
                    case "GH":
                        uCGH = null;
                        if (uCGH == null)
                        {
                            uCGH = new UCGH(main.userIDLogin);
                            panel.Controls.Add(uCGH);
                            uCGH.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCGH.Location = new System.Drawing.Point(0, 0);
                            uCGH.Name = "uCGH";
                            uCGH.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCGH);
                        }
                        break;
                    case "CD":
                        if (uCCD == null)
                        {
                            uCCD = new UCCD(main.userIDLogin);
                            panel.Controls.Add(uCCD);
                            uCCD.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCCD.Location = new System.Drawing.Point(0, 0);
                            uCCD.Name = "uCCD";
                            uCCD.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCCD);
                        }
                        break;
                    case "CH":
                        if (uCCH == null)
                        {
                            uCCH = new UCCH();
                            panel.Controls.Add(uCCH);
                            uCCH.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCCH.Location = new System.Drawing.Point(0, 0);
                            uCCH.Name = "uCCH";
                            uCCH.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCCH);
                        }
                        break;
                    case "DN":

                        uCDN = new UCDN();
                        panel.Controls.Add(uCDN);
                        uCDN.Dock = System.Windows.Forms.DockStyle.Fill;
                        uCDN.Location = new System.Drawing.Point(0, 0);
                        uCDN.Name = "uCDN";
                        uCDN.TabIndex = 0;
                        break;
                    case "DK":
                        uCDK = new UCDK();
                        panel.Controls.Add(uCDK);
                        uCDK.Dock = System.Windows.Forms.DockStyle.Fill;
                        uCDK.Location = new System.Drawing.Point(0, 0);
                        uCDK.Name = "uCDK";
                        uCDK.TabIndex = 0;
                        break;
                    case "CardTD":
                        if (cardTD == null)
                        {
                            cardTD = new CardTD();
                            panel.Controls.Add(cardTD);
                            cardTD.Dock = System.Windows.Forms.DockStyle.Fill;
                            cardTD.Location = new System.Drawing.Point(0, 0);
                            cardTD.Name = "cardTD";
                            cardTD.TabIndex = 0;
                            cardTD.AutoScroll = true;
                        }
                        else
                        {
                            panel.Controls.Add(cardTD);
                        }
                        break;
                    case "CardDH":
                        if (cardDH == null)
                        {
                            cardDH = new CardDH();
                            panel.Controls.Add(cardDH);
                            cardDH.Dock = System.Windows.Forms.DockStyle.Fill;
                            cardDH.Location = new System.Drawing.Point(0, 0);
                            cardDH.Name = "cardDH";
                        }
                        else
                        {
                            panel.Controls.Add(cardDH);
                        }
                        break;
                    case "CardKM":
                        if (cardKM == null)
                        {
                            cardKM = new CardKM();
                            panel.Controls.Add(cardKM);
                            cardKM.Dock = System.Windows.Forms.DockStyle.Fill;
                            cardKM.Location = new System.Drawing.Point(0, 0);
                            cardKM.Name = "cardKM";
                        }
                        else
                        {
                            panel.Controls.Add(cardKM);
                        }
                        break;
                    case "TK":
                        if (uCTK == null)
                        {
                            uCTK = new UCTK();
                            panel.Controls.Add(uCTK);
                            uCTK.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTK.Location = new System.Drawing.Point(0, 0);
                            uCTK.Name = "uCTK";
                            uCTK.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCTK);
                        }
                        break;
                    case "KMAdmin":
                        if (uCKMAdmin == null)
                        {
                            uCKMAdmin = new UCKMAdmin();
                            panel.Controls.Add(uCKMAdmin);
                            uCKMAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCKMAdmin.Location = new System.Drawing.Point(0, 0);
                            uCKMAdmin.Name = "uCKMAdmin";
                            uCKMAdmin.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Clear();
                            panel.Controls.Add(uCKMAdmin);
                        }
                        break;
                    case "DT":
                        if (uCDT == null)
                        {
                            uCDT = new UCDTAdmin();
                            panel.Controls.Add(uCDT);
                            uCDT.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCDT.Location = new System.Drawing.Point(0, 0);
                            uCDT.Name = "uCDT";
                            uCDT.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCDT);
                        }
                        break;
                    case "TBAdmin":
                        if (uCTBAdmin == null)
                        {
                            uCTBAdmin = new UCTBAdmin();
                            panel.Controls.Add(uCTBAdmin);
                            uCTBAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTBAdmin.Location = new System.Drawing.Point(0, 0);
                            uCTBAdmin.Name = "uCTBAdmin";
                            uCTBAdmin.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCTBAdmin);
                        }
                        break;
                    case "TDStaff":
                        if (uCTDStaff == null)
                        {
                            uCTDStaff = new UCTDStaff(mainStaff.userIDLogin);
                            panel.Controls.Add(uCTDStaff);
                            uCTDStaff.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTDStaff.Location = new System.Drawing.Point(0, 0);
                            uCTDStaff.Name = "uCTDStaff";
                            uCTDStaff.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCTDStaff);
                        }
                        break;
                    case "KMStaff":
                        uCKMStaff = null;
                        if (uCKMStaff == null)
                        {
                            uCKMStaff = new UCKMStaff(mainStaff.userIDLogin);
                            panel.Controls.Add(uCKMStaff);
                            uCKMStaff.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCKMStaff.Location = new System.Drawing.Point(0, 0);
                            uCKMStaff.Name = "uCKMStaff";
                            uCKMStaff.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCKMStaff);
                        }
                        break;
                    case "GHStaff":
                        uCGHStaff = null;
                        if (uCGHStaff == null)
                        {
                            uCGHStaff = new UCGHStaff(mainStaff.userIDLogin);
                            panel.Controls.Add(uCGHStaff);
                            uCGHStaff.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCGHStaff.Location = new System.Drawing.Point(0, 0);
                            uCGHStaff.Name = "uCGHStaff";
                            uCGHStaff.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCGHStaff);
                        }
                        break;
                    case "CDStaff":
                        if (uCCDStaff == null)
                        {
                            uCCDStaff = new UCCDStaff(mainStaff.userIDLogin);
                            panel.Controls.Add(uCCDStaff);
                            uCCDStaff.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCCDStaff.Location = new System.Drawing.Point(0, 0);
                            uCCDStaff.Name = "uCCDStaff";
                            uCCDStaff.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCCDStaff);
                        }
                        break;
                    case "NV":
                        if (uCNV == null)
                        {
                            uCNV = new UCNV(mainManager.userIDLogin);
                            panel.Controls.Add(uCTBAdmin);
                            uCNV.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCNV.Location = new System.Drawing.Point(0, 0);
                            uCNV.Name = "uCNV";
                            uCNV.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCNV);
                        }
                        break;
                    case "Luong":
                        if (uCLuong == null)
                        {
                            uCLuong = new UCLuong();
                            panel.Controls.Add(uCLuong);
                            uCLuong.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCLuong.Location = new System.Drawing.Point(0, 0);
                            uCLuong.Name = "uCLuong";
                            uCLuong.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCLuong);
                        }
                        break;
                    case "DTManager":
                        if (uCDTManager == null)
                        {
                            uCDTManager = new UCDTManager(mainManager.userIDLogin);
                            panel.Controls.Add(uCDTManager);
                            uCDTManager.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCDTManager.Location = new System.Drawing.Point(0, 0);
                            uCDTManager.Name = "uCDTManager";
                            uCDTManager.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCDTManager);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        
    }
}
