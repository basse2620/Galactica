using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    sealed class Moon : Planet
    {
        public Planet Orbiting{ get; set; }

        public double Distance(Planet planet, Moon moon)
        {
            double distance = Math.Sqrt(Math.Pow((planet.position.x - moon.position.x), 2) + Math.Pow((planet.position.y - moon.position.y), 2));
            return distance;
        }
    }
}
