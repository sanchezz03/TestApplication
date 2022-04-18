using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheAngle
{
    class Clock
    {
        public int hours { get; set; }
        public int minutes { get; set; }

        public int AnalyzeHours(int hours)
        {
            if (hours == 13)
                hours = 1;
            else if (hours == 14)
                hours = 2;
            else if (hours == 15)
                hours = 3;
            else if (hours == 16)
                hours = 4;
            else if (hours == 17)
                hours = 5;
            else if (hours == 18)
                hours = 6;
            else if (hours == 19)
                hours = 7;
            else if (hours == 20)
                hours = 8;
            else if (hours == 21)
                hours = 9;
            else if (hours == 22)
                hours = 10;
            else if (hours == 23)
                hours = 11;

            return hours;
        }
    }
}
