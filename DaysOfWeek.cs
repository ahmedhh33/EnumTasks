using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTasks
{
    internal class DaysOfWeek
    {
        public DoW dow;

        public DaysOfWeek(DoW dow)
        {
            this.dow=dow;
        }

        public static void Dayscheduale(String days)
        {

            try
            {
                DoW day;//giv enum name

                if (Enum.TryParse(days, out day))//convert from enum to string it takes input string and out put nam of enum
                {
                    switch (day)
                    {
                        case DoW.SUNDAY:
                            Console.WriteLine("You Do not have nothing scheduled");
                        break;
                        case DoW.MONDAY:
                            Console.WriteLine("You Have To go to GYM");
                        break;
                        case DoW.TUSDAY:
                            Console.WriteLine("You Have job test");
                        break;
                        case DoW.WEDNESDAY:
                            Console.WriteLine("You Have job intervew");
                        break;
                        case DoW.THURSDAY:
                            Console.WriteLine("you have nuthing");
                        break;
                        case DoW.FRIDAY:
                            Console.WriteLine("Jomaa Prayer");
                        break;
                        case DoW.SATURDAY:
                            Console.WriteLine("End the Break");
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("You Entered Wrong Choice");
            }
        }
      

    }

        
    
    enum DoW
    {
        SUNDAY,
        MONDAY,
        TUSDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
    }
}
