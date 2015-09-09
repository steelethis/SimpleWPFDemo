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

namespace WPFDemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool toggleButton;
        public MainWindow()
        {
            InitializeComponent();
            toggleButton = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBox.Items.Add($"Item{i}");
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBox.Text = comboBox.SelectedItem.ToString() + " Selected";
        }

        private void toggleButton1_Checked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "ToggleButton Checked";

        }

        private void toggleButton1_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "ToggleButton Unchecked";
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "RadioButton Checked";
        }

        private void radioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "RadioButton Unchecked";
        }
    }
}
