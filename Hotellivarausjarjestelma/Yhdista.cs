using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
    class Yhdista
    {
        //   public string yhteyslause()
        private MySqlConnection yhteys = new MySqlConnection("datasource=sql7.freesqldatabase.com; port=3306; username=sql7604185; password=JpwQnlPbS5; database=sql7604185");
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
