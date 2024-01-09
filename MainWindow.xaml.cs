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

namespace BMICaculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
           
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int heightInCm = Convert.ToInt32(heightBox.Text);
            float heightInM = heightInCm / 100.0f;
            float massInKg = float.Parse(massBox.Text);
            float BMI = (float)(massInKg / Math.Pow(heightInM, 2));
            bmiBox.Text = BMI.ToString("F2");

            // Set background color based on BMI categories
            if (BMI < 18.5)
            {
                bmiBox.Background = Brushes.Blue;
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                bmiBox.Background = Brushes.Green;
            }
            else if (BMI >= 25 && BMI < 30)
            {
                bmiBox.Background = Brushes.Yellow;
            }
            else if (BMI >= 30 && BMI < 35)
            {
                bmiBox.Background = Brushes.Orange;
            }
            else
            {
                bmiBox.Background = Brushes.Red;
            }

            // Display BMI status
            DisplayBMIStatus(BMI);
        }

        private void DisplayBMIStatus(float BMI)
        {
            if (BMI < 18.5)
            {
                bmiStatus.Text = "Underweight";
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                bmiStatus.Text = "Normal";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                bmiStatus.Text = "Overweight";
            }
            else if (BMI >= 30 && BMI < 35)
            {
                bmiStatus.Text = "Obese";
            }
            else
            {
                bmiStatus.Text = "Extremely Obese";
            }
        }

        private void heightBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void massBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bmiBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

