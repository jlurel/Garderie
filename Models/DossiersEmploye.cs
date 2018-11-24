using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class DossiersEmploye
    {
        public DossiersEmploye()
        {
            Conges = new HashSet<Conge>();
            FichesPaye = new HashSet<FichesPaye>();
        }

        public int DossierId { get; set; }
        public DateTime? DateEntree { get; set; }
        public int? NbMoisAnciennete { get; set; }
        public double? TauxHoraireBrut { get; set; }
        public byte? Visible { get; set; }
        public int TypeContratId { get; set; }
        public int EmployeId { get; set; }

        public Employe Employe { get; set; }
        public TypesContrat TypeContrat { get; set; }
        public ICollection<Conge> Conges { get; set; }
        public ICollection<FichesPaye> FichesPaye { get; set; }
    }
}
