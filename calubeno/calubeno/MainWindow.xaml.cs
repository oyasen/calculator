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

namespace calubeno
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

        private void sum_button(object sender, RoutedEventArgs e)
        {
            try
            {
                
                int sum = int.Parse(num1_t.Text) + int.Parse(num2_t.Text);
                result.Content = sum;
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }
    }
}
