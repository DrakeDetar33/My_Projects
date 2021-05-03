using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace CalorieCalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void S_Button(object sender, RoutedEventArgs e)
        {
            // Variables
            int height = Convert.ToInt32(HeightInput.Text);
            int weight = Convert.ToInt32(WeightInput.Text);
            int age = Convert.ToInt32(AgeInput.Text);
            double activityLevel = 0;
            int genderBMR = 0;
            double BMR = 0;
            double caloric_intake = 0;
            double weightGoal = 0;
            double proteinPercent = 0;
            double carbPercent = 0;
            double fatPercent = 0;
            double calProtein = 0;
            double calCarbs = 0;
            double calFats = 0;
            


            // Gender Radio button if Statements
            if (Convert.ToBoolean(MaleRB.IsChecked))
            {
                genderBMR = 5;
            }
            else
            {
                genderBMR = -161;
            }
            // Activity level if statements
            if (Convert.ToBoolean(Intake1.IsChecked))
            {
                activityLevel = 1.2;
            }
            else if (Convert.ToBoolean(Intake2.IsChecked))
            {
                activityLevel = 1.375;
            }
            else if (Convert.ToBoolean(Intake3.IsChecked))
            {
                activityLevel = 1.65;
            }
            else
            {
                activityLevel = 1.9;
            }
            // Goals for weight if statements
            if (Convert.ToBoolean(Lose.IsChecked))
            {
                weightGoal = -150;
            }
            else if (Convert.ToBoolean(Maintain.IsChecked))
            {
                weightGoal = 0;
            }
            else 
            {
                weightGoal = 150;
            }



            // Calculations
            proteinPercent = Convert.ToDouble(ProteinTextBlock.Text);
            carbPercent = Convert.ToDouble(CarbohydrateTextBlock.Text);
            fatPercent = Convert.ToDouble(FatTextBlock.Text);


            BMR = (4.536 * weight) + (15.88 * height) - (5 * age) + genderBMR;
            caloric_intake = BMR * activityLevel + weightGoal;
            calProtein = (0.01 * proteinPercent) * caloric_intake;
            calCarbs = (0.01 * carbPercent) * caloric_intake;
            calFats = (0.01 * fatPercent) * caloric_intake;


            // Output
            OutputBox.Text = $"Your daily caloric intake is {Convert.ToString(caloric_intake)}" +
                $"\nCalories from Protein {calProtein}" +
                $"\nCalories from Carbohydrates {calCarbs}" +
                $"\nCalories from Protein {calFats}";




        }


    }
}
