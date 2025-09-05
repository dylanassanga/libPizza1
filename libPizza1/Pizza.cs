using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza1
{
     public class Pizza
    {
        private string nom;

        public Pizza(string nom)
        {  this.nom = nom; }

        public string Name
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Afficher_Pizza()
        {
            return $"Nom de la pizza {nom}";
        }
    }
}
