using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    internal class Skill
    {
        protected string sName { get; set; }
        protected string sVerb { get; set; }
        protected int damMod { get; set; }  
        protected bool heals { get; set; }

        public Skill(string n, string v)
        { sName = n; sVerb = v; damMod = 1; heals = false; }

        public Skill(string n, string v, int m)
        { sName = n; sVerb = v; damMod = m; heals = false; }

        public Skill(string n, string v, int m, bool h)
        { sName = n; sVerb = v; damMod = m; heals = h; }

        public void doSkill(Fighter source, Fighter target)
        { 
            if (heals) { healCalc(source, target); }    
            else { damageCalc(source, target); }
        }


        public void damageCalc(Fighter source, Fighter target)
        {
            int damage = source.getStrength() - target.getDefense() + damMod;
            int hp = target.getHp();

            int remaining = hp - damage;

            target.setHp(remaining);

            doFeedback(source, target, damage, remaining);
        }

        public void healCalc(Fighter source, Fighter target)
        {
            Random r = new Random();
            int power = source.getStrength();

            int upHP = r.Next(0, power);

            target.setHp(upHP + target.getHp());
        }

        public string doFeedback(Fighter source, Fighter target, int damage, int remaining)
        {
            string msg;
            string tgt = target.ToString();

            if (source == target ) { tgt = "themself"; }

            if (heals) { msg = $"{source} heals {tgt} for {damage} HP!"; }
            else { msg = $"{source} {sVerb} {tgt} for {damage} damage!"; }

            if (remaining <= 0) { msg += $"The {tgt} passes out!"; }

            return msg;
        }
    }
}
