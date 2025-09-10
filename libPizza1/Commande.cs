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
        private int numCommandeInstance;


        public Commande(Client monClient)
        { 
            this.monClient = monClient;
            this.mesPizzas = new List<Pizza>();
            numCommande++;
            this.numCommandeInstance = numCommande;
            this.aEmporter = aEmporter;
            this.dateCommande = DateTime.Now;
        } 

        public void AjouterNouvellePizza(Pizza pz)
        {
            mesPizzas.Add(pz);
        }

        public int GetQuantiteTotalePizzas()
        {
            
            return mesPizzas.Count;
        }

        public int GetNumCommande()
        {
            return numCommandeInstance;
        }
        
        public override string ToString()
        {
            return $"Commande #{numCommandeInstance} pour {monClient.Nom} le {dateCommande:dd/MM/yyyy} à {dateCommande:HH}h{dateCommande:mm} pour {mesPizzas.Count} items";
        }


    }
}
