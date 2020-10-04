using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccsEco.Models
{
    public class Panier
    {
        public Panier(string image, string des, int qte, double prix)
        {
            this.image = image;
            this.desegnation = des;
            this.qte = qte;
            this.PrixU = prix;


        }

        public string codebarre { get; set; }
        public string image { get; set; }

        public string desegnation { get; set; }

        public int qte { get; set; }
        public double PrixU { get; set; }



    }
}