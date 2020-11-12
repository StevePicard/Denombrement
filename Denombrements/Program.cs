using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static long ProduitEntiers(int valeurDebut, int valeurFin)
        {
            long produit = 1;
            for (int p = valeurDebut; p <= valeurFin; p++)
            {
                produit *= p;
            }
            return produit ;
        }

        // Menu permettant de faire 3 calculs : Permutation, Arrangement, Combinaison
        static void Main(string[] args)
        {
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();

                // Choix correct
                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        Console.Write("Nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());
                        // Permutation
                        if (choix == "1")
                        {
                            long permutation = ProduitEntiers(1, nbTotal);
                            Console.WriteLine(nbTotal + "!= " + permutation);
                        }
                        else
                        {
                            Console.Write("Nombre d'éléments dans le sous ensemble = ");
                            int nbSousEnsemble = int.Parse(Console.ReadLine());
                            // Calcul de l'Arrangement
                            long arrangement = ProduitEntiers(nbTotal - nbSousEnsemble + 1, nbTotal);
                            // Arrangement
                            if (choix == "2")
                            {
                                Console.WriteLine("C(" + nbTotal + "/" + nbSousEnsemble + ")" + arrangement);
                            }
                            // Combinaison
                            else
                            {
                                long combinaison = arrangement / ProduitEntiers(1, nbSousEnsemble);
                                Console.Write("C(" + nbTotal + "/" + nbSousEnsemble + ")" + combinaison);
                            }
                        }
                    }
                    catch {
                        Console.WriteLine("Calcul impossible : une/des valeur(s) est/sont incorrecte(s) ou trop grande(s) !");
                    }
                }
                
            }
        }
    }
}
