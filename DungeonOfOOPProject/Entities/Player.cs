namespace DungeonOfOOPProject.Entities
{
    public class Player
    {
        private IBattleStrategy battleStrategy;
        public void SetBattleStrategy(IBattleStrategy strategy)
        {
            this.battleStrategy = strategy;
        }
        public void Attack(Monster monster)
        {
            battleStrategy.ExecuteAttack(this, monster);
        }

    }
}
