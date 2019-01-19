using Xunit;
using Zoo.Classes;
using Zoo.Classes.Creatures;
using Zoo.Interfaces;

namespace XUnitTestProject1
{

    public class UnitTest1
    {
        // Dragon can attack
        [Fact]
        public void DragonCanAttack()
        {
            int wing = 80;
            string superPower = "Flame thrower";
            string name = "tido";

            Dragon dragon = new Dragon(superPower, name, wing);

            bool attack = dragon.Attack();

            Assert.True(attack);
        }

        // Does the dragon have a superpower and a name, properties for dragon
        [Fact]
        public void DragonHasASuperPower()
        {
            int wing = 80;
            string superPower = "Flame thrower";
            string name = "tido";

            Dragon dragon = new Dragon(superPower, name, wing);
            Assert.Equal("tido", name);
            Assert.Equal("Flame thrower", superPower);           
        }

        // Is dragon a fantasy creature or in this case an animal and implements IFly
        [Fact]
        public void DragonIsAFantasyCreature()
        {
            int wing = 80;
            string superPower = "Flame thrower";
            string name = "tido";

            Dragon dragon = new Dragon(superPower, name, wing);

            Assert.IsAssignableFrom<FantasyCreature>(dragon);
            Assert.IsAssignableFrom<IFly>(dragon);
        }

        // Shows hippo shares from fantasy creature and can do its own attack with override
        [Fact]
        public void HippoGriffSharesWhatDragonHas()
        {
            int wing = 80;
            int length = 150;
            string superPower = "Speed flight";
            string name = "aldo";

            Hippogriff hippo = new Hippogriff(superPower, name, length, wing);
            
            // Hippo can attack
            Assert.Equal(hippo.Attack(), hippo.Attack());

            // comes from fantasycreature 
            Assert.IsAssignableFrom<FantasyCreature>(hippo);
            Assert.IsAssignableFrom<IFly>(hippo);

        }
       
        [Fact]

        // Verifying interfaces for hippogriff
        public void HippoGriffUsesInterfaces1()
        {
            int wing = 80;
            int length = 150;
            string superPower = "Speed flight";
           // string superPower2 = "healer";
           string name = "aldo";    

            Hippogriff hippo = new Hippogriff(superPower, name, length, wing);
            //Pegacorn pega = new Pegacorn(superPower2, name2);
     
            Assert.IsAssignableFrom<IFly>(hippo);
            Assert.IsAssignableFrom<ISwim>(hippo);
        }

        // Verifyimg interface for pegacorn
        [Fact]    
        public void PegacornInterface()
        {          
            string superPower = "Speed flight";
            // string superPower2 = "healer";
            string name = "aldo";

            Pegacorn pega = new Pegacorn(superPower, name);
            Assert.IsAssignableFrom<IFly>(pega);           
        }

        [Fact]

        // Checking to see if Override works, pegacorn will have a specific name
        public void PegacornOverrideName()
        {
            string superPower = "Speed flight";
            // string superPower2 = "healer";
            string name = "aldo";

            Pegacorn pega = new Pegacorn(superPower, name);           

           // Pegacorn Override Name to change name
            Assert.Equal("aldo", "aldo");
            Assert.IsAssignableFrom<IFly>(pega);
        }

        [Fact]
        // Checking to see if Override works, pegacorn will have a specific attack
        public void PegacornOverrideAttack()
        {
            string superPower = "Speed flight";
            // string superPower2 = "healer";
            string name = "aldo";

            Pegacorn pega = new Pegacorn(superPower, name);
            pega.Attack();           
            Assert.Equal(pega.Attack(), pega.Attack());
            Assert.IsAssignableFrom<IFly>(pega);
        }

        [Fact]
        // Checking to see if Override works, pegacorn will have a specific attack
        public void MegladonInheritsPolymorph()
        {
            string superPower = "Speed flight";
            // string superPower2 = "healer";
            string name = "aldo";
            int length = 100;

            Megalodon mega = new Megalodon(superPower, name, length);
           

            Assert.Equal(mega.Attack(), mega.Attack());
            Assert.Equal(mega.Heal(), mega.Heal());
            Assert.IsAssignableFrom<ISwim>(mega);
        }

    }
}
