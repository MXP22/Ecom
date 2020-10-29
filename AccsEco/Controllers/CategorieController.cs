using AccsEco.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using WebGrease.Configuration;

namespace AccsEco.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        private AcceecoEntities db = new AcceecoEntities();
        public ActionResult Sport(string Submit)
        {
            if (Submit == "Add") { }
            var produit = db.Produit.Include(P => P.ImageProduit).Where(P => P.categorie == "Sport" || P.categorie == "sport");

            return View(produit.ToList());
        }
        public ActionResult Mode(string Submit,int? id)
        {
            if (Submit == "Add")
            {

                db.UtilisateurSite.Add(new UtilisateurSite { Adresse = "hajdkddlsodihfdhsd2050" ,telephone=id.ToString()});

                db.SaveChanges();

            }

            var produit = db.Produit.Include(P => P.ImageProduit).Where(P => P.categorie == "Mode" || P.categorie == "mode");

            return View(produit.ToList());
        }
        public ActionResult Electro(string Submit)
        {
            if (Submit == "Add") { }

            var produit = db.Produit.Include(P => P.ImageProduit).Where(P => P.categorie == "Elecrtonique" || P.categorie == "elecrtonique");

            return View(produit.ToList());

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DetailProduit(int? id, string submit)
        {
            Produit produit = null;

            produit = db.Produit.Include(P => P.ImageProduit).SingleOrDefault(c => c.IDProduit == id);
            if (submit == "Ajouter au panier")
            {
                UtilisateurSite utilisateurSite = new UtilisateurSite() { Adresse = "Hello", Nom = "Hjhahaha", telephone = id.ToString() };

                db.UtilisateurSite.Add(utilisateurSite);

                db.SaveChanges();

            }



            return View(produit);
        }
        //ajouter Produit au panier

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Addtobasket(int id)
        {
            if (ModelState.IsValid)
            {
                var produit = db.Produit.Include(P => P.ImageProduit).SingleOrDefault(c => c.IDProduit == id);

                ViewData["Qte"] = produit.qte;
                UtilisateurSite utilisateurSite = new UtilisateurSite() { Adresse = "Hello", Nom = "Hjhahaha", telephone = id.ToString() };

                db.UtilisateurSite.Add(utilisateurSite);

                db.SaveChanges();
            }

            return RedirectToAction("DetailProduit");

        }


        //contenu de panier
        public ActionResult Basket()
        {

            ImageProduit image = new ImageProduit();
            CommandeDtrail commandeDtrail = new CommandeDtrail();
            Commande commande = new Commande();
            List<Panier> t = new List<Panier>();

            for (int i = 0; i < t.Count; i++)
            {


            }


            return View(t.ToList());

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddItem()
        {


            return View();
        }
        [HttpDelete, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem()
        {


            return RedirectToAction("Basket");
        }





    }
}