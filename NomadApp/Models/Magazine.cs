using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.Models
{
    public class Magazine : Entity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
