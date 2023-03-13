using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotellivarausjarjestelma
{
    class ASIAKAS
    {
        Yhdista yhteys = new Yhdista();


        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String kayttaja, String ssana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO asiakkaat " + "(kayttajanimi, etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, salasana) " + "VALUES (@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            if(kayttaja !="")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value =kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if (ssana != "")
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = ssana;
            }
            else
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = "xcxcRT6!2@";
            }

            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.avaaYhteys();
                return false; 
            }
        }

        //Luodaan funktio kaikkien asiakastietojan hakemiseksi 

        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, kayttajanimi FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri= new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand= komento;
            adapteri.Fill(taulu);

            return taulu;
        }


        //Luodaan funktio asiakkaan tietojen muokkaamiseksi

        public bool muokkaaAsiakasta(String enimi, String snimi, String osoite, String pnro, String ppaikka, String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `asiakkaat` SET `etunimi` = @enm," + "`sukunimi` = @snm, `lahiosoite` = @oso, `postinumero` = @pno, `postitoimipaikka` = @ptp" + " WHERE kayttajanimi = @ktu";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;


            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.avaaYhteys();
                return false;
            }
        }


        //Luodaan funktio asiakkaan tietojen poistamiseen

        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM asiakkaat WHERE kayttajanimi = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
