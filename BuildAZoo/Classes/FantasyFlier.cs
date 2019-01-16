using System;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class FantasyFlier: FantasyCreature, IFly
    {

        // Properties of Fantasy Creature
        public override string SuperPower { get; set; }
        public override string Name { get; set; }

        // Properties of IFly
        public virtual int WingSpan { get; set; } = 200;

        // Method of IFly
        public virtual int FlightSpeed()
        {
            try
            {
                int speed = WingSpan * 100;
                Console.WriteLine($"{Name}'s flight speed is {speed}.");
                return speed;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Flight speed is not calculatable because an error was caught {ex.Message}");
                return 0;
            }
        }

        // Methods of Fantasy Creature
        public override bool Attack()
        {
            if (SuperPower.ToUpper() == "FLAME THROWER")
            {
                Console.WriteLine($"{Name} successfuly attacked with their {SuperPower} super power.");
                return true;
            }
            Console.WriteLine($"{Name}'s {SuperPower} super power is not an attacking power.");
            return false;
        }

        public override bool Heal()
        {
            if (SuperPower.ToUpper() == "GLITTER BOMB")
            {
                Console.WriteLine($"{Name} successfuly healed with their {SuperPower} super power.");
                return true;
            }
            Console.WriteLine($"{Name}'s {SuperPower} super power is not an healing power.");
            return false;
        }

      
    }

}
