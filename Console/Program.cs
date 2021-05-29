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

            spectateur.croiserDresseur(dresseur1);
            Console.WriteLine("***************************");
            Console.WriteLine("***************************");
            spectateur.croiserDresseur(dresseur2);
        }
    }
}
