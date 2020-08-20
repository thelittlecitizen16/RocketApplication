using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;
using MenuBuilder.Interfaces;

namespace RocketApplication.Options
{
    public class OptionLaunchRockets : IOption
    {
        public string OptionMessage => "launch Rockets from battery";
        private Battery _battery;
        private ConsoleSystem _consoleSystem;

        public OptionLaunchRockets(Battery battery, ConsoleSystem consoleSystem)
        {
            _battery = battery;
            _consoleSystem = consoleSystem;
        }

        public void Run()
        {
            _consoleSystem.Write("Enter rocket type you want to launch from below:");
            PrintEnumTypes();
            string userRocketType = _consoleSystem.ReadString();

            _consoleSystem.Write("Enter rocket amount to launch");
            string userRocketAmount = _consoleSystem.ReadString();

            CheckUserInput(userRocketType, userRocketAmount);
        }
        private void PrintEnumTypes()
        {
            foreach (string rocketType in Enum.GetNames(typeof(RocketType)))
            {
                _consoleSystem.Write(rocketType);
            }
        }

        private void CheckUserInput(string userRocketType, string userRocketAmount)
        {
            if (RocketValidation.IsRocketTypeValid(userRocketType))
            {
                RocketType rocketType = (RocketType)Enum.Parse(typeof(RocketType), userRocketType);
                int amount = int.Parse(userRocketAmount);

                int amontRoketlaunch = _battery.LaunchFewRockets(rocketType, amount);
                _consoleSystem.Write($"the rocket amount success to launch: {amontRoketlaunch.ToString()}");
            }
            else
            {
                _consoleSystem.Write($"There is no rocket with the type: {userRocketType}");
            }
        }
    }
}
