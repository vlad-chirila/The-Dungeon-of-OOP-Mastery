using DungeonOfOOPProject.Entities;

namespace DungeonOfOOPProject.MonstersLogic
{
    public interface IMonsterBuilder
    {
        public Monster GetMonster();
        public void SetMonsterType();
        public void SetHealth(int health);
        public void SetAttackPower(int attackPower);
        public void SetMessages();
        public void SetAppearance();

    }
}
