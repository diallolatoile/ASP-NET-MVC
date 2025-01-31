﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ASPNETMVCWebAppM1GL2025.Models;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Date Début Réservation")]
        public DateTime DateDebutRsv { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Date Fin Réservation")]
        public DateTime DateFinRsv { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Statut Réservation")]
        public string StatutRsv { get; set; }

        public decimal MontantRsv { get; set; }
        public int NombrePersonnes { get; set; }

        // Relation
        [ForeignKey("Bien")]
        public int BienId { get; set; }
        public virtual Bien Bien { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }

}