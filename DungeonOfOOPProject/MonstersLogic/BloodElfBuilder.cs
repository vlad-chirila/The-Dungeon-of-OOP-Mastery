using DungeonOfOOPProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfOOPProject.MonstersLogic
{
    public class BloodElfBuilder : IMonsterBuilder
    {
        private Monster monster = new BloodElfMonster();
        public Monster GetMonster()
        {
            return monster;
        }

        public void SetMonsterType()
        {
            monster.Type = MonsterType.BloodElf;
        }
        public void SetAppearance()
        {
            monster.Appearance = "1";
        }

        public void SetAttackPower(int attackPower = 5)
        {
            monster.AttackPower = attackPower;
        }

        public void SetHealth(int health = 100)
        {
            monster.Health = health;
        }

        public void SetMessages()
        {
            monster.Messages = new string[]{ "Poor player!", "I will be your doom" }; 
        }
    }
}
