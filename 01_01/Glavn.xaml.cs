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
        
        public Glavn()
        {
            InitializeComponent();
        
        }

        private void table_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItemMyusl_Click(object sender, RoutedEventArgs e)
        {
            
            MainFrame.Navigate(new Myusl());
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
