using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    class Planet : SpaceObjects
    {        
        public double DiameterInMeter { get; set; }
        public double RotationPeriodInHours { get; set; }
        public double RevolutionPeriodInDays { get; set; }
        public PlanetType Type { get; set; }

        public List<Moon> Moons = new List<Moon>();

        public override string ToString()
        {
            return "Id " + Id.ToString() + " " +  Name.ToString();
        }

        public double Distance(Star star, Planet planet)
        {
            double distance = Math.Sqrt(Math.Pow((star.position.x - planet.position.x), 2) + Math.Pow((star.position.y - planet.position.y), 2));
            return distance;
        }
    }
}
