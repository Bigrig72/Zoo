namespace Zoo.Classes.Creatures
{
    public class Pegacorn : FantasyFlier
    {
        public Pegacorn(string superPower, string name)
        {
            SuperPower = superPower;
            Name = name;
        }

        public override string SuperPower { get; set; }
        public override string Name { get; set; }
        public override int WingSpan { get => base.WingSpan; set => base.WingSpan = value; }

      
        public override bool Attack()
        {
            return base.Attack();
        }

        public override int FlightSpeed()
        {
            return base.FlightSpeed();
        }

        public override bool Heal()
        {
            return base.Heal();
        }
    }
}
