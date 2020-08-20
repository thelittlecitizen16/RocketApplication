using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;
using MenuBuilder.Interfaces;
using RocketApplication.ParentClasses;

namespace RocketApplication.Options
{
    public class OptionEmptyingBattery : IOption
    {
        public string OptionMessage => "emptying battery";
        private IBattery _battery;
        private ISystem _consoleSystem;

        public OptionEmptyingBattery(IBattery battery, ISystem consoleSystem)
        {
            _battery = battery;
            _consoleSystem = consoleSystem;
        }

        public void Run()
        {
            _consoleSystem.Write("Enter place to empting the rocket");
            string userInputPlace = _consoleSystem.ReadString();

            int place;
            if (int.TryParse(userInputPlace,out place))
            {
                TryEmptingByPlace(place-1);
            }
            else
            {
                _consoleSystem.Write("place need to be a number");
            }
        }

        private void TryEmptingByPlace(int place)
        {
            if (_battery.EmptyingByPlace(place))
            {
                _consoleSystem.Write("success to empty");
            }
            else
            {
                _consoleSystem.Write($"there is no place {place} in the battery with rocket");
            }
        }
    }
}
