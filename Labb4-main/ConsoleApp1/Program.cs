using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleListProgram
{
    class Program
    {
        static bool IsAuthenticated = false; // Змінна для перевірки авторизації

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> numbers = new List<int>(); // Створення списку цілих чисел

            Authenticate(); // Виклик функції авторизації

            if (IsAuthenticated)
            {
                bool exit = false;
                while (!exit)
                {
                    // Останній код залишається незмінним
                    // ...
                }

                Console.WriteLine("Програма завершила роботу.");
            }
            else
            {
                Console.WriteLine("Авторизація не пройшла успішно. Програма завершила роботу.");
            }
        }

        static void Authenticate()
        {
            // Простий приклад авторизації (з паролем)
            Console.WriteLine("Введіть пароль:");
            string password = Console.ReadLine();

            // Перевірка пароля (може бути більш складною залежно від потреб)
            if (password == "password123")
            {
                IsAuthenticated = true;
                Console.WriteLine("Авторизація успішна!");
            }
            else
            {
                Console.WriteLine("Неправильний пароль. Авторизація не вдалася.");
            }
        }
    }
}