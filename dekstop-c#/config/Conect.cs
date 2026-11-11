using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dekstop_c_.config
{
    internal class Conect
    {
        static string connect= "server=localhost;port=3306;database=db_spp_sekolah_xii;user=root;password=;";

        public static MySqlConnection koneksi()
        {
            MySqlConnection koneksi = new MySqlConnection(connect);
            try
            {
                koneksi.Open();
                return koneksi;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
