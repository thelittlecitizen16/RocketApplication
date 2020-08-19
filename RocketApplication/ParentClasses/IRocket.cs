using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.ParentClasses
{
    public interface IRocket
    {
        RocketType RocketType { get; }
        ITechnique Technique { get; }
        bool TryLaunch { get; set; }
        bool IsSuccess();
    }
}
