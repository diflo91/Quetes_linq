using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Animal
    {
        public Guid AnimalId { get; set; }
        public string Name { get; set; }
        public string DateNaissance { get; set; }
        public Species Species { get; set; }
    }
}
