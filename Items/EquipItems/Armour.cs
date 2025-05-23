using GamePrototype.Utils;

namespace GamePrototype.Items.EquipItems
{
    public sealed class Armour : EquipItem
    {
        public Armour(uint defence, uint durability, string name) : base(durability, name)
        {
            Defence = defence;
            Durability = durability;
        }

        public uint Defence { get; }
        public uint Durability { get; private set; } // ← добавлено

        public override EquipSlot Slot => EquipSlot.Armour;

        public void ReduceDurability()
        {
            if (Durability > 0)
            {
                Durability--;
            }
        }
    }


}
