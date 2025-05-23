using GamePrototype.Dungeon;
using GamePrototype.Items.EconomicItems;
using GamePrototype.Units;

namespace GamePrototype.Utils
{
    
    public class HardDungeonBuilder : IDungeonBuilder
    {
        public DungeonRoom BuildDungeon(Difficulty difficulty)
        {
            var enter = new DungeonRoom("Enter");
            var monsterRoom1 = new DungeonRoom("Monster1", new HardUnitFactory().CreateEnemy());
            var monsterRoom2 = new DungeonRoom("Monster2", new HardUnitFactory().CreateEnemy());
            var trapRoom = new DungeonRoom("Trap");
            var lootRoom = new DungeonRoom("Loot", new Grindstone("Grindstone"));
            var finalRoom = new DungeonRoom("Final", new Gold());

            enter.TrySetDirection(Direction.Right, monsterRoom1);
            enter.TrySetDirection(Direction.Left, trapRoom);
            monsterRoom1.TrySetDirection(Direction.Forward, monsterRoom2);
            monsterRoom2.TrySetDirection(Direction.Forward, lootRoom);
            trapRoom.TrySetDirection(Direction.Forward, lootRoom);
            lootRoom.TrySetDirection(Direction.Forward, finalRoom);

            return enter;
        }
    }
}