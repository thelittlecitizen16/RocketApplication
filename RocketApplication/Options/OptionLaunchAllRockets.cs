using MenuBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Options
{
    public class OptionLaunchAllRockets : IOption
    {
        public string OptionMessage => "launch all Rockets from battery";

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
