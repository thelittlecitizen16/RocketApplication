using System;

namespace RocketApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery battery = new Battery();
            RocketFactory rocketFactory = new RocketFactory(battery);
            RocketMenu menuOption1 = new RocketMenu(rocketFactory , battery);
            menuOption1.RunMenu();
        }
    }
}
