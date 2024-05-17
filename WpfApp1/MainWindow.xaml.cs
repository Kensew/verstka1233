﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            // Здесь должна быть логика проверки имени пользователя и пароля
            if (username == "admin" && password == "password") // Пример простой проверки
            {
                MessageBox.Show("Авторизация успешна!");
                OpenListWindow();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль.");
            }
        }

        private void GuestButton_Click(object sender, RoutedEventArgs e)
        {
            OpenListWindow();
        }

        private void OpenListWindow()
        {
            ListWindow listWindow = new ListWindow();
            listWindow.Show();
            this.Close();
        }
    }
}