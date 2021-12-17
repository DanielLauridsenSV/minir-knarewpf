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
using miniräknarewpf.Classlibrary;

namespace miniräknarewpf
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

        private void Checkresultsview()
        {
            if (Results.Text =="resultat")
            {
                Results.Text = "";
            }
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "1";
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "5";
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "8";
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "9"; 
        }

        private void Muliply_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "*";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text = "";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            Calculator calc = new();
            Results.Text = calc.Calculate(Results.Text);
        }

        private void Subtraktion_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "-";
        }

        private void Divided_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "/";
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            Checkresultsview();
            Results.Text += "+";
        }


    }
}
