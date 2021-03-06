﻿using System;
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
            string income_text = RemoveNonNumber(incomeTextBox.Text);
            incomeTextBox.Text = income_text;
            float income = float.Parse(income_text);

            string expenses_text = RemoveNonNumber(expensesTextBox.Text);
            expensesTextBox.Text = expenses_text;
            float expenses = float.Parse(expenses_text);
            

            string wishList_text = RemoveNonNumber(wishListTextBox.Text);
            wishListTextBox.Text = wishList_text;
            float wishList = float.Parse(wishList_text);

            

            float day = wishList / (income - expenses);
            int iday = (int)Math.Round(day);
            string sDay = iday.ToString();
            totalTextBlock.Text = sDay;
        }

        public string RemoveNonNumber(string input)
		{
            string output = "";
            foreach (char c in input)
			{
                if (c == '-')
                    output += c;
                else if (c == '.')
                    output += c;
                else if (char.IsDigit(c))
                    output += c;
			}
            return output;
		}
    }
}
