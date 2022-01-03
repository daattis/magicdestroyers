using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon
    {
        //field
        private int damagePoints;

        //prop
        public int DamagePoints
        {
            get
            {
                return damagePoints;
            }

            set
            {
                if (value >= 0)
                {
                    this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage Points value should be a positive number");
                }
            }
        }

        public abstract void SpecialAbility();
    }
}
