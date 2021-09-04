using System;

namespace workOrHoliday
{
    class Program
    {
        enum Day
        {
            workingDay,
            holiday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day:");
            int day = int.Parse(Console.ReadLine());
            Day d;
            if (day > 0 && day <= 7)
            {
                if (1 <= day && day <= 5){
                    d = Day.workingDay;
                }
                else{
                    d = Day.holiday;
                }
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }
        }
    }
}
