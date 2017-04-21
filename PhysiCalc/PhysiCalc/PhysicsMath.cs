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
        const int speedOfSound = 343;

        public double FreeFallMath (double timeOrHeight, bool inputType)//if inputType = true, then
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
        public double LightningMath(int timeToEar)
        {

        }
    }
}
