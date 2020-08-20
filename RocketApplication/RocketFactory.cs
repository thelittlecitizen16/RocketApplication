using MenuBuilder;
using MenuBuilder.Interfaces;
using RocketApplication.ParentClasses;
using RocketApplication.Rockets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication
{
    public class RocketFactory : IRocketFactory
    {
        public IBattery Battery;
        private ISystem _consoleSystem;
        public RocketFactory(IBattery battery, ISystem consoleSystem)
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
