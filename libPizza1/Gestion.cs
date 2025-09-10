using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza1
{
    public class Gestion
    {
        private List<Commande> mesCommandes;
        private List<Client> mesClients;
        private List<Pizza> mesPizzas;

        public Gestion()
        {
            this.mesCommandes = new List<Commande>();
            this.mesClients = new List<Client>();
            this.mesPizzas = new List<Pizza>();
        }

        public List<Commande> GetCommandes
        {
            get { return this.mesCommandes; }
        }


        public int AjouterCommande(Client client)
        {
            Commande commande = new Commande(client);
            mesCommandes.Add(commande);
            //Je retourne le numéro de l'emprunt crée 
            return commande.GetNumCommande();
        }

        public void AjouterNouveauClient(string adresse, string codePostal, string nom, string prenom, string telephone, string ville)
        {
            Client nouVclient = new Client(adresse, codePostal, nom, prenom, telephone, ville);
            mesClients.Add(nouVclient);
        }

        public void AjouterNouvelPizza(string nom)
        {
            Pizza nouVpizza = new Pizza(nom);
            mesPizzas.Add(nouVpizza);
        }
        public void AjouterPizza(Pizza pizza, int numCommande)
        {
            Commande commande = null;
            for (int i = 0; i < mesCommandes.Count; i++)
            {
                if (mesCommandes[i].GetNumCommande() == numCommande)
                {
                    commande = mesCommandes[i];
                    break;
                }
            }
            if (commande != null)
            {
                commande.AjouterNouvellePizza(pizza);
            }

        }

        public List<Client> GetListClient()
        {
            return new List<Client>(mesClients);
        }

        public List<Pizza> GetListPizza()
        {
            return new List<Pizza>(mesPizzas);
        }

        public Client GetClient(string nomClient)
        {
            foreach (Client client in mesClients)
            {
                if (client.Nom.Equals(nomClient, StringComparison.OrdinalIgnoreCase))
                {
                    return client;
                }
            }
            return null;
        }

        public Pizza GetPizza(string nomPizza)
        {
            foreach (Pizza pizza in mesPizzas)
            {
                if(pizza.Name == nomPizza)
                {
                    return pizza;
                }
            }
            return null;
        }

        public Commande GetCommande(int numCommande)
        {
            foreach (Commande commande in mesCommandes)
            {
                if (commande.GetNumCommande() == numCommande)
                {
                    return commande;
                }
            }
            return null;
        }


        public string AfficherCommande(int numCommande)
        {
            Commande commande = GetCommande(numCommande);
            if (commande != null)
            {
                return commande.ToString();
            }
            return "Commande non trouvée";
        }

    }
}
