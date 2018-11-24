using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class StatutsFacture
    {
        public StatutsFacture()
        {
            Factures = new HashSet<Factures>();
        }

        public int StatutFactureId { get; set; }
        public string Libelle { get; set; }

        public ICollection<Factures> Factures { get; set; }
    }
}
