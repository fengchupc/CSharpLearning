using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCConsol
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateDate();
        }

        public static void calculateDate()
        {
            DateCalculation dc = new DateCalculation();

            Console.Write("Enter the start date (yyyy-mm-dd): ");
            String a = Console.ReadLine();
            dc.startDate = Convert.ToDateTime(a);
            Console.Write("Enter the end date (yyyy-mm-dd): ");
            a = Console.ReadLine();
            dc.endDate = Convert.ToDateTime(a);

            long ticks = dc.endDate.Ticks - dc.startDate.Ticks;

            TimeSpan ts = new TimeSpan(ticks);
             
            DateTime dt = new DateTime(ticks);

            Console.Write("Difference between these two dates are: {0} years, {1} months, {2} days,", ts.Days/365, ts.Days%365/30, ts.Days%365%30);
            Console.ReadLine();
            
            
        }
    }
}
