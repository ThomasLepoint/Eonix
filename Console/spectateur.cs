using System;
using System.Collections.Generic;
using System.Text;

namespace EonixConsole
{
    class spectateur
    {
        public void croiserDresseur(dresseur dresseur)
        {
            for (int i = 0; i < dresseur.singe.tours.Count; i++)
            {
                tours tour = dresseur.ExecuterTour(i);
                if (tour.type == "Acrobatie")
                {
                    Console.WriteLine(this.Applaudir(dresseur.singe, tour));
                }
                else
                {
                    Console.WriteLine(this.Siffler(dresseur.singe, tour));
                }
            }
        }
        private string Applaudir(singe singe, tours tour)
        {
            return ($"spectateur applaudit pendant le tour d'acrobatie '{tour.name}' du {singe.name}");
        }
        private string Siffler(singe singe, tours tour)
        {
            return ($"spectateur siffle pendant le tour de musique '{tour.name}' du {singe.name}");
        }
    }
}
