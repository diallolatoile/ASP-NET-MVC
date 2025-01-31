using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Bien
    {
        [Key]
        public int BienId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Libelle Bien")]
        [MaxLength(100, ErrorMessage = "Le libellé ne peut pas dépasser 100 caractères.")]
        public string LibelleBien { get; set; }

        [Display(Name = "Description")]
        public string DescriptionBien { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Prix Journalier")]
        public decimal PrixJournalier { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Région")]
        [MaxLength(50, ErrorMessage = "Le nom de la région ne peut pas dépasser 50 caractères.")]
        public string Region { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Pays")]
        [MaxLength(50, ErrorMessage = "Le nom du pays ne peut pas dépasser 50 caractères.")]
        public string Pays { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [Required(ErrorMessage = "*")]
        public int NbreChambre { get; set; }

        [Required(ErrorMessage = "*")]
        public int NbreLit { get; set; }

        [Required(ErrorMessage = "*")]
        public int NbreSalleBain { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Type de Bien")]
        public string TypeBien { get; set; }

        public bool Disponible { get; set; }
        public DateTime DateAjout { get; set; }
        public string Adresse { get; set; }

        // Relations
        public virtual ICollection<Annonce> Annonces { get; set; }
        public virtual ICollection<Media> Medias { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }

}