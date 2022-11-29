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
    /// Логика взаимодействия для Tarif.xaml
    /// </summary>
    public partial class Tarif : Page
    {
        public Tarif()
        {
            InitializeComponent();
            List<_01_01.USl> reisii = new List<_01_01.USl>();
            reisii = TEL_USL_01_01Entities.GetContext().USl.ToList();
            tarif.ItemsSource = reisii;
            Tarif customer = (Tarif)tarif.SelectedItem;
        }
    }
}
