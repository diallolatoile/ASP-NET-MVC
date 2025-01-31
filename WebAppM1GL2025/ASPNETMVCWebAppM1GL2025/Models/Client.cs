using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASPNETMVCWebAppM1GL2025.Models;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Client : Utilisateur
    {
        [Display(Name = "CNI"), MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Le CNI doit être composé de 9 chiffres.")]
        public string CNI { get; set; }

        [Display(Name = "Passport"), MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        public string Passport { get; set; }

        public DateTime DateNaissance { get; set; }
        public string Genre { get; set; }
        
        // Relations
        public virtual ICollection<Reservation> Reservations { get; set; } 
        public virtual ICollection<Review> Reviews { get; set; }
    }
}