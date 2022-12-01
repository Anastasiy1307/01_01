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
    /// Логика взаимодействия для Internet.xaml
    /// </summary>
    public partial class Internet : Page
    {
        public Internet()
        {
            InitializeComponent();
            List<_01_01.USl> act = new List<_01_01.USl>();
            act = TEL_USL_01_01Entities.GetContext().USl.ToList();
           
            int count = TEL_USL_01_01Entities.GetContext().USl.Count();
          
            internet.Visibility = Visibility.Visible;
            for (int i = 0; i < count; i++)
            {
                if (act[i].Usluga != "Интернет")
                {                    
                    act.RemoveAt(i);
                    i--;
                    count--;
                }
            }

            internet.ItemsSource = act;
            Internet customer2 = (Internet)internet.SelectedItem;
        }
    }
}
