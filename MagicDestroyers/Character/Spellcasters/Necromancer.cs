//using MagicDestroyers.Armor.Leather;
//using MagicDestroyers.Character.Spellcasters;
//using MagicDestroyers.Enumerations;
//using MagicDestroyers.Weapons.Sharp;
//using System;

//namespace MagicDestroyers.Characters.Spellcasters
//{

//    public class Necromancer : Spellcaster
//    {

//        private const int DEFAULT_DAMAGE = 10;
//        private const int DEFAULT_HEALTH_POINTS = 100;
//        private const string DEFAULT_NAME = "Druid";
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_ABILITYPOINTS = 2;
//        private readonly int ID;
//        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

//        private readonly Sword DEFAULT_WEAPON = new Sword();
//        private readonly LeatherVest DEFAULT_BODYARMOR = new LeatherVest();

//        //constructor
//        public Necromancer()
//            :this(DEFAULT_NAME, DEFAULT_LEVEL)
//        {
//        }
//        public Necromancer(string name, int level)
//            :this(name, level, DEFAULT_ABILITYPOINTS)
//        {
//        }
//        public Necromancer(string name, int level, int manaPoints)
//            :base(name, level, manaPoints)
//        {
//            base.HealthPoints = DEFAULT_HEALTH_POINTS;
//            base.Faction = DEFAULT_FACTION;
//            base.BodyArmor = DEFAULT_BODYARMOR;
//            base.Weapon = DEFAULT_WEAPON;
//        }

//        public int ShadowRage()
//        {
//            return base.Weapon.DamagePoints + 10;
//        }

//        public int VampireTouch()
//        {
//            throw new NotImplementedException();
//        }

//        public int BoneShield()
//        {
//            return base.BodyArmor.ArmorPoints + 5;
//        }

//        public override int Attack()
//        {
//            return this.ShadowRage();
//        }

//        public override int SpecialAttack()
//        {
//            return this.VampireTouch();
//        }

//        public override int Defend()
//        {
//            return this.BoneShield();
//        }
//    }


//}