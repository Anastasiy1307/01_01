using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _01_01
{
    /// <summary>
    /// Логика взаимодействия для Glavn.xaml
    /// </summary>
    public partial class Glavn : Window
    {
        public string k;
        public Glavn(string klient)
        {
            InitializeComponent();
            k= klient;
        }

        private void table_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItemMyusl_Click(object sender, RoutedEventArgs e)
        {

            Myusl myusl = new Myusl(k);
            myusl.Lib(k);
            MainFrame.Navigate(myusl);
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Tarif tarif = new Tarif();
            MainFrame.Navigate(tarif);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Internet internet = new Internet();
            MainFrame.Navigate(internet);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Mob mob = new Mob();
            MainFrame.Navigate(mob);
        }

        private void kab(object sender, RoutedEventArgs e)
        {
            Pol pol = new Pol();
            MainFrame.Navigate(pol);
        }
    }
}
