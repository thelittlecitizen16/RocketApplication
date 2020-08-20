using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Techniques
{
    public class ProbabilityTwentyTechnique : ProbabilityTechnique, ITechnique
    {
        public string TechniqueName => "probability twenty technique";

        public bool CalculateSuccessTechnique()
        {
            return CalculateSuccessTechnique(20);
        }
    }
}
