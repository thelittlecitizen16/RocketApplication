using MenuBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.ParentClasses
{
    public abstract class MenuOption
    {
        public MenuBuilder<string> MenuBuilderString;
        public MenuBuilder<int> MenuBuilderInt;
        public Menu<int> Menu;
        public ConsoleSystem ConsoleSystem;
        public Validation Validation;

        public MenuOption()
        {
            ConsoleSystem = new ConsoleSystem();
            Validation = new Validation();
            MenuBuilderString = new MenuBuilder<string>(ConsoleSystem, Validation);
            MenuBuilderInt = new MenuBuilder<int>(ConsoleSystem, Validation);
        }

    }
}
