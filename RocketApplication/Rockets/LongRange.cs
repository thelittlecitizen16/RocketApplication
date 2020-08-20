using MenuBuilder;
using MenuBuilder.Interfaces;
using RocketApplication.ParentClasses;
using RocketApplication.Techniques;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Rockets
{
    public class LongRange : IRocket
    {
        public RocketType RocketType { get; }

        public ITechnique Technique { get; }
        public bool TryLaunch { get; set; }

        public LongRange(ISystem consoleSystem , ITechnique technique = null)
        {
            Technique = technique ?? new RangeTechnique(consoleSystem);
            RocketType = RocketType.LongRange;
            TryLaunch = false;
        }

        public bool IsSuccess()
        {
            return Technique.CalculateSuccessTechnique();
        }
    }
}
