using System;
using System.Collections.Generic;

namespace gestion_parc_véhicules
{
    class Program
    {
        static List<Vehicule> ListeVehicule;
        static void Main(string[] args)
        {
            ListeVehicule = new List<Vehicule>();
            int choix = AfficherMenu();

            while (choix != 5) //5 = quitter
            {
                switch (choix)
                {
                    case 1:
                        //afficher la liste
                        AfficherListe();
                        break;
                    case 2:
                        // ajouter une voiture
                        AjouterVoiture();
                        break;

                    case 3:
                        // ajouter un utilitaire 
                        AjouterUtilitaire();
                        break;

                    case 4:
                        // supprimer un vehicule
                        SupprimerVehicule();
                        break;


                }
                choix = AfficherMenu();
            }
        }

        private static void SupprimerVehicule()
        {
            Console.WriteLine("suppression d'un véhicule à partir de son immatriculation ");
            Console.WriteLine("Immatriculation ?");
            string immatriculation = Console.ReadLine();
            int index = ChercherVehicule(immatriculation);

            if (index>=0)
            {
                ListeVehicule.RemoveAt(index);
                Console.WriteLine("Véhicule supprimé \n");
            }
            else
            {
                Console.WriteLine("Désolé, pas de véhicule correspondant.");
            }
        }

        private static int ChercherVehicule(string immatriculation)
        {
            int index = -1;
            foreach (Vehicule v in ListeVehicule)
                if (v.Immatriculation.Equals(immatriculation))
                    {
                    return ListeVehicule.IndexOf(v);
                }
            return index;

        }

        private static void AjouterUtilitaire()
        {
            Console.WriteLine("Ajoutez un utilitaire :");

            Console.Write("Immatriculation ? ");
            string imm = Console.ReadLine();

            Console.WriteLine("Couleur ? ");
            string coul = Console.ReadLine();

            Console.WriteLine("Marque ?");
            string marque = Console.ReadLine();

            Console.WriteLine("Volume ?");
            int volume = int.Parse(Console.ReadLine());

            Utilitaire util = new Utilitaire(imm, marque, coul, volume);
            ListeVehicule.Add(util);

            Console.WriteLine("\n");
        }

        private static void AjouterVoiture()
        {
            Console.WriteLine("Ajoutez une voiture :");

            Console.Write("Immatriculation ? ");
            string imm = Console.ReadLine();

            Console.WriteLine("Couleur ? ");
            string coul = Console.ReadLine();

            Console.WriteLine("Marque ?");
            string marque = Console.ReadLine();

            Console.WriteLine("Nombre de portes ?");
            int nbPortes = int.Parse(Console.ReadLine());

            Voiture voiture = new Voiture(imm, marque, coul, nbPortes);
            ListeVehicule.Add (voiture);

            Console.WriteLine("\n");




        }

     

        private static void AfficherListe()
        {
            Console.WriteLine("Liste des véhicules :");
            foreach(Vehicule v in ListeVehicule)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n");
        }

        private static  int AfficherMenu()
        {
           
            while (true)
            {
                Console.WriteLine("Gestion d'un parc de véhicules.");
                Console.WriteLine("Il y a actuellement " + ListeVehicule.Count + " véhicules dans le parc ");

                // afficher le menu
                Console.WriteLine("1 : afficher la liste de véhicules");
                Console.WriteLine("2 : ajouter une voiture");
                Console.WriteLine("3 : ajouter un utilitaire");
                Console.WriteLine("4 : supprimer un vehicule");
                Console.WriteLine("5 : quitter");

                string reponse = Console.ReadLine();
                int choix;

                if (int.TryParse(reponse, out choix))
                {
                    if (choix > 0 && choix <= 5)
                    {
                        
                        return choix;

                    }
                }
            }
        }
    }
}
