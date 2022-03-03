using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVloApp
{
    class AdventureBikeCreator : Creator
    {
        public override Bike FactoryMethhod()
        {
            return new AdventureBikeCreator();
        }
    }
}
