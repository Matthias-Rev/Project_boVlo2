using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVloApp
{
    class AdventureBike : Bike
    {
        public string type;
        public string quantity;
        public string colour;
        public string size;
        public string price;

        public virtual String GetInfo()
        {
            return String.Format("Type is {0}, quantity is {1}, colours is {2}, size is {3} and price is {4}.", type, quantity, colour, size, price);
        }
    }
}
