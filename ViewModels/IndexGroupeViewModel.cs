using System;
using System.ComponentModel.DataAnnotations;

namespace Garderie.ViewModels
{
    public class IndexGroupeViewModel
    {
        public IndexGroupeViewModel()
        {
        }
        public int GroupeId { get; set; }
        public string Descriptif { get; set; }
        public string Referant { get; set; }
        [Display(Name = "Type")]
        public string TypeGroupe { get; set; }
    }
}
