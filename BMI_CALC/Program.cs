using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_CALC
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight, height, bmi;

            Console.WriteLine("----BMI CALCULATOR----");
            Console.Write("Weight (kg): ");
            weight = float.Parse(Console.ReadLine());
            Console.Write("Height (m): ");
            height = float.Parse(Console.ReadLine());

            bmi = (weight / (height * height));

            if (bmi < 18.5)
            {
                Console.WriteLine("Your BMI (" + String.Format("{0:0.00}", bmi) + ") is underweight.");
            }
            else if(bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Your BMI (" + String.Format("{0:0.00}", bmi) + ") is normal.");
            }
            else if(bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Your BMI (" + String.Format("{0:0.00}", bmi) + ") is overweight.");
            }
            else if(bmi >= 30 && bmi < 40)
            {
                Console.WriteLine("Your BMI (" + String.Format("{0:0.00}", bmi) + ") is obese.");
            }
            else if(bmi >= 40)
            {
                Console.WriteLine("Your BMI (" + String.Format("{0:0.00}", bmi) + ") is extremely obese.");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}