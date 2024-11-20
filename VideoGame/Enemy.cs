using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    internal class Enemy : Fighter
    {
        public Enemy()
        {
            name = "Slime";
            Hp = 20;
            MaxHp = 20;
            Strength = 8;
            Defense = 2;
        }

    }
}
