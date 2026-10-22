using System;
using System.Text;

// Zombie Survival: The Radio Broadcast
// You've been rescued and now run the survivors' radio station.
// This app builds a call sign (string concatenation), an emergency alert (uppercase)
// and an evening broadcast (StringBuilder), then reads the broadcast out.
namespace ZombieRadio
{
    class RadioStation
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== SURVIVOR RADIO STATION ===");
            Console.WriteLine("You've been rescued! Now you help others stay alive.\n");

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Where were you hiding? (e.g. Supermarket):");
            string hideout = Console.ReadLine();

            Console.WriteLine("Choose a codename (e.g. Hawk):");
            string codename = Console.ReadLine();


            string callSign = firstName + " from the " + hideout + ", codename " + codename;
            Console.WriteLine($"\nYour call sign: {callSign}");


            string shortCallSign = string.Concat(firstName, "-", hideout, "-", codename);
            Console.WriteLine($"Short call sign: {shortCallSign}\n");


            Console.WriteLine("Type a warning for other survivors (e.g. zombies spotted near the bridge):");
            string warning = Console.ReadLine();

            string alert = warning.ToUpper();
            Console.WriteLine($"\nALERT: {alert}\n");


            StringBuilder broadcast = new StringBuilder();

            broadcast.Append($"Good evening, this is {callSign}. ");
            broadcast.Append($"Urgent news: {alert}. ");
            broadcast.Append("Supplies are low, so ration your food carefully. ");
            broadcast.Append("The rescue helicopter flies again at dawn. ");
            broadcast.Append("Stay safe. Stay hidden.");

            string finalBroadcast = broadcast.ToString();

            Console.WriteLine("=== TONIGHT'S BROADCAST ===");
            Console.WriteLine(finalBroadcast);
            Console.WriteLine($"\n(Broadcast length: {finalBroadcast.Length} characters)");

            Console.WriteLine("\nPress Enter to end transmission...");
            Console.ReadLine();
        }
    }
}
