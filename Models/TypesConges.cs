using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class TypesConges
    {
        public TypesConges()
        {
            Conges = new HashSet<Conge>();
        }

        public int TypeCongeId { get; set; }
        public string Type { get; set; }

        public ICollection<Conge> Conges { get; set; }
    }
}
