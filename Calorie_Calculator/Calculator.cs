using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Calculator
{
    class Calculator
    {
        // Height/ Weight/ age/ bmr/ cal. intake/ gender
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public double ActivityLevel { get; set; }
        public string Gender { get; set; }

        double BMR = 0;

        double CalorieIntake=0;
        public Calculator()
        {
            Height = 0;
            Weight = 0;
            Age = 0;
            ActivityLevel = 0;
            Gender = "";
        }

        public Calculator(double height, double weight, int age, int activityLevel, string gender)
        {
            Height = height;
            Weight = weight;
            Age = age;
            ActivityLevel = activityLevel;
            Gender = gender;

            switch (ActivityLevel)
            {
                case 1:
                    ActivityLevel = 1.2;
                    break;
                case 2:
                    ActivityLevel = 1.375;
                    break;
                case 3:
                    ActivityLevel = 1.65;
                    break;
                default:
                    ActivityLevel = 1.9;
                    break;
            }

            if (Gender == "male")
            {
                BMR = 66 + (6.3 * Weight) + (12.9 * Height) - (6.8 * Age);
                CalorieIntake = BMR * ActivityLevel;
                Console.WriteLine($"Your daily caloric intake is {CalorieIntake} calories");
            }
            else
            {
                BMR = 655 + (4.3 * weight) + (4.7 * height) - (4.7 * age);
                CalorieIntake = BMR * ActivityLevel;
                Console.WriteLine($"Your daily caloric intake is {CalorieIntake} calories");
            }
        }

    }
}
