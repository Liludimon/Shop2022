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
using Shop2022.Windows;

namespace Shop2022.Windows
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        private User user = Store.user;
        public Admin()
        {
            InitializeComponent();
            
            fioElem.Content = $"{user.UserSurname} {user.UserName} {user.UserPatronymic}";
            productElem.ItemsSource = Helpers.connection.Product.ToList();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Add().Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = (Product)productElem.SelectedItem;

            if (product == null)
            {
                MessageBox.Show("Вы не выбрали товар, который хотите отредактировать!");
                return;
            }
            new Edit(product).Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Product product = (Product)productElem.SelectedItem;

            if (product == null)
            {
                MessageBox.Show("Вы не выбрали товар, который хотите удалить!");
                return;
            }

            Helpers.connection.Product.Remove(product); 
            Helpers.connection.SaveChanges(); 
            productElem.ItemsSource = Helpers.connection.Product.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Store.user = null;
            new MainWindow().Show();
            Close();
        }
    }
}