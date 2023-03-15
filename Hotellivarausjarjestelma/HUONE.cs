using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
    class HUONE
    {
        Yhdista yhteys = new Yhdista();

        
        //luodaan funktio uuden huoneen lisäämiseksi

        public bool lisaaHuone(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO huoneet " + "(huoneenNumero, huoneTyyppi, puhelin, vapaa) " + "VALUES (@hno, @hty, @puh, @vap); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;
           
            

            yhteys.avaaYhteys();
            try
            {
                if (komento.ExecuteNonQuery() == 1)
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
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }
        }

        //Luodaan funktio kaikkien huoneiden listaamiseksi 

        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT FROM huonekategoria", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }


        //Luodaan funktio asiakkaan huoneen muokkaamiseksi

        public bool muokkaaHuonetta(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `huoneet` SET `huoneTyyppi` = @hny," + "`puhelin` = @puh, `vapaa` = @vap" + " WHERE huoneenNro = @hno";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
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


        //Luodaan funktio huoneen poistamiseksi

        public bool poistaHuone(String hnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM huoneet WHERE huoneenNro = @hno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = hnro;

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
