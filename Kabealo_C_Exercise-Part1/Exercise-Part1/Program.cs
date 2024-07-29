using System;

namespace FloorCostConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double INSTALLATION_COST_PER_HOUR = 35.75;
            const double SQ_FT_PER_HOUR = 40;

            Console.WriteLine("Collin M. Kabealo Cost Estimator");
            Console.Write("Please enter length of floor: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Please enter width of floor: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Please enter the cost per square foot for the flooring selected: ");
            double costPerSqFt = double.Parse(Console.ReadLine());

            double totalArea = length * width;
            double flooringCost = totalArea * costPerSqFt;
            double hoursToInstall = totalArea / SQ_FT_PER_HOUR;
            double installationCost = hoursToInstall * INSTALLATION_COST_PER_HOUR;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"For a total floor size of {totalArea} the flooring cost is ${flooringCost:0.00}");
            Console.WriteLine($"It will take {hoursToInstall:0.00} hours to install the floor at a cost of ${installationCost:0.00}");
            Console.WriteLine($"The total finished cost for the new floor is: ${flooringCost + installationCost:0.00}");
        }
    }
}
