using System;

/* This program calculates the estimated construction cost of famous monuments
   by computing their total areas using geometric formulas and multiplying
   the result by a fixed cost per square meter */

namespace ArchitectArithmetic
{
    class Program
    {
        // Cost per square meter in pesos
        const double CostPerSquareMeter = 180;

        public static void Main(string[] args)
        {
            // Initial test outputs to verify area calculations
            Console.WriteLine("Shape Test Outputs:");
            Console.WriteLine($"Rectangle 4x5: {CalculateRectangleArea(4, 5)}");
            Console.WriteLine($"Circle r=4: {CalculateCircleArea(4)}");
            Console.WriteLine($"Triangle base=10, height=9: {CalculateTriangleArea(10, 9)}");

            // Precompute costs for each monument
            double teotihuacanCost = CalculateTeotihuacanCost();
            double tajMahalCost = CalculateTajMahalCost();
            double greatMosqueCost = CalculateGreatMosqueCost();

            // Loop allowing the user to select monuments until they exit
            while (true)
            {
                Console.WriteLine("\nWhich monument would you like to see the cost for? (or type 'exit' to quit)");
                Console.WriteLine("Enter 1 for Teotihuacan");
                Console.WriteLine("Enter 2 for Taj Mahal");
                Console.WriteLine("Enter 3 for Great Mosque of Mecca");

                string monumentChoice = Console.ReadLine();

                // Exit the program if the user types "exit"
                if (monumentChoice?.Equals("exit", StringComparison.OrdinalIgnoreCase) == true)
                    break;

                // Display cost based on user selection
                switch (monumentChoice)
                {
                    case "1":
                        Console.WriteLine(FormatTotalCost(teotihuacanCost));
                        break;
                    case "2":
                        Console.WriteLine(FormatTotalCost(tajMahalCost));
                        break;
                    case "3":
                        Console.WriteLine(FormatTotalCost(greatMosqueCost));
                        break;
                    default:
                        Console.WriteLine("Unknown monument. Please try again.");
                        break;
                }
            }
        }

        // Calculates the total cost of Teotihuacan
        static double CalculateTeotihuacanCost()
        {
            double mainRectangle = CalculateRectangleArea(2500, 1500);
            double centralCircle = CalculateCircleArea(375);
            double sideTriangle = CalculateTriangleArea(750, 500);

            double totalArea = mainRectangle + centralCircle + sideTriangle;
            return totalArea * CostPerSquareMeter;
        }

        // Calculates the total cost of the Taj Mahal
        static double CalculateTajMahalCost()
        {
            double mainSquare = CalculateRectangleArea(90.5, 90.5);
            double cornerTriangles = CalculateTriangleArea(24, 24) * 4;

            double totalArea = mainSquare - cornerTriangles;
            return totalArea * CostPerSquareMeter;
        }

        // Calculates the total cost of the Great Mosque of Mecca
        static double CalculateGreatMosqueCost()
        {
            double largeRectangle = CalculateRectangleArea(284, 200);
            double smallRectangle = CalculateRectangleArea(180, 106);
            double triangleCutout = CalculateTriangleArea(264, 84);

            double totalArea = largeRectangle + smallRectangle - triangleCutout;
            return totalArea * CostPerSquareMeter;
        }

        // Calculates the area of a rectangle
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        // Calculates the area of a circle
        static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Calculates the area of a triangle
        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
        
        // Formats and returns the total cost in pesos
        static string FormatTotalCost(double cost)
        {
            return $"\nThe plan for that monument costs: {cost:C2}";
        }
    }
}