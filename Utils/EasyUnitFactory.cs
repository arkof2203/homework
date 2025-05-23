using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Units;


namespace GamePrototype.Utils
{
    public class EasyUnitFactory : IUnitFactory
    {
        public Unit CreatePlayer(string name)
        {
            var player = new Player(name, 50, 50, 8);
            player.AddItemToInventory(new Weapon(12, 20, "Iron Sword"));
            player.AddItemToInventory(new Armour(12, 20, "Leather Armour"));
            player.AddItemToInventory(new HealthPotion("Health Potion"));
            player.AddItemToInventory(new SharpeningStone());
            return player;
        }

        public Unit CreateEnemy()
        {
            return new Goblin("Weak Goblin", 10, 10, 1);
        }
    }

}