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
        private int targetIndex;
        private int level;

        public Player()
        {
            Hp = 200;
            MaxHp = 200;
            Strength = 5;
            Defense = 5;
            targetIndex = -1;
        }

        public void setLevel(int i)
        {
            level = i;
        }

        public int getLevel()
        {
            return level;
        }

        public void setTargetIndex(int i)
        {
            targetIndex = i;
        }

        public int getTargetIndex()
        {
            return targetIndex;
        }
    }
}
