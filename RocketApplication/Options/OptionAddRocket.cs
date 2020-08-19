using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;
using MenuBuilder.Interfaces;
namespace RocketApplication.Options
{
    public class OptionAddRocket : IOption
    {
        public string OptionMessage => "Add Rocket To Battery";
        private RocketFactory _rocketFactory;
        private ConsoleSystem _consoleSystem;

        public OptionAddRocket(RocketFactory rocketFactory, ConsoleSystem consoleSystem)
        {
            _rocketFactory = rocketFactory;
            _consoleSystem = consoleSystem;
        }

        public void Run()
        {
            _consoleSystem.Write("Enter the Rocket type:");
            string userRocketType = _consoleSystem.ReadString();

            CheckUserInput(userRocketType);
        } 

        private void CheckUserInput(string userRocketType)
        {
            RocketType rocketType;

            if (Enum.TryParse(userRocketType, out rocketType))
            {
                _rocketFactory.AddRocket(rocketType);
            }
            else
            {
                _consoleSystem.Write($"There is no rocket with the type: {userRocketType}");
            }
        }
    }
}
