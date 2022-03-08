using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BoVloApp
{
    class Client
    {
        public void InstantiateBikes()
        {
            string requestBike = "SELECT * FROM Velo";

            DataTable veloDispo = GlobalVar.ReadSQL(requestBike);
            foreach (DataRow row in veloDispo.Rows)
            {
                if (row.ToString() == "City")
                {
                    CityBike City = new CityBike(); //doit-on déclarer les différentes variables? (type, prix, etc.) comment les liens entre tables sont-ils représentés sur c#?
                }
                if (row.ToString() == "Explorer")
                {
                    ExplorerBike Explorer = new ExplorerBike(); 
                }
                if (row.ToString() == "Adventure")
                {
                    AdventureBike Adventure = new AdventureBike();
                }
            }
        }
    }
}
