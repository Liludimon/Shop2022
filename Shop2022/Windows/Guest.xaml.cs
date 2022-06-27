﻿using System;
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

namespace Shop2022.Windows
{
    /// <summary>
    /// Логика взаимодействия для Guest.xaml
    /// </summary>
    public partial class Guest : Window
    {
        public Guest()
        {
            InitializeComponent();
            productElem.ItemsSource = Helpers.connection.Product.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Store.user = null;
            new MainWindow().Show();
            Close();
        }
    }
}
