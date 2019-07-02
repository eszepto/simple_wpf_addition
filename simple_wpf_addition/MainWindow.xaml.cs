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

using System.Text.RegularExpressions;

namespace simple_wpf_addition
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
            bool isTextXNumeric = double.TryParse(TextX.Text, out double firstValue);
            bool isTextYNumeric = double.TryParse(TextY.Text, out double secondValue);

            if ( isTextXNumeric && isTextYNumeric)
            {
                double answerValue = firstValue + secondValue;
                TextAnswer.Text = answerValue.ToString();

                LabelError.Content = string.Empty;
            }

            else
            {
                LabelError.Content = "invalid value";

            }
        }

        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]");
            e.Handled = regex.IsMatch(e.Text);
        }

        
    }
}
