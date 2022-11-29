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

        public string klient;

        public Myusl(string k)
        {
            InitializeComponent();
            klient = k;
          
        }
        public void Lib(string k)
        {
            int y=0;
            List<_01_01.Schet> user = new List<_01_01.Schet>();
            user = TEL_USL_01_01Entities.GetContext().Schet.ToList();
            int count = TEL_USL_01_01Entities.GetContext().Schet.Count();
            int count1 = TEL_USL_01_01Entities.GetContext().Client.Count();
            List<_01_01.Client> kk = new List<_01_01.Client>();
            kk = TEL_USL_01_01Entities.GetContext().Client.ToList();
            for (int i = 0; i < count1; i++)
            {
                if (kk[i].Login==k)
                {
                     y = kk[i].ID;
                }
            }
            for (int i = 0; i < count; i++)
            {
                if (Convert.ToString(user[i].id_client) != Convert.ToString(y)) 
                {
                    user.RemoveAt(i);
                    i--;
                    count--;
                }
            }
            Uslugi.Visibility = Visibility.Visible;
            Uslugi.ItemsSource = user;
            Myusl customer = (Myusl)Uslugi.SelectedItem;
        }
    }
}

