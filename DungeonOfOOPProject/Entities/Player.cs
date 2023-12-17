using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
