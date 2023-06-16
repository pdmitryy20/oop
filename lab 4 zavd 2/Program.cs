using System;

namespace lab_4_zavd_2
{
    // Базовий клас для прогресій
    public class TVSeries
    {
        public double firstTerm; // Перший член прогресії
        public double commonDiff; // Різниця між сусідніми членами прогресії

        public TVSeries(double firstTerm, double commonDiff)
        {
            this.firstTerm = firstTerm;
            this.commonDiff = commonDiff;
        }

        // Знаходження n-го члена прогресії
        public double NthTerm(int n)
        {
            return firstTerm + (n - 1) * commonDiff;
        }

        // Знаходження суми перших n членів прогресії
        public double SumOfTerms(int n)
        {
            return (n / 2) * (2 * firstTerm + (n - 1) * commonDiff);
        }
    }
    public class ArithmeticSeries : TVSeries
    {
        public ArithmeticSeries(double firstTerm, double commonDiff) : base(firstTerm, commonDiff)
        {
        }

        public new double NthTerm(int n) // Застосування ключового слова new для перевизначення методу батьківського класу
        {
            return base.NthTerm(n); // Виклик методу батьківського класу
        }

        public new double SumOfTerms(int n)
        {
            return base.SumOfTerms(n); // Виклик методу батьківського класу
        }
    }

    public class GeometricSeries : TVSeries
    {
        public GeometricSeries(double firstTerm, double commonRatio) : base(firstTerm, commonRatio)
        {
        }

        public new double NthTerm(int n)
        {
            return firstTerm * Math.Pow(commonDiff, n - 1);
        }

        public new double SumOfTerms(int n)
        {
            return firstTerm * (1 - Math.Pow(commonDiff, n)) / (1 - commonDiff);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = 10; // Кількість прогресій
            int m = 5; // Кількість членів, суму яких треба знайти
            double maxNthTerm = double.MinValue; // Максимальний n-тий член серед усіх прогресій
            TVSeries maxSeries = null; // Прогресія, до якої належить максимальний n-тий член

            // Створюємо випадкові прогресії
            TVSeries[] series = new TVSeries[n];
            for (int i = 0; i < n; i++)
            {
                double firstTerm = rand.Next(1, 11); // Випадкове ціле число від 1 до 10
                double commonDiff = rand.Next(1, 6); // Випадкове ціле число від 1 до 5
                double commonRatio = rand.Next(2, 6); // Випадкове ціле число від 2 до 5

                if (i % 2 == 0) // Парні індекси - арифметичні прогресії
                {
                    series[i] = new ArithmeticSeries(firstTerm, commonDiff);
                }
                else // Непарні індекси - геометричні прогресії
                {
                    series[i] = new GeometricSeries(firstTerm, commonRatio);
                }
            }

            // Знаходимо прогресію, до якої належить максимальний n-тий член
            for (int i = 0; i < n; i++)
            {
                double nthTerm = series[i].NthTerm(n);
                if (nthTerm > maxNthTerm)
                {
                    maxNthTerm = nthTerm;
                    maxSeries = series[i];
                }
            }

            // Знаходимо суму перших m членів прогресії, до якої належить максимальний n-тий член
            double sumOfFirstMTerms = maxSeries.SumOfTerms(m);

            Console.WriteLine($"Максимальний {n}-тий член у прогресії: {maxNthTerm}");
            Console.WriteLine($"Сума перших {m} членів цієї прогресії: {sumOfFirstMTerms}");
        }
    }
}