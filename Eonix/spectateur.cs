using System;
using System.Collections.Generic;
using System.Text;

namespace EonixConsole
{
    class spectateur
    {
        public string Applaudir(singe singe, int index)
        {
            return ($"spectateur applaudit pendant le tour d'acrobatie '{singe.tours[index].name}' du {singe.name}");
        }
        public string Siffler(singe singe, int index)
        {
            return ($"spectateur siffle pendant le tour de musique '{singe.tours[index].name}' du {singe.name}");
        }
    }
}
