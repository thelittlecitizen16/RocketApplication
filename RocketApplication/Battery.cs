using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocketApplication
{
    public class Battery
    {
        private List<IRocket> _allRockets;

        public Battery()
        {
            _allRockets = new List<IRocket>();
        }
        public void AddRocket(IRocket rocket)
        {
            _allRockets.Add(rocket);
        }
        public bool EmptyingByPlace(int place)
        {
            IRocket rocket = _allRockets.ElementAtOrDefault(place);

            if (rocket != null)
            {
                _allRockets.Remove(rocket);

                return true;
            }

            return false;
        }
        public int LaunchAllRockets()
        {
            int count = 0;

            foreach (var rocket in _allRockets)
            {
                count += LaunchFewRockets(rocket.RocketType, 1);
            }

            return count;
        }
        public int LaunchFewRockets(RocketType rocket, int amount)
        {
            int count = 0;

            for (int i = 0; i < amount; i++)
            {
                if (LaunchRocket(rocket))
                {
                    count++;
                } 
            }
                  
            return count;
        }
        public int RocketsAmount()
        {
            return _allRockets.Count();
        }
        public List<string> GetAllRocketsData()
        {
           return _allRockets.Select(r => r.RocketType.ToString() + "-" + r.Technique.TechniqueName).ToList();
        }
        private bool LaunchRocket(RocketType rocket)
        {
            IRocket rocketToLaunch = _allRockets.FirstOrDefault(r => r.RocketType == rocket);

            if (rocketToLaunch!=null)
            {
                if (rocketToLaunch.TryLaunch == true)
                {
                    return false;
                }
                else if (rocketToLaunch.IsSuccess())
                {
                    _allRockets.Remove(rocketToLaunch);
                    return true;
                }
                else
                {
                    rocketToLaunch.TryLaunch = true;
                    return false;
                }
            }

            return false;
        }

    }
}
