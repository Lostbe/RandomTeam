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
        const double convertRad = Math.PI / 180;

        public double FreeFallMath (double timeOrHeight, bool inputType)//if inputType = true, then it is time, else is height
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
            theta = theta * convertRad;
            double yVelocity = Math.Sin(theta) * initialVelocity;
            double xVelocity = Math.Sqrt((initialVelocity * initialVelocity) - (yVelocity * yVelocity));
            double tToMax = (yVelocity / gravityAcceleration);
            double yHeight = (yVelocity * tToMax) - ((gravityAcceleration / 2) * (tToMax * tToMax));
            double heightOfFall = yHeight + launchHeight;
            double timeToFall = FreeFallMath(heightOfFall, true);
            double totalTime = timeToFall + tToMax;
            double xDistance = totalTime * xVelocity;
            return xDistance;
        }
    }
}
