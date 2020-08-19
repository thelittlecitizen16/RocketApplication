using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.Interfaces;
namespace RocketApplication.Options
{
    public class OptionEmptyingBattery : IOption
    {
        public string OptionMessage => "emptying battery";

        public void Run()
        {
        }
    }
}
