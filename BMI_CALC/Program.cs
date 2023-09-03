using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_1_Ignacio
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight, height, bBmi, bmi;

            Console.WriteLine("----BMI CALCULATOR----");
            Console.Write("Weight (kg): ");
            weight = float.Parse(Console.ReadLine());
            Console.Write("Height (m): ");
            height = float.Parse(Console.ReadLine());

            bBmi = (weight / (height * height));
            bmi = String.Format("{0:0.00}", bmi);


            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI ({bmi}) is underweight.");
            }
            else if(bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine($"Your BMI ({bmi}) is normal.");
            }
            else if(bmi >= 25 && bmi < 30)
            {
                Console.WriteLine($"Your BMI ({bmi}) is overweight.");
            }
            else if(bmi >= 30 && bmi < 40)
            {
                Console.WriteLine($"Your BMI ({bmi}) is obese.");
            }
            else if(bmi >= 40)
            {
                Console.WriteLine($"Your BMI ({bmi}) is extremely obese.");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}