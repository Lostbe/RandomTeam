using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysiCalc
{
    class PhysicsMath
    {
        const double gravityAcceleration = 9.8;
        const double speedOfSound = .343;

        public double FreeFallMath (double timeOrHeight, bool inputType)//if inputType = false, then time is being inputed, otherwise height is inputed
        {
            if(inputType == true)
            {
                return Math.Sqrt(timeOrHeight / (0.5 * gravityAcceleration));
            }
            else
            {
                return 0.5 * gravityAcceleration * Math.Pow(timeOrHeight, 2);
            }
        }
        public double LightningMath(double timeToEar)
        {
            double distanceToStrike = speedOfSound * timeToEar;
            return distanceToStrike;
        }
        public double ProjectileDistance(double launchHeight, double theta, double initialVelocity)
        {
            theta = theta * radianConvertionFactor;
            double y = Math.Sin(theta) * initialVelocity;
            double deltaY = (y * (y / gravityAcceleration)) - ((gravityAcceleration / 2) * (Math.Pow((y / gravityAcceleration), 2)));
            double totalY = launchHeight + deltaY;
            double totalT = (y / gravityAcceleration) + (FreeFallMath(totalY, true));
            return (Math.Cos(theta) * initialVelocity) * totalT;
        }
    }
}
