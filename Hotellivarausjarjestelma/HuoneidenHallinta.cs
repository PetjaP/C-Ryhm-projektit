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
            huoneetDG.DataSource = huone.haeHuoneet();
            huoneTyyppiCB.DataSource = huone.huonetyyppilista();
            huoneTyyppiCB.DisplayMember = "huoneTyyppi";
            huoneTyyppiCB.ValueMember = "kategoriaID";
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
            int numero = Convert.ToInt32(huoneenNumeroTB.Text);
            int tyyppi = Convert.ToInt32(huoneTyyppiCB.SelectedValue.ToString());
           // String tyyppi = huoneTyyppiCB.Text;
            String puhelin = puhelinTB.Text;
            if(huone.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            huoneetDG.DataSource = huone.haeHuoneet();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            huoneenNumeroTB.Text = "";
            huoneTyyppiCB.SelectedIndex= 0;
            puhelinTB.Text = "";
        }

        private void huoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
               {

            
                huoneenNumeroTB.Text = huoneetDG.CurrentRow.Cells[0].Value.ToString();
                huoneTyyppiCB.SelectedValue = huoneetDG.CurrentRow.Cells[1].Value.ToString();
                puhelinTB.Text = huoneetDG.CurrentRow.Cells[2].Value.ToString();

                }
            catch
            {
                MessageBox.Show("Huone on tyhjä", "Huone on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(huoneTyyppiCB.SelectedValue.ToString());
            String puhelin = puhelinTB.Text;
            String vapaa = "";
            try
            {
                int numero = Convert.ToInt32(huoneenNumeroTB.Text);
                if(kyllaRB.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if(eiRB.Checked)
                {
                    vapaa = "Ei";

                }
                if(huone.muokkaaHuonetta(numero,tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         huoneetDG.DataSource = huone.haeHuoneet();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String huonenro = huoneenNumeroTB.Text;
                if(huone.poistaHuone(huonenro))
                {
                    huoneetDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tyhjennaBT.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
        }

        private void HuoneidenHallinta_Load_1(object sender, EventArgs e)
        {

        }
    }
}
