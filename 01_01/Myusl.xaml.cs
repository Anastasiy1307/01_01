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
    /// Логика взаимодействия для Myusl.xaml
    /// </summary>
    public partial class Myusl : Page
    {
        public Myusl()
        {
            InitializeComponent();
            Uslugi.ItemsSource = TEL_USL_01_01Entities.GetContext().Schet.ToList();
            Myusl customer = (Myusl)Uslugi.SelectedItem;
        }
    }
}
