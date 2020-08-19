using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.Interfaces;
namespace RocketApplication.Options
{
    public class OptionAddRocket : IOption
    {
        public string OptionMessage => "Add Rocket To Battery";

        public void Run()
        {
        }
    }
}
