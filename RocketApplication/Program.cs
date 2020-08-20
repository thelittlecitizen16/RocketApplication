using System;
using MenuBuilder;

namespace RocketApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery battery = new Battery();
            ConsoleSystem consoleSystem = new ConsoleSystem();
            RocketFactory rocketFactory = new RocketFactory(battery, consoleSystem);
            RocketMenu menuOption1 = new RocketMenu(rocketFactory , battery);

            menuOption1.RunMenu();
        }
    }
}
