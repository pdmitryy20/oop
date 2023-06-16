using System;

namespace lab11zavd2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть дату (у форматі дд.мм.рррр):");
            string dateString = Console.ReadLine();

            DateTime targetDate;

            if (DateTime.TryParse(dateString, out targetDate))
            {
                DateTime currentDate = DateTime.Today;

                if (targetDate > currentDate)
                {
                    TimeSpan remainingDays = targetDate - currentDate;
                    Console.WriteLine("Залишилось днів: " + remainingDays.Days);
                }
                else if (targetDate == currentDate)
                {
                    Console.WriteLine("Сьогодні є вказана дата!");
                }
                else
                {
                    Console.WriteLine("Вказана дата вже минула.");
                }
            }
            else
            {
                Console.WriteLine("Некоректний формат дати.");
            }
        }
    }
}

