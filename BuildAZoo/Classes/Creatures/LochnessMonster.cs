namespace Zoo.Classes.Creatures
{
    public class LochnessMonster : FantasySwimmer
    {
        public LochnessMonster(string superPower, string name)
        {
            SuperPower = superPower;
            Name = name;
        }

        public override string SuperPower { get; set; }
        public override string Name { get; set; }
        public override int BodyLength { get => base.BodyLength; set => base.BodyLength = value; }

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
            return base.SwimSpeed();
        }
    }
}
