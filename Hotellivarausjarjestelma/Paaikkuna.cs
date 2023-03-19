using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellivarausjarjestelma
{
    public partial class PaaikkunaForm : Form
    {
        public PaaikkunaForm()
        {
            InitializeComponent();
        }

        private void PaaikkunaForm_Load(object sender, EventArgs e)
        {

        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsiakkaidenHallinta asiHallinta = new AsiakkaidenHallinta();
            asiHallinta.Show();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testLB varKallinta = new testLB();
            varKallinta.Show();
        }

        private void hallitseHuoneitaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HuoneidenHallinta huoHallinta = new HuoneidenHallinta();
            huoHallinta.Show();
        }
    }
}
