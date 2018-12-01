using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public class DossierContactUrgence
    {
        public string LienParente { get; set; }
        public int ContactId { get; set; }
        public byte Visible { get; set; }
        public int DossierInscriptionId { get; set; }

        public ContactUrgence Contact { get; set; }
        public DossierInscription DossierInscription { get; set; }
    }
}
