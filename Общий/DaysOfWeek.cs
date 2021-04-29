using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    enum Days: int
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class DaysOfWeek
    {
        public object ReturnNameDay()
        {
            try
            {
                int day1 = Convert.ToInt32(Console.ReadLine());
                int day2 = Convert.ToInt32(Console.ReadLine());
                int min = day1 > day2 ? day2 : day1;
                int max = day1 > day2 ? day1 : day2;
                if ((max - min) < (min + 7 - max))
                {
                    return Math.Abs(max - min);
                }
                else
                {
                    return Math.Abs(min + 7 - max);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Хрень, гляди: " + e.Message);
            }
            
            return 0;
        }
        public object ReturnCountDaysBetween()
        {
            try
            {
                int numb = Convert.ToInt32(Console.ReadLine());
                switch (numb)
                {
                    case 1: return Days.Monday;
                    case 2: return Days.Tuesday;
                    case 3: return Days.Wednesday;
                    case 4: return Days.Thursday;
                    case 5: return Days.Friday;
                    case 6: return Days.Saturday;
                    case 7: return Days.Sunday;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Хрень, гляди: " + e.Message);
            }
            return 0;
        }
    }
}
