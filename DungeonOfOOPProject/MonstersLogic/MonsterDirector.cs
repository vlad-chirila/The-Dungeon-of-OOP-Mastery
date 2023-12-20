namespace DungeonOfOOPProject.MonstersLogic
{
    public class MonsterDirector
    {
        public void ConstructBloodElf(BloodElfBuilder builder)
        {
            builder.SetMonsterType();
            builder.SetAppearance();
            builder.SetAttackPower();
            builder.SetHealth();
            builder.SetMessages();
        }
    }
}
