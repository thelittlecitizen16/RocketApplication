using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Techniques
{
    public class ProbabilityTwentyTechnique : ITechnique
    {
        public string TechniqueName => "probability twenty technique";
        private Random _rand;
        public ProbabilityTwentyTechnique()
        {
            _rand = new Random();
        }

        public bool CalculateSuccessTechnique()
        {
            int number = _rand.Next(1, 101);

            if (number>=1 && number<=20)
            {
                return true;
            }

            return false;
        }
    }
}
