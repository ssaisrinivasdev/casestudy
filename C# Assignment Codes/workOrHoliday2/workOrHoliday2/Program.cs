using System;

namespace workOrHoliday2
{
    class Program
    {
        enum Day
        {
            workingday,
            holiday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day:");
            int day = int.Parse(Console.ReadLine());
            Day d;
            if (day > 0 && day <= 7)
            {
                if (1 <= day && day <= 5)
                {
                    d = Day.workingday;
                }
                else
                {
                    d = Day.holiday;
                }
                Console.WriteLine(day+" is "+d);
            }
            else
            {
                Console.WriteLine(day+" is an "+"Invalid Date");
            }
        }
    }
}
