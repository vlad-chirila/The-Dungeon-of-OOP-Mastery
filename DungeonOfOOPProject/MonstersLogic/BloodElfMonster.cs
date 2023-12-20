using DungeonOfOOPProject.Entities;

namespace DungeonOfOOPProject.MonstersLogic
{
    public class BloodElfMonster : Monster
    {
        public override void Interact(Player player)
        {
            throw new NotImplementedException();
        }

        public override void ShowIntroduction()
        {
            //todo: call write message method
            Console.WriteLine(this.Messages[new Random().Next(0, Messages.Length-1)]);
        }
    }
}
