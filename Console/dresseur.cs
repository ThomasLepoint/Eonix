using System;
using System.Collections.Generic;
using System.Text;

namespace EonixConsole
{
    class dresseur
    {
        public singe singe { get; set; }

        public tours ExecuterTour(int index)
        {
            Console.WriteLine($"Le singe : {this.singe.name} exécute le tour : {this.singe.tours[index].name}");
            return this.singe.tours[index];
        }
            
    }
}
