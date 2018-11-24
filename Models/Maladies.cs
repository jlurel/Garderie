using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class Maladies
    {
        public Maladies()
        {
            Traitements = new HashSet<Traitements>();
        }

        public int MaladieId { get; set; }
        public string Nom { get; set; }
        public string Descriptif { get; set; }
        public byte? Visible { get; set; }

        public ICollection<Traitements> Traitements { get; set; }
    }
}
