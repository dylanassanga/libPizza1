using libPizza1; 
class Program
{
    private static void Main(string[] args)
    {
        Client c1 = new Client("10 avenue azerty","75018","Boby","titi","01 45 78 45","Paris");
        Console.WriteLine(c1.Afficher_Client());

        Pizza p1 = new Pizza("Reine");
        Console.WriteLine(p1.Afficher_Pizza());

        Commande co1 = new Commande(c1);
        co1.AjouterNouvellePizza( p1);
        Console.WriteLine(co1.ToString());
    }

}