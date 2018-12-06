using System;
using System.ComponentModel.DataAnnotations;

namespace Garderie.ViewModels.ParentViewModels
{
    public class CreateParentViewModel
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }
        [Required]
        public string Sexe { get; set; }
        [Required]
        [Display(Name = "Date de naissance")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateNaissance { get; set; }
        [Required]
        [Display(Name = "Numéro de sécurité sociale")]
        public string NumSecu { get; set; }
        [Required]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }
    }
}
