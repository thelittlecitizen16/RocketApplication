using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Techniques
{
    public class ProbabilityOneHundredTechnique :  ITechnique
    {
        public string TechniqueName => "probability one hundred technique";

        public bool CalculateSuccessTechnique()
        {
            return true;
        }
    }
}
