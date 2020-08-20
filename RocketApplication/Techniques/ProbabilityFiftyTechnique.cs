using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Techniques
{
    public class ProbabilityFiftyTechnique : ProbabilityTechnique, ITechnique
    {
        public string TechniqueName => "probability fifty technique";

        public bool CalculateSuccessTechnique()
        {
            return CalculateSuccessTechnique(50);
        }
    }
}
