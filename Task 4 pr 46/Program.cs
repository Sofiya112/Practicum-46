using System;

namespace Task_4_pr_46
{
    class Program
    {
        enum UserRole
        {
            Admin,      // Администратор
            Moderator,  // Модератор
            User,       // Пользователь
            Guest       // Гость
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу роль (Admin, Moderator, User, Guest):");
            string input = Console.ReadLine();

            
            bool success = Enum.TryParse<UserRole>(input, true, out UserRole role);

            if (success)
            {
                switch (role)
                {
                    case UserRole.Admin:
                        Console.WriteLine("Вы зарегистрированы как администратор.");
                        break;
                    case UserRole.Moderator:
                        Console.WriteLine("Вы зарегистрированы как модератор.");
                        break;
                    case UserRole.User:
                        Console.WriteLine("Вы зарегистрированы как пользователь.");
                        break;
                    case UserRole.Guest:
                        Console.WriteLine("Вы зарегистрированы как гость.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введена некорректная роль.");
            }

            Console.Read();
        }
    }
}
