using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    internal class Enemy : Fighter
    {
        private String Name;

        public Enemy(string enemyname)
        {
            initiateEnemy(enemyname);
        }

        public void initiateEnemy(string newname)
        {
            switch (newname)
            {
                case "Slime":
                    MaxHp = 20;
                    Strength = 3;
                    Defense = 2;
                    break;
                case "Goblin":
                    MaxHp = 10;
                    Strength = 6;
                    Defense = 3;
                    break;
                case "Golem":
                    MaxHp = 15;
                    Strength = 8;
                    Defense = 10;
                    break;
                default:
                    MaxHp = 1;
                    Strength = 1;
                    Defense = 1;
                    break;
            }
            Name = newname;
            Hp = MaxHp;
        }
    }
}
