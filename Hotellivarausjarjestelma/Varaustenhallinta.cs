using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
    public partial class testLB : Form
    {
        HUONE huone = new HUONE();
        ASIAKAS asiakas = new ASIAKAS();
        VARAUS varaus = new VARAUS();
        public testLB()
        {
            InitializeComponent();
        }

        private void lisaaVarausBT_Click(object sender, EventArgs e)
        {
            int asiakas = Convert.ToInt32(asiakasNroCB.SelectedIndex.ToString());
            int huone = Convert.ToInt32(huoneenNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(sisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(ulosDTP.Value);

           
            if (varaus.lisaaVaraus(huone, asiakas, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            varauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void Varaustenhallinta_Load(object sender, EventArgs e)
        {
            // Haetaan listaus funktiosta huonetyyppilista
            // Huonetyypin nimen näyttäminen (DisplayMember)
            // Silti lähetetään eteenpäin kategoriaId (ValueMember)
            huoneTyyppiCB.DataSource = huone.huonetyyppilista();
            huoneTyyppiCB.DisplayMember = "huoneTyyppi";
            huoneTyyppiCB.ValueMember = "kategoriaID";

            asiakasNroCB.DataSource = asiakas.haeAsiakkaat();
            asiakasNroCB.DisplayMember = "etunimi" + "sukunimi";
            asiakasNroCB.ValueMember = "kayttajanimi";
            varauksetDG.DataSource = varaus.haeVaraukset();

        }
        private void huoneTyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // alin huonetyyppi on 1, mutta index alkaa 0, niin täytyy kasvattaa yhdellä
            int htyyppi = huoneTyyppiCB.SelectedIndex + 1;

            // Huoneiden numero haku huonetyyppien perusteella
            huoneenNroCB.DataSource = huone.tyyppilisetHuoneet(htyyppi);
            huoneenNroCB.DisplayMember = "huoneenNumero";
            huoneenNroCB.ValueMember = "huoneenNumero";

           
        }
        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            int huone = Convert.ToInt32(huoneenNroCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(asiakasNroCB.SelectedIndex.ToString());
            DateTime sisaan = Convert.ToDateTime(sisaanDTP.Value);
            DateTime ulos = Convert.ToDateTime(ulosDTP.Value);
            try
            {
                int vara = Convert.ToInt32(varausNroTB.Text);

                if(varaus.muokkaaVarausta(huone, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            varauksetDG.DataSource = varaus.haeVaraukset();
        }
        private void varauksetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void varauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            varausNroTB.Text = varauksetDG.CurrentRow.Cells[0].Value.ToString();
            huoneenNroCB.SelectedValue = Convert.ToInt32(varauksetDG.CurrentRow.Cells[1].Value.ToString());
            asiakasNroCB.SelectedIndex = Convert.ToInt32(varauksetDG.CurrentRow.Cells[2].Value.ToString());            
            sisaanDTP.Value = Convert.ToDateTime(varauksetDG.CurrentRow.Cells[3].Value);
            ulosDTP.Value = Convert.ToDateTime(varauksetDG.CurrentRow.Cells[4].Value);
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String varausnro = varausNroTB.Text;
                if (varaus.poistaVaraus(varausnro))
                {
                    varauksetDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tyhjennaBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            varausNroTB.Text = "";
            asiakasNroCB.SelectedIndex = -1;
            huoneenNroCB.SelectedIndex = 0;
            huoneTyyppiCB.SelectedIndex = 0;
            
            sisaanDTP.Value = DateTime.Now;
            ulosDTP.Value = DateTime.Now;

        }

       
    }
}
