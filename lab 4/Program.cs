using System;

namespace lab_4
{
    class Bird // оголошення класу птах
    {
        public void Fly()
        {
            Console.WriteLine("Я літаю!");
        }
        public void Sing()
        {
            Console.WriteLine("Я співаю!");
        }
    }
    class Cukoo : Bird // оголошення класу зозуля, який успадковує клас птах
    {
        public void Sing()
        {
            Console.WriteLine("Ку-ку!");
        }
        class Hen : Bird // оголошення класу квочка, який успадковує клас птах
        {
            public void LayEgg()
            {
                Console.WriteLine("Я висаджую яйці!");
            }
            public void HatchEgg()
            {
                Console.WriteLine("Я висаджую пташенят!");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Hen hen = new Hen();
                hen.Fly();
                hen.Sing();
                hen.LayEgg();
                hen.HatchEgg();

            }
        }
    }
}
