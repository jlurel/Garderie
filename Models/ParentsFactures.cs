using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class ParentsFactures
    {
        public int FactureId { get; set; }
        public int ParentId { get; set; }
        public int Visible { get; set; }

        public Factures Facture { get; set; }
        public Parent Parent { get; set; }
    }
}
