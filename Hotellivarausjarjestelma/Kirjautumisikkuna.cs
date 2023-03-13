using MySql.Data.MySqlClient;
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
    public partial class Kirjautumisikkuna : Form
    {
        public Kirjautumisikkuna()
        {
            InitializeComponent();
        }
        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            // Käytetään itse luotua luokkaa
            Yhdista tietokantaan = new Yhdista();
            //Muuttujat yhdistämistä varten
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            
            MySqlCommand komento = new MySqlCommand();
           
            // Luodaan kysely
            String kysely = "SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @ktu AND salasana = @ssa";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.otaYhteys();

            // Lisätään lomakkeelta tiedot @kn ja @ss muuttujiin
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajaTunnusTB.Text;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salaSanaTB.Text;

            adapteri.SelectCommand= komento;
            adapteri.Fill(taulu); // Täyttää taulua
     

            // Tarkistetaan, että ovat salasana ja käyttäjätunnus tietokannassa.
            // Jos rivi tulee, niin nämä löytyivät tietokannasta
            if (taulu.Rows.Count > 0) 
            {
                // Lomakkeen piiloitus ja avataan pääikkuna.
                this.Hide();
               // Paaikkuna plomake = new Paaikkuna();
                PaaikkunaForm plomake = new PaaikkunaForm();
                plomake.Show();
            }
            else  // Muussa tapauksessa tarkistetaan jos jompikumpi on tyhjä
            { 
                if(kayttajaTunnusTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimesi kirjautuaksesi", "Käyttäjänimi on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (salaSanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi", "Salasana on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else  // Jos kentät on täytetty, mutta yhdistelmää ei löydy tietokannasta
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }     
        }   


    }
}
