using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garderie.ViewModels.ArticleViewModels
{
    public class DetailsArticleViewModel
    {
        public int ArticleId { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public string Photo { get; set; }
        public byte Visible { get; set; }
        public string Description { get; set; }
        public int? EnfantInventaireId { get; set; }
        public string Categorie { get; set; }



    }
}
