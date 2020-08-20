using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication.ParentClasses
{
    public interface IBattery
    {
        void AddRocket(IRocket rocket);
        bool EmptyingByPlace(int place);
        int LaunchAllRockets();
        int LaunchFewRockets(RocketType rocket, int amount);
        int RocketsAmount();
        List<string> GetAllRocketsData();

    }
}
