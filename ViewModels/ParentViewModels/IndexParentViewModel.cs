using System;
using System.ComponentModel.DataAnnotations;

namespace Garderie.ViewModels.ParentViewModels
{
    public class IndexParentViewModel
    {
        public int ParentId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string NumSecu { get; set; }
        public string Telephone { get; set; }
        public int? NbEnfantsInscrits { get; set; }
    }
}
