using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class LignesFactures
    {
        public int LigneId { get; set; }
        public double? TotalHt { get; set; }
        public double? TotalTtc { get; set; }
        public int? Quantite { get; set; }
        public int FactureId { get; set; }
        public int ObjetFacturableId { get; set; }
        public byte? Visible { get; set; }

        public ObjetsFacturables ObjetFacturable { get; set; }
    }
}
