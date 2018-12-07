using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garderie.Models;

namespace Garderie.ViewModels.CategoriesArticleViewModels
{
    public class DetailsCategoriesArticleViewModel
    {
        public DetailsCategoriesArticleViewModel()
        {
            articles = new HashSet<Article>();
        }
        public int CategorieId { get; set; }
        public string Nom { get; set; }

        public ICollection<Article> articles { get; set; }
    }
}
