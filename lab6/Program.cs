using System;
using System.Collections.Generic;
using System.Linq;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionType[] collectionArray = new CollectionType[]
            {
            new CollectionType { Field = "Value1", Collection = new List<int> { 1, 2 } },
            new CollectionType { Field = "Value2", Collection = new List<int> { 3, 4 } },
            new CollectionType { Field = "Value3", Collection = new List<int> { 5, 6 } },
            new CollectionType { Field = "Value4", Collection = new List<int> { 7, 8 } },
            new CollectionType { Field = "Value5", Collection = new List<int> { 9, 10, 11 } },
            new CollectionType { Field = "Value6", Collection = new List<int> { 12, 13 } },
            new CollectionType { Field = "Value7", Collection = new List<int> { 14, 15 } }
            };

            // Знайти кількість колекцій, що містять лише 2 елементи
            int countCollectionsWithTwoElements = collectionArray.Count(c => c.Collection.Count == 2);
            Console.WriteLine($"Кількість колекцій, що містять лише 2 елементи: {countCollectionsWithTwoElements}");

            // Знайти максимальну колекцію в масиві за заданим значенням поля об'єкта
            string targetFieldValue = "Value3";
            CollectionType maxCollection = collectionArray
                .Where(c => c.Field == targetFieldValue)
                .OrderByDescending(c => c.Collection.Count)
                .FirstOrDefault();

            if (maxCollection != null)
            {
                Console.WriteLine($"Максимальна колекція з полем '{targetFieldValue}': {string.Join(", ", maxCollection.Collection)}");
            }
            else
            {
                Console.WriteLine($"Колекції з полем '{targetFieldValue}' не знайдено.");
            }

            // Знайти мінімальну колекцію в масиві за заданим значенням поля об'єкта
            CollectionType minCollection = collectionArray
                .Where(c => c.Field == targetFieldValue)
                .OrderBy(c => c.Collection.Count)
                .FirstOrDefault();

            if (minCollection != null)
            {
                Console.WriteLine($"Мінімальна колекція з полем '{targetFieldValue}': {string.Join(", ", minCollection.Collection)}");
            }
            else
            {
                Console.WriteLine($"Колекції з полем '{targetFieldValue}' не знайдено.");
            }

            Console.ReadLine();
        }
    }

    class CollectionType
    {
        public string Field { get; set; }
        public List<int> Collection { get; set; }
    }
}
