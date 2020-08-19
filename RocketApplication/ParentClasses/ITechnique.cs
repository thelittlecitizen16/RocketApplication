using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.ParentClasses
{
    public interface ITechnique
    {
        string TechniqueName { get; }
        bool CalculateSuccessTechnique();
    }
}
