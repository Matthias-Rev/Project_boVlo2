using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace BoVloApp
{
    public class GlobalVar
    {
        static public List<Button> GetAllButtons(Form f)
        {
            List<Button> resultList = new List<Button>();
            foreach (Control a in f.Controls)
            {
                if (a is Button)
                {
                    resultList.Add((Button)a);
                }
            }
            return resultList;
        }
        static public Point SetLocation(Form f, int x, int y, Control b)
        {
            int form_horizontal_center = f.Width / 2;
            int form_vertical_center = f.Height / 2;
            int x_mid = b.Width / 2;
            int y_mid = b.Height / 2;
            x = form_horizontal_center - x_mid + x;
            y = form_vertical_center - y_mid + y;
            return new Point(x,y);
        }
        static public string ReadXML(string key)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\..\Resources\sessionvariables.xml");
            XmlNodeList session_variables = xmlDoc.GetElementsByTagName(key);
            return session_variables[0].InnerText.ToString();

        }
        static public void ResetXML()
        {
            WriteXML("", "");
        }
        static public void WriteXML(string key, string value)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Session));
            using (StreamWriter writer = new StreamWriter(@"..\..\..\Resources\sessionvariables.xml"))
            {
                Session session = new Session();
                if(key == "username")
                {
                    session.username = value;
                }
                serializer.Serialize(writer, session);
                writer.Close();
            }
        }
        static public Menu menupage = new Menu();
        static public Catalogue cataloguepage = new Catalogue();
        public string username;
    }
}
