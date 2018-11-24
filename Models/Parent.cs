using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Garderie.Models
{
    public partial class Parent
    {
        public Parent()
        {
            Filiations = new HashSet<Filiations>();
            ParentsFactures = new HashSet<ParentsFactures>();
        }

        [ForeignKey(nameof(Personne))]
        public int ParentId { get; set; }
        public int? NbEnfantsInscrits { get; set; }
        public string Telephone { get; set; }

        public Personne Personne { get; set; }
        public ICollection<Filiations> Filiations { get; set; }
        public ICollection<ParentsFactures> ParentsFactures { get; set; }
    }
}
