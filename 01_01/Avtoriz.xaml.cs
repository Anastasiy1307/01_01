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
using System.Windows.Shapes;

namespace _01_01
{
    /// <summary>
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Window
    {
        public Avtoriz()
        {
            InitializeComponent();
        }
        List<_01_01.Client> users = new List<_01_01.Client>();
        private void avt_Click(object sender, RoutedEventArgs e)
        {
            string klients = TextBoxLog.Text;
            string pas = TextBoxpass.Password;
            int count = TEL_USL_01_01Entities.GetContext().Client.Count();
            users = TEL_USL_01_01Entities.GetContext().Client.ToList();
            for (int i = 0; i < count; i++)
            {
                if (users[i].Login == klients)
                {
                    if (users[i].Password == pas)
                    {
                        Glavn glavn1 = new Glavn();
                        glavn1.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }          
           
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow reg = new MainWindow();
            reg.Show();
            Close();
        }

        private void TextBoxLog_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
