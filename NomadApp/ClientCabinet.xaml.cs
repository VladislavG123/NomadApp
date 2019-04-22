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
    /// Логика взаимодействия для ClientCabinet.xaml
    /// </summary>
    public partial class ClientCabinet : Window
    {
        private Client _client;

        public ClientCabinet(Client client)
        {
            _client = client;
            InitializeComponent();
            
        }
    }
}
