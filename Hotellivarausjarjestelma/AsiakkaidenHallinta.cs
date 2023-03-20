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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotellivarausjarjestelma
{
    public partial class AsiakkaidenHallinta : Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        
        public AsiakkaidenHallinta()
        {
            InitializeComponent();
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void AsiakkaidenHallinta_Load(object sender, EventArgs e, DataGridView asiakkatDG)
        {
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }

       

        private void kauttajaTunnusLB_Click(object sender, EventArgs e)
        {

        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = kauttajaTunnusTB.Text;
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
            if (asiakas.poistaAsiakas(ktunnus))
            {
                asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();

        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            {
                String enimi = eNimiTB.Text;
                String snimi = sNimiTB.Text;
                String osoite = osoiteTB.Text;
                String pnro = postiNumeroTB.Text;
                String ppaikka = postiNumeroTB.Text;
                String ktunnus = kauttajaTunnusTB.Text;
               

                if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Equals("") || ppaikka.Equals(""))
                {
                    MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, osoite, postinumero ja postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Boolean muokkaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, osoite, pnro, ppaikka, ktunnus);
                    if (muokkaaAsiakas)
                    {
                        MessageBox.Show("Uusi asiakas päivitetty onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Utta asiakasta ei pystyty päivittämään", "Asiakas muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    
                }
            }
        }


        //Näytetään listalta valitun asiakkaan tiedot testibokseissa
        private void asiakkaatDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eNimiTB.Text = asiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            sNimiTB.Text = asiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            osoiteTB.Text = asiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            postiNumeroTB.Text = asiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            postiTPTB.Text = asiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            kauttajaTunnusTB.Text = asiakkaatDG.CurrentRow.Cells[5].Value.ToString();

        }

        private void lisaaUusiAsBT_Click(object sender, EventArgs e)
        {
            String enimi = eNimiTB.Text;
            String snimi = sNimiTB.Text;
            String osoite = osoiteTB.Text;
            String pnro = postiNumeroTB.Text;
            String ppaikka = postiTPTB.Text;
            String ssana = salasanaTB.Text;
            String kayttaja = kauttajaTunnusTB.Text;

            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Equals("") || ppaikka.Equals(""))
            {
                
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, osoite, postinumero ja postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, osoite, pnro, ppaikka, kayttaja, ssana);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Utta asiakasta ei pystyty lisäämään", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            eNimiTB.Text = "";
            sNimiTB.Text = "";
            osoiteTB.Text = "";
            postiNumeroTB.Text = "";
            postiTPTB.Text = "";
            salasanaTB.Text = "";
            kauttajaTunnusTB.Text = "";
        }

        private void asiakkaatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void postiTPLB_Click(object sender, EventArgs e)
        {

        }
    }
}
