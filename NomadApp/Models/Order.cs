using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.Models
{
    public class Order : Entity
    {
        public DateTime DepatureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }

        public virtual Magazine Magazine { get; set; }
        public virtual Client Client { get; set; }
    }
}
