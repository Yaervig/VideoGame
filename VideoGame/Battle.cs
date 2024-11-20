using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame
{
    internal class Battle
    {
        bool inProgress;
      
        public Battle()
        {
            inProgress = true;
        }

        public void setInProgress(bool a)
        {
            inProgress = a;
        }

        public bool getInProgress()
        {
            return inProgress;
        }

        public void castSkill(Fighter attacker, Fighter defender, String skill)
        {
            switch (skill)
            {
                case "Basic":
                    defender.setHp(defender.getHp() - damageCalc(attacker.getStrength(), defender.getDefense(), defender.getHp()));
                    break;
                case "Fireball":
                    defender.setHp(defender.getHp() - damageCalc(6, 0, defender.getHp()));
                    break;
                case "Heal":
                    attacker.setHp(attacker.getHp() + healCalc(6, attacker.getMaxHp(), attacker.getHp()));
                    break;
                default:
                    break;
            }
        }

        public void enemyTurn(Fighter attacker, Fighter defender)
        {
            castSkill(attacker, defender, "Basic");
        }

        public int damageCalc(int dmg, int def, int hp)
        {
            int damage = dmg - def;

            if (damage < 1)
                damage = 1;
      
            if (damage <= hp)
                return damage;
            else
                return hp;
        }

        public int healCalc(int heal, int maxHp, int hp)
        {
            if (heal < maxHp - hp)
                return heal;
            return maxHp - hp;
        }
    }
}
