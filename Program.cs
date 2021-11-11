/**
 * Exercice 2 : modification de l'exercice 1 avec une fonction qui retourne un résultat
 * author : CT
 * date : 11/2021
 */
using System;

namespace Exercice2
{
    class Program
    {
        /// <summary>
        /// Saisie de O ou N avec contrôle de saisie
        /// </summary>
        /// <returns>lettre saisie</returns>
        static char saisie()
        {
            char reponse;
            do
            {
                Console.WriteLine();
                Console.Write("Avez-vous un prix à saisir ? (O/N) ");
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != 'O' && reponse != 'N');
            return reponse;
        }

        static void Main(string[] args)
        {
            // Déclarations
            float prix, total = 0;
            char rep;

            // demande si un prix est à saisir
            rep = saisie();

            // Boucle sur la saisie des prix et le cumul
            while (rep == 'O')
            {
                // saisie d'un nouveau prix
                Console.Write("   Entrez un prix = ");
                prix = float.Parse(Console.ReadLine());
                // cumul
                total = total + prix;
                // demande si un nouveau prix est à saisir
                rep = saisie();
            }

            // Affichage du total
            Console.WriteLine("   total des prix = " + total);
            Console.ReadLine();
        }
    }
}
