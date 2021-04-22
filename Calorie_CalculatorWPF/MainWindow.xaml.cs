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

namespace Calorie_CalculatorWPF
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
        // List of objects I created
        List<CalculatorWPF> calculator = new List<CalculatorWPF>();
        // Submit button method
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {

            // New Instance of c class
            CalculatorWPF c = new CalculatorWPF();

            double.TryParse(HeightInput.Text, out double Height);
            c.Height = Height;
            int.TryParse(WeightInput.Text, out int weight);
            c.Weight = weight;
            int.TryParse(AgeInput.Text, out int age);
            c.Age = age;
            int.TryParse(ActivityLevel.Text, out int activity_lvl);
            c.ActivityLevel = activity_lvl;
            if (MaleRadioButton.IsChecked == true)
            {
                c.Gender = "Male";
            }
            else if (FemaleRadioButton.IsChecked == true)
            {
                c.Gender = "Female";
            }

            
            calculator.Add(c);
            string s = c.OutputResult();
            OutputBox.Items.Add(s);

            HeightInput.Clear();
            WeightInput.Clear();
            AgeInput.Clear();
            ActivityLevel.Clear();

        }
    }
}
