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
        private int Value;

        public Enemy(string enemyname)
        {
            initiateEnemy(enemyname);
        }

        public void setValue(int val)
        {
            Value = val;
        }

        public int getValue()
        {
            return Value;
        }

        public void initiateEnemy(string newname)
        {
            switch (newname)
            {
                case "Slime":
                    MaxHp = 20;
                    Strength = 3;
                    Defense = 1;
                    Value = 3;
                    break;
                case "Goblin":
                    MaxHp = 10;
                    Strength = 5;
                    Defense = 2;
                    Value = 5;
                    break;
                case "Bat":
                    MaxHp = 12;
                    Strength = 3;
                    Defense = 2;
                    Value = 2;
                    break;
                case "Skeleton":
                    MaxHp = 15;
                    Strength = 4;
                    Defense = 3;
                    Value = 6;
                    break;
                case "Hydra":
                    MaxHp = 50;
                    Strength = 4;
                    Defense = 5;
                    Value = 30;
                    break;
                default:
                    MaxHp = 0;
                    Strength = 1;
                    Defense = 1;
                    Value = 0;
                    break;
            }
            name = newname;
            Hp = MaxHp;
        }
    }
}
