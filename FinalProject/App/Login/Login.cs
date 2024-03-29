using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.MainUser;

namespace FinalProject.App.Login
{
    public partial class Login : Form
    {
        public static String name = "DN";
        public  event Action Something;
        public Login()
        {
            InitializeComponent();
        }
        Func Func=new Func();
        private UCDN uCDN;
        private void Login2_Load(object sender, EventArgs e)
        {
            Func.togglePanel(panel_login, name);
            MinimizeBox = false;
            MaximizeBox= false;
            UCDN Item = new UCDN();
        }
    }
}
