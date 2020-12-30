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

namespace Helloapp
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
        float income = 0;
        float expenses = 0;
        float wishList = 0;
        float total = 0;
        private void incomeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void process_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GGG");
        }
    }
}
