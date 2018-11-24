using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class Factures
    {
        public Factures()
        {
            ParentsFactures = new HashSet<ParentsFactures>();
        }

        public int FactureId { get; set; }
        public DateTime? DateEmission { get; set; }
        public DateTime? DatePaiement { get; set; }
        public double? MontantTtc { get; set; }
        public byte? Visible { get; set; }
        public int StatutFactureId { get; set; }

        public StatutsFacture StatutFacture { get; set; }
        public ICollection<ParentsFactures> ParentsFactures { get; set; }
    }
}
