using NomadApp.Models;
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

namespace NomadApp
{
    /// <summary>
    /// Логика взаимодействия для PublisherRegistrationWindow.xaml
    /// </summary>
    public partial class PublisherRegistrationWindow : Window
    {
        public PublisherRegistrationWindow()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new AppContext())
            {
                foreach (var publisher in context.Publishers)
                {
                    if (publisher.Login == LoginTextBox.Text)
                    {
                        MessageBox.Show("Данный логин уже занят");
                        return;
                    }
                }

                Publisher newPublisher = new Publisher
                {
                    Login = LoginTextBox.Text,
                    Password = PasswordTextBox.Text,
                    Name = NameTextBox.Text,
                    Money = 0
                };
                context.Publishers.Add(newPublisher);

                context.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!");
                Hide();
            }
        }
    }
}
