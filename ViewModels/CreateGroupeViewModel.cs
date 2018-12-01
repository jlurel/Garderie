using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Garderie.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garderie.ViewModels
{
    public class CreateGroupeViewModel
    {

        [Required]
        public String Descriptif { get; set; }

        [Required]
        public SelectList Referants { get; set; }
        public Employe Referant { get; set; }


        public SelectList TypesGroupe { get; set; }
        [Required]
        [Display(Name = "Type")]
        public TypeGroupe TypeGroupe { get; set; }

    }
}
