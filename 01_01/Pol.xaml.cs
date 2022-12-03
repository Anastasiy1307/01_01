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
    /// Логика взаимодействия для Pol.xaml
    /// </summary>
    public partial class Pol : Page
    {

        public string klient;
        public List<_01_01.Client> kk = new List<_01_01.Client>() { new Client() };

        public Pol(string k)
        {
            InitializeComponent();
            klient = k;
            List<_01_01.Client> u = new List<Client>();
            u= TEL_USL_01_01Entities.GetContext().Client.ToList();
            Lib(klient);
            yy.Text = kk[0].Name;
            yy_Copy.Text = kk[0].Familia;
            yy_Copy1.Text = kk[0].Login;
            yy_Copy2.Text = kk[0].Password;
            
        }
        public void Lib(string k)
        {
            int y = 0;
            List<_01_01.Client> user = new List<_01_01.Client>();
            user = TEL_USL_01_01Entities.GetContext().Client.ToList();
            int count1 = TEL_USL_01_01Entities.GetContext().Client.Count();
            
            for (int i = 0; i < count1; i++)
            {
                if (user[i].Login == k)
                {
                    kk[0] = user[i];
                }
            }
      
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}



    