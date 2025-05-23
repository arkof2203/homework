using GamePrototype.Units;

namespace GamePrototype.Items.EconomicItems
{
    public sealed class SharpeningStone : EconomicItem
    {
        public SharpeningStone() : base("Sharpening Stone") { }

        public override bool Stackable => false;


        public override void Use(Player player)
        {
            if (player.TrySharpenWeapon())
            {
                Console.WriteLine("Weapon was sharpened!");
            }
            else
            {
                Console.WriteLine("No weapon equipped to sharpen.");
            }
        }
    }
}

