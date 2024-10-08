using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BMI Calculator!");

            // Get user input for weight
            Console.Write("Please enter your weight in kilograms (KG): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Get user input for height
            Console.Write("Please enter your height in meters (M): ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI
            double bmi = CalculateBMI(weight, height);

            // Display the result
            Console.WriteLine($"Your BMI is: {bmi:F2}");
            Console.WriteLine(GetBMICategory(bmi));

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "You are underweight.";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "You have a normal weight.";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "You are overweight.";
            }
            else
            {
                return "You are obese.";
            }
        }
    }
}
