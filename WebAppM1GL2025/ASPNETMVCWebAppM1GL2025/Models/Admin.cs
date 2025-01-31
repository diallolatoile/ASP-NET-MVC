using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Admin : Utilisateur
    {
        [Required(ErrorMessage = "Le matricule est requis.")]
        [MaxLength(20, ErrorMessage = "La taille maximale du matricule est de 20 caractères.")]
        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "Le matricule ne peut contenir que des lettres et des chiffres.")]
        [Display(Name = "Matricule")]
        public string Matricule { get; set; }
    }
}