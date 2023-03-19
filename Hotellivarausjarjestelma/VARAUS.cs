using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Hotellivarausjarjestelma
{
    internal class VARAUS
    {
        
      Yhdista yhteys = new Yhdista();

        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * from huonekategoria", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * from varaukset", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        // Funktio asiakkaan tietojen lisäämiseksi
        public bool lisaaVaraus(int hnro, int aid, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT into `varaukset`" + "(huoneenNro, asiakasId, sisaan, ulos)" +
                                  "VALUES (@hno, @aid, @sis, @ulo); "; 

            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            
            
            //@hno @aid @sis @ulo
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = aid;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
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
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }  
            
        }   
        public bool muokkaaVarausta(int hnro, int aid, DateTime sisaan, DateTime ulos, int vara)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `varaukset` SET `huoneenNro`= @hno," +
                                    "`asiakasId` = @aid,`sisaan`= @sis,`ulos`= @ulo" +
                                    " WHERE varausId = @vid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            // @hno @aid @sis @ulo @vid
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = aid;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
            komento.Parameters.Add("@vid", MySqlDbType.Int32).Value = vara;

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
        public bool poistaVaraus(String varausnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM varaukset WHERE varausId = @vno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            //ktu
            komento.Parameters.Add("@vno", MySqlDbType.Int32).Value = varausnro;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery()==1)
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
