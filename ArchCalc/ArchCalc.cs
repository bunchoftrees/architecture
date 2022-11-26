using System;

namespace ArchCalc
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] monuments = { "Teotihuacan", "Taj Mahal", "Great Mosque of Mecca" };
            int monument = SelectMonument();
            double flooringCost = CalculateTotalCost(monument);
            Console.WriteLine($"The cost to retile the {monuments[monument - 1]} is ${flooringCost} dollars!");

        }
        static double Rectangle(double length, double width)
        {
            return length * width;
        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
        static double CalculateTotalCost(int selection)
        {
            double tileCost = 9.31;
            switch (selection)
            {
                case 1:
                    return Math.Round((Rectangle(1500, 2500) + (Circle(375) / 2) + Triangle(500, 750)) * tileCost, 2);
                    break;
                case 2:
                    return Math.Round((Rectangle(90.5, 90.5) - (Triangle(24, 24) * 4)) * tileCost, 2);
                    break;
                case 3:
                    return Math.Round((Rectangle(180, 106) + Rectangle(284, 200) - Triangle(264, 84)) * tileCost, 2);
                    break;
                default:
                    Console.WriteLine("You did not supply a valid selection.\nTry again.");
                    return 0;
                    break;
            }
            return 0;

        }
        static int SelectMonument()
        {
            Console.WriteLine("What monument would you like to retile?");
            Console.WriteLine("1. Teotihuacan\n2. Taj Mahal\n3. Great Mosque of Mecca");
            Console.WriteLine("Enter the number for the monument.");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }
}
