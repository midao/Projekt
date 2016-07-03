using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProjekt
{
    public class Kartenset
    {

        public String name { get; set; }
        public List<Karte> karten { get; set; }
        public String bild { get; set; }

        public Kartenset()

        {

            karten = new List<Karte>();
        }
        

    }

    public class Karte
    {

        public int ID { get; set; }
        public String set { get; set; }
        public int nummer { get; set; }
        public String bild { get; set; }
    }
}
