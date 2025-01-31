namespace ASPNETMVCWebAppM1GL2025.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MASPNETMVCWebAppM1GL2025Status : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomPrenom = c.String(nullable: false, maxLength: 160),
                        Telephone = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 80),
                        Adresse = c.String(nullable: false, maxLength: 160),
                        UtilisateurType = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                        Matricule = c.String(maxLength: 20),
                        CNI = c.String(maxLength: 20),
                        Passport = c.String(maxLength: 20),
                        DateNaissance = c.DateTime(),
                        Genre = c.String(),
                        NINEA = c.String(maxLength: 20),
                        RCCM = c.String(maxLength: 20),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Annonces",
                c => new
                    {
                        AnnonceId = c.Int(nullable: false, identity: true),
                        DateDebutAnnonce = c.DateTime(nullable: false),
                        DateFinAnnonce = c.DateTime(nullable: false),
                        StatutAnnonce = c.Boolean(nullable: false),
                        DescriptionAnnonce = c.String(),
                        BienId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AnnonceId)
                .ForeignKey("dbo.Biens", t => t.BienId, cascadeDelete: true)
                .Index(t => t.BienId);
            
            CreateTable(
                "dbo.Biens",
                c => new
                    {
                        BienId = c.Int(nullable: false, identity: true),
                        LibelleBien = c.String(nullable: false, maxLength: 100),
                        DescriptionBien = c.String(),
                        PrixJournalier = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Region = c.String(nullable: false, maxLength: 50),
                        Pays = c.String(nullable: false, maxLength: 50),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        NbreChambre = c.Int(nullable: false),
                        NbreLit = c.Int(nullable: false),
                        NbreSalleBain = c.Int(nullable: false),
                        TypeBien = c.String(nullable: false),
                        Disponible = c.Boolean(nullable: false),
                        DateAjout = c.DateTime(nullable: false),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.BienId);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        MediaId = c.Int(nullable: false, identity: true),
                        Url = c.String(maxLength: 500),
                        Type = c.String(),
                        BienId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MediaId)
                .ForeignKey("dbo.Biens", t => t.BienId, cascadeDelete: true)
                .Index(t => t.BienId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        DateDebutRsv = c.DateTime(nullable: false),
                        DateFinRsv = c.DateTime(nullable: false),
                        StatutRsv = c.String(nullable: false),
                        MontantRsv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NombrePersonnes = c.Int(nullable: false),
                        BienId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Biens", t => t.BienId, cascadeDelete: true)
                .ForeignKey("dbo.Utilisateurs", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.BienId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        DateAvis = c.DateTime(nullable: false),
                        Commentaire = c.String(nullable: false),
                        Note = c.Int(nullable: false),
                        BienId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Biens", t => t.BienId, cascadeDelete: true)
                .ForeignKey("dbo.Utilisateurs", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.BienId)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Annonces", "BienId", "dbo.Biens");
            DropForeignKey("dbo.Reservations", "ClientId", "dbo.Utilisateurs");
            DropForeignKey("dbo.Reviews", "ClientId", "dbo.Utilisateurs");
            DropForeignKey("dbo.Reviews", "BienId", "dbo.Biens");
            DropForeignKey("dbo.Reservations", "BienId", "dbo.Biens");
            DropForeignKey("dbo.Media", "BienId", "dbo.Biens");
            DropIndex("dbo.Reviews", new[] { "ClientId" });
            DropIndex("dbo.Reviews", new[] { "BienId" });
            DropIndex("dbo.Reservations", new[] { "ClientId" });
            DropIndex("dbo.Reservations", new[] { "BienId" });
            DropIndex("dbo.Media", new[] { "BienId" });
            DropIndex("dbo.Annonces", new[] { "BienId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Reservations");
            DropTable("dbo.Media");
            DropTable("dbo.Biens");
            DropTable("dbo.Annonces");
            DropTable("dbo.Utilisateurs");
        }
    }
}
