using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Techniques
{
    public class ProbabilityFiftyTechnique : ITechnique
    {
        public string TechniqueName => "probability fifty technique";
        private Random _rand;
        public ProbabilityFiftyTechnique()
        {
            _rand = new Random();
        }

        public bool CalculateSuccessTechnique()
        {
            int number = _rand.Next(1, 101);

            if (number >= 1 && number <= 50)
            {
                return true;
            }

            return false;
        }
    }
}
