namespace DungeonOfOOPProject.Entities
{
    public class Monster
    {
        public MonsterType Type { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsAlive { get; set; } = true;
        public string[] Messages { get; set; }
        public string Appearance { get; set; }
        public virtual void Interact(Player player);
        public abstract void ShowIntroduction();

    }
}