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
using Shop2022.Windows;

namespace Shop2022
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = loginElem.Text;
            string password = passwordElem.Password;

            User user = Helpers.Auth(login, password);
            Store.user = user;
            if (user == null)
            { 
                return; 
            }
            if (user.UserPassword != password) {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }
            if (user.UserRole == 1)
            {
                new Admin().Show();
                Close();
            }
            else
            {
                new ManagerClient().Show();
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Guest().Show();
            Close();
        }
    }
}
