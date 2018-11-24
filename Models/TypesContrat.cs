using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class TypesContrat
    {
        public TypesContrat()
        {
            DossiersEmploye = new HashSet<DossiersEmploye>();
        }

        public int TypeContratId { get; set; }
        public string Libelle { get; set; }

        public ICollection<DossiersEmploye> DossiersEmploye { get; set; }
    }
}
