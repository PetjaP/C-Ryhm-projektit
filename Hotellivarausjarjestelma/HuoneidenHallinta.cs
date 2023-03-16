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
    public partial class HuoneidenHallinta : Form
    {
        public HuoneidenHallinta()
        {
            InitializeComponent();
        }
        HUONE huone = new HUONE();

        private void HuoneidenHallinta_Load(object sender, EventArgs e)
        {
            huoneTyyppiCB.DataSource = huone.huonetyyppilista();
            huoneTyyppiCB.DisplayMember = "huoneTyyppi";
            huoneTyyppiCB.ValueMember = "kategoriaID";

            huoneetDG.DataSource = huone.haeHuoneet();
        }


        private void uusiHuoneBT_Click(object sender, EventArgs e)
        {

        }
    }
}
