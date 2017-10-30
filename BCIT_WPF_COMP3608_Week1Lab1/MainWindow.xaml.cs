using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BCIT_WPF_COMP3608_Week1Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Krzysztof Szczurowski - COMP3608
    /// Repo: https://github.com/kriss3/BCIT_WPF_COMP3608_Week1Lab1.git
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (FontFamily F in Fonts.SystemFontFamilies)
            {
                comboBox1.Items.Add(F.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selection = richTextBox1.Selection.GetPropertyValue(FontWeightProperty).ToString();

            if (selection.Equals("Bold"))
            {
                richTextBox1.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Normal);
            }
            else
            {
                richTextBox1.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Bold);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selection = richTextBox1.Selection.GetPropertyValue(FontStyleProperty).ToString();
   
            if (selection.Equals("Normal"))
            {
                richTextBox1.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Italic);
            }
            else
            {
                richTextBox1.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Normal);
            }
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            richTextBox1.Selection.ApplyPropertyValue(FontSizeProperty, Slider1.Value.ToString());
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            richTextBox1.Selection.ApplyPropertyValue(FontFamilyProperty, new FontFamily(comboBox1.Text));
        }
    }
}
