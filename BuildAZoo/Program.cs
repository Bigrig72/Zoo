using System;
using Zoo.Classes.Creatures;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the Zoo! Let's get the animals settled.");

            bool createDragon = CreateDragon();
            bool createPegacon = CreatePegicorn();
            bool createMegaladon = CreateMegaladon();

        }

        public static bool CreateDragon()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                Console.WriteLine("Name the Zoo's Dragon:");
                string name = Console.ReadLine();

                Console.WriteLine("What is the Dragon's wingspan?");
                int wingSpan = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the Dragon's super power?");
                string superPower = Console.ReadLine();

                Dragon dragon = new Dragon(superPower, name, wingSpan);
                int speed = dragon.FlightSpeed();
                bool attack = dragon.Attack();
                bool heal = dragon.Heal();

                Console.ReadKey();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception thrown: {ex.Message}");
                return false;
            }
        }

        public static bool CreatePegicorn()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            try
            {
                Console.WriteLine("Name the Zoo's Pegacorn:");
                string name = Console.ReadLine();

                Console.WriteLine("What is the pegacorn's super power?");
                string superPower = Console.ReadLine();

                Pegacorn pegacorn = new Pegacorn(superPower, name);
                int speed = pegacorn.FlightSpeed();
                bool attack = pegacorn.Attack();
                bool heal = pegacorn.Heal();

                Console.ReadKey();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Pegicorn - Exception thrown: {ex.Message}");
                return false;
            }



     
        }

        public static bool CreateMegaladon()
        {
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                try
                {
                    Console.WriteLine("Name the Zoo's Megaladon:");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the Megaladon's super power?");
                    string superPower = Console.ReadLine();

                    Console.WriteLine("What is Megaladon's BodyLength?");
                    int length = int.Parse(Console.ReadLine());

                    Megalodon megaladon = new Megalodon(superPower, name, length);
                    int bodyLength = megaladon.BodyLength;
                    bool attack = megaladon.Attack();
                    bool heal = megaladon.Heal();

                    Console.ReadKey();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Megaladon - Exception thrown: {ex.Message}");
                    return false;
                }
            }
        }
    }
}