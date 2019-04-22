using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.Models
{
    public class Publisher : Entity
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }

        public virtual ICollection<Magazine> Magazines { get; set; }
    }
}
