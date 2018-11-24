using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class CompteUser
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte Privilege { get; set; }
        public int PersonneId { get; set; }
        public byte? Visible { get; set; }

        public Personne Personne { get; set; }
    }
}
