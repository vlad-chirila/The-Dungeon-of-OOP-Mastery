using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
