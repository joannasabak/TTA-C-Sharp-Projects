using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class Starship
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public int Crew { get; set; }

        //constructor 1 - name only, chains to constr 2 with a deafult weapon
        public Starship(string name) : this(name, "Laser Canon") { }

        //constructor 2 - every ship starts with 100 crew members
        public Starship(string name, string weapon)
        {
            Name = name;
            Weapon = weapon;
            Crew = 100;
        }

        //fires at target for 10-30 random damage
        public void Fire(Starship target, Random rng)
        {
            int damage = rng.Next(10, 31);
            target.Crew = Math.Max(0, target.Crew - damage);
            Console.WriteLine($"{Name} fires {Weapon} for a loss of {damage}! {target.Name} crew: {target.Crew}");
        }
    }
}
