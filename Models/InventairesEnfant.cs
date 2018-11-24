using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class InventairesEnfant
    {
        public InventairesEnfant()
        {
            Articles = new HashSet<Article>();
            Enfants = new HashSet<Enfant>();
        }

        public int InventaireId { get; set; }
        public byte? Visible { get; set; }

        public ICollection<Article> Articles { get; set; }
        public ICollection<Enfant> Enfants { get; set; }
    }
}
