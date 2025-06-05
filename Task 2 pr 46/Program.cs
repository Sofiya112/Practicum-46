using System;

namespace Task_2_pr_46
{
    class Program
    {
        enum Days
        {
            SAT = 0,
            SUN = 1,
            MON = 2,
            TUE = 3,
            WED = 4,
            THU = 5,
            FRI = 6
        }

        static void Main(string[] args)
        {
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine($"{day} - имеет значение {(int)day}");
            }

            Console.Read();
        }
    }
}
