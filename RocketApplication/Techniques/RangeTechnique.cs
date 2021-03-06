﻿using MenuBuilder;
using MenuBuilder.Interfaces;
using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RocketApplication.Techniques
{
    public class RangeTechnique : ProbabilityTechnique, ITechnique
    {
        public string TechniqueName => "Range technique";
        private ISystem _consoleSystem;
        public RangeTechnique(ISystem consoleSystem)
        {
            _consoleSystem = consoleSystem;
        }
        public bool CalculateSuccessTechnique()
        {
            _consoleSystem.Write("Enter the target in KM");
            string userInputTarget = _consoleSystem.ReadString();

            return TryCalculateSuccessTechnique(userInputTarget);
        }
        private bool IsInputInRange(double target)
        {
            if (target >= 0 && target <= 1500)
            {
                return true;
            }

            return false;
        }

        private bool TryCalculateSuccessTechnique(string userInputTarget)
        {
            double target;

            if (double.TryParse(userInputTarget, out target))
            {
                if (IsInputInRange(target))
                {
                    int success = (int)(1500 - target) / 1500 * 100;

                    return CalculateSuccessTechnique(success);
                }
            }

            _consoleSystem.Write("To launch you need to enter a target between 0-1500");

            return false;
        }


    }
}
