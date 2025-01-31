using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNETMVCWebAppM1GL2025.Models;

namespace ASPNETMVCWebAppM1GL2025.Controllers
{
    public class UtilisateursController : Controller
    {
        private TripAdvisorDBContext db = new TripAdvisorDBContext();

        // GET: Utilisateurs
        public ActionResult Index()
        {
            var users = db.Utilisateurs.ToList();
            return View(users);
        }

        // GET: Utilisateurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur user = db.Utilisateurs.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Utilisateurs/CreateAdmin
        public ActionResult CreateAdmin()
        {
            return View();
        }

        // POST: Utilisateurs/CreateAdmin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAdmin([Bind(Include = "NomPrenom,Telephone,Email,Adresse,Matricule")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                admin.UtilisateurType = UtilisateurType.Admin;
                db.Utilisateurs.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        // GET: Utilisateurs/CreateClient
        public ActionResult CreateClient()
        {
            return View();
        }

        // POST: Utilisateurs/CreateClient
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateClient([Bind(Include = "NomPrenom,Telephone,Email,Adresse,CNI,DateNaissance,Genre")] Client client)
        {
            if (ModelState.IsValid)
            {
                client.UtilisateurType = UtilisateurType.Client;
                db.Utilisateurs.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Utilisateurs/CreateManager
        public ActionResult CreateManager()
        {
            return View();
        }

        // POST: Utilisateurs/CreateManager
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateManager([Bind(Include = "NomPrenom,Telephone,Email,Adresse,NINEA,RCCM")] Manager manager)
        {
            if (ModelState.IsValid)
            {
                manager.UtilisateurType = UtilisateurType.Manager;
                db.Utilisateurs.Add(manager);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manager);
        }

        // GET: Utilisateurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur user = db.Utilisateurs.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Utilisateurs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomPrenom,Telephone,Email,Adresse,UtilisateurType")] Utilisateur user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Utilisateurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur user = db.Utilisateurs.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Utilisateurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Utilisateur user = db.Utilisateurs.Find(id);
            db.Utilisateurs.Remove(user);
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
