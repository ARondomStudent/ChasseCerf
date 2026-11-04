namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        int fleches = 5;
        int nTouche = 0;
        do
        {
            bool touche = Random.Shared.Next(0, 2) == 1;
            Console.WriteLine("Fleches restante : " + fleches);
            Console.WriteLine("Résultat du tir (touche/rate) : "+ touche);
            if (touche)
            {
                nTouche++;
                Console.WriteLine("Bien joué ! Le cerf est touché.");
            }
            else
            {
                Console.WriteLine("Raté ! Le cerf s'est échappé de justesse.");
            }
            fleches--;
        }while((fleches > 0) && (nTouche != 3));

        if (nTouche == 3)
        {
            Console.WriteLine("Vous avez battu le cerf");
        }
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
    }
}