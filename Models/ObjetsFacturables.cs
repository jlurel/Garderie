using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class ObjetsFacturables
    {
        public ObjetsFacturables()
        {
            LignesFactures = new HashSet<LignesFactures>();
        }

        public int ObjetFacturableId { get; set; }
        public double? PrixHt { get; set; }
        public string Nom { get; set; }
        public int Tvaid { get; set; }
        public int? ActiviteId { get; set; }
        public byte? Visible { get; set; }

        public Activite Activite { get; set; }
        public Tvas Tva { get; set; }
        public ICollection<LignesFactures> LignesFactures { get; set; }
    }
}
