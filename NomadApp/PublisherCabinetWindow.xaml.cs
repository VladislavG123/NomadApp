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
    /// Логика взаимодействия для PublisherCabinetWindow.xaml
    /// </summary>
    public partial class PublisherCabinetWindow : Window
    {
        private Publisher _publisher { get; set; }
        public PublisherCabinetWindow(Publisher publisher)
        {
            InitializeComponent();
            _publisher = publisher;
            AccounInfo.Content += $"Name - {_publisher.Name}\nMoney - {_publisher.Money}";

            using (var context = new AppContext())
            {
               /* foreach (var magazine in context.Magazines)
                {
                    if (magazine.Publisher.Id == _publisher.Id)
                    {
                        StatisticInfo.Content += $"Head Name - {magazine.Name}\nContent {magazine.Content}\nRelease Date - {magazine.ReleaseDate}";
                    }
                }*/
            }

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text.Length > 1 && InfoTextBox.Text.Length > 1)
            {
                using (var context = new AppContext())
                {
                    context.Magazines.Add(new Magazine
                    {
                        Name = NameTextBox.Text,
                        Content = InfoTextBox.Text,
                        ReleaseDate = DateTime.Now,
                    });
                    context.SaveChanges();
                    MessageBox.Show("Журнал добавлен");
                }
            }
        }
    }
}
