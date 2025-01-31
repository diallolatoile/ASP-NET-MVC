using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Nom Prénom")]
        [MaxLength(160, ErrorMessage = "La taille maximale est de 160")]
        public string NomPrenom { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Téléphone")]
        [MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        public string Telephone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Email")]
        [MaxLength(80, ErrorMessage = "La taille maximale est de 80")]
        [Remote("CheckEmail", "Email", ErrorMessage = "Cet email est déjà pris")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Adresse")]
        [MaxLength(160, ErrorMessage = "La taille maximale est de 160")]
        public string Adresse { get; set; }

        [Required]
        [Display(Name = "Type d'Utilisateur")]
        public UtilisateurType UtilisateurType { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe")]
        [Compare("Password", ErrorMessage = "Les mots de passe ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

    public enum UtilisateurType
    {
        Admin,
        Client,
        Manager
    }

}
