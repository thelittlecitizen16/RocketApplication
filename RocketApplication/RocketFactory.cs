using MenuBuilder;
using RocketApplication.ParentClasses;
using RocketApplication.Rockets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication
{
    public class RocketFactory
    {
        public Battery Battery;
        private ConsoleSystem _consoleSystem;
        public RocketFactory(Battery battery, ConsoleSystem consoleSystem)
        {
            Battery = battery;
            _consoleSystem = consoleSystem;
        }
       

        public void AddRocket(RocketType rocketType)
        {
            switch (rocketType)
            {
                case RocketType.Ballistic:
                    Battery.AddRocket(new Ballistic());
                    break;
                case RocketType.Cruise:
                    Battery.AddRocket(new Cruise());
                    break;
                case RocketType.Torpedo:
                    Battery.AddRocket(new Torpedo());
                    break;
                case RocketType.LongRange:
                    Battery.AddRocket(new LongRange(_consoleSystem)); 
                    break;
                default:
                    break;
            }
        }
    }
}
