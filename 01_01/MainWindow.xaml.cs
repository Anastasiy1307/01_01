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

namespace _01_01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxLog_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxLog_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            Avtoriz avtor = new Avtoriz();
            avtor.Show();
            Close();
        }

        
    }
}
