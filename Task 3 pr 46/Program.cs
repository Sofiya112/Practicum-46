using System;

namespace Task_2_pr_46
{
    class Program
    {
        enum Operation
        {
            Add,        // Сложение
            Subtract,   // Вычитание
            Multiply,   // Умножение
            Divide      // Деление
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            foreach (var op in Enum.GetValues(typeof(Operation)))
            {
                Console.WriteLine($"{(int)op} - {op}");
            }

            Console.Write("Введите номер операции: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Operation selectedOperation = (Operation)choice;

            double result = 0;

            switch (selectedOperation)
            {
                case Operation.Add:
                    result = num1 + num2;
                    break;
                case Operation.Subtract:
                    result = num1 - num2;
                    break;
                case Operation.Multiply:
                    result = num1 * num2;
                    break;
                case Operation.Divide:
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
            Console.Read();
        }
    }
}
