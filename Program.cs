using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodesExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date;
            date = DateTime.Now;

            bool test = DateTimeHelper.IsWeekEnd(date);

            Console.WriteLine(test);


            date = DateTimeHelper.GetLastDayOfMonth(date);

            Console.WriteLine(date);

            Console.ReadKey();
        }
    }
}
