using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Time
    {
        public string? hour;
        public string? minute;
        public string? second;

        public void ShowTime()
        {
            Console.WriteLine($"Time is {hour}:" + $"{minute}:" + $"{second}");

        }

        public void SetTime()
        {

            Console.WriteLine("Enter Hour");
            hour = Console.ReadLine();
            int a = Convert.ToInt32(hour);
            while (a < 0 || a > 24)
            {
                Console.WriteLine("Wrong Hour enter new one");
                hour = Console.ReadLine();
                a = Convert.ToInt32(hour);
            }

            Console.WriteLine("Enter Minute");
            minute = Console.ReadLine();
            int b = Convert.ToInt32(minute);
            while (b < 0 || b > 60)
            {
                Console.WriteLine("Wrong Minute enter new one");
                minute = Console.ReadLine();
                b = Convert.ToInt32(minute);
            }
            Console.WriteLine("Enter Second");
            second = Console.ReadLine();
            int c = Convert.ToInt32(second);
            while (c < 0 || c > 60)
            {
                Console.WriteLine("Wrong Second enter new one");
                second = Console.ReadLine();
                c = Convert.ToInt32(second);

            }

        }
        public void ChangeHour()
        {
            Console.WriteLine("Enter new Hour");
            hour = Console.ReadLine();
            int a = Convert.ToInt32(hour);
            while (a < 0 || a > 24)
            {
                Console.WriteLine("Wrong Hour enter new one");
                hour = Console.ReadLine();
                a = Convert.ToInt32(hour);
            }
        }
        public void ChangeMinute()
        {
            Console.WriteLine("Enter new Minute");
            minute = Console.ReadLine();
            int b = Convert.ToInt32(minute);
            while (b < 0 || b > 60)
            {
                Console.WriteLine("Wrong Minute enter new one");
                minute = Console.ReadLine();
                b = Convert.ToInt32(minute);
            }
        }
        public void ChangeSecond()
        {
            Console.WriteLine("Enter new Second");
            second = Console.ReadLine();
            int c = Convert.ToInt32(second);
            while (c < 0 || c > 60)
            {
                Console.WriteLine("Wrong Second enter new one");
                second = Console.ReadLine();
                c = Convert.ToInt32(second);

            }
        }
    }
}
