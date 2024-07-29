using System;

namespace BMI_and_KarvonenCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI and Karvonen Calculator");
            
            Console.WriteLine("Please enter the following values for the user...");

            
            
            Console.Write("Height in inches: ");
            double heightInInches = double.Parse(Console.ReadLine());

            Console.Write("Weight in pounds: ");
            double weightInPounds = double.Parse(Console.ReadLine());

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Resting heart rate: ");
            int restingHeartRate = int.Parse(Console.ReadLine());

            
            double heightInMeters = heightInInches * 0.0254;
            double weightInKg = weightInPounds * 0.45359237;
            double bmi = weightInKg / Math.Pow(heightInMeters, 2);

            Console.WriteLine("\nResults...");
            Console.WriteLine($"Your BMI is: {bmi.ToString("F2")} – {GetBMICategory(bmi)}");

            Console.WriteLine("Exercise Intensity Heart Rates:");
            Console.WriteLine("Intensity\t\tMax Heart Rate");

            
            for (int intensityPercent = 50; intensityPercent <= 95; intensityPercent += 5)
            {
                double intensity = intensityPercent / 100.0;
                int maxHeartRate = (int)((220 - age - restingHeartRate) * intensity + restingHeartRate);
                Console.WriteLine($"{intensityPercent}%\t\t--\t\t{maxHeartRate}");
            }

            Console.WriteLine("\nPlease press any key to end the program...");
            Console.ReadKey();
        }

        static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                return "Normal weight";
            else if (bmi >= 25 && bmi <= 29.9)
                return "Overweight";
            else
                return "Obesity";
        }
    }
}
