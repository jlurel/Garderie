using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Garderie.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garderie.ViewModels
{
    public class EditGroupeViewModel
    {
        public EditGroupeViewModel()
        {
        }

        public int GroupeId { get; set; }

        [Required]
        public String Descriptif
        {
            get;
            set;
        }

        [Required]
        public SelectList Referants
        {
            get;
            set;
        }
        public Employe Referant { get; set; }

        [Required]
        [Display(Name = "Type")]
        public SelectList TypesGroupe { get; set; }
        public TypeGroupe TypeGroupe { get; set; }
    }
}
