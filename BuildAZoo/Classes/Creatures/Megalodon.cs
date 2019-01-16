using System;

namespace Zoo.Classes.Creatures
{
    public class Megalodon : FantasySwimmer
    {
        // Megalodon Constructor
        public Megalodon(string superPower, string name, int bodyLength)
        {
            SuperPower = superPower;
            Name = name;
            BodyLength = bodyLength;
        }

        public override string SuperPower { get; set; }
        public override string Name { get; set; }
        public override int BodyLength { get; set; }

        public override bool Attack()
        {
            return base.Attack();
        }

        public override bool Heal()
        {
            return base.Heal();
        }

        public override int SwimSpeed()
        {
            try
            {
                int speed = BodyLength * 1385;
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
