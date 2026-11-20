using Constructor;
using System.Xml.Linq;

namespace Construct
{
    class Program
    {
        static void Main()
        {
            //a value fixed at compile that never changes
            const string Sector = "Andromeda-7";

            //var: the complier infers type
            var rng = new Random();
            var deathStar = new Starship("Death Star");
            var millenium = new Starship("Millenium Falcon", "Plasma Torpedo");

            Console.WriteLine("Battle in sector {0}!\n", Sector);

            while (deathStar.Crew > 0 && millenium.Crew > 0)
            {
                deathStar.Fire(millenium, rng);
                if (millenium.Crew > 0) millenium.Fire(deathStar, rng);
            }

            Console.WriteLine($"\n {(deathStar.Crew > 0 ? deathStar.Name : millenium.Name)} wins!");
            Console.ReadLine();
        }
    }
}