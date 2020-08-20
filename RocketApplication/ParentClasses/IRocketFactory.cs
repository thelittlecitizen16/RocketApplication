using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.ParentClasses
{
    public interface IRocketFactory
    {
        void AddRocket(RocketType rocketType);
    }
}
