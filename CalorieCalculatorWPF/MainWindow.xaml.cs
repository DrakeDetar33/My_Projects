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
            int height = Convert.ToInt32(HeightInput.Text);
            int weight = Convert.ToInt32(WeightInput.Text);
            int age = Convert.ToInt32(AgeInput.Text);
            double activityLevel = 0;
            int genderBMR = 0;
            double BMR = 0;
            double caloric_intake = 0;

            if (Convert.ToBoolean(MaleRB.IsChecked))
            {
                genderBMR = 5;
            }
            else
            {
                genderBMR = -161;
            }
            switch (activityLevel)
            {
                default:
                    break;
            }
            BMR = (4.536 * weight) + (15.88 * height) - (5 * age) + genderBMR;

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

            caloric_intake = BMR * activityLevel;
            OutputBox.Text = $"Your daily caloric intake is {Convert.ToString(caloric_intake)}";
            

        }
    }
}
