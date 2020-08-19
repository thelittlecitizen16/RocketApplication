using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.Interfaces;
namespace RocketApplication.Options
{
    public class OptionBatteryReport : IOption
    {
        public string OptionMessage => "get battery report";

        public void Run()
        {
        }
    }
}
