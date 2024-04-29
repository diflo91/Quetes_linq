using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Species
    {
        public Guid SpeciesId { get; set; }
        public string Name { get; set; }


        public Species(Guid _SpeciesId, string _Name) 
        {
            SpeciesId = _SpeciesId;
            Name = _Name;
        }


    }
}
