 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ASPNETMVCWebAppM1GL2025.Models;

namespace ASPNETMVCWebAppM1GL2025.Models
{
    public class TripAdvisorDBContext : DbContext
    {
        public TripAdvisorDBContext() : base("ConnTripAdvisor")
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Bien> Biens { get; set; }
        public DbSet<Annonce> Annonces { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<ASPNETMVCWebAppM1GL2025.Models.Utilisateur> Utilisateurs { get; set; }
    }

}