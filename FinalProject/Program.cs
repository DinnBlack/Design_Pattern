using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.App.Admin;
using FinalProject.App.Login;
using FinalProject.App.Staff;
using FinalProject.App.Manager;

using Krypton.Toolkit;

namespace FinalProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUser("UID00001"));
        }
    }
}
