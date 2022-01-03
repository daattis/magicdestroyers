namespace MagicDestroyers.Character.Interfaces
{
    public interface ISpellcaster
    {
        int ManaPoints { get; set; }

      //  Staff Weapon { get; set; }

        void CastSpell();
    }
}
