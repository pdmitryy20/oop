using System;

namespace lab5zavd3
{
    public class Shop
    {
        string[] clothingSizes = new string[] { "XXS", "XS", "S", "M", "L", "XL" };
        public string getDescription(string size)
        {
            if (size == "XXS") return "Дитячий розмір";
            else return "Дорослий розмір";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Console.Write("Введіть розмір одягу: ");
            string size = Console.ReadLine();
            string description = shop.getDescription(size);
            Console.WriteLine(description);
        }
    }
}
