using System;

class Program
{
    // Створення делегата для методів, що виводять місяць і температуру
    public delegate void MonthTemperatureHandler(int month);

    static void Main()
    {
        // Масиви назв місяців та температур
        string[] months = { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень",
                            "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" };

        double[] temperatures = { -5.0, -3.0, 2.0, 10.0, 15.0, 20.0, 25.0, 24.0, 18.0, 10.0, 3.0, -1.0 };

        // Методи для виведення місяця та середньої температури
        MonthTemperatureHandler[] monthHandlers = {
            new MonthTemperatureHandler(MonthInfo1),
            new MonthTemperatureHandler(MonthInfo2),
            new MonthTemperatureHandler(MonthInfo3)
        };

        // Приклад використання
        Console.WriteLine("Введіть номер місяця (1-12): ");
        int monthNumber = int.Parse(Console.ReadLine());

        if (monthNumber < 1 || monthNumber > 12)
        {
            Console.WriteLine("Невірний номер місяця!");
        }
        else
        {
            Console.WriteLine($"Місяць: {months[monthNumber - 1]}, середня температура: {temperatures[monthNumber - 1]} °C");

            // Використання делегованих методів для трьох місяців
            if (monthNumber == 1 || monthNumber == 4 || monthNumber == 7)
            {
                monthHandlers[0].Invoke(monthNumber);
            }
            else if (monthNumber == 2 || monthNumber == 5 || monthNumber == 8)
            {
                monthHandlers[1].Invoke(monthNumber);
            }
            else if (monthNumber == 3 || monthNumber == 6 || monthNumber == 9)
            {
                monthHandlers[2].Invoke(monthNumber);
            }
        }
    }

    // Метод 1
    static void MonthInfo1(int month)
    {
        Console.WriteLine($"Метод 1: Місяць {month} - Інформація про місяць та температуру.");
    }

    // Метод 2
    static void MonthInfo2(int month)
    {
        Console.WriteLine($"Метод 2: Місяць {month} - Інформація про місяць та температуру.");
    }

    // Метод 3
    static void MonthInfo3(int month)
    {
        Console.WriteLine($"Метод 3: Місяць {month} - Інформація про місяць та температуру.");
    }
}

