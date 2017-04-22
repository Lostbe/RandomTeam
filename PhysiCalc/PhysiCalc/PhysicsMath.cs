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
            theta = theta * (Math.PI / 180);
            double yVelocity = (Math.Sin(theta)) * initialVelocity;
            double xVelocity = Math.Sqrt(Math.Pow(initialVelocity, 2) - (Math.Pow((yVelocity), 2)));
            double tToMaxHeight = (yVelocity) / gravityAcceleration;
            double totalHeight = ((yVelocity * tToMaxHeight) + ((-1 * (gravityAcceleration / 2)) * (Math.Pow(tToMaxHeight, 2)))) + launchHeight;
            double totalTime = (tToMaxHeight + (FreeFallMath(totalHeight, false)));
            double xDistance = xVelocity * totalTime;
            return xDistance;
        }
    }
}
