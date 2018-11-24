using System;
using System.Collections.Generic;

namespace Garderie.Models
{
    public partial class EmployeGroupes
    {
        public int GroupeId { get; set; }
        public int EmployeId { get; set; }

        public Employe Employe { get; set; }
        public Groupes Groupe { get; set; }
    }
}
