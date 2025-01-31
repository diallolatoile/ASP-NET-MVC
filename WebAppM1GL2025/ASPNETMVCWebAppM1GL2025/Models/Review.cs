using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ASPNETMVCWebAppM1GL2025.Models;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Date du Avis")]
        public DateTime DateAvis { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Commentaire")]
        public string Commentaire { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(1, 5, ErrorMessage = "La note doit être comprise entre 1 et 5.")]
        public int Note { get; set; }

        // Relation
        [ForeignKey("Bien")]
        public int BienId { get; set; }
        public virtual Bien Bien { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }

}