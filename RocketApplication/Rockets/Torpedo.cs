using RocketApplication.ParentClasses;
using RocketApplication.Techniques;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Rockets
{
    public class Torpedo : IRocket
    {
        public RocketType RocketType { get; }

        public ITechnique Technique { get; }
        public bool TryLaunch { get; set; }

        public Torpedo(ITechnique technique = null)
        {
            Technique = technique ?? new ProbabilityOneHundredTechnique();
            RocketType = RocketType.Torpedo;
            TryLaunch = false;
        }
        public bool IsSuccess()
        {
            return Technique.CalculateSuccessTechnique();
        }
    }
}
