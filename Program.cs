using System;
using System.ComponentModel.Design;
using System.Reflection.Emit;

namespace BMICalculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the BMI Calculator:)");

            double weight = GetWeight();
            double height = GetHeight();

            double BMI = calculateBMI(weight, height);
            Console.WriteLine("Your final BMI is: " + Math.Round(BMI, 2));
        }

        static double GetWeight()
        {
            Console.WriteLine("Enter Your Weight In kilograms: ");
            double weight = Double.Parse(Console.ReadLine());
            return weight;
        }

        static double GetHeight()
        {
            Console.WriteLine("Enter your Height in feet and inches (ex. 5'8\"): ");
            String input = Console.ReadLine();
            String[] split = input.Split("'");
            double feet = Double.Parse(split[0]);
            double inches = Double.Parse(split[1].Trim('"'));
            double height = (feet * 12) + inches;
            return height;
        }

        static double calculateBMI(double weight, double height)
        {
            // convert inches to meters
            double meterHeight = height * 0.0254;
            // convert our weight into kilograms
            double kilogramWeight = weight * 0.045392;
            double bmi = kilogramWeight / (meterHeight * meterHeight);
            return bmi;
        // Determines yout weight according to your BMI
        if(Convert.ToDouble(bmi) < 18.5)
        {
            LabelYouAre.Text = "Underweight";
        }
        else if (Convert.ToDouble(bmi) >= 18.5 && Convert.ToDouble(BMI) < 24.9);
        {
            labelYouAre.Text = "Normal";
        }
        else if (Convert.ToDouble(bmi) >= 25 && Convert.ToDouble(BMI) < 29.9
        {
            LabelYouAre.Text = "Overweight";
        }       
        else if (Convert.ToDouble(bmi) >= 30)
        {
            LabelYouare.Text = "Obese";
        }


    }

}



