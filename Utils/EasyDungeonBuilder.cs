using GamePrototype.Dungeon;
using GamePrototype.Items.EconomicItems;
using GamePrototype.Units;

namespace GamePrototype.Utils
{
    public class EasyDungeonBuilder : IDungeonBuilder
    {
        public DungeonRoom BuildDungeon(Difficulty difficulty)
        {
            var enter = new DungeonRoom("Enter");
            var monsterRoom = new DungeonRoom("Monster", new EasyUnitFactory().CreateEnemy());
            var lootRoom = new DungeonRoom("Loot", new Gold());
            var finalRoom = new DungeonRoom("Final", new HealthPotion("Health Potion"));

            enter.TrySetDirection(Direction.Right, monsterRoom);
            enter.TrySetDirection(Direction.Left, lootRoom);
            monsterRoom.TrySetDirection(Direction.Forward, finalRoom);
            lootRoom.TrySetDirection(Direction.Forward, finalRoom);

            return enter;
        }
    }

}