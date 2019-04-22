using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.Models
{
    public class Client : Entity
    {
        public string Login { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string BankCard { get; set; }
        public int AmountSubscribesMonths { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
    }
}
