using System;
using System.Collections.Generic;
using System.Text;

namespace EonixConsole
{
    class singe
    {
        public string name { get; set; }
        public  List<tours> tours { get; set; }
        public singe()
        {
            tours = new List<tours>();
            tours.Add(new tours
            {
                name = "Danser",
                type = "Acrobatie"
            });
            tours.Add(new tours
            {
                name = "Jouer du tambour",
                type = "Musique"
            });
            tours.Add(new tours
            {
                name = "Faire du Monocycle",
                type = "Acrobatie"
            });
            tours.Add(new tours
            {
                name = "Jouer du Ukulélé",
                type = "Musique"
            });
        }
    }
}
