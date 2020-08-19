using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;
using MenuBuilder.Interfaces;
namespace RocketApplication.Options
{
    public class OptionBatteryReport : IOption
    {
        public string OptionMessage => "get battery report";
        private Battery _battery;
        private ConsoleSystem _consoleSystem;

        public OptionBatteryReport(Battery battery, ConsoleSystem consoleSystem)
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
