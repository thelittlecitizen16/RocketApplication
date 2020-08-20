using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;
using MenuBuilder.Interfaces;
using RocketApplication.ParentClasses;

namespace RocketApplication.Options
{
    public class OptionBatteryReport : IOption
    {
        public string OptionMessage => "get battery report";
        private IBattery _battery;
        private ISystem _consoleSystem;

        public OptionBatteryReport(IBattery battery, ISystem consoleSystem)
        {
            _battery = battery;
            _consoleSystem = consoleSystem;
        }
        public void Run()
        {
            _consoleSystem.Write($"the rockets amount: {_battery.RocketsAmount().ToString()}");
            _consoleSystem.Write($"All Rockets: ");

            foreach (var rocketData in _battery.GetAllRocketsData())
            {
                _consoleSystem.Write(rocketData);
            }
        }
    }
}
