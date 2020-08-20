using MenuBuilder;
using MenuBuilder.Interfaces;
using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Options
{
    public class OptionLaunchAllRockets : IOption
    {
        public string OptionMessage => "launch all Rockets from battery";
        private IBattery _battery;
        private ISystem _consoleSystem;

        public OptionLaunchAllRockets(IBattery battery, ISystem consoleSystem)
        {
            _battery = battery;
            _consoleSystem = consoleSystem;
        }
        public void Run()
        {
            int amountIfAll = _battery.RocketsAmount();
            int amountOfSuccess = _battery.LaunchAllRockets();

            _consoleSystem.Write($"from {amountIfAll} rockets in battery, {amountOfSuccess} success to launch");
        }
    }
}
