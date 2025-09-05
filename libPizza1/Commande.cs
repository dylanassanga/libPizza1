using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza1
{
    public class Commande
    {
        private Client monClient; 
        private List<Pizza> mesPizzas;
        private static int numCommande=0;
        private bool aEmporter;
        private DateTime dateCommande;

        public Commande(Client monClient)
        { 
            this.monClient = monClient;
            this.mesPizzas = new List<Pizza>();
            numCommande++;
            this.aEmporter = aEmporter;
            this.dateCommande = DateTime.Now;
        } 

        public void AjouterNouvellePizza(Pizza pz)
        {
            mesPizzas.Add(pz);
        }

        public int GetQuantiteTotalePizzas()
        {
            int nbreCommande = 0;
            foreach( Pizza p in mesPizzas)
            {
                nbreCommande++;
            }
            return nbreCommande;
        }

        public int GetNumCommande()
        {
            return numCommande;
        }
        
        public override string ToString()
        {
            return $"Commande #{numCommande} pour {monClient.Nom} le {dateCommande:dd/MM/yyyy}  pour {mesPizzas.Count()} items";
        }


    }
}
