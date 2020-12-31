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

namespace MoneyCalculator
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
       
        private void process_Click(object sender, RoutedEventArgs e)
        {
            float income = float.Parse(incomeTextBox.Text);
            float expenses = float.Parse(expensesTextBox.Text);
            float wishList = float.Parse(wishListTextBox.Text);
            float day = wishList / (income - expenses);
            int iday = (int)Math.Round(day);
            string sDay = iday.ToString();
            totalTextBlock.Text = sDay;
        }


    }
}
