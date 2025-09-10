using System;
using libPizza1; 
class Program
{
    private static void Main(string[] args)
    {
        Client c1 = new Client("10 avenue azerty","75018","Boby","titi","01 45 78 45","Paris");
        Console.WriteLine(c1.Afficher_Client());

        Pizza p1 = new Pizza("Reine");
        Pizza p2 = new Pizza("Calzone");
        Console.WriteLine(p1.Afficher_Pizza());
        Console.WriteLine(p2.Afficher_Pizza());

        Commande co1 = new Commande(c1);
        co1.AjouterNouvellePizza(p1);
        co1.AjouterNouvellePizza(p2);
        Console.WriteLine(co1.ToString());

        Gestion gestion = new Gestion();
        gestion.AjouterNouveauClient("123 rue Test", "75001", "Dupont", "Jean", "01 23 45 67 89", "Paris");
        gestion.AjouterNouvelPizza("4 Fromages");
        gestion.AjouterNouvelPizza("Margherita");

        //Recherche d'un client
        Client client = gestion.GetClient("Dupont");

        if(client != null)
        {
            int numCommande = gestion.AjouterCommande(client);
            Console.WriteLine($"Commande créée avec le numéro: {numCommande}");

            Pizza pizza1 = gestion.GetPizza("Margherita");
            Pizza pizza2 = gestion.GetPizza("4 fromages");

            if (pizza1 != null)
                gestion.AjouterPizza(pizza1, numCommande);
            if(pizza2 != null)
                gestion.AjouterPizza(pizza2, numCommande);

            Console.WriteLine(gestion.AfficherCommande(numCommande));
        }
        
    }//Je verifie si mon push marche!

}