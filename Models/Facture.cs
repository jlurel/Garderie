using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class Facture
    {
        public Facture()
        {
            ParentsFactures = new HashSet<ParentFacture>();
        }

        public int FactureId { get; set; }
        public DateTime? DateEmission { get; set; }
        public DateTime? DatePaiement { get; set; }
        public double? MontantTtc { get; set; }
        public byte? Visible { get; set; }
        public int StatutFactureId { get; set; }

        public StatutFacture StatutFacture { get; set; }
        public ICollection<ParentFacture> ParentsFactures { get; set; }
    }
}
