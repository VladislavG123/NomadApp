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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NomadApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientLoginFrame.xaml
    /// </summary>
    public partial class ClientLoginFrame : Page
    {

        public ClientLoginFrame()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ClientRegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            ClientRegistration clientRegistrationWindow = new ClientRegistration();
            clientRegistrationWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text.Length < 3 || PasswordTextBox.Password.Length < 3) return;

            using (var context = new AppContext())
            {
                foreach (var client in context.Clients)
                {
                    if (client.Login == LoginTextBox.Text)
                    {
                        if (client.Password == PasswordTextBox.Password)
                        {
                            ClientCabinet clientCabinet = new ClientCabinet(client);
                            clientCabinet.Show();
                            
                        }
                        else
                            MessageBox.Show("Неверный пароль!");

                    }
                }
            }


        }

        
    }
}
