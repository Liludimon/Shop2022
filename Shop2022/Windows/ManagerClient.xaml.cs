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
    /// Логика взаимодействия для ManagerClient.xaml
    /// </summary>
    public partial class ManagerClient : Window
    {
        private User user = Store.user;
        public ManagerClient()
        {
            InitializeComponent();
            fioElem.Content = $"{user.UserSurname} {user.UserName} {user.UserPatronymic}";
            productElem.ItemsSource = Helpers.connection.Product.ToList();

            List<string> manuf = new List<string>();
            manuf.Add("Все производители");
            manuf.AddRange(Helpers.connection.Product.Select(x => x.ProductManufacturer).Distinct().ToList());

            filtrElem.ItemsSource = manuf;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Store.user = null;
            new MainWindow().Show();
            Close();
        }

        private void findElem_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Product> products = Helpers.connection.Product.Where(x => x.ProductName.Contains(findElem.Text)).ToList();
            productElem.ItemsSource = products;
        }

        private void filtrElem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string manuf = filtrElem.SelectedItem.ToString();
            List<Product> products = new List<Product>();
            if (manuf == "Все производители")
            {
                products = Helpers.connection.Product.ToList();
            }
            else
            {
                products = Helpers.connection.Product.Where(x => x.ProductManufacturer == manuf).ToList();
            }

            productElem.ItemsSource = products;
        }
    }
}
