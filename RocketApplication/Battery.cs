using RocketApplication.ParentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocketApplication
{
    public class Battery : IBattery
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
            List<IRocket> rockets = LaunchRocket(_allRockets);
            RemoveFromList(rockets);

            return rockets.Count();    
        }
        private void RemoveFromList(List<IRocket> rockets)
        {
            foreach (var rocket in rockets)
            {
                _allRockets.Remove(rocket);
            }
        }
        public int LaunchFewRockets(RocketType rocketType, int amount)
        {
            List<IRocket> rockets = new List<IRocket>();
            List<IRocket> rocketsByType = _allRockets.Where(r => r.RocketType == rocketType).ToList();

            if  (rocketsByType.Count() >= amount)
            {
                rockets = LaunchRocket(rocketsByType.Take(amount).ToList());
                RemoveFromList(rockets);

                return rockets.Count();
            }
         
            return 0;
        }
        public int RocketsAmount()
        {
            return _allRockets.Count();
        }
        public List<string> GetAllRocketsData()
        {
           return _allRockets.Select(r => r.RocketType.ToString() + "-" + r.Technique.TechniqueName).ToList();
        }
        private List<IRocket> LaunchRocket(List<IRocket> rocketsToLaunch)
        {
            List<IRocket> rockets = new List<IRocket>();

            foreach (var rocket in rocketsToLaunch)
            {
                if (rocket.TryLaunch == false)
                {
                    if (rocket.IsSuccess())
                    {
                        rockets.Add(rocket);
                    }
                    else
                    {
                        rocket.TryLaunch = true;
                    }
                } 
            }

            return rockets;
        }

    }
}
