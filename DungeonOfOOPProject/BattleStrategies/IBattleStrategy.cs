namespace DungeonOfOOPProject.Entities
{
    public interface IBattleStrategy
    {

        void ExecuteAttack(Player player, Monster monster);
    }
}