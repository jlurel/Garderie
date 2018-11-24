using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class Tvas
    {
        public Tvas()
        {
            ObjetsFacturables = new HashSet<ObjetsFacturables>();
        }

        public int Tvaid { get; set; }
        public string Nom { get; set; }
        public double? Valeur { get; set; }
        public byte Visible { get; set; }

        public ICollection<ObjetsFacturables> ObjetsFacturables { get; set; }
    }
}
