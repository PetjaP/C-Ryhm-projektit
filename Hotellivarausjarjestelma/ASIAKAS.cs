using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                komento.Parameters.Add("@ktu", MySqlDdType.VarChar).Value =kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu", MySqlDdType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if (ssana != "")
            {
                komento.Parameters.Add("@ssa", MySqlDdType.VarChar).Value = ssana;
            }
            else
            {
                komento.Parameters.Add("@ssa", MySqlDdType.VarChar).Value = "xcxcRT6!2@";
            }

            yhteys.avaayhteys();
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
    }
}
