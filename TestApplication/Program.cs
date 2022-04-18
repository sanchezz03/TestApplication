using System;

namespace FindTheAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Angle angle = new Angle();

            Console.WriteLine($"Enter the hours:");
            clock.hours = int.Parse(Console.ReadLine());

            if (clock.hours < 0 || clock.hours > 23)
            {
                Console.WriteLine("You entered the wrong value. Hours: from 0 to 23");
                return;
            }

            Console.WriteLine($"Enter the minutes:");
            clock.minutes = int.Parse(Console.ReadLine());

            if (clock.minutes < 0 || clock.minutes > 59)
            {
                Console.WriteLine("You entered the wrong value. Minutes: from 0 to 59");
                return;
            }

            if (clock.hours > 12 && clock.hours < 24)
                clock.hours = clock.AnalyzeHours(clock.hours);

            angle.angle = angle.FindTheAngleBetween(clock.hours, clock.minutes);
            Console.WriteLine($"Angle between = {angle.angle}");
        }
    }
}
