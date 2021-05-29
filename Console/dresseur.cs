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
            return this.singe.tours[index];
        }
            
    }
}
