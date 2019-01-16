using System;

namespace Zoo.Classes.Creatures
{
    public class Dragon : FantasyFlier
    {
        public Dragon(string superPower, string name, int wingSpan)
        {
            SuperPower = superPower;
            Name = name;
            WingSpan = wingSpan;
        }

        public override string SuperPower { get; set;}
        public override string Name { get; set; }
        public override int WingSpan { get; set; }

        public override bool Attack()
        {
            return base.Attack();
        }

        public override int FlightSpeed()
        {
            try
            {
                int speed = WingSpan * 200;
                Console.WriteLine($"{Name}'s flight speed is {speed}.");
                return speed;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Flight speed is not calculatable because an error was caught {ex.Message}");
                return 0;
            }           
        }

        public override bool Heal()
        {
            return base.Heal();
        }
    }
}
