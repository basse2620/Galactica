using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    class Star : SpaceObjects
    {
        public Startype Type { get; set; }
        int Temperature { get; set; }
        public Position position { get; }        

        new public List<Planet> Planets = new List<Planet>();

        public Star()
        {
            this.position = new Position();
        }
    }
    enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
}
