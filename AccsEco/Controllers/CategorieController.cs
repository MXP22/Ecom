using AccsEco.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Configuration;

namespace AccsEco.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        private AcceecoEntities db = new AcceecoEntities();
        public ActionResult Sport()
        {

            return View();
        }
        public ActionResult Mode()
        {
            return View();
        }
        public ActionResult Electro()
        {
            var produit = db.Produit.Include(P => P.ImageProduit).Where(P => P.categorie == "Electro" || P.categorie == "electro");

            return View(produit.ToList());
        }
        public ActionResult DetailProduit()
        {
            ViewBag.message = "Hello";
            return View();

        }

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