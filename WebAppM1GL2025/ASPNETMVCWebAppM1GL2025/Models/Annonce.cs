using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Annonce
    {
        [Key]
        public int AnnonceId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Date Début Annonce")]
        public DateTime DateDebutAnnonce { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Date Fin Annonce")]
        public DateTime DateFinAnnonce { get; set; }

        [Display(Name = "Statut Annonce")]
        public bool StatutAnnonce { get; set; }

        public string DescriptionAnnonce { get; set; }

        // Relation
        [ForeignKey("Bien")]
        public int BienId { get; set; }
        public virtual Bien Bien { get; set; }
    }

}