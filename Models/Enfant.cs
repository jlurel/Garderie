using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Garderie.Models
{
    public class Enfant
    {
        public Enfant()
        {
            DossiersInscription = new HashSet<DossiersInscription>();
            Filiations = new HashSet<Filiations>();
            Traitements = new HashSet<Traitements>();
        }

        [ForeignKey(nameof(Personne))]
        public int EnfantId { get; set; }
        public string Photo { get; set; }
        public int GroupeId { get; set; }
        public int InventaireEnfantId { get; set; }

        public Personne Personne { get; set; }
        public Groupes Groupe { get; set; }
        public InventairesEnfant InventaireEnfant { get; set; }
        public ICollection<DossiersInscription> DossiersInscription { get; set; }
        public ICollection<Filiations> Filiations { get; set; }
        public ICollection<Traitements> Traitements { get; set; }
    }
}
