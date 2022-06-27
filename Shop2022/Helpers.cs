using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shop2022
{
    public static class Helpers
    {
        public static Connection connection = new Connection();
        public static User Auth(string login, string password)
        {
            User user = connection.User.FirstOrDefault(x => x.UserLogin == login);

            if (user == null)
            {
                MessageBox.Show("Пользователь не найден!");
            }

            if (user.UserPassword != password)
            {
                MessageBox.Show("Пароли не совпадают!");
                return null;
            }

            return user;
        }
    }
}

