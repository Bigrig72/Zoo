using System;
using Zoo.Interfaces;

namespace Zoo.Classes.Creatures
{
    public class Hippogriff : FantasyCreature, ISwim, IFly
    {
        // Hippogriff Constructor
        public Hippogriff(string superPower, string name, int bodyLength, int wingSpan)
        {
            SuperPower = superPower;
            Name = name;
            BodyLength = bodyLength;
            WingSpan = wingSpan;
        }

        // Properties of Fantasy Creature
        public override string SuperPower { get; set; }
        public override string Name { get; set; }

        // Properties of ISwim
        public int BodyLength { get; set; }

        // Properties of IFly
        public int WingSpan { get; set; }

        // Methods of Fantasy Creature
        public override bool Attack()
        {
            if (SuperPower.ToUpper() == "FLAME THROWER" || SuperPower.ToUpper() == "TSUNAMI THROWER")
            {
                Console.WriteLine($"{Name} successfuly attacked with their {SuperPower} super power.");
                return true;
            }
            Console.WriteLine($"{Name}'s {SuperPower} super power is not an attacking power.");
            return false;
        }

        public override bool Heal()
        {
            if (SuperPower.ToUpper() == "INVISIBILITY SMOKE PUFF")
            {
                Console.WriteLine($"{Name} successfuly healed with their {SuperPower} super power.");
                return true;
            }
            Console.WriteLine($"{Name}'s {SuperPower} super power is not an healing power.");
            return false;
        }

        // Methods of IFly
        public int FlightSpeed()
        {
            try
            {
                int speed = WingSpan * 90;
                Console.WriteLine($"{Name}'s flight speed is {speed}.");
                return speed;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Flight speed is not calculatable because an error was caught {ex.Message}");
                return 0;
            }
        }

        // Methods of ISwim
        public int SwimSpeed()
        {
            try
            {
                int speed = BodyLength * 45;
                Console.WriteLine($"{Name}'s swim speed is {speed}.");
                return speed;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Swim speed is not calculatable because an error was caught {ex.Message}");
                return 0;
            }
        }
    }
}
