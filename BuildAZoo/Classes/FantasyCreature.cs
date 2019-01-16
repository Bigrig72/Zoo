using System;

namespace Zoo.Classes
{
    public abstract class FantasyCreature
    {
        // Properties of Fantasy Creature
        public abstract string SuperPower { get; set; }
        public abstract string Name { get; set; }

        // Methods of Fantasy Creature
        public abstract bool Attack();
        public abstract bool Heal();
    }
}
