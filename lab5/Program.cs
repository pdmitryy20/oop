using System;

namespace lab5
{
    public interface IShape
    {
        void DisplayType(); // Метод, що виводить на екран тип фігури
        void DisplayArea(); // Метод, що виводить на екран площу фігури
        double Dimension { get; set; } // Властивість, що відповідає за перший лінійний розмір фігури
    }

    public interface IColoredShape : IShape
    {
        string Color { get; set; } // Властивість, що відповідає за колір фігури
        void DisplayColor(); // Метод, що виводить на екран колір фігури
    }

    public class Circle : IShape
    {
        public double Dimension { get; set; } // Радіус кола

        public void DisplayType()
        {
            Console.WriteLine("Circle");
        }

        public void DisplayArea()
        {
            double area = Math.PI * Dimension * Dimension;
            Console.WriteLine($"Area: {area}");
        }
    }

    public class ColoredCircle : IColoredShape
    {
        public double Dimension { get; set; } // Радіус кола
        public string Color { get; set; } // Колір кола

        public void DisplayType()
        {
            Console.WriteLine("Colored Circle");
        }

        public void DisplayArea()
        {
            double area = Math.PI * Dimension * Dimension;
            Console.WriteLine($"Area: {area}");
        }

        public void DisplayColor()
        {
            Console.WriteLine($"Color: {Color}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створення екземплярів
            IShape shape1 = new Circle { Dimension = 5 };
            IShape shape2 = new Circle { Dimension = 7 };
            IShape shape3 = new Circle { Dimension = 3 };

            IColoredShape coloredShape1 = new ColoredCircle { Dimension = 4, Color = "Red" };
            IColoredShape coloredShape2 = new ColoredCircle { Dimension = 6, Color = "Blue" };
            IColoredShape coloredShape3 = new ColoredCircle { Dimension = 2, Color = "Green" };

            // Формування масиву
            IShape[] shapes = new IShape[] { shape1, shape2, shape3, coloredShape1, coloredShape2, coloredShape3 };

            // Виклик методу для кожного елемента масиву
            foreach (var shape in shapes)
            {
                shape.DisplayType();
                shape.DisplayArea();

                if (shape is IColoredShape coloredShape)
                {
                    coloredShape.DisplayColor();
                }

            }
        }
    }
}
