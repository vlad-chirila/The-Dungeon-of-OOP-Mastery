namespace DungeonOfOOPProject.Entities
{
    public abstract class Room
    {
        public RoomType Type { get; set; }
        public string? Name { get; set; }
        public bool IsCompleted { get; set; }
        public Door Door { get; set; }
        public abstract void Enter(Player player);
    }
}
