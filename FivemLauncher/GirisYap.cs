using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FivemLauncher
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            KayitOl k = new KayitOl();
            this.Hide();
            k.ShowDialog();
            

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
