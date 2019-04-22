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
    /// Логика взаимодействия для PublicsherLoginPage.xaml
    /// </summary>
    public partial class PublicsherLoginPage : Page
    {
        public PublicsherLoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text.Length < 3 || PasswordTextBox.Password.Length < 3) return;

            using (var context = new AppContext())
            {
                foreach (var publisher in context.Publishers)
                {
                    if (publisher.Login == LoginTextBox.Text)
                    {
                        if (publisher.Password == PasswordTextBox.Password)
                        {
                            PublisherCabinetWindow publisherCabinet = new PublisherCabinetWindow(publisher);
                            publisherCabinet.Show();
                        }
                        else
                            MessageBox.Show("Неверный пароль!");

                    }
                }
            }
        }

        private void PublisherRegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            PublisherRegistrationWindow publisherRegistrationWindow = new PublisherRegistrationWindow();
            publisherRegistrationWindow.Show();
        }
    }
}
