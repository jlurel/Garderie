using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class TypesGroupe
    {
        public TypesGroupe()
        {
            Groupes = new HashSet<Groupes>();
        }

        public int TypeGroupeId { get; set; }
        public string Libelle { get; set; }

        public ICollection<Groupes> Groupes { get; set; }
    }
}
