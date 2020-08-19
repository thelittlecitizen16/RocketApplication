using RocketApplication.ParentClasses;
using RocketApplication.Techniques;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Rockets
{
    public class Ballistic : IRocket
    {
        public RocketType RocketType { get; }
        public ITechnique Technique { get; }
        public bool TryLaunch { get; set; }

        public Ballistic(ITechnique technique = null)
        {
            Technique = technique ?? new ProbabilityFiftyTechnique();
            RocketType = RocketType.Ballistic;
            TryLaunch = false;
        }
        public bool IsSuccess()
        {
            return Technique.CalculateSuccessTechnique();
        }
    }
}
