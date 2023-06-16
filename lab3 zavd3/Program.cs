using System;
using System.Data;

namespace lab3_zavd3
{
    // Оголошення класу Book
    class Book
    {
        public string name;
        public int numPages;
        public int cost;
        public string setName(string name)
        {
            this.name = name;
            return name;
        }
        public int setAmountOfPages(int numPages)
        {
            this.numPages = numPages;
            return numPages;
        }
        public int setCost(int cost)
        {
            this.cost = cost;
            return cost;
        }
    }
    // Оголошення дочірнього класу BookShop
    class BookShop : Book
    {
        public string name;
        public int numPages;
        public double cost;
        public int discountInPercents;
        public int prog;
        public int costOfOnePage;
        public string setName(string name)
        {
            this.name = name;
            return name;
        }
        public int setNumPages(int numPages)
        {
            this.numPages = numPages;
            return numPages;
        }
        public int setCost(int cost)
        {
            this.cost = cost;
            return cost;
        }
        // Функція, яка рахує вартість книги з урахуванням знижки
        public double setDiscount(int discountInPercents)
        {
            double discountAmount = cost * discountInPercents / 100.0;
            double discountedPrice = cost - discountAmount;
            Console.WriteLine("Ціна книги з урахуванням знижки у " + discountInPercents + "% дорівнює $" + discountedPrice);
            return discountedPrice;
        }
        // Функція, яка рахує вартість одніє сторінки книги
        public double setOnePage(int cost)
        {
            double result = (double)cost / (double)numPages;
            Console.WriteLine("Вартість одніє сторінки книги дорівнюює $" + result);
            return result;
        }
        // Функуція, яка множить ціну на два, якщо назва книги Programming
        public int setProgramming(string name, int cost)
        {
            
            if (name == "програмування")
            {
                cost = cost * 2;
                Console.WriteLine("Книга, яка містить слово програмування дорожча у два рази, тому її вартість " +
                    " буде дорівнювати $" + cost);
            }
            return cost;
        }
    }
    internal class Program
    {
        // Створення нової книги
        static void Main(string[] args)
        {
            BookShop book = new BookShop();
            book.setName("Книга про програмування");
            book.setCost(20);
            book.setNumPages(300);
            book.setDiscount(10);
            book.setOnePage(1);
            book.setProgramming("програмування", 20);
        }
    }
}
