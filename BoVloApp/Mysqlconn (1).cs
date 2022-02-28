using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BoVloApp
{
    public class Mysqlconn
    {
        static public MySqlConnection connect()
        {
            MySqlConnection connection;
            string connetionString = "server=pat.infolab.ecam.be;port=63316;database=Bovlo;uid=BovloUser;pwd=Bovlopass;";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return connection;
            }
        }
        static public void disconnect(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}
