using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVloApp
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the CityBikeCreator.");
            ClientCode(new CityBikeCreator());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ExplorerBikeCreator.");
            ClientCode(new ExplorerBikeCreator());
        }
        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class" + "but it still works. \n" + creator.SomeOperation());
        }
    }
}
