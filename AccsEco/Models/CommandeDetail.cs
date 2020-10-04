using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccsEco.Models
{
    public class CommandeDetail 
    {
        public int IDCommandedetail { get; set; }

        public int IDcommande { get; set; }


        public DateTime datefacturation { get; set; }

        public int Qte { get; set; }

        





    }
}