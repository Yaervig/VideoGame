using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    internal class Fighter
    {
        protected int Hp;
        protected int MaxHp;
        protected int Strength;
        protected int Defense;
        protected string name;

        public Fighter()
        {
            Hp = 20;
            MaxHp = 20;
            Strength = 5;
            Defense = 5;
            name = "Fighter";
        }

        public string getName()
        {
            return name;
        }

        public void setHp(int hp)
        {
            Hp = hp;
        }

        public int getHp()
        {
            return Hp;
        }

        public void setMaxHp(int hp)
        {
            MaxHp = hp;
        }

        public int getMaxHp()
        {
            return MaxHp;
        }

        public void setStrength(int str)
        {
            Strength = str;
        }

        public int getStrength()
        {
            return Strength;
        }

        public void setDefense(int def)
        {
            Defense = def;
        }

        public int getDefense()
        {
            return Defense;
        }
    }
}
