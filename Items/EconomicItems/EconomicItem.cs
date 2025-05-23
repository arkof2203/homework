using GamePrototype.Units;

namespace GamePrototype.Items.EconomicItems
{
    public abstract class EconomicItem : Item
    {

        public virtual void Use(Player player) { }
        protected EconomicItem(string name) : base(name)
        {
        }
    }
}
