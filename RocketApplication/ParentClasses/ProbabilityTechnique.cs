using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.Techniques
{
    public abstract class ProbabilityTechnique
    {
        private Random _rand = new Random();

        public bool CalculateSuccessTechnique(int probabilty)
        {
            int number = _rand.Next(1, 101);

            if (number >= 1 && number <= probabilty)
            {
                return true;
            }

            return false;
        }
    }
}
