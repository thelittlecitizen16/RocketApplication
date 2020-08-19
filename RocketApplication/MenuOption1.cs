using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;
using MenuBuilder.Interfaces;
using MenuBuilder.Options;
using RocketApplication.ParentClasses;
using RocketApplication.Options;

namespace RocketApplication
{
    public class MenuOption1  : MenuOption
    {
        private OptionAddRocket _optionAddRocket;
        private OptionBatteryReport _optionBatteryReport;
        private OptionEmptyingBattery _optionEmptyingBattery;
        private OptionLaunchAllRockets _optionLaunchAllRockets;
        private OptionLaunchRockets _optionLaunchRockets;
        private ExitOption _exitOption;
        private MenuOption<string> _menuOption;

        public MenuOption1() : base()
        {
            _optionAddRocket = new OptionAddRocket();
            _optionBatteryReport = new OptionBatteryReport();
            _optionEmptyingBattery = new OptionEmptyingBattery();
            _optionLaunchAllRockets = new OptionLaunchAllRockets();
            _optionLaunchRockets = new OptionLaunchRockets();
            _exitOption = new ExitOption();
        }

        public void RunMenu()
        {
            var menu1 = MenuBuilderString
               .AddOption("Launch rocket from one kind", _optionLaunchRockets)
               .AddOption("TotalWar", _optionLaunchRockets)
               .Build();

            _menuOption = new MenuOption<string>(menu1, "launch rocket menu");

            var menu2 = MenuBuilderInt
                .AddOption(1, _optionAddRocket)
                .AddOption(2, _menuOption)
                .AddOption(3, _optionBatteryReport)
                .AddOption(4, _optionEmptyingBattery)
                .AddOption(5, _exitOption)
                .Build();

            menu2.RunMenu();
        }
    }
}
