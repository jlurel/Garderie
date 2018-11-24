using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public class Personne
    {
        public Personne()
        {
            ComptesUser = new HashSet<CompteUser>();
            PersonneAdresses = new HashSet<PersonneAdresse>();
        }

        public int PersonneId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string NumSecu { get; set; }
        public byte? Visible { get; set; }
        public string Discriminator { get; set; }

        public ICollection<CompteUser> ComptesUser { get; set; }
        public ICollection<PersonneAdresse> PersonneAdresses { get; set; }
    }
}
