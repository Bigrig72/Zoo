using System;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class FantasySwimmer : FantasyCreature, ISwim
    {

        // Properties of Fantasy Creature
        public override string SuperPower { get; set; }
        public override string Name { get; set; }

        // Properties of ISwim
        public virtual int BodyLength { get; set; } = 75;

        // Method of ISwim
        public virtual int SwimSpeed()
        {
            try
            {
                int speed = BodyLength * 80;
                Console.WriteLine($"{Name}'s swim speed is {speed}.");
                return speed;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Swim speed is not calculatable because an error was caught {ex.Message}");
                return 0;
            }
        }

        // Methods of Fantasy Creature
        public override bool Attack()
        {
            if (SuperPower.ToUpper() == "TAIL WHIP")
            {
                Console.WriteLine($"{Name} successfuly attacked with their {SuperPower} super power.");
                return true;
            }
            Console.WriteLine($"{Name}'s {SuperPower} super power is not an attacking power.");
            return false;
        }

        public override bool Heal()
        {
            if (SuperPower.ToUpper() == "SEASHELL SPELLS")
            {
                Console.WriteLine($"{Name} successfuly healed with their {SuperPower} super power.");
                return true;
            }
            Console.WriteLine($"{Name}'s {SuperPower} super power is not an healing power.");
            return false;
        }
    }

}
