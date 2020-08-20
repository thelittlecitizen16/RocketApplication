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
            _consoleSystem.Write("Enter Rocket type from below:");

            PrintEnumTypes();

            string userRocketType = _consoleSystem.ReadString();

            CheckUserInput(userRocketType);
        }
        private void PrintEnumTypes()
        {
            foreach (string rocketType in Enum.GetNames(typeof(RocketType)))
            {
                _consoleSystem.Write(rocketType);
            }
        }

        private void CheckUserInput(string userRocketType)
        {
            if (RocketValidation.IsRocketTypeValid(userRocketType))
            {
                RocketType rocketType = (RocketType)Enum.Parse(typeof(RocketType), userRocketType);
                _rocketFactory.AddRocket(rocketType);
            }
            else
            {
                _consoleSystem.Write($"There is no rocket with the type: {userRocketType}");
            }      
        }
    }
}
