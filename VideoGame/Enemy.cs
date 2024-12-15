using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    internal class Enemy : Fighter
    {
        //private String Name;

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
                case "Bat":
                    MaxHp = 12;
                    Strength = 3;
                    Defense = 2;
                    break;
                case "Skeleton":
                    MaxHp = 15;
                    Strength = 4;
                    Defense = 4;
                    break;
                case "Golem":
                    MaxHp = 15;
                    Strength = 8;
                    Defense = 10;
                    break;
                case "Hydra":
                    MaxHp = 100;
                    Strength = 10;
                    Defense = 10;
                    break;
                default:
                    MaxHp = 0;
                    Strength = 1;
                    Defense = 1;
                    break;
            }
            name = newname;
            Hp = MaxHp;
        }
    }
}
