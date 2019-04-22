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
    /// Логика взаимодействия для ClientRegistration.xaml
    /// </summary>
    public partial class ClientRegistration : Window
    {
        public ClientRegistration()
        {
            InitializeComponent();
        }

        private bool CheckValues()
        {
            bool isCorrect = true;
            if (LoginTextBox.Text.Length < 3)
            {
                isCorrect = false;
                LoginTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                LoginTextBox.BorderBrush = Brushes.Green;
            }

            if (PasswordTextBox.Text.Length < 3)
            {
                isCorrect = false;
                PasswordTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                PasswordTextBox.BorderBrush = Brushes.Green;
            }

            if (SecondPasswordTextBox.Text != PasswordTextBox.Text)
            {
                isCorrect = false;
                SecondPasswordTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                SecondPasswordTextBox.BorderBrush = Brushes.Green;
            }

            if (FullNameTextBox.Text.Length < 3)
            {
                isCorrect = false;
                FullNameTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                FullNameTextBox.BorderBrush = Brushes.Green;
            }

            if (PhoneTextBox.Text.Length < 11)
            {
                isCorrect = false;
                PhoneTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                PhoneTextBox.BorderBrush = Brushes.Green;
            }

            if (EmailTextBox.Text.Length < 3)
            {
                isCorrect = false;
                EmailTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                EmailTextBox.BorderBrush = Brushes.Green;
            }

            if (CountryTextBox.Text.Length < 3)
            {
                isCorrect = false;
                CountryTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                CountryTextBox.BorderBrush = Brushes.Green;
            }

            if (CityTextBox.Text.Length < 3)
            {
                isCorrect = false;
                CityTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                CityTextBox.BorderBrush = Brushes.Green;
            }

            if (AddressTextBox.Text.Length < 3)
            {
                isCorrect = false;
                AddressTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                AddressTextBox.BorderBrush = Brushes.Green;
            }

            if (BankCardTextBox.Text.Length < 3)
            {
                isCorrect = false;
                BankCardTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                BankCardTextBox.BorderBrush = Brushes.Green;
            }

            return isCorrect;
        }

        private void NextTextBox_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValues())
            {
                using (var context = new AppContext())
                {
                    foreach (var client in context.Clients)
                    {
                        if (client.Login == LoginTextBox.Text)
                        {
                            MessageBox.Show("Этот логин уже занят, ведите другой");
                            LoginTextBox.BorderBrush = Brushes.Red;
                            return;
                        }
                    }

                    Client newClient = new Client
                    {
                        Login = LoginTextBox.Text,
                        Password = PasswordTextBox.Text,
                        FullName = FullNameTextBox.Text,
                        Phone = PhoneTextBox.Text,
                        Email = EmailTextBox.Text,
                        Country = CountryTextBox.Text,
                        City = CityTextBox.Text,
                        Address = AddressTextBox.Text,
                        BankCard = BankCardTextBox.Text,
                        AmountSubscribesMonths = 0
                    };

                    try
                    {
                        context.Clients.Add(newClient);
                        context.SaveChanges();
                        MessageBox.Show("Регистрация прошла успешно!");
                        Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Возникла ошибка!");
                    }

                }
            }
        }
    }
}

