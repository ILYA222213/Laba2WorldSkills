using System;

// Перечисление для дней недели
enum Weekdays
{
    Понедельник = 1,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Воскресенье
}

// Перечисление для времени суток
enum DayTime
{
    Утро,
    День,
    Вечер,
    Ночь
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите день недели (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        // Проверяем корректность ввода дня недели
        if (day < 1 || day > 7)
        {
            Console.WriteLine("Неверный день недели, введите число от 1 до 7.");
            Environment.Exit(0);
        }

        Console.Write("Введите время (0-23): ");
        int time = Convert.ToInt32(Console.ReadLine());

        Weekdays inputDay = (Weekdays)day;
        DayTime timeOfDay = GetTimeOfDay(time);

        Console.WriteLine($"Сейчас {inputDay}, {timeOfDay}");
    }

    // Функция для определения времени суток
    static DayTime GetTimeOfDay(int time)
    {
        if (time >= 7 && time <= 12)
        {
            return DayTime.Утро;
        }
        else if (time >= 13 && time <= 17)
        {
            return DayTime.День;
        }
        else if (time >= 18 && time <= 23)
        {
            return DayTime.Вечер;
        }
        else
        {
            return DayTime.Ночь;
        }
    }
}
