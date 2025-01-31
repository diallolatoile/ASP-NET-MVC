using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNETMVCWebAppM1GL2025.Models;

using System.Diagnostics;
using System.Text;

namespace ASPNETMVCWebAppM1GL2025.Controllers
{
    public class BiensController : Controller
    {
        private static readonly TripAdvisorDBContext db = new TripAdvisorDBContext();
        //private TripAdvisorDBContext db = tripAdvisorDBContext;

        // GET: Biens
        public ActionResult Index()
        {
            return View(db.Biens.ToList());
        }

        // GET: Biens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bien bien = db.Biens.Find(id);
            if (bien == null)
            {
                return HttpNotFound();
            }
            return View(bien);
        }

        // GET: Biens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Biens/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BienId,LibelleBien,DescriptionBien,PrixJournalier,Region,Pays,Latitude,Longitude,NbreChambre,NbreLit,NbreSalleBain,TypeBien,Disponible,DateAjout,Adresse")] Bien bien)
        {
            if (!ModelState.IsValid)
            {
                // Collecter les messages d'erreur dans une chaîne
                var errorMessages = new StringBuilder();
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        errorMessages.AppendLine($"Erreur dans {modelStateKey}: {error.ErrorMessage}");
                    }
                }

                // Construire la chaîne pour afficher les détails du bien
                /* var bienDetails = $@"
                    Détails du bien soumis:
                    BienId: {bien.BienId}
                    LibelleBien: {bien.LibelleBien}
                    DescriptionBien: {bien.DescriptionBien}
                    PrixJournalier: {bien.PrixJournalier}
                    Region: {bien.Region}
                    Pays: {bien.Pays}
                    Latitude: {bien.Latitude}
                    Longitude: {bien.Longitude}
                    NbreChambre: {bien.NbreChambre}
                    NbreLit: {bien.NbreLit}
                    NbreSalleBain: {bien.NbreSalleBain}
                    TypeBien: {bien.TypeBien}
                    Disponible: {bien.Disponible}
                    DateAjout: {bien.DateAjout}
                    Adresse: {bien.Adresse}";
               */

                // Afficher les erreurs et les détails du bien dans la vue
                ViewBag.ErrorMessages = errorMessages.ToString();
                //ViewBag.BienDetails = bienDetails;
                ViewBag.BienDetails = Newtonsoft.Json.JsonConvert.SerializeObject(bien, Newtonsoft.Json.Formatting.Indented);

                return View(bien);
            }

            // Si valide, ajouter l'objet et sauvegarder
            db.Biens.Add(bien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Biens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bien bien = db.Biens.Find(id);
            if (bien == null)
            {
                return HttpNotFound();
            }
            return View(bien);
        }

        // POST: Biens/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BienId,LibelleBien,DescriptionBien,PrixJournalier,Region,Pays,Latitude,Longitude,NbreChambre,NbreLit,NbreSalleBain,TypeBien,Disponible,DateAjout,Adresse")] Bien bien)
        {
            if (!ModelState.IsValid)
            {
                // Collecter les messages d'erreur dans une chaîne
                var errorMessages = new StringBuilder();
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        errorMessages.AppendLine($"Erreur dans {modelStateKey}: {error.ErrorMessage}");
                    }
                }

                // Construire la chaîne pour afficher les détails du bien
                /* var bienDetails = $@"
                    Détails du bien soumis:
                    BienId: {bien.BienId}
                    LibelleBien: {bien.LibelleBien}
                    DescriptionBien: {bien.DescriptionBien}
                    PrixJournalier: {bien.PrixJournalier}
                    Region: {bien.Region}
                    Pays: {bien.Pays}
                    Latitude: {bien.Latitude}
                    Longitude: {bien.Longitude}
                    NbreChambre: {bien.NbreChambre}
                    NbreLit: {bien.NbreLit}
                    NbreSalleBain: {bien.NbreSalleBain}
                    TypeBien: {bien.TypeBien}
                    Disponible: {bien.Disponible}
                    DateAjout: {bien.DateAjout}
                    Adresse: {bien.Adresse}";
               */

                // Afficher les erreurs et les détails du bien dans la vue
                ViewBag.ErrorMessages = errorMessages.ToString();
                //ViewBag.BienDetails = bienDetails;
                ViewBag.BienDetails = Newtonsoft.Json.JsonConvert.SerializeObject(bien, Newtonsoft.Json.Formatting.Indented);

                return View(bien);
            }

            // Si valide, modifier l'objet et sauvegarder
            db.Entry(bien).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: Biens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bien bien = db.Biens.Find(id);
            if (bien == null)
            {
                return HttpNotFound();
            }
            return View(bien);
        }

        // POST: Biens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bien bien = db.Biens.Find(id);
            db.Biens.Remove(bien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
