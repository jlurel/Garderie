using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class DossiersInscription
    {
        public DossiersInscription()
        {
            DocumentsOfficiels = new HashSet<DocumentOfficiel>();
            DossiersContactUrgence = new HashSet<DossiersContactUrgence>();
            RapportJournalier = new HashSet<RapportJournalier>();
        }

        public int DossierId { get; set; }
        public DateTime? DateInscription { get; set; }
        public int? NbDemiJourneesInscrit { get; set; }
        public int? NbDemiJourneesAbsent { get; set; }
        public string MedecinTraitant { get; set; }
        public int EnfantId { get; set; }
        public byte? Visible { get; set; }

        public Enfant Enfant { get; set; }
        public ICollection<DocumentOfficiel> DocumentsOfficiels { get; set; }
        public ICollection<DossiersContactUrgence> DossiersContactUrgence { get; set; }
        public ICollection<RapportJournalier> RapportJournalier { get; set; }
    }
}
