using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Manager : Utilisateur
    {
        [Required(ErrorMessage = "Le NINEA est requis.")]
        [Display(Name = "NINEA"), MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Le NINEA doit être composé de 9 chiffres.")]
        public string NINEA { get; set; }


        [Required(ErrorMessage = "Le RCCM est requis.")]
        [Display(Name = "RCCM"), MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        public string RCCM { get; set; }

    }
}