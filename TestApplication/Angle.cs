using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheAngle
{
    class Angle
    {
        public double angle { get; set; }

        public double FindTheAngleBetween(int hours, int minutes)
        { 
            angle = (hours + (Convert.ToDouble(minutes) / 60)) * 30 - minutes * 6;

            if (angle < 0)
                angle *= -1;

            return angle;
        }

      
    }
}
