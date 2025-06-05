using System;

namespace Task_2_pr_46
{
    class Program
    {
        enum Months
        {
            Январь,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {
            foreach (int i in Enum.GetValues(typeof(Months)))
            {
                string monthName = Enum.GetName(typeof(Months), i);
                Console.WriteLine($"{i} - {monthName}");
            }

            Console.Read();
        }
    }
}
