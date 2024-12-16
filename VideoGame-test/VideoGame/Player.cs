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
        private int Gold;
        private int Mana;
        private int MaxMana;
        private int targetIndex;
        private int level;

        public Player()
        {
            Hp = 20;
            MaxHp = Hp;
            Mana = 5;
            MaxMana = Mana;
            Strength = 5;
            Defense = 2;
            targetIndex = -1;
            Gold = 5;
        }

        public void setMana(int m)
        {
            Mana = m;
        }

        public int getMana()
        {
            return Mana;
        }

        public void setMaxMana(int m)
        {
            MaxMana = m;
        }

        public int getMaxMana()
        {
            return MaxMana;
        }

        public void setGold(int g)
        {
            Gold = g;
        }

        public int getGold()
        {
            return Gold;
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
