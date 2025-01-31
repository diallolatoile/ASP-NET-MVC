using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Media
    {
        [Key]
        public int MediaId { get; set; }

        [Display(Name = "URL du Media")]
        [MaxLength(500, ErrorMessage = "L'URL ne peut pas dépasser 500 caractères.")]
        public string Url { get; set; }

        [Display(Name = "Type de Media")]
        public string Type { get; set; }

        // Relation
        [ForeignKey("Bien")]
        public int BienId { get; set; }
        public virtual Bien Bien { get; set; }
    }
}