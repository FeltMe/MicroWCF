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
using ClientForDz2.ServiceReference1;

namespace ClientForDz2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertClick(object sender, RoutedEventArgs e)
        {
            AllWork();
        }

        private void AllWork()
        {
            try
            {

                if (string.IsNullOrEmpty(TextBoxForMetrs.Text) == false)
                {
                    var num = Double.Parse(TextBoxForMetrs.Text);
                    using (ConverterClient client = new ConverterClient())
                    {
                        var s = client.LinearMeasure(num);
                        TextBoxForFeets.Text = s.Feets.ToString();
                        TextBoxForInches.Text = s.Inches.ToString();
                        TextBoxForYards.Text = s.Yards.ToString();
                    }
                }
                if (string.IsNullOrEmpty(TextBoxForCelsius.Text) == false)
                {
                    using (ConverterClient client = new ConverterClient())
                    {
                        var num = Double.Parse(TextBoxForCelsius.Text);
                        var s = client.CelsiusToFahrenheit(num);
                        TextBoxForWriteFahrenheit.Text = s.Fahrenheit.ToString();
                    }
                }
                if (string.IsNullOrEmpty(TextBoxForFahrenheit.Text) == false)
                {
                    using (ConverterClient client = new ConverterClient())
                    {
                        var num = Double.Parse(TextBoxForFahrenheit.Text);
                        var s = client.FahrenheitToCelsius(num);
                        TextBoxForWriteCelsius.Text = s.Fahrenheit.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("No data available");
            }
        }
    }
}
