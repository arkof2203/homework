using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Units;


namespace GamePrototype.Utils
{


    public class HardUnitFactory : IUnitFactory
    {
        public Unit CreatePlayer(string name)
        {
            var player = new Player(name, 25, 25, 5);
            player.AddItemToInventory(new Weapon(8, 10, "Rusty Sword"));
            player.AddItemToInventory(new Armour(8, 10, "Worn Armour"));
            return player;
        }

        public Unit CreateEnemy()
        {
            var goblin = new Goblin("Strong Goblin", 25, 25, 4);
            goblin.AddItemToInventory(new Gold());
            return goblin;
        }
    }
}