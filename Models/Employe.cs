using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Garderie.Models
{
    public partial class Employe
    {
        public Employe()
        {
            Calendriers = new HashSet<Calendrier>();
            DossiersEmploye = new HashSet<DossiersEmploye>();
            EmployeGroupes = new HashSet<EmployeGroupes>();
            Groupes = new HashSet<Groupes>();
            Inventaires = new HashSet<Inventaires>();
        }

        [ForeignKey(nameof(Personne))]
        public int EmployeId { get; set; }
        public string Poste { get; set; }
        public byte? Externe { get; set; }
        public string Telephone { get; set; }

        public Personne Personne { get; set; }
        public ICollection<Calendrier> Calendriers { get; set; }
        public ICollection<DossiersEmploye> DossiersEmploye { get; set; }
        public ICollection<EmployeGroupes> EmployeGroupes { get; set; }
        public ICollection<Groupes> Groupes { get; set; }
        public ICollection<Inventaires> Inventaires { get; set; }
    }
}
