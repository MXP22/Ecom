using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccsEco.Models
{
    public class InformationPaiement
    {


        [Display(Name ="Nom")]
        public string Nom { get; set; }
        [Display(Name = "Prenom")]
        public string Prenom { get; set; }
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        [Display(Name = "Adresse de Livraison")]
        public string Adresselivraison { get; set; }
        [Display(Name = "Code Postal")]
        public string CodePostallivraison { get; set; }
        [Display(Name = "Ville")]
        public string Villelivraison { get; set; }
        [Display(Name = "Pays")]
        public string Payslivraison { get; set; }
 
        [Display(Name = "Adresse de Facturation")]
        public string AdresseFacturation { get; set; }
        [Display(Name = "Code Postal")]
        public string CodePostalFacturation { get; set; }
        [Display(Name = "Ville")]
        public string VilleFacturation { get; set; }
        [Display(Name = "Pays")]
        public string PaysFacturation { get; set; }
        [Display(Name = "Numéro de la carte ")]
        public string nemrocarte { get; set; }
        [Display(Name = "Mois")]

        public string Mois { get; set; }
        [Display(Name = "Année")]
        public string annee { get; set; }
        [Display(Name = "CVC")]
        public string Code { get; set; }



    }
}