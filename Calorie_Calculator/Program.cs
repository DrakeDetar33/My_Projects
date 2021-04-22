using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro
            Console.WriteLine("What is up! The purpose of this program is \n   to help you " +
                "determine how many calories you should \n  be eating to reach your aesthetic goals " +
                "based on \n    your current lifestyle. I intend to make it more clear than the \n  calculators" +
                " you can find on the internet!");
            // Variables
            double activity_lvl;
            double height;
            double weight;
            double age;
            string gender;
            // Inputs 
            // Body Measurements
            Console.WriteLine("\nThe first thing I need to do is get some information from you \n" +
                "   to know where you currently sit at.\n");
            // Height
            Console.WriteLine("How tall are you in inches?");
            height = Convert.ToDouble(Console.ReadLine());
            // Weight 
            Console.WriteLine("\nWhat is your current weight in pounds?");
            weight = Convert.ToDouble(Console.ReadLine());
            // Gender
            Console.WriteLine("\nWhat is your gender?");
            gender = Console.ReadLine();
            gender = gender.ToLower();
            //Age   
            Console.WriteLine("\nHow old are you?");
            age = Convert.ToDouble(Console.ReadLine());
            // Activity lvl
            Console.WriteLine("On a scale of 1-4 how active are you?\n" +
                "1) Less than 30 minutes a day of intentional exercise\n" +
                "2) Daily exercise that burns around 130-160 calories\n" +
                "3) Daily exercise that burns about 470-580 calories\n" +
                "4) Daily exercise that burns around 1100 to 1400\n");
            activity_lvl = Convert.ToDouble(Console.ReadLine());

            // Set activity level
            switch (activity_lvl)
            {
                case 1:
                    activity_lvl = 1.2;
                    break;
                case 2:
                    activity_lvl = 1.375;
                    break;
                case 3:
                    activity_lvl = 1.65;
                    break;
                default:
                    activity_lvl = 1.9;
                    break;
            }

            new Calculator(height, weight, Convert.ToInt32(age), Convert.ToInt32(activity_lvl), gender);
            Console.ReadKey();
        }

    }
}
