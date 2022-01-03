//using MagicDestroyers.Character.Spellcasters;
//using MagicDestroyers.Enumerations;
//using MagicDestroyers.Weapons.Sharp;
//using System;

//namespace MagicDestroyers.Characters.Spellcasters
//{

//    public class Druid : Spellcaster
//    {

//        private const int DEFAULT_DAMAGE = 10;
//        private const int DEFAULT_HEALTH_POINTS = 100;
//        private const string DEFAULT_NAME = "Druid";
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_ABILITYPOINTS = 2;
//        private readonly int ID;
//        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

//        private readonly Axe DEFAULT_WEAPON = new Axe();
//        private readonly ChainLink DEFAULT_BODYARMOR = new ChainLink();

//        //constructor
//        public Druid()
//            :this(DEFAULT_NAME, DEFAULT_LEVEL)
//        {
//        }
//        public Druid(string name, int level)
//            :this(name, level, DEFAULT_ABILITYPOINTS)
//        {
//        }
//        public Druid(string name, int level, int manaPoints)
//            : base(name, level, manaPoints)
//        {
//            base.HealthPoints = DEFAULT_HEALTH_POINTS;
//            base.Faction = DEFAULT_FACTION;
//            base.BodyArmor = DEFAULT_BODYARMOR;
//            base.Weapon = DEFAULT_WEAPON;
//        }


//        public int Moonfire()
//        {
//            return base.Weapon.DamagePoints + 10;
//        }

//        public int Starburst()
//        {
//            throw new NotImplementedException();
//        }

//        public int OneWithTheNature()
//        {
//            return base.BodyArmor.ArmorPoints + 5;
//        }

//        public override int Attack()
//        {
//            return this.Moonfire();
//        }

//        public override int SpecialAttack()
//        {
//            return this.Starburst();
//        }

//        public override int Defend()
//        {
//            return this.OneWithTheNature();
//        }
//    }
//}
