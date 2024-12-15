using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Alex
namespace VideoGame
{
    internal class Skill
    {
        public string sName { get; set; }
        protected string sVerb { get; set; }
        protected int damMod { get; set; }  
        protected bool heals { get; set; }

        public Skill(string n, string v)
        { sName = n; sVerb = v; damMod = 1; heals = false; }

        public Skill(string n, string v, int m)
        { sName = n; sVerb = v; damMod = m; heals = false; }

        public Skill(string n, string v, int m, bool h)
        { sName = n; sVerb = v; damMod = m; heals = h; }

        public string doSkill(Fighter source, Fighter target)
        { 
            if (heals) {return healCalc(source, source); }    
            else { return damageCalc(source, target); }
        }


        public string damageCalc(Fighter source, Fighter target)
        {
            int damage = source.getStrength() - target.getDefense() + damMod;
            if (damage <= 0)
                damage = 1;

            int hp = target.getHp();

            int remaining = hp - damage;

            target.setHp(remaining);

            string msg = doFeedback(source, target, damage, remaining);
            return msg;
        }

        public string healCalc(Fighter source, Fighter target)
        {
            Random r = new Random();
            int power = source.getStrength();

            int upHP = r.Next(0, power);

            target.setHp(upHP + target.getHp());

            string msg = doFeedback(source, target, upHP, target.getHp());
            return msg;
        }

        public string doFeedback(Fighter source, Fighter target, int damage, int remaining)
        {
            string msg;
            string tgt = target.ToString();

            if (source == target ) { tgt = "themself"; }

            if (heals) { msg = $"{source.ToString()} heals {tgt} for {damage} HP!"; }
            else { msg = $"{source.ToString()} {sVerb} {tgt} for {damage} damage!"; }

            if (remaining <= 0) { msg += $" The {tgt} passes out!"; }

            return msg;
        }
        //End Alex
    }
}
