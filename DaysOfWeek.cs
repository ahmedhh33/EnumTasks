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
