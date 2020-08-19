using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.Interfaces;

namespace RocketApplication.Options
{
    public class OptionLaunchRockets : IOption
    {
        public string OptionMessage => "launch Rockets from battery";

        public void Run()
        {
        }
    }
}
