using System;
using System.ComponentModel.DataAnnotations;

namespace Garderie.ViewModels.ArticleViewModels
{
    public class IndexArticleViewModel
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
