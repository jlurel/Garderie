using System;
using System.ComponentModel.DataAnnotations;

namespace Garderie.ViewModels.ActiviteViewModels
{
    public class IndexActiviteViewModel
    {
        public int ArticleId { get; set; }
        public string Nom { get; set; }
        [Display(Name = "Quantité")]
        public int Quantite { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        [Display(Name = "Catégorie")]
        public string Categorie { get; set; }
    }
}
