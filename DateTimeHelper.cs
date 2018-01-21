using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodesExtension
{
   
    
    public static class DateTimeHelper
    {
       

        public static bool IsWeekEnd(this DateTime dt)
        {
            if ((dt.DayOfWeek == DayOfWeek.Saturday) || (dt.DayOfWeek == DayOfWeek.Sunday))              
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static DateTime GetLastDayOfMonth(this DateTime dt)
        {
            int daysInMonth = DateTime.DaysInMonth(dt.Year, dt.Month);

            return new DateTime(dt.Year,dt.Month,daysInMonth);
               
           
        
        }

        public static bool IsInRange(DateTime dt, DateTime debut, DateTime fin)
        {
            if (dt >= debut && dt <= fin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
