using Patterns.ExampleClasses;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Relational patterns:
            int numericGrade = 88;
            string alphaGrade = ConvertToAlphaGrade(numericGrade);
            Console.WriteLine($"The grade {numericGrade} corresponds to {alphaGrade}\n");

            //Logical patterns:
            float bmiValue = 20f;
            string bmiCategory = GetBmiCategory(bmiValue);
            Console.WriteLine($"Body mass index of {bmiValue} corresponds to {bmiCategory}\n");

            //Simple type and Not patterns:
            int bookDiscount = GetDiscount(new Book());
            int magazineDiscount = GetDiscount(new Magazine());
            int smartphoneDiscount = GetDiscount(new Smartphone());
            Console.WriteLine($"Discount for your Book: {bookDiscount}");
            Console.WriteLine($"Discount for your Magazine: {magazineDiscount}");
            Console.WriteLine($"Discount for your Smartphone: {smartphoneDiscount}");

            Console.ReadLine();
        }

        static string ConvertToAlphaGrade(float grade)
        {
            return grade switch
            {
                //Relational patterns:
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "E"
            };
        }

        static string GetBmiCategory(float bmi)
        {
            //Logical patterns:
            return bmi switch
            {
                < 18.5f => "Underweight",
                >= 18.5f and < 25f => "Normal weight",
                >= 25 and < 29.9f => "Overweight",
                _ => "Obesity"
            };
        }
        
        
        private static int GetDiscount(Product p)
        {
            return p switch
            {
                Book => 50,
                not Smartphone => 5,
                _ => 0
            };
        }
    }
}
