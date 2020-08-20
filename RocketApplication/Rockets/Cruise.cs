using RocketApplication.ParentClasses;
using RocketApplication.Techniques;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Rockets
{
    public class Cruise : IRocket
    {
        public RocketType RocketType { get; }

        public ITechnique Technique { get; }
        public bool TryLaunch { get; set; }

        public Cruise(ITechnique technique = null)
        {
            Technique = technique ?? new ProbabilityTwentyTechnique();
            RocketType = RocketType.Cruise;
            TryLaunch = false;
        }
        public bool IsSuccess()
        {
            return Technique.CalculateSuccessTechnique();
        }
    }
}
