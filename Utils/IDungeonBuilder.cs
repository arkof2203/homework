using GamePrototype.Dungeon;

namespace GamePrototype.Utils
{
    public interface IDungeonBuilder
    {
        DungeonRoom BuildDungeon(Difficulty difficulty);
    }
}