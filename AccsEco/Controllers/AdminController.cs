using AccsEco.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace AccsEco.Controllers
{
    public class AdminController : Controller
    {

        private AcceecoEntities db = new AcceecoEntities();
        // GET: Admin


        public ActionResult Plat()
        {


            return View();

        }
        public ActionResult Index()

        {
            List<Produits> produits = new List<Produits>();




            var Produitss = db.Produit.Include(P => P.ImageProduit);  //db.ImageProduit.Include(c => c.Produit);



            return View(Produitss.ToList());
        }


        // GET:AddProduct
        public ActionResult AddProduct()
        {
            return View();
        }

        //Post: AddProduct

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(List<HttpPostedFileBase> files, Produits produits)
        {
            Produit produit = new Produit();
            List<ImageProduit> imageProduit = new List<ImageProduit>();
            int idproduit = 0;
            produit.desegnation = produits.designation;
            produit.DescriptionProduit = produits.Desciption;
            produit.qte = produits.qte;
            produit.Prix = produits.PrixU;
            produit.Prixbarre = produits.PrixBarre;
            produit.categorie = produits.Categorie;
            produit.codebar = produits.codebarre;

            db.Produit.Add(produit);
            db.SaveChanges();

            idproduit = produit.IDProduit;

            if (ModelState.IsValid)
            {
                foreach (var file in files)
                {
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/StorageImage/"), InputFileName);
                        //Save file to server folder  

                        file.SaveAs(ServerSavePath);

                        imageProduit.Add(new ImageProduit { NomImage = InputFileName, PathImage = ServerSavePath, IdProduit = idproduit });

                    }
                }
                for (int i = 0; i < imageProduit.Count; i++)
                {
                    db.ImageProduit.Add(imageProduit[i]);
                    db.SaveChanges();
                }

            }



            return RedirectToAction("Index");

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id)
        {

            ImageProduit imageProduit = db.ImageProduit.Include(c => c.Produit).Single(c => c.IdProduit == id);

            return View(imageProduit);
        }

        public ActionResult Delete(int id)
        {
            var Produitss = db.ImageProduit.Include(c => c.Produit).Where(x => x.IdProduit == id);

            return View(Produitss);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {
            Produit d = db.Produit.Include(c => c.ImageProduit).Single(i => i.IDProduit == id);


            db.Produit.Remove(d);


            db.SaveChanges();
            //ImageProduit imageProduit = db.ImageProduit.Include(I => I.Produit).Where( == id);

            //db.ImageProduit.Remove(imageProduit);
            //db.SaveChanges();

            return RedirectToAction("Index");

        }
        // get orders commande panier
        public ActionResult Orders()
        {

            return View();

        }



    }
}