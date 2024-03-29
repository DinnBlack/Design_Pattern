using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Manager.ThucDon
{
    public partial class CardTDManager : UserControl
    {
        public CardTDManager()
        {
            InitializeComponent();
        }
        public void setChoice(Krypton.Toolkit.KryptonLabel lbl, Krypton.Toolkit.KryptonButton btn, Boolean flag)
        {
            int n = Int32.Parse(lbl.Text);
            if (flag)
            {
                lbl.Text = (n + 1).ToString();
            }
            else
            {
                if (n > 0)
                {
                    lbl.Text = (n - 1).ToString();
                }
            }
        }
        private void PlusItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, PlusItem1, true);
        }

        private void SubItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, SubItem1, false);
        }
    }
}
