using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {

            Star Sun = new Star();
            {
                Sun.Id = 1;
                Sun.Name = "Sun";
                Sun.Type = Startype.YellowDwarf;
            }
            Planet Mercury = new Planet();
            {
                Mercury.Id = 1;
                Mercury.Name = "Mercury";
                Mercury.DiameterInMeter = 24397000;
                Mercury.RotationPeriodInHours = 1407.5;
                Mercury.RevolutionPeriodInDays = 88;
                Mercury.Type = PlanetType.Terrestial;
                Mercury.position = (new SpaceObjects.Position() { x = 5, y = 4 });
            }
            Planet Venus = new Planet();
            {
                Venus.Id = 2;
                Venus.Name = "Venus";
                Venus.DiameterInMeter = 6051800;
                Venus.RotationPeriodInHours = 2.802;
                Venus.RevolutionPeriodInDays = 255;
                Venus.Type = PlanetType.Terrestial;
                Venus.position = (new SpaceObjects.Position() { x = 10, y = 11 });
            }
            Planet Earth = new Planet();
            {
                Earth.Id = 3;
                Earth.Name = "Earth";
                Earth.DiameterInMeter = 523523523523;
                Earth.RotationPeriodInHours = 24;
                Earth.RevolutionPeriodInDays = 88;
                Earth.Type = PlanetType.Terrestial;
                Earth.position = (new SpaceObjects.Position() { x = 20, y = 26 });
            }
            Planet Mars = new Planet();
            {
                Mars.Id = 4;
                Mars.Name = "Mars";
                Mars.DiameterInMeter = 2343243141;
                Mars.RotationPeriodInHours = 123123;
                Mars.RevolutionPeriodInDays = 42356;
                Mars.Type = PlanetType.Terrestial;
                Mars.position = (new SpaceObjects.Position() { x = 30, y = 33 });
            }
            Planet Jupiter = new Planet();
            {
                Jupiter.Id = 5;
                Jupiter.Name = "Jupiter";
                Jupiter.DiameterInMeter = 12345767;
                Jupiter.RotationPeriodInHours = 10;
                Jupiter.RevolutionPeriodInDays = 834345348;
                Jupiter.Type = PlanetType.Gas_Giant;
                Jupiter.position = (new SpaceObjects.Position() { x = 55, y = 56 });
            }
            Planet Saturn = new Planet();
            {
                Saturn.Id = 6;
                Saturn.Name = "Saturn";
                Saturn.DiameterInMeter = 543787807;
                Saturn.RotationPeriodInHours = 11;
                Saturn.RevolutionPeriodInDays = 342356;
                Saturn.Type = PlanetType.Gas_Giant;
                Saturn.position = (new SpaceObjects.Position() { x = 77, y = 67 });
            }
            Planet Uranus = new Planet();
            {
                Uranus.Id = 7;
                Uranus.Name = "Uranus";
                Uranus.DiameterInMeter = 23423678;
                Uranus.RotationPeriodInHours = 17;
                Uranus.RevolutionPeriodInDays = 635345;
                Uranus.Type = PlanetType.Gas_Giant;
                Uranus.position = (new SpaceObjects.Position() { x = 82, y = 85 });
            }
            Planet Neptune = new Planet();
            {
                Neptune.Id = 8;
                Neptune.Name = "Neptune";
                Neptune.DiameterInMeter = 1232145688;
                Neptune.RotationPeriodInHours = 16;
                Neptune.RevolutionPeriodInDays = 4156;
                Neptune.Type = PlanetType.Gas_Giant;
                Neptune.position = (new SpaceObjects.Position() { x = 94, y = 99 });
            }
            Moon Luna = new Moon();
            {
                Luna.Id = 1;
                Luna.Name = "Luna";
                Luna.DiameterInMeter = 1232145688;
                Luna.RotationPeriodInHours = 0;
                Luna.RevolutionPeriodInDays = 4156;
                Luna.Orbiting = (new Planet() { Id = 1, Name = "Earth" });
                Luna.position = (new SpaceObjects.Position() { x = 21, y = 24 });
            }
            Moon Titan = new Moon();
            {
                Titan.Id = 2;
                Titan.Name = "Titan";
                Titan.DiameterInMeter = 1232145688;
                Titan.RotationPeriodInHours = 0;
                Titan.RevolutionPeriodInDays = 4156;
                Titan.Orbiting = (new Planet() { Id = 5, Name = "Earth" });
                Titan.position = (new SpaceObjects.Position() { x = 2, y = 99 });
            }
            Moon Phobos = new Moon();
            {
                Phobos.Id = 3;
                Phobos.Name = "Phobos";
                Phobos.DiameterInMeter = 1232145688;
                Phobos.RotationPeriodInHours = 0;
                Phobos.RevolutionPeriodInDays = 4156;
                Phobos.Orbiting = (new Planet() { Id = 4, Name = "Mars" });
                Phobos.position = (new SpaceObjects.Position() { x = 94, y = 99 });
            }
            Moon Europa = new Moon();
            {
                Europa.Id = 4;
                Europa.Name = "Europe";
                Europa.DiameterInMeter = 1232145688;
                Europa.RotationPeriodInHours = 0;
                Europa.RevolutionPeriodInDays = 4156;
                Europa.Orbiting = (new Moon() { Id = 5, Name = "Jupiter" });
                Europa.position = (new SpaceObjects.Position() { x = 94, y = 99 });
            }
            Moon Deimos = new Moon();
            {
                Deimos.Id = 5;
                Deimos.Name = "Deimos";
                Deimos.DiameterInMeter = 1232145688;
                Deimos.RotationPeriodInHours = 0;
                Deimos.RevolutionPeriodInDays = 4156;
                Deimos.Orbiting = (new Moon() { Id = 4, Name = "Mars" });
                Deimos.position = (new SpaceObjects.Position() { x = 94, y = 99 });
            }
            Moon Ganymedes = new Moon();
            {
                Ganymedes.Id = 6;
                Ganymedes.Name = "Ganymedes";
                Ganymedes.DiameterInMeter = 1232145688;
                Ganymedes.RotationPeriodInHours = 0;
                Ganymedes.RevolutionPeriodInDays = 4156;
                Ganymedes.Orbiting = (new Moon() { Id = 5, Name = "Jupiter" });
                Ganymedes.position = (new SpaceObjects.Position() { x = 94, y = 99 });
            }
            Moon Io = new Moon();
            {
                Io.Id = 7;
                Io.Name = "Io";
                Io.DiameterInMeter = 1232145688;
                Io.RotationPeriodInHours = 0;
                Io.RevolutionPeriodInDays = 4156;
                Io.Orbiting = (new Moon() { Id = 5, Name = "Jupiter" });
                Io.position = (new SpaceObjects.Position() { x = 94, y = 99 });
            }
            Moon Mimas = new Moon();
            {
                Mimas.Id = 8;
                Mimas.Name = "Mimas";
                Mimas.DiameterInMeter = 1232145688;
                Mimas.RotationPeriodInHours = 0;
                Mimas.RevolutionPeriodInDays = 4156;
                Mimas.Orbiting = (new Moon() { Id = 6, Name = "Saturn" });
                Mimas.position = (new SpaceObjects.Position() { x = 94, y = 99 });
            }

            Sun.Planets.Add(Mercury);
            Sun.Planets.Add(Venus);
            Sun.Planets.Add(Earth);
            Sun.Planets.Add(Mars);
            Sun.Planets.Add(Jupiter);
            Sun.Planets.Add(Saturn);
            Sun.Planets.Add(Uranus);
            Sun.Planets.Add(Neptune);

            Earth.Moons.Add(Luna);
            Jupiter.Moons.Add(Titan);
            Mars.Moons.Add(Phobos);
            Jupiter.Moons.Add(Europa);
            Mars.Moons.Add(Deimos);
            Jupiter.Moons.Add(Ganymedes);
            Jupiter.Moons.Add(Io);
            Saturn.Moons.Add(Mimas);



            foreach (var planet in Sun.Planets)
            {
                foreach (PropertyDescriptor planetDescriptor in TypeDescriptor.GetProperties(planet))
                {
                    string name1 = planetDescriptor.Name;
                    object value1 = planetDescriptor.GetValue(planet);

                    Console.WriteLine($"{name1}: {value1}");


                }


                Console.WriteLine($"Distense to the sun : {planet.Distance(Sun, planet)}\n");

                foreach (var moon in planet.Moons)
                {
                    foreach (PropertyDescriptor moonDescriptor in TypeDescriptor.GetProperties(moon))
                    {
                        string name2 = moonDescriptor.Name;
                        object value2 = moonDescriptor.GetValue(moon);

                        Console.WriteLine($"{name2}: {value2}");

                    }
                    Console.WriteLine($"Distense to the host planet : {moon.Distance(planet, moon)}\n");
                }
            }
        }
    }
}
