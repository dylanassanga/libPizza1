namespace libPizza1
{
    public class Client
    {
        private string adresse;
        private string codePostal;
        private string nom;
        private string prenom;
        private string telephone;
        private string ville;

        public Client(string adresse, string codePostal, string nom,string prenom, string telephone, string ville)
        {
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.nom = nom;           
            this.prenom = prenom;
            this.telephone = telephone;
            this.ville = ville;
        }

        public string Adresse
        { 
        get { return adresse; }
        set { adresse = value; }
        }

        public string CodePostal
        {
          get { return codePostal; } 
          set { codePostal = value; } 
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public string Afficher_Client()
        {
            return $"Adresse:{adresse}\n Code postal:{codePostal}\n Nom:{nom}\n Prenom:{prenom}\n Ville:{ville}\n Téléphone: {telephone}\n ";
        }


       

        
    }
}
