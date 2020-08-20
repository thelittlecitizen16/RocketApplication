using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApplication
{
    public static class RocketValidation
    {
        public static bool IsRocketTypeValid(string userRocketType)
        {
            RocketType rocketType;
            int number;

            if (Enum.TryParse(userRocketType, out rocketType) && !int.TryParse(userRocketType, out number))
            {
                return true;
            }

            return false;  
        }
    }
}
