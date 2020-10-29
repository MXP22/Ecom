using Stripe.BillingPortal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccsEco.Models
{
    public class Chechout
    {

        public InformationPaiement info { get; set; }

        public Produits Produits { get; set; }

        public Session SessionPaiement { get; set; }



    }
}