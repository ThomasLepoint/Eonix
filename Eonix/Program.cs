using System;

namespace EonixConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            singe singe1 = new singe();
            singe singe2 = new singe();
            dresseur dresseur1 = new dresseur();
            dresseur dresseur2 = new dresseur();
            spectateur spectateur = new spectateur();

            singe1.name = "Singe1";
            singe2.name = "Singe2";
            dresseur1.singe = singe1;
            dresseur2.singe = singe2;

            ExecuterTours(dresseur1, spectateur);
            Console.WriteLine();
            Console.WriteLine();
            ExecuterTours(dresseur2, spectateur);


        }
       static void ExecuterTours(dresseur dresseur, spectateur spectateur)
        {

            for (int i = 0; i < dresseur.singe.tours.Count; i++)
            {
                tours tour = dresseur.ExecuterTour(i);
                if (tour.type == "Acrobatie")
                {
                    Console.WriteLine(spectateur.Applaudir(dresseur.singe, i));
                }
                else
                {
                    Console.WriteLine(spectateur.Siffler(dresseur.singe, i));
                }
            }
        }
    }
}
