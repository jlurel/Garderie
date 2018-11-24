using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class DossiersContactUrgence
    {
        public int DossierContactUrgenceId { get; set; }
        public string LienParente { get; set; }
        public int ContactId { get; set; }
        public byte Visible { get; set; }
        public int DossierInscriptionId { get; set; }

        public ContactUrgence Contact { get; set; }
        public DossiersInscription DossierInscription { get; set; }
    }
}
