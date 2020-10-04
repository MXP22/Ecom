using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace AccsEco.Models
{
    public class Produits
    {

        public int IDproduit { get; set; }
        public string codebarre { get; set; }

        [Display(Name ="Nom Produit")]
        public string designation { get; set; }
        [Display(Name = "Image")]
        public string imagepath { get; set; }
        [Display(Name = "Quantité")]
        public int qte { get; set; }
        [Display(Name = "Prix")]
        public float PrixU { get; set; }
        [Display(Name = "Prix barré")]
        public float PrixBarre { get; set; }
        [Display(Name = "Description")]
        public string Desciption { get; set; }

        [Display(Name = "Catégorie")]
        public string Categorie { get; set; }



    }
}