using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    internal class Player : Fighter
    {
        //private int Gold;

        public Player()
        {
            Hp = 20;
            MaxHp = 20;
            Strength = 5;
            Defense = 5;
        }
    }
}
