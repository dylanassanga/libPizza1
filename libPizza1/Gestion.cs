using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza1
{
    public class Gestion
    {
        private List <Commande> mesCommandes;
        private List <Client> mesClient;
        private List<Pizza> mesPizzas;

        public Gestion()
        {
            this.mesCommandes = new List<Commande>();
            this.mesClient = new List<Client>();
            this.mesPizzas = new List<Pizza>();
        }

        public int AjouterCommande(Client client)
        {
            Commande commande = new Commande(client);
            mesCommandes.Add(commande);
            return 1;
        }

        
    }
}
